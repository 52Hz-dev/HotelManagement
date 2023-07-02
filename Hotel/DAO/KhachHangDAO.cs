using Hotel.DTB;
using Hotel.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

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
