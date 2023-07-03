﻿using Hotel.DTB;
using Hotel.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotel.DAO
{
    public class KhachHangDAO
    {
        public static DataRow selectIfKH()
        {
            String query = "select * from KHACHHANG where MAKH = 'KH001'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0];
        }
    }
}
