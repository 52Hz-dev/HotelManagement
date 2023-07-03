using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotel.DTO
{
    internal class KHACHHANG
    {
        private String MAKH;
        private String HOTEN;
        private String EMAIL;
        private String CMND;
        private String SDT;
        private String FAX;
        private String DIACHI;

        public string MAKH1 { get => MAKH; set => MAKH = value; }
        public string HOTEN1 { get => HOTEN; set => HOTEN = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string FAX1 { get => FAX; set => FAX = value; }
        public string DIACHI1 { get => DIACHI; set => DIACHI = value; }

        public KHACHHANG(DataRow row)
        {
            this.MAKH = (string)row["MAKH"].ToString();
            this.HOTEN = (string)row["HOTEN"].ToString();
            this.EMAIL = (string)row["EMAIL"].ToString();
            this.CMND = (string)row["CMND"].ToString();
            this.SDT = (string)row["SDT"].ToString();
            this.FAX = (string)row["FAX"].ToString();
            this.DIACHI = (string)row["DIACHI"].ToString();
        }

    }
}
