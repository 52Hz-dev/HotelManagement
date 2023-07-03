using Hotel.DTB;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    internal class HoaDonDAO
    {
        public static string GetLastId()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select MAHD from HOADON");
            return data.Rows[data.Rows.Count - 1]["MAHD"].ToString();
        }
        public static bool Insert(HoaDon hd)
        {
            string query = $"INSERT INTO HOADON (MAHD,NGAYLAP, MAPDP, NOIDUNG, THANHTIEN, MANGUOILAP)\r\nVALUES ('{hd.MAHD}', '{hd.NGAYLAP.ToShortDateString()}',  {hd.MAPDP}, {hd.THANHTIEN}, '{hd.MANGUOILAP}')";
            var count = DataProvider.Instance.ExecuteNonQuery(query);
            if (count > 0) return true;
            else return false;
        }
    }
}
