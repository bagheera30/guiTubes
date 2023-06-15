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
    public partial class pembayaran1 : Form
    {
        private int tagihanDefault;
        private int Tagihan;

        public pembayaran1()
        {
            InitializeComponent();

            LoadTagihan(Tagihan);
        }

        public void LoadTagihan(int tagihan)
        {
            try
            {
                string json = File.ReadAllText("tagihan.json");
                var data = JsonConvert.DeserializeObject<dynamic>(json);
                tagihanDefault = data.tagihanDefault;
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Terjadi kesalahan saat memuat data tagihan: " + ex.Message);
            }

            DisplayTagihan(tagihan);
        }

        private void DisplayTagihan(int total)
        {
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
                    await Task.Delay(2000);

                    string metodePembayaran = infometode.Text;

                    if (metodePembayaran == "QRIS" || metodePembayaran == "E-Wallet")
                    {
                        ShowPaymentSuccess(tagihanDefault, jumlahPembayaran, metodePembayaran);
                    }
                    else if (metodePembayaran == "Cash")
                    {
                        int kembalian = jumlahPembayaran - tagihanDefault;
                        ShowPaymentSuccess(tagihanDefault, jumlahPembayaran, metodePembayaran, kembalian);
                    }
                }
                else
                {
                    ShowErrorMessage("Pembayaran gagal! Jumlah pembayaran tidak sesuai dengan tagihan.");
                }
            }
            else
            {
                ShowErrorMessage("Jumlah pembayaran tidak valid!");
            }
        }

        private void ShowPaymentSuccess(int tagihan, int jumlahPembayaran, string metodePembayaran, int kembalian = 0)
        {
            string informasi = $"Tagihan: {tagihan}\nJumlah Pembayaran: {jumlahPembayaran}\nMetode Pembayaran: {metodePembayaran}";

            if (kembalian > 0)
            {
                informasi += $"\nKembalian: {kembalian}";
            }

            MessageBox.Show("Pembayaran sukses!\n\n" + informasi, "Informasi Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tagihan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tagihan.Text))
            {
                DisplayTagihan(Tagihan);
            }
        }
        private void infotagihan_Click(object sender, EventArgs e)
        {

        }
    }
}
