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
    internal class PhieuSuDungDichVuTourDAO
    {
        public static List<PHIEUSUDUNGDICHVUTOUR> selectDVTour()
        {
            List<PHIEUSUDUNGDICHVUTOUR> list = new List<PHIEUSUDUNGDICHVUTOUR>();
            string query = "select TOUR.MADVT, TOUR.MANGUOILAP, TOUR.MAPDP, TOUR.MAPDVT, TOUR.NGAYLAP, TOUR.SLNGUOI, TOUR.TGKHOIHANH, TOUR.THANHTIEN " +
                           "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVUTOUR AS TOUR " +
                           "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = TOUR.MAPDP"; DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUSUDUNGDICHVUTOUR DVTour = new PHIEUSUDUNGDICHVUTOUR(dr);
                list.Add(DVTour);
            }
            return list;
        }
    }
}
