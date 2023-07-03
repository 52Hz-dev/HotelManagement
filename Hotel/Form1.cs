using Hotel.DAO;
using Hotel.DTB;
using Hotel.DTO;
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
            KhachHang kh = new KhachHang(KhachHangDAO.selectIfKH());
            lbGetName.Text = kh.HoTen;
            lbGetCMND.Text = kh.CMND;
            lbGetSDT.Text = kh.SDT;
        }
        void loadListRoom()
        {
            int x = lbTitlePhong.Size.Width / 2;
            int y = lbTitlePhong.Size.Height;
            lbTitlePhong.Location = new Point(panel3.Size.Width / 2 - x, y);
            List<LOAIPHONG> ListRoom = LoaiPhongDAO.InfoRoom();
            DGV_ListRoom.DataSource = ListRoom;
        }

        void loadListDVThuong()
        {
            int x = lb_TitleDVThuong.Size.Width / 2;
            int y = lb_TitleDVThuong.Size.Height;
            lb_TitleDVThuong.Location = new Point(panel4.Size.Width / 2 - x, y);
            List<PHIEUSUDUNGDICHVU> DVThuong = PhieuSuDungDichVuDAO.selectDVThuong();
            DGV_DVThuong.DataSource = DVThuong;
        }
        void loadListDVTour()
        {
            int x = lb_TitleDVTour.Size.Width / 2;
            int y = lb_TitleDVTour.Size.Height;
            lb_TitleDVTour.Location = new Point(panel5.Size.Width / 2 - x, y);
            List<PHIEUSUDUNGDICHVUTOUR> DVTour = PhieuSuDungDichVuTourDAO.selectDVTour();
            DGV_DVTour.DataSource = DVTour;
        }
        void loadMiniBar()
        {
            int x = lb_TitleMiniBar.Size.Width / 2;
            int y = lb_TitleMiniBar.Size.Height;
            lb_TitleMiniBar.Location = new Point(panel6.Size.Width / 2 - x, y);
            lb_TitleDVTour.Location = new Point(panel5.Size.Width / 2 - x, y);
            List<DICHVU> MiniBar = DichVuDAO.listMiniBar();
            DGV_MiniBar.DataSource = MiniBar;
        }

        void loadTongTien()
        {
            int x = lbTitleTongTien.Size.Width / 2;
            int y = lbTitleTongTien.Size.Height;
            lbTitleTongTien.Location = new Point(panel9.Size.Width / 2 - x, y);
            int TienDVThuong = Convert.ToInt32(loadTienDVThuong());
            int TienDVTour = Convert.ToInt32(loadTienDVTour());
            int TienMiniBar = Convert.ToInt32(loadTienDVMiniBar());
            int TienPhong = Convert.ToInt32(loadTienPhong());
            int TienCoc = Convert.ToInt32(loadTienCoc());
            lbGetTongTien.Text = (TienPhong + TienDVThuong + TienDVTour + TienMiniBar - TienCoc).ToString();
        }

        String loadTienDVThuong()
        {

            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string tienDVThuong = PhieuSuDungDichVuDAO.TienDVThuong();
            lbGetTienDVThuong.Text = tienDVThuong;
            return tienDVThuong;
        }
        String loadTienDVTour()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string tienDVTour= PhieuSuDungDichVuTourDAO.TienDVTour();
            lbGetTienDVTour.Text = tienDVTour;
            return tienDVTour;
        }

        String loadTienDVMiniBar()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string tienMiniBar= DichVuDAO.TienMiniBar();
            lbGetTienMiniBar.Text = tienMiniBar;
            return tienMiniBar;
        }

        String loadTienPhong()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string TienPhong = PhieuDatPhongDAO.TienPhong();
            lbGetTienPhong.Text = TienPhong;
            return TienPhong;
        }
        String loadTienCoc()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string TienCoc = PhieuDatPhongDAO.TienCoc();
            lbGetTienCoc.Text = TienCoc;
            return TienCoc;
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

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
