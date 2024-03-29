﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.json;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public class Menu
    {
        public int id { get; set; }
        public string Nama { get; set; }
        public int harga { get; set; }
        public string descripsi { get; set; }
        public int tersedia { get; set; }

    }

    public static class MenuManager
    {
        private static List<Menu> menus;
        private static string fp;

        static MenuManager()
        {
            fp = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "menu.json");
            menus = new List<Menu>();
            if (File.Exists(fp))
            {
                Deserialize();
            }
        }


        public static List<Menu> GetMenus()
        {
            return menus;
        }
        public static Menu getmenusbyNama(string nama)
        {
            return menus.FirstOrDefault(m => m.Nama == nama);
        }
        public static void Deserialize()
        {
            try
            {
                string jsonData = File.ReadAllText(fp);
                List<Menu> deserializedMenus = JsonSerializer.Deserialize<List<Menu>>(jsonData);
                ClearMenus();

                foreach (var menu in deserializedMenus)
                {
                    menus.Add(menu);
                    Console.WriteLine($"Menu '{menu.Nama}' has been added to the library.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while deserializing the library: {e.Message}");
            }
        }
        public static void ClearMenus()
        {
            menus.Clear();
        }
        public static string Serialize()
        {
            try
            {
                string json = JsonSerializer.Serialize(menus);
                File.WriteAllText(fp, json);
                return "Library has been serialized.";
            }
            catch (Exception ex)
            {
                return $"An error occurred while serializing the library: {ex.Message}";
            }
        }
        public static void addmenu(Menu m)
        {
            Contract.Requires(m != null, "Menu object is null.");

            Contract.Requires(!menus.Any(menu => menu.Nama == m.Nama), $"Menu with name '{m.Nama}' already exists.");

            menus.Add(m);
            Console.WriteLine($"Menu '{m.Nama}' has been added to the library.");

            Contract.Ensures(menus.Contains(m));
        }
        public static void UpdateMenu(string nama, Menu updatedMenu)
        {
            Contract.Requires(updatedMenu != null, "Updated menu object is null.");

            Contract.Ensures(menus.All(menu => menu.Nama != nama) || menus.Any(menu => menu.Nama == updatedMenu.Nama && menu.harga == updatedMenu.harga && menu.descripsi == updatedMenu.descripsi && menu.tersedia==updatedMenu.tersedia));

            Menu menu = menus.FirstOrDefault(m => m.Nama == nama);
            if (menu != null)
            {
                menu.Nama = updatedMenu.Nama;
                menu.harga = updatedMenu.harga; // Memperbarui nilai harga menu yang ada
                menu.descripsi = updatedMenu.descripsi;
                menu.tersedia = updatedMenu.tersedia;
                Console.WriteLine($"Menu with name '{nama}' has been updated: {menu.Nama}");
            }
            else
            {
                Console.WriteLine($"Menu with name '{nama}' not found.");
            }
        }

        public static void DeleteMenu(string nama)
        {
            Contract.Ensures(!menus.Any(menu => menu.Nama == nama));

            var menuToRemove = menus.FirstOrDefault(m => m.Nama == nama);
            if (menuToRemove != null)
            {
                menus.Remove(menuToRemove);
                Console.WriteLine($"Menu with name '{nama}' has been deleted from the library.");
            }
            else
            {
                Console.WriteLine($"Menu with name '{nama}' not found.");
            }

        }
    }
}
