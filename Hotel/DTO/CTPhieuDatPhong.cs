using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.DTO
{
    public class CTPhieuDatPhong
    {
        public string MaPDP { get; set; }
        public string MaPH { get; set; }

        public CTPhieuDatPhong(string maPDP, string maPH)
        {
            MaPDP = maPDP;
            MaPH = maPH;
        }



        public static bool Insert(CTPhieuDatPhong chitiet)
        {
            return CTPhieuDatPhongDAO.Insert(chitiet);
        }
    }
}
