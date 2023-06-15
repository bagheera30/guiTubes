using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class daftarMenu : Form
    {
        private const string url = "http://localhost:5046/api/menu";
        HttpClient httpClient;
        private Timer timer;
        CartForm cart = new CartForm();
        public daftarMenu()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mendapatkan daftar menu dari API
                List<Menu> menus = await GetMenusFromApi();

                // Mendapatkan ID terbesar dari daftar menu
                int lastId = menus.Count > 0 ? menus.Max(m => m.id) : 0;

                Menu menu = new Menu
                {
                    id = lastId + 1, // Menambahkan 1 ke ID terakhir untuk mendapatkan ID baru
                    Nama = textBox1.Text.Trim(),
                    harga = int.Parse(textBox2.Text.Trim()),
                    descripsi = textBox3.Text.Trim(),
                    tersedia = int.Parse(textBox4.Text.Trim())
                };

                await AddMenuToApi(menu);

                MessageBox.Show("Menu added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add menu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void daftarMenu_Load(object sender, EventArgs e)
        {
            try
            {
                await RefreshDataGridView();
                timer.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to fetch menus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                await RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to fetch menus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task RefreshDataGridView()
        {
            var menus = await GetMenusFromApi();
            dataGridView1.DataSource = menus;
        }
        private async Task<List<Menu>> GetMenusFromApi()
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Menu>>(json);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Add"].Index && e.RowIndex >= 0)
            {
                try
                {
                    object menuNameObj = dataGridView1.Rows[e.RowIndex].Cells["namaDataGridViewTextBoxColumn"].Value;
                    object menuPriceObj = dataGridView1.Rows[e.RowIndex].Cells["hargaDataGridViewTextBoxColumn"].Value;

                    if (menuNameObj != null && menuPriceObj != null)
                    {
                        string menuName = menuNameObj.ToString();
                        int menuPrice;

                        if (int.TryParse(menuPriceObj.ToString(), out menuPrice))
                        {
                            // Tambahkan nilai ke form keranjang (cartForm)
                            cart.AddItem(menuName, menuPrice);

                            MessageBox.Show("Menu added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid menu price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add menu to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private async Task AddMenuToApi(Menu menu)
        {
            var json = JsonConvert.SerializeObject(menu);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
        }
        private void ClearInputFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void keranjang_Click(object sender, EventArgs e)
        {
            cart.Show();
            this.Hide();
        }
    }
}
