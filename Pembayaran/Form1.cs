using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace Pembayaran
{
    public partial class Form1 : Form
    {
        public int tagihanDefault;
        public Form1()
        {
            InitializeComponent();

            LoadTagihan();
        }

        private void LoadTagihan()
        {
            try
            {
                // Membaca isi file "tagihan.json"
                string json = File.ReadAllText("tagihan.json");

                // Deserialisasi JSON menjadi objek
                var data = JsonConvert.DeserializeObject<dynamic>(json);

                // Mendapatkan nilai tagihanDefault dari data JSON
                tagihanDefault = data.tagihanDefault;
            }
            catch (Exception ex)
            {
                // Menangani kesalahan jika terjadi masalah saat membaca file JSON
                MessageBox.Show("Terjadi kesalahan saat memuat data tagihan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Menampilkan nilai tagihanDefault pada TextBox
            tagihan.Text = tagihanDefault.ToString();
        }
        private void infometode_TextChanged(object sender, EventArgs e)
        {
            if (infometode.Text == "")
            {
                infometode.Text = "Cash";
            }
            if (qrisRadioButton.Checked)
            {
                infometode.Text = "QRIS";
            }
            else if (cashRadioButton.Checked)
            {
                infometode.Text = "Cash";
            }
            else if (ewalletRadioButton.Checked)
            {
                infometode.Text = "E-Wallet";
            }
        }

        private void qrisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (qrisRadioButton.Checked)
            {
                infometode.Text = "QRIS";
            }
        }

        private void cashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cashRadioButton.Checked)
            {
                infometode.Text = "Cash";
            }
        }

        private void ewalletRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ewalletRadioButton.Checked)
            {
                infometode.Text = "E-Wallet";
            }
        }

        private async void bayar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(pembayaran.Text, out int jumlahPembayaran))
            {
                if (jumlahPembayaran == tagihanDefault)
                {
                    MessageBox.Show("Pembayaran sedang diproses...", "Informasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await Task.Delay(2000); // Menunda eksekusi selama 2 detik (2000 milidetik)

                    string metodePembayaran = infometode.Text;

                    if (metodePembayaran == "QRIS" || metodePembayaran == "E-Wallet")
                    {
                        string informasi = $"Tagihan: {tagihanDefault}\nJumlah Pembayaran: {jumlahPembayaran}\nMetode Pembayaran: {metodePembayaran}";
                        MessageBox.Show("Pembayaran sukses!\n\n" + informasi, "Informasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (metodePembayaran == "Cash")
                    {
                        int kembalian = jumlahPembayaran - tagihanDefault;
                        string informasi = $"Tagihan: {tagihanDefault}\nJumlah Pembayaran: {jumlahPembayaran}\nMetode Pembayaran: {metodePembayaran}\nKembalian: {kembalian}";
                        MessageBox.Show("Pembayaran sukses!\n\n" + informasi, "Informasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Pembayaran gagal! Jumlah pembayaran tidak sesuai dengan tagihan.", "Informasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Jumlah pembayaran tidak valid!", "Informasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tagihan_TextChanged(object sender, EventArgs e)
        {
            if (tagihan.Text == string.Empty)
            {
                tagihan.Text = tagihanDefault.ToString();
            }
        }
    }
}
