﻿using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace Hotel.DTO
{
    internal class Room
    {
        private string _maph;

        private string _trangthai;
        private string _loaiphong;
        private int _dondep;

        public Room(string maph, string trangthai, string loaiphong, int dondep)
        {
            Maph = maph;
            Trangthai = trangthai;
            Loaiphong = loaiphong;
            Dondep = dondep;
        }
        public Room(DataRow dataRow)
        {
            Maph = (String)dataRow["MAPH"];
            Trangthai = (String)dataRow["TRANGTHAI"];
            Loaiphong = (String)dataRow["LOAIPH"];
            Dondep = (int)dataRow["DONDEP"];
        }
        public string Maph { get => _maph; set => _maph = value; }
        public string Trangthai { get => _trangthai; set => _trangthai = value; }
        public string Loaiphong { get => _loaiphong; set => _loaiphong = value; }
        public int Dondep { get => _dondep; set => _dondep = value; }
        static public List<Room> getListRoom()
        {
            List<Room> list = new List<Room>();
            DataTable table = TinhTrangPhongDAO.get_Room_inf();
            foreach (DataRow row in table.Rows)
            {
                Room room = new Room(row);
                list.Add(room);
            }
            return list;
        }
    }
}
