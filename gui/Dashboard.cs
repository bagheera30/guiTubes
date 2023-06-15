using Login;
using Pembayaran;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pembayaranform = new pembayaran1();
            this.Visible = false;
            pembayaranform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loginform = new LoginForm();
            this.Visible = false;
            loginform.Show();
        }
    }
}
