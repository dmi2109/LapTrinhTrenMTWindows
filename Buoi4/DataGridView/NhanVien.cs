using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class frmNhanVien : Form
    {

        public string MSNV {  get; set; }
        public string tenNhanVien { get; set; }
        public string luongCB { get; set; }
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txtMa.Text;
            tenNhanVien = txtTen.Text;
            luongCB = txtLuong.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMa.Text = MSNV;
            txtTen.Text = tenNhanVien;
            txtLuong.Text = luongCB;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
