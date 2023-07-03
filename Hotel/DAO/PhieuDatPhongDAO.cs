using Hotel.DTB;
using Hotel.DTO;
using iTextSharp.text;
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
            String query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }    
            return list;
        }
        public static string GetLastId()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select MAPDP from PHIEUDATPHONG");
            return data.Rows[data.Rows.Count - 1]["MaPDP"].ToString();
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

        public static bool Insert(PhieuDatPhong phieudp)
        {
            string query = $"INSERT INTO PHIEUDATPHONG (MAPDP, NGAYDAT, NGAYDEN, SODEMLUUTRU, GHICHU, TIENDATCOC, NGUOIDAT, TINHTRANG)\r\nVALUES ('{phieudp.MaDatPhong}', '{phieudp.NgayDat.ToShortDateString()}', '{phieudp.NgayDen.ToShortDateString()}', {phieudp.SoDemLT}, N'{phieudp.GhiChu}', {phieudp.TienDaTra}, '{phieudp.MaKH}', N'Chờ check in')";
            var count = DataProvider.Instance.ExecuteNonQuery(query);
            if (count > 0) return true;
            else return false;
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
        public static int ghinhancheckin(PHIEUDATPHONG pdp)
        {
            string query = "update phieudatphong set GHICHU = N'" + pdp.GHICHUDB + "', TIENDATCOC = '" + pdp.DATCOC + "', HTTHANHTOAN=N'" + pdp.HINHTHUCTRA + "', NGAYCHECKIN = '" + pdp.NGAYCHECK_IN + "' where mapdp='" + pdp.MAPHIEUDP + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_MAPHIEU(string value)
        {
            
            string query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and pdp.MAPDP LIKE '%" + value+"%'";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_HOTEN(string value)
        {
            string query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and kh.HOTEN LIKE N'%" + value + "%' ";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_CMND(string value)
        {
            string query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and  kh.CMND LIKE '%" + value + "%' ";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_SDT(string value)
        {
            string query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and kh.SDT LIKE '%" + value + "%'";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
    }
}
