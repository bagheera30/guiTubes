using gui;
using RegistrationForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Panggil logika table driven atau automata
            ProcessTableDrivenLogic(username, password);
            // atau
            ProcessAutomataLogic(username, password);

            var dashboardform = new Dashboard();
            this.Visible = false;
            dashboardform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var regisform = new RegForm();
            this.Visible = false;
            regisform.Show();

        }

        private void ProcessTableDrivenLogic(string username, string password)
        {
            // Kode logika table driven Anda di sini
            // ...

            Console.WriteLine("Proses logika table driven");
            // Contoh aksi berdasarkan hasil logika table driven
            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Login berhasil (table driven)");
            }
            else
            {
                MessageBox.Show("Login gagal (table driven)");
            }
        }

        // Method untuk logika automata
        private void ProcessAutomataLogic(string username, string password)
        {
            // Kode logika automata Anda di sini
            // ...

            Console.WriteLine("Proses logika automata");
            // Contoh aksi berdasarkan hasil logika automata
            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Login berhasil (automata)");
            }
            else
            {
                MessageBox.Show("Login gagal (automata)");
            }
        }

     
    }
}
