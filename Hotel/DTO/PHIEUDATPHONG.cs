using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    public class PHIEUDATPHONG
    {
        private string MAPDP;
        private string NGAYDAT;
        private string NGAYDEN;
        private string SODEMLUUTRU;
        private string GHICHU;
        private string TIENDATCOC;
        private string NGUOIDAT;
        private string HTTHANHTOAN;
        private string MANGUOILAP;
        private string NGAYCHECKIN;
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string FAX { get; set; }
        public string DiaChi { get; set; }

        public string MAPHIEUDP { get => MAPDP; set => MAPDP = value; }
        public string NGAYDATPHONG { get => NGAYDAT; set => NGAYDAT = value; }
        public string NGAYDENNHAN { get => NGAYDEN; set => NGAYDEN = value; }
        public string GHICHUDB { get => GHICHU; set => GHICHU = value; }
        public string DATCOC { get => TIENDATCOC; set => TIENDATCOC = value; }
        public string MAKHACHHANG { get => NGUOIDAT; set => NGUOIDAT = value; }
        public string HINHTHUCTRA { get => HTTHANHTOAN; set => HTTHANHTOAN = value; }
        public string MANVLAPPHIEU { get => MANGUOILAP; set => MANGUOILAP = value; }
        public string NGAYCHECK_IN { get => NGAYCHECKIN; set => NGAYCHECKIN = value; }
        public string SODEMDAT { get => SODEMLUUTRU; set => SODEMLUUTRU = value; }

        public PHIEUDATPHONG(DataRow row)
        {
            this.MAPDP = (string)row["MAPDP"].ToString();
            this.NGAYDAT = row["NGAYDAT"].ToString();
            this.NGAYDEN = row["NGAYDEN"].ToString();
            this.SODEMLUUTRU = row["SODEMLUUTRU"].ToString();
            this.GHICHU = (string)row["GHICHU"].ToString();
            this.TIENDATCOC = row["TIENDATCOC"].ToString();
            this.NGUOIDAT = (string)row["NGUOIDAT"].ToString();
            this.HTTHANHTOAN = (string)row["HTTHANHTOAN"].ToString();
            this.MANGUOILAP = (string)row["MANGUOILAP"].ToString();
            this.NGAYCHECKIN = row["NGAYCHECKIN"].ToString();
            MaKH = row["MaKH"].ToString();
            HoTen = row["HOTEN"].ToString();
            Email = row["EMAIL"].ToString();
            CMND = row["CMND"].ToString();
            SDT = row["SDT"].ToString();
            FAX = row["FAX"].ToString();
            DiaChi = row["DIACHI"].ToString();
        }

        public PHIEUDATPHONG(string MAPDP, string GHICHU, string TIENDATCOC, string HTTHANHTOAN, string NGAYCHECKIN)
        {
            this.MAPDP = MAPDP;
            this.GHICHU = GHICHU;
            this.TIENDATCOC = TIENDATCOC;
            this.HTTHANHTOAN = HTTHANHTOAN;
            this.NGAYCHECKIN = NGAYCHECKIN;
        }
        public static int checkin(PHIEUDATPHONG pdp)
        {
            return PhieuDatPhongDAO.ghinhancheckin(pdp);
        }
        public static List<PHIEUDATPHONG> FILTER_WITH_ATTRIBUTE(string attribute, string value)
        {
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            
            switch (attribute)
            {
                case "Mã phiếu":
                    list = PhieuDatPhongDAO.FILTER_BY_MAPHIEU(value);
                    break;
                case "Họ tên":
                    list = PhieuDatPhongDAO.FILTER_BY_HOTEN(value);
                    break;
                case "CMND":
                    list = PhieuDatPhongDAO.FILTER_BY_CMND(value);
                    break;
                case "SĐT":
                    list = PhieuDatPhongDAO.FILTER_BY_SDT(value);
                    break;

            }
            return list;
        }
    }
}
