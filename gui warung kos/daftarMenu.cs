<<<<<<< HEAD
﻿using System;
=======
<<<<<<< HEAD
﻿using System;
=======
﻿using Newtonsoft.Json;
using System;
>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
>>>>>>> 686a2c4bc99fc84d965e9d489b3a36fd9ace55ee
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
<<<<<<< HEAD
using Newtonsoft.Json;
=======
>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
>>>>>>> 686a2c4bc99fc84d965e9d489b3a36fd9ace55ee

namespace gui_warung_kos
{
    public partial class daftarMenu : Form
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD

=======
>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
>>>>>>> 686a2c4bc99fc84d965e9d489b3a36fd9ace55ee
        private const string url = "http://localhost:5065/api/menu";
        HttpClient httpClient;
        private Timer timer;
        public daftarMenu()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            timer = new Timer();
<<<<<<< HEAD
            timer.Interval = 100;
=======
<<<<<<< HEAD
            timer.Interval = 5000;
>>>>>>> 686a2c4bc99fc84d965e9d489b3a36fd9ace55ee
            timer.Tick += Timer_Tick;
        }

        private async void daftarMenu_Load(object sender, EventArgs e)
<<<<<<< HEAD
=======
=======
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private async void daftarMenu_LoadAsync(object sender, EventArgs e)
>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
>>>>>>> 686a2c4bc99fc84d965e9d489b3a36fd9ace55ee
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
<<<<<<< HEAD

=======
<<<<<<< HEAD
=======

>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
>>>>>>> 686a2c4bc99fc84d965e9d489b3a36fd9ace55ee
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
<<<<<<< HEAD
    }
}
=======

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {

=======
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
>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
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
<<<<<<< HEAD
        
=======

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["action"].Index && e.RowIndex >= 0)
            {
                try
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                }
            }
        }
     
>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
    }
    public class Menu
    {
        public int id { get; set; }
        public string Nama { get; set; }
        public int harga { get; set; }
        public string descripsi { get; set; }
        public int tersedia { get; set; }
    }
<<<<<<< HEAD

}
=======
}

>>>>>>> 7730df9977e186fe5e42fc8760cd551a8405c167
>>>>>>> 686a2c4bc99fc84d965e9d489b3a36fd9ace55ee
