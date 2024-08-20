﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212453_NgoBaTai_Trang35
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			string strURL = "mailto:2212453@dlu.edu.vn";
			this.linkLabel1.Links.Add(0, strURL.Length, strURL);
			strURL = "https://2212453.blogspot.com/";
			this.linkLabel2.Links.Add(0, strURL.Length, strURL);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string strURL = Convert.ToString(e.Link.LinkData);
			if (strURL.StartsWith("mailto:"))
				Process.Start(strURL + "?subject=hello");
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string strURL = Convert.ToString(e.Link.LinkData);
			if (strURL.StartsWith("https://"))
				Process.Start(strURL);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		
	}
}
