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
    internal class PhieuSuDungDichVuDAO
    {
        public static List<PHIEUSUDUNGDICHVU> selectDVThuong()
        {
            List<PHIEUSUDUNGDICHVU> list = new List<PHIEUSUDUNGDICHVU>();
            string query = "select DV.MAPDV, DV.MAPDP, DV.MADV,DV.NOIDUNG, DV.SOLUONG, DV.THANHTIEN, DV.NGAYLAP, DV.MANGUOILAP " +
                           "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU AS DV " +
                           "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = DV.MAPDP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUSUDUNGDICHVU DVThuong = new PHIEUSUDUNGDICHVU(dr);
                list.Add(DVThuong);
            }
            return list;
        }
        public static String TienDVThuong()
        {
            string query = "select SUM(THANHTIEN*SOLUONG) " +
                           "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU AS DV " +
                           "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = DV.MAPDP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }
    }
}
