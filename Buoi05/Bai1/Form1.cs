using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = null;
        string strcon = "Server=LAPTOP-MDLF6AS5\\SQLEXPRESS;Database=QLBH;Trusted_Connection=True;";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlcon != null && sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
                MessageBox.Show("Da dong");
            }
        }
    }
}
