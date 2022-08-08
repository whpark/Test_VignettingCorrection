namespace VignettingCorrection
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pathImage = new System.Windows.Forms.TextBox();
			this.btnBrowseImage = new System.Windows.Forms.Button();
			this.btnOpenImage = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnCorrectVignetting = new System.Windows.Forms.Button();
			this.btnFindDots = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.btnFindDotsOrg = new System.Windows.Forms.Button();
			this.chkShowImage = new System.Windows.Forms.CheckBox();
			this.chkVignettingCorrection_Sub = new System.Windows.Forms.CheckBox();
			this.chkVignettingCorrection_Mul = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pathImage
			// 
			this.pathImage.Location = new System.Drawing.Point(90, 12);
			this.pathImage.Name = "pathImage";
			this.pathImage.Size = new System.Drawing.Size(375, 23);
			this.pathImage.TabIndex = 1;
			// 
			// btnBrowseImage
			// 
			this.btnBrowseImage.Location = new System.Drawing.Point(471, 12);
			this.btnBrowseImage.Name = "btnBrowseImage";
			this.btnBrowseImage.Size = new System.Drawing.Size(34, 23);
			this.btnBrowseImage.TabIndex = 2;
			this.btnBrowseImage.Text = "...";
			this.btnBrowseImage.UseVisualStyleBackColor = true;
			// 
			// btnOpenImage
			// 
			this.btnOpenImage.Location = new System.Drawing.Point(12, 12);
			this.btnOpenImage.Name = "btnOpenImage";
			this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
			this.btnOpenImage.TabIndex = 3;
			this.btnOpenImage.Text = "Open";
			this.btnOpenImage.UseVisualStyleBackColor = true;
			this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(640, 480);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(12, 555);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(640, 480);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(678, 555);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(640, 480);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// btnCorrectVignetting
			// 
			this.btnCorrectVignetting.Location = new System.Drawing.Point(12, 527);
			this.btnCorrectVignetting.Name = "btnCorrectVignetting";
			this.btnCorrectVignetting.Size = new System.Drawing.Size(163, 23);
			this.btnCorrectVignetting.TabIndex = 5;
			this.btnCorrectVignetting.Text = "Vignetting Correction";
			this.btnCorrectVignetting.UseVisualStyleBackColor = true;
			this.btnCorrectVignetting.Click += new System.EventHandler(this.btnCorrectVignetting_Click);
			// 
			// btnFindDots
			// 
			this.btnFindDots.Location = new System.Drawing.Point(678, 527);
			this.btnFindDots.Name = "btnFindDots";
			this.btnFindDots.Size = new System.Drawing.Size(75, 23);
			this.btnFindDots.TabIndex = 6;
			this.btnFindDots.Text = "Search";
			this.btnFindDots.UseVisualStyleBackColor = true;
			this.btnFindDots.Click += new System.EventHandler(this.btnFindDots_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(678, 41);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(640, 480);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// btnFindDotsOrg
			// 
			this.btnFindDotsOrg.Location = new System.Drawing.Point(678, 12);
			this.btnFindDotsOrg.Name = "btnFindDotsOrg";
			this.btnFindDotsOrg.Size = new System.Drawing.Size(75, 23);
			this.btnFindDotsOrg.TabIndex = 7;
			this.btnFindDotsOrg.Text = "Search";
			this.btnFindDotsOrg.UseVisualStyleBackColor = true;
			this.btnFindDotsOrg.Click += new System.EventHandler(this.btnFindDotsOrg_Click);
			// 
			// chkShowImage
			// 
			this.chkShowImage.AutoSize = true;
			this.chkShowImage.Location = new System.Drawing.Point(184, 530);
			this.chkShowImage.Name = "chkShowImage";
			this.chkShowImage.Size = new System.Drawing.Size(91, 19);
			this.chkShowImage.TabIndex = 8;
			this.chkShowImage.Text = "Show Image";
			this.chkShowImage.UseVisualStyleBackColor = true;
			// 
			// chkVignettingCorrection_Sub
			// 
			this.chkVignettingCorrection_Sub.AutoSize = true;
			this.chkVignettingCorrection_Sub.Location = new System.Drawing.Point(305, 530);
			this.chkVignettingCorrection_Sub.Name = "chkVignettingCorrection_Sub";
			this.chkVignettingCorrection_Sub.Size = new System.Drawing.Size(31, 19);
			this.chkVignettingCorrection_Sub.TabIndex = 9;
			this.chkVignettingCorrection_Sub.Text = "-";
			this.chkVignettingCorrection_Sub.UseVisualStyleBackColor = true;
			// 
			// chkVignettingCorrection_Mul
			// 
			this.chkVignettingCorrection_Mul.AutoSize = true;
			this.chkVignettingCorrection_Mul.Location = new System.Drawing.Point(342, 530);
			this.chkVignettingCorrection_Mul.Name = "chkVignettingCorrection_Mul";
			this.chkVignettingCorrection_Mul.Size = new System.Drawing.Size(32, 19);
			this.chkVignettingCorrection_Mul.TabIndex = 9;
			this.chkVignettingCorrection_Mul.Text = "x";
			this.chkVignettingCorrection_Mul.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1506, 1037);
			this.Controls.Add(this.chkVignettingCorrection_Mul);
			this.Controls.Add(this.chkVignettingCorrection_Sub);
			this.Controls.Add(this.chkShowImage);
			this.Controls.Add(this.btnFindDotsOrg);
			this.Controls.Add(this.btnFindDots);
			this.Controls.Add(this.btnCorrectVignetting);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOpenImage);
			this.Controls.Add(this.btnBrowseImage);
			this.Controls.Add(this.pathImage);
			this.Name = "MainForm";
			this.Text = "Vignetting Correction";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private TextBox pathImage;
		private Button btnBrowseImage;
		private Button btnOpenImage;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private Button btnCorrectVignetting;
		private Button btnFindDots;
		private PictureBox pictureBox4;
		private Button btnFindDotsOrg;
		private CheckBox chkShowImage;
		private CheckBox chkVignettingCorrection_Sub;
		private CheckBox chkVignettingCorrection_Mul;
	}
}