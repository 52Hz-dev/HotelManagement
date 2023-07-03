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

        public static DataRow InfoRoom()
        {
            string query = "select 	PDP.MAPDP, PDP.NGAYDAT, PDP.NGAYDEN, PDP.SODEMLUUTRU, PDP.GHICHU, PDP.TIENDATCOC, " +
                            "PDP.NGUOIDAT, PDP.HTTHANHTOAN, PDP.MANGUOILAP, PDP.NGAYCHECKIN " +
                            "from PHIEUDATPHONG AS PDP, KHACHHANG " +
                            "where KHACHHANG.MAKH = 'KH001' and KHACHHANG.MAKH = PDP.NGUOIDAT";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0];
        }
    }
}
