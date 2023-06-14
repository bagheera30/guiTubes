using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gui_warung_kos
{
    public partial class daftarMenu : Form
    {
        private const string url = "http://localhost:5065/api/menu";
        HttpClient httpClient;
        private Timer timer;
        public daftarMenu()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private async void daftarMenu_LoadAsync(object sender, EventArgs e)
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

        private async void button1_Click(object sender, EventArgs e)
        {

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

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Add"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Dapatkan nilai dari sel yang diklik
                    int menuId = (int)dataGridView1.Rows[e.RowIndex].Cells["No"].Value;
                    string menuName = (string)dataGridView1.Rows[e.RowIndex].Cells["Nama"].Value;
                    int menuPrice = (int)dataGridView1.Rows[e.RowIndex].Cells["harga"].Value;

                    // Tambahkan nilai ke form keranjang (misalnya, menggunakan form keranjang bernama "cartForm")
                    cartForm.AddItem(menuId, menuName, menuPrice);

                    MessageBox.Show("Menu added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add menu to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
    public class Menu
    {
        public int id { get; set; }
        public string Nama { get; set; }
        public int harga { get; set; }
        public string descripsi { get; set; }
        public int tersedia { get; set; }
    }
}
