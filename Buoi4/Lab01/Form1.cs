using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void delPassDate(TextBox text);

        
        private void btnTruyen_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            delPassDate del = new delPassDate(frm.funData);
            del(this.txtDuLieu);
            frm.Show();
        }

        
       
    }
}
