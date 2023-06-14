﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}