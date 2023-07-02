using Hotel.DAO;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class fCHECKIN : Form
    {
        public fCHECKIN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fCHECKIN_THANHCONG form = new fCHECKIN_THANHCONG();
            form.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fCHECKIN_Load(object sender, EventArgs e)
        {
            cbAttribute.Items.Clear();
            cbAttribute.Items.Add("Mã phiếu");
            cbAttribute.Items.Add("Họ tên");
            cbAttribute.Items.Add("CMND");
            cbAttribute.Items.Add("SĐT");
            cbAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            List<PHIEUDATPHONG> pdp = PhieuDatPhongDAO.DS_PDP_CHOCHECKIN();
            dgvPHIEUDATPHONG.DataSource = pdp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgvPHIEUDATPHONG.DataSource = PHIEUDATPHONG.FILTER_WITH_ATTRIBUTE(attribute,value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dgvPHIEUDATPHONG.DataSource = PHIEUDATPHONG.DS_PDP_CHOCHECKIN(trangthai);
        }
    }
}
