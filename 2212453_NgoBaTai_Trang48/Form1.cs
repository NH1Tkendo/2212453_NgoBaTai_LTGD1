using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Trang48
{
	public partial class frmDemoComboBox : Form
	{
		public frmDemoComboBox()
		{
			InitializeComponent();
		}

		private void lblChon_Click(object sender, EventArgs e)
		{

		}

		private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show(this.cboNgoaiNgu.SelectedItem.ToString());
		}

		private void frmDemoComboBox_Load(object sender, EventArgs e)
		{
			string[] a = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
			this.cboNgoaiNgu.DataSource = a;
		}
	}
}
