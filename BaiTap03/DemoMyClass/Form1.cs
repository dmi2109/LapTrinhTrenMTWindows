using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMyClass
{
    public partial class frmDemoMyClass : Form
    {
        public frmDemoMyClass()
        {
            InitializeComponent();
        }

        private void frmDemoMyClass_Load(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;


            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

            DateTime ngaySinh = dtpNgaySinh.Value;
            string ngaySinhString = ngaySinh.ToString("dd/MM/yyyy");


            string soThich = "";
            if (chkTheThao.Checked) soThich += "Thể thao, ";
            if (chkPhim.Checked) soThich += "Phim ảnh, ";
            if (chkDuLich.Checked) soThich += "Du lịch, ";
            if (soThich.EndsWith(", ")) soThich = soThich.Substring(0, soThich.Length - 2);

            string[] row = { hoTen, gioiTinh, ngaySinhString, soThich };

            ListViewItem item = new ListViewItem(row);
            lvThongTin.Items.Add(item);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvThongTin.SelectedItems.Count > 0)
            {
                lvThongTin.Items.Remove(lvThongTin.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
                if (lvThongTin.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lvThongTin.SelectedItems[0];

                    selectedItem.SubItems[0].Text = txtHoTen.Text;

                    selectedItem.SubItems[1].Text = radNam.Checked ? "Nam" : "Nữ";

                    selectedItem.SubItems[2].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                    
                    string soThich = "";
                    if (chkTheThao.Checked) soThich += "Thể thao, ";
                    if (chkPhim.Checked) soThich += "Phim ảnh, ";
                    if (chkDuLich.Checked) soThich += "Du lịch, ";
                    if (soThich.EndsWith(", ")) soThich = soThich.Substring(0, soThich.Length - 2);

                    selectedItem.SubItems[3].Text = soThich;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một mục để sửa.");
                }
            

        }

        private void lvThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongTin.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvThongTin.SelectedItems[0];

                txtHoTen.Text = selectedItem.SubItems[0].Text;


                if (selectedItem.SubItems[1].Text == "Nam") radNam.Checked = true;
                else radNu.Checked = true;

                DateTime ngaySinh;
                string format = "dd/MM/yyyy";
                if (DateTime.TryParseExact(selectedItem.SubItems[2].Text, format, null, System.Globalization.DateTimeStyles.None, out ngaySinh))
                {
                    dtpNgaySinh.Value = ngaySinh;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không đúng định dạng.");
                }

                chkTheThao.Checked = selectedItem.SubItems[3].Text.Contains("Thể thao");
                chkPhim.Checked = selectedItem.SubItems[3].Text.Contains("Phim ảnh");
                chkDuLich.Checked = selectedItem.SubItems[3].Text.Contains("Du lịch");
            }
        }
    }
}
