﻿using Hotel.DTB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadIfKH();
        }

        void loadIfKH()
        {
            string query = "select * from KHACHHANG where MAKH = 'KH001'";
            DataProvider provider = new DataProvider();
            DGV_Info_KH.DataSource = provider.ExecuteQuery(query);

        }
        private void txt_DV_SuDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
