using Hotel.DTB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadIfKH();
            loadListRoom();
            loadListDVThuong();
            loadListDVTour();
            loadMiniBar();
            loadTongTien();
        }

        void loadIfKH()
        {
            int x = lBTitle.Size.Width / 2;
            int y = lBTitle.Size.Height;
            lBTitle.Location = new Point(panel2.Size.Width / 2 - x, y);
            string query = "select * from KHACHHANG where MAKH = 'KH001'";
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(query);
            lbGetName.Text = dt.Rows[0]["HOTEN"].ToString();
            lbGetCMND.Text = dt.Rows[0]["CMND"].ToString();
            lbGetSDT.Text = dt.Rows[0]["SDT"].ToString();

        }
        void loadListRoom()
        {
            int x = lbTitlePhong.Size.Width / 2;
            int y = lbTitlePhong.Size.Height;
            lbTitlePhong.Location = new Point(panel3.Size.Width / 2 - x, y);
            string query = "select 	PDP.MAPDP, PDP.MANGUOILAP, PDP.SODEMLUUTRU, PDP.NGAYDAT, PDP.NGAYDEN,PDP.GHICHU " +
                            "from PHIEUDATPHONG AS PDP, KHACHHANG " +
                            "where KHACHHANG.MAKH = 'KH001' and KHACHHANG.MAKH = PDP.NGUOIDAT";
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(query);
            lbGetNVPhong.Text = dt.Rows[0]["MANGUOILAP"].ToString();
            lbGetNgayDat.Text = dt.Rows[0]["NGAYDAT"].ToString();
            lbGetNgayDen.Text = dt.Rows[0]["NGAYDEN"].ToString();
            lbGetSoNgay.Text = dt.Rows[0]["SODEMLUUTRU"].ToString();
            lbGetNotePhong.Text = dt.Rows[0]["GHICHU"].ToString();
        }

        void loadListDVThuong()
        {
            int x = lb_TitleDVThuong.Size.Width / 2;
            int y = lb_TitleDVThuong.Size.Height;
            lb_TitleDVThuong.Location = new Point(panel4.Size.Width / 2 - x, y);
            string query = "select DV.MAPDV, DV.MAPDP, DV.MADV,DV.NOIDUNG, DV.SOLUONG, DV.THANHTIEN, DV.NGAYLAP, DV.MANGUOILAP " +
                           "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU AS DV " +
                           "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = DV.MAPDP";
            DataProvider provider = new DataProvider();
            DGV_DVThuong.DataSource = provider.ExecuteQuery(query);
        }
        void loadListDVTour()
        {
            int x = lb_TitleDVTour.Size.Width / 2;
            int y = lb_TitleDVTour.Size.Height;
            lb_TitleDVTour.Location = new Point(panel5.Size.Width / 2 - x, y);
            string query = "select TOUR.MADVT, TOUR.MANGUOILAP, TOUR.MAPDP, TOUR.MAPDVT, TOUR.NGAYLAP, TOUR.SLNGUOI, TOUR.TGKHOIHANH, TOUR.THANHTIEN " +
                           "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVUTOUR AS TOUR " +
                           "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = TOUR.MAPDP";
            DataProvider provider = new DataProvider();
            DGV_DVTour.DataSource = provider.ExecuteQuery(query);
        }
        void loadMiniBar()
        {
            int x = lb_TitleMiniBar.Size.Width / 2;
            int y = lb_TitleMiniBar.Size.Height;
            lb_TitleMiniBar.Location = new Point(panel6.Size.Width / 2 - x, y);
            string query = "select DICHVU.MADV,DICHVU.TENDV,DICHVU.THONGTIN,DICHVU.DONGIA " +
                "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU, DICHVU " +
                "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT " +
                "and PHIEUDATPHONG.MAPDP = PHIEUSUDUNGDICHVU.MAPDP and PHIEUSUDUNGDICHVU.MADV = DICHVU.MADV";
            DataProvider provider = new DataProvider();
            DGV_MiniBar.DataSource = provider.ExecuteQuery(query);
        }

        void loadTongTien()
        {
            int x = lbTitleTongTien.Size.Width / 2;
            int y = lbTitleTongTien.Size.Height;
            lbTitleTongTien.Location = new Point(panel9.Size.Width / 2 - x, y);
            int TienDVThuong = Convert.ToInt32(loadTienDVThuong());
            int TienDVTour = Convert.ToInt32(loadTienDVTour());
            int TienMiniBar = Convert.ToInt32(loadTienDVMiniBar());
            lbGetTongTien.Text = (TienDVThuong + TienDVTour + TienMiniBar).ToString();
        }

        String loadTienDVThuong()
        {
            string query = "select SUM(THANHTIEN*SOLUONG) " +
                           "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU AS DV " +
                           "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = DV.MAPDP";
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(query);
            lbGetTienDVThuong.Text = dt.Rows[0][0].ToString();
            return dt.Rows[0][0].ToString();
        }
        String loadTienDVTour()
        {
            string query = "select SUM(THANHTIEN*SLNGUOI) " +
                           "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVUTOUR AS TOUR " +
                           "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = TOUR.MAPDP";
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(query);
            lbGetTienDVTour.Text = dt.Rows[0][0].ToString();
            return dt.Rows[0][0].ToString();
        }

        String loadTienDVMiniBar()
        {
            string query = "select SUM(DONGIA) AS TongTienMiniBar " +
                            "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU, DICHVU " +
                            "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = PHIEUSUDUNGDICHVU.MAPDP " +
                            "and PHIEUSUDUNGDICHVU.MADV = DICHVU.MADV;";
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            dt = provider.ExecuteQuery(query);
            lbGetTienMiniBar.Text = dt.Rows[0][0].ToString();
            return dt.Rows[0][0].ToString();
        }

        private void txt_DV_SuDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
