namespace _2212453_NgoBaTai_Trang56
{
	partial class frmDemoRadioButtons
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.rbNam = new System.Windows.Forms.RadioButton();
			this.lblGioiTinh = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.Location = new System.Drawing.Point(34, 60);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(39, 17);
			this.rbNu.TabIndex = 5;
			this.rbNu.TabStop = true;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
			// 
			// rbNam
			// 
			this.rbNam.AutoSize = true;
			this.rbNam.Location = new System.Drawing.Point(34, 37);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(47, 17);
			this.rbNam.TabIndex = 4;
			this.rbNam.TabStop = true;
			this.rbNam.Text = "Nam";
			this.rbNam.UseVisualStyleBackColor = true;
			this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
			// 
			// lblGioiTinh
			// 
			this.lblGioiTinh.AutoSize = true;
			this.lblGioiTinh.Location = new System.Drawing.Point(31, 21);
			this.lblGioiTinh.Name = "lblGioiTinh";
			this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
			this.lblGioiTinh.TabIndex = 3;
			this.lblGioiTinh.Text = "Giới tính";
			this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
			// 
			// frmDemoRadioButtons
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rbNu);
			this.Controls.Add(this.rbNam);
			this.Controls.Add(this.lblGioiTinh);
			this.Name = "frmDemoRadioButtons";
			this.Text = "Demo RadioButtons";
			this.Load += new System.EventHandler(this.frmDemoRadioButtons_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.RadioButton rbNam;
		private System.Windows.Forms.Label lblGioiTinh;
	}
}

