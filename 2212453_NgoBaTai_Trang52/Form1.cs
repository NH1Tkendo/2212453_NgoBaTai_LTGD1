﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Trang52
{
	public partial class frmListBoxs : Form
	{
		public frmListBoxs()
		{
			InitializeComponent();
		}

		private void frmListBoxs_Load(object sender, EventArgs e)
		{

		}

		private void lbDanhsach_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			int itemselect = lbDanhsach.SelectedItems.Count - 1;
			for (int i = itemselect; i >= 0; i--)
			{
				lbDanhsachChon.Items.Add(lbDanhsach.SelectedItems[i]);
				lbDanhsach.Items.Remove(lbDanhsach.SelectedItems[i]);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = lbDanhsachChon.SelectedItems.Count - 1;
			while (i >= 0)
			{
				lbDanhsach.Items.Add(lbDanhsachChon.SelectedItems[i]);
				lbDanhsachChon.Items.RemoveAt(lbDanhsachChon.SelectedIndices[i]);
				i--;
			}
		}

		private void lblDanhSachChon_Click(object sender, EventArgs e)
		{

		}

		private void lbDanhsachChon_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
