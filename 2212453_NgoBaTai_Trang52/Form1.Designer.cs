namespace _2212453_NgoBaTai_Trang52
{
	partial class frmListBoxs
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
			this.lbDanhsachChon = new System.Windows.Forms.ListBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblDanhSachChon = new System.Windows.Forms.Label();
			this.lblDanhsach = new System.Windows.Forms.Label();
			this.lbDanhsach = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lbDanhsachChon
			// 
			this.lbDanhsachChon.ForeColor = System.Drawing.Color.Fuchsia;
			this.lbDanhsachChon.FormattingEnabled = true;
			this.lbDanhsachChon.Location = new System.Drawing.Point(400, 45);
			this.lbDanhsachChon.Name = "lbDanhsachChon";
			this.lbDanhsachChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDanhsachChon.Size = new System.Drawing.Size(233, 186);
			this.lbDanhsachChon.TabIndex = 12;
			this.lbDanhsachChon.SelectedIndexChanged += new System.EventHandler(this.lbDanhsachChon_SelectedIndexChanged);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(298, 147);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 11;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(298, 94);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Chọn";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblDanhSachChon
			// 
			this.lblDanhSachChon.AutoSize = true;
			this.lblDanhSachChon.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.lblDanhSachChon.Location = new System.Drawing.Point(397, 26);
			this.lblDanhSachChon.Name = "lblDanhSachChon";
			this.lblDanhSachChon.Size = new System.Drawing.Size(190, 13);
			this.lblDanhSachChon.TabIndex = 9;
			this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia bóng đá";
			this.lblDanhSachChon.Click += new System.EventHandler(this.lblDanhSachChon_Click);
			// 
			// lblDanhsach
			// 
			this.lblDanhsach.AutoSize = true;
			this.lblDanhsach.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.lblDanhsach.Location = new System.Drawing.Point(24, 26);
			this.lblDanhsach.Name = "lblDanhsach";
			this.lblDanhsach.Size = new System.Drawing.Size(121, 13);
			this.lblDanhsach.TabIndex = 8;
			this.lblDanhsach.Text = "Danh sách sinh viên lớp";
			// 
			// lbDanhsach
			// 
			this.lbDanhsach.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.lbDanhsach.FormattingEnabled = true;
			this.lbDanhsach.Items.AddRange(new object[] {
            "Nguyễn Ái Mừng",
            "Danh Nguyễn Tuấn Khanh ",
            "Phạm Thanh Bình",
            "Nguyễn Hồ Đức Huy",
            "Phan Ngọc Vỹ",
            "Trần Chính Phát"});
			this.lbDanhsach.Location = new System.Drawing.Point(27, 45);
			this.lbDanhsach.Name = "lbDanhsach";
			this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDanhsach.Size = new System.Drawing.Size(233, 186);
			this.lbDanhsach.TabIndex = 7;
			this.lbDanhsach.SelectedIndexChanged += new System.EventHandler(this.lbDanhsach_SelectedIndexChanged);
			// 
			// frmListBoxs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbDanhsachChon);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblDanhSachChon);
			this.Controls.Add(this.lblDanhsach);
			this.Controls.Add(this.lbDanhsach);
			this.Name = "frmListBoxs";
			this.Text = "ListBoxs";
			this.Load += new System.EventHandler(this.frmListBoxs_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbDanhsachChon;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblDanhSachChon;
		private System.Windows.Forms.Label lblDanhsach;
		private System.Windows.Forms.ListBox lbDanhsach;
	}
}

