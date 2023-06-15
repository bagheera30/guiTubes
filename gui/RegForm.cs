using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;
using Registration;
using UtilityLibrary;

namespace RegistrationForm
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegistrationLibrary.areNull(namaTextBox.Text) || RegistrationLibrary.areNull(usernameTextBox.Text) 
                || RegistrationLibrary.areNull(pwTextBox.Text) || RegistrationLibrary.areNull(cpwTextBox.Text))
            {
                MessageBox.Show("Silahkan isi kolom yang masih kosong");
            }
            else if (RegistrationClass.checkUsername(namaTextBox.Text)){
                MessageBox.Show("Username sudah ada, silahkan masukkan ulang.");
            }else if (!RegistrationClass.checkPassword(pwTextBox.Text)) {
                MessageBox.Show("Password minimal 8 karakter");
            } else if (pwTextBox.Text != cpwTextBox.Text)
            {
                MessageBox.Show("password tidak sama, silahkan masukkan ulang");
            }
            else
            {
                try
                {
                    RegistrationClass.createAkun(namaTextBox.Text, usernameTextBox.Text, pwTextBox.Text);
                    MessageBox.Show("Akun Berhasil Dibuat, silahkan ke halaman login");
                } catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan pada saat register: " +  ex.Message);
                }
                
                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cpwTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var loginform = new LoginForm();
            this.Visible = false;
            loginform.Show();
        }
    }
}
