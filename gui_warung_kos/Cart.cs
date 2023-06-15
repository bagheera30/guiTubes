using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_warung_kos
{
    public partial class Cart : Form
    {
        private List<CartItem> cartItems;
        public Cart()
        {
            InitializeComponent();
            cartItems = new List<CartItem>();
        }
        public void AddItem(int menuNumber, string menuName, int menuPrice)
        {
            // Buat objek CartItem baru dengan informasi menu
            CartItem item = new CartItem(menuNumber, menuName, menuPrice);
            cartItems.Add(item);

            // Tampilkan item pada ListBox
            listBox1.Items.Add(item);

            // Perbarui total harga
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int totalPrice = 0;
            foreach (CartItem item in cartItems)
            {
                totalPrice += item.Price;
            }

            // Tampilkan total harga pada label
            labelTotalPrice.Text = "Total Price: $" + totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            listBox1.Items.Clear();
            UpdateTotalPrice();

            MessageBox.Show("Checkout successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class CartItem
    {
        public int MenuNumber { get; }
        public string MenuName { get; }
        public int Price { get; }

        public CartItem(int menuNumber, string menuName, int price)
        {
            MenuNumber = menuNumber;
            MenuName = menuName;
            Price = price;
        }

        public string GetDisplayText()
        {
            return MenuNumber + ". " + MenuName + " - $" + Price.ToString();
        }
    }
}
