using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui
{
    public class CartItem
    {
<<<<<<< HEAD
        public int MenuId { get; }
=======
        
>>>>>>> master
        public string MenuName { get; }
        public int Price { get; }

        public CartItem(string menuName, int price)
        {
<<<<<<< HEAD
            
=======

>>>>>>> master
            MenuName = menuName;
            Price = price;
        }

        public string GetDisplayText()
        {
            return MenuName + " - $" + Price.ToString();
        }
    }
}
