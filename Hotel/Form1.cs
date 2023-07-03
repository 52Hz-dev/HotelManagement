using Hotel.DAO;
using Hotel.DTB;
using Hotel.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            PHIEUDATPHONG infpdp = new PHIEUDATPHONG(PhieuDatPhongDAO.InfoRoom());
            lbGetNVPhong.Text = infpdp.MANGUOILAP1;
            lbGetNgayDat.Text = infpdp.NGAYDAT1;
            lbGetNgayDen.Text = infpdp.NGAYDEN1;
            lbGetSoNgay.Text = infpdp.SODEMLUUTRU1;
            lbGetNotePhong.Text = infpdp.GHICHU1;
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
            DGV_DVTour.DataSource = MiniBar;
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
            thanhTien = lbGetTongTien.Text;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
            PdfWriter writer=PdfWriter.GetInstance(doc,new FileStream("../../HoaDon/Create.pdf",FileMode.Create));
            doc.Open();
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bm, System.Drawing.Imaging.ImageFormat.Bmp);
            img.ScaleAbsoluteWidth(550f);
            img.ScaleAbsoluteHeight(800f);
            doc.Add(img);
            doc.Close();
            MessageBox.Show("In hoa don thanh cong");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            String mahd = HoaDon.GenerateNewId();
            HoaDon hd = new HoaDon(mahd, maPDP, thanhTien, "NV001");
        }
        private String maPDP;
        private String thanhTien;
    }
}
