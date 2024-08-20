namespace _2212453_NgoBaTai_Trang48
{
	partial class frmDemoComboBox
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
			this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
			this.lblChon = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cboNgoaiNgu
			// 
			this.cboNgoaiNgu.FormattingEnabled = true;
			this.cboNgoaiNgu.Location = new System.Drawing.Point(126, 38);
			this.cboNgoaiNgu.Name = "cboNgoaiNgu";
			this.cboNgoaiNgu.Size = new System.Drawing.Size(121, 21);
			this.cboNgoaiNgu.TabIndex = 3;
			this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgoaiNgu_SelectedIndexChanged);
			// 
			// lblChon
			// 
			this.lblChon.AutoSize = true;
			this.lblChon.Location = new System.Drawing.Point(37, 41);
			this.lblChon.Name = "lblChon";
			this.lblChon.Size = new System.Drawing.Size(83, 13);
			this.lblChon.TabIndex = 2;
			this.lblChon.Text = "Chọn ngôn ngữ:";
			this.lblChon.Click += new System.EventHandler(this.lblChon_Click);
			// 
			// frmDemoComboBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cboNgoaiNgu);
			this.Controls.Add(this.lblChon);
			this.Name = "frmDemoComboBox";
			this.Text = "Demo ComboBox";
			this.Load += new System.EventHandler(this.frmDemoComboBox_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboNgoaiNgu;
		private System.Windows.Forms.Label lblChon;
	}
}

