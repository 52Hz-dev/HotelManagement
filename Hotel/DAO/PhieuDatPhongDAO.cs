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
    public class PhieuDatPhongDAO
    {
        public static List<PHIEUDATPHONG> DS_PDP_CHOCHECKIN()
        {
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            String query = "select * from phieudatphong where ngaycheckin is null";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }    
            return list;
        }

        public static String TienPhong()
        {
            string query = "select SUM(LOAIPHONG.DONGIA*PHIEUDATPHONG.SODEMLUUTRU) " +
                            "from KHACHHANG, PHIEUDATPHONG, CHITIETDATPHONG, PHONG, LOAIPHONG " +
                            "where  KHACHHANG.MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT " +
                            "and PHIEUDATPHONG.MAPDP = CHITIETDATPHONG.MAPDP " +
                            "and CHITIETDATPHONG.MAPH = PHONG.MAPH and PHONG.LOAIPH = LOAIPHONG.MALP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }
        public static String TienCoc()
        {
            string query = "select SUM(PHIEUDATPHONG.TIENDATCOC) " +
                            "from KHACHHANG, PHIEUDATPHONG, CHITIETDATPHONG, PHONG, LOAIPHONG " +
                            "where  KHACHHANG.MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT " +
                            "and PHIEUDATPHONG.MAPDP = CHITIETDATPHONG.MAPDP " +
                            "and CHITIETDATPHONG.MAPH = PHONG.MAPH and PHONG.LOAIPH = LOAIPHONG.MALP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }
    }
}
