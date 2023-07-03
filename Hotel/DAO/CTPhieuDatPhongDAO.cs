using Hotel.DTB;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    public class CTPhieuDatPhongDAO
    {
        public static bool Insert(CTPhieuDatPhong chitiet)
        {
            int result = DataProvider.Instance.ExecuteNonQuery($"INSERT INTO CHITIETDATPHONG (MAPDP, MAPH) VALUES ('{chitiet.MaPDP}', '{chitiet.MaPH}');");
            return result > 0;        
        }
    }
}
