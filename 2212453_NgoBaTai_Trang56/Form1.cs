using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Trang56
{
	public partial class frmDemoRadioButtons : Form
	{
		public frmDemoRadioButtons()
		{
			InitializeComponent();
		}

		private void frmDemoRadioButtons_Load(object sender, EventArgs e)
		{

		}

		private void lblGioiTinh_Click(object sender, EventArgs e)
		{

		}

		private void rbNam_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbNam.Checked)
			{
				MessageBox.Show("Gioi tinh cua ban la: " + rbNam.Text);
			}
		}

		private void rbNu_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rbNu.Checked)
			{
				MessageBox.Show("Gioi tinh cua ban la: " + rbNu.Text);
			}
		}
	}
}
