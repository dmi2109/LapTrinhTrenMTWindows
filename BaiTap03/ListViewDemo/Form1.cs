using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class frmListViewDemo : Form
    {
        public frmListViewDemo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtLastName.Text);
            lvi.SubItems.Add(txtFirstName.Text);
            lvi.SubItems.Add(txtPhone.Text);
            lvHoTen.Items.Add(lvi);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
