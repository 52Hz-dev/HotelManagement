using System;
using System.Collections.Generic;
using System.Data;
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

        public string MAPDP1 { get => MAPDP; set => MAPDP = value; }
        public string NGAYDAT1 { get => NGAYDAT; set => NGAYDAT = value; }
        public string NGAYDEN1 { get => NGAYDEN; set => NGAYDEN = value; }
        public string GHICHU1 { get => GHICHU; set => GHICHU = value; }
        public string TIENDATCOC1 { get => TIENDATCOC; set => TIENDATCOC = value; }
        public string NGUOIDAT1 { get => NGUOIDAT; set => NGUOIDAT = value; }
        public string HTTHANHTOAN1 { get => HTTHANHTOAN; set => HTTHANHTOAN = value; }
        public string MANGUOILAP1 { get => MANGUOILAP; set => MANGUOILAP = value; }
        public string NGAYCHECKIN1 { get => NGAYCHECKIN; set => NGAYCHECKIN = value; }
        public string SODEMLUUTRU1 { get => SODEMLUUTRU; set => SODEMLUUTRU = value; }

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
        }
    }
}
