﻿using Hotel.DTB;
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
        public static string GetLastId()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select MAPDP from PHIEUDATPHONG");
            return data.Rows[data.Rows.Count - 1]["MaPDP"].ToString();
        }


        public static bool Insert(PhieuDatPhong phieudp)
        {
            string query = $"INSERT INTO PHIEUDATPHONG (MAPDP, NGAYDAT, NGAYDEN, SODEMLUUTRU, GHICHU, TIENDATCOC, NGUOIDAT, TINHTRANG)\r\nVALUES ('{phieudp.MaDatPhong}', '{phieudp.NgayDat.ToShortDateString()}', '{phieudp.NgayDen.ToShortDateString()}', {phieudp.SoDemLT}, N'{phieudp.GhiChu}', {phieudp.TienDaTra}, '{phieudp.MaKH}', N'Chờ check in')";
            var count = DataProvider.Instance.ExecuteNonQuery(query);
            if (count > 0) return true;
            else return false;
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
