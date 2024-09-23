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
    public partial class frmDGV : Form
    {
        public frmDGV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNhanVien = new frmNhanVien();
            if(frmNhanVien.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(frmNhanVien.MSNV, frmNhanVien.tenNhanVien, frmNhanVien.luongCB);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                frmNhanVien frmNhanVien = new frmNhanVien();
                frmNhanVien.MSNV = row.Cells[0].Value.ToString();
                frmNhanVien.tenNhanVien = row.Cells[1].Value.ToString();
                frmNhanVien.luongCB = row.Cells[2].Value.ToString();

                if (frmNhanVien.ShowDialog(this) == DialogResult.OK)
                {
                    row.Cells[0].Value = frmNhanVien.MSNV;
                    row.Cells[1].Value = frmNhanVien.tenNhanVien;
                    row.Cells[2].Value = frmNhanVien.luongCB;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
