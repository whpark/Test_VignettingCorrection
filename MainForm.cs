using System;
using System.IO;
using Microsoft.Win32;
using cv = OpenCvSharp;
using Cv2 = OpenCvSharp.Cv2;

namespace VignettingCorrection
{
	public partial class MainForm : Form
	{
		private cv::Mat m_img = new cv::Mat();
		private cv::Mat m_imgD = new cv::Mat();

		private cv::Mat m_imgV = new cv::Mat();
		private cv::Mat m_imgVD = new cv::Mat();

		public MainForm()
		{
			InitializeComponent();
			RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Biscuit-Lab").CreateSubKey("VignettingCorrection");
			string str = Convert.ToString(reg.GetValue("ImagePath"));
			pathImage.Text = (str == null) || (str.Length == 0) ? @"C:\Downloads\org_image\1-1.bmp" : str;
			chkVignettingCorrection_Sub.Checked = true;
			chkVignettingCorrection_Mul.Checked = false;
		}

		private void btnOpenImage_Click(object sender, EventArgs e)
		{
			try
			{
				m_img = new cv::Mat(pathImage.Text);
				if (m_img == null)
					return;
				var bitmap = cv::Extensions.BitmapConverter.ToBitmap(m_img);
				pictureBox1.Image = bitmap;
				pictureBox2.Image = null;
				pictureBox3.Image = null;
				pictureBox4.Image = null;

				RegistryKey reg = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("Biscuit-Lab").CreateSubKey("VignettingCorrection");
				reg.SetValue("ImagePath", pathImage.Text);

				btnCorrectVignetting_Click(sender, e);
				btnFindDotsOrg_Click(sender, e);
			}
			catch 
			{
				System.Windows.Forms.MessageBox.Show("Failed");
			}
		}

		private void btnCorrectVignetting_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				if (m_img == null) return;
				cv::Mat[] imgs = m_img.Split();
				//cv.Window.ShowImages(imgs);
				for (int i = 0; i < imgs.Length; i++)
				{
					cv::Mat img = imgs[i];
					cv::Mat filter = img.Resize(new cv::Size(11, 11), 0.0, 0.0, cv::InterpolationFlags.Area);
					filter = filter.Resize(img.Size(), 0.0, 0.0, cv::InterpolationFlags.Linear);
					//cv::Mat m2 = filter * 2.0;
					//cv.Window.ShowImages(m2);
					if (chkShowImage.Checked)
						cv.Window.ShowImages(filter);
					filter.ConvertTo(filter, cv::MatType.CV_32FC1);

					double dMin = 0.0, dMax = 0.0;
					filter.MinMaxLoc(out dMin, out dMax);

					double weight = 0.0;
					cv::Mat matC = new cv::Mat();
					img.ConvertTo(matC, cv.MatType.CV_32F);
					cv::Mat matR = new cv::Mat(matC.Size(), matC.Type());

					if (chkVignettingCorrection_Sub.Checked)
					{
						weight += 1.0;
						matR += matC - filter + dMax;
					}

					if (chkVignettingCorrection_Mul.Checked)
					{
						weight += 1.0;
						matR += matC.Mul(dMax / filter);
					}

					if (weight == 0)
					{
						System.Windows.Forms.MessageBox.Show("'-' 또는 'x' 선택해야 함");
						return;
					}
					matR /= weight;
					matR.ConvertTo(imgs[i], cv::MatType.CV_8U);

				}

				if (imgs.Length == 1)
				{
					m_imgV = imgs[0];
				}
				else if (imgs.Length == 3)
				{
					m_imgV = new cv::Mat(m_img.Size(), m_img.Type());
					Cv2.Merge(imgs, m_imgV);
				}

				pictureBox2.Image = cv::Extensions.BitmapConverter.ToBitmap(m_imgV);

				btnFindDots_Click(sender, e);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private static void FindDots(cv::Mat img, PictureBox box)
		{
			if (img == null) return;

			try
			{
				Cursor.Current = Cursors.WaitCursor;

				cv::Mat imgD = new cv::Mat(img.Size(), img.Type());
				img.CopyTo(imgD);

				cv.SimpleBlobDetector.Params p = new cv.SimpleBlobDetector.Params();
				p.ThresholdStep = 10.0f;
				p.MinThreshold = 50.0f;
				p.MaxThreshold = 150.0f;
				p.MinRepeatability = 1;
				p.MinDistBetweenBlobs = 10;

				p.FilterByColor = false;
				p.BlobColor = 0;

				p.FilterByArea = true;
				p.MinArea = 14 * 14;
				p.MaxArea = 22 * 22;

				p.FilterByCircularity = true;
				p.MinCircularity = 0.85f;
				//params.maxCircularity = 1.0;

				p.FilterByInertia = true;
				p.MinInertiaRatio = 0.89f;
				//params.maxInertiaRatio = 0.0;

				p.FilterByConvexity = false;
				p.MinConvexity = 0.9f;
				//params.maxConvexity = 1.0;

				cv.SimpleBlobDetector blobDetector = cv::SimpleBlobDetector.Create(p);
				if (blobDetector == null) return;
				cv.KeyPoint[] keyPoints = blobDetector.Detect(img);
				for (int i = 0; i < keyPoints.Length; i++)
				{
					cv.KeyPoint p0 = keyPoints[i];
					cv.Point2f pt = p0.Pt;
					float diameter = p0.Size;

					Cv2.PutText(imgD, $"{diameter:F1}", new cv::Point((int)pt.X-120, (int)pt.Y+80),
						cv::HersheyFonts.HersheyPlain, 6.0, new cv::Scalar(0, 192, 0), 5);
				}

				box.Image = cv::Extensions.BitmapConverter.ToBitmap(imgD);

			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void btnFindDots_Click(object sender, EventArgs e)
		{
			FindDots(m_imgV, pictureBox3);
		}

		private void btnFindDotsOrg_Click(object sender, EventArgs e)
		{
			FindDots(m_img, pictureBox4);
		}

		private void btnBrowseImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "image files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*||";
			dlg.Multiselect = false;
			dlg.ReadOnlyChecked = true;
			dlg.ShowReadOnly = false;
			DialogResult r = dlg.ShowDialog();
			if (r != DialogResult.OK)
				return;

			pathImage.Text = dlg.FileName;

			btnOpenImage_Click(sender, e);
		}
	}
}
