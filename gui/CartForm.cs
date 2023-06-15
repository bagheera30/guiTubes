using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class CartForm : Form
    {
        private List<CartItem> cartItems;
        public CartForm()
        {
            InitializeComponent();
            cartItems = new List<CartItem>();
        }
        public void AddItem(string menuName, int menuPrice)
        {
            // Buat objek CartItem baru dengan informasi menu
            CartItem item = new CartItem(menuName, menuPrice);
            cartItems.Add(item);

            // Tampilkan item pada ListBox
            listBox1.Items.Add(item.GetDisplayText());

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

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            // Lakukan proses checkout
            // ...

            // Reset keranjang
            cartItems.Clear();
            listBox1.Items.Clear();
            UpdateTotalPrice();

            MessageBox.Show("Checkout successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
