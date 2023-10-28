using Shop_system.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_system
{
    // Used to reduce repeated code
    internal static class Helper
    {
        // When items are added to cart, the value of the button changes. This occurs across many forms.
        public static List<CartProduct> UpdateCartButtonText(Customer customer, Button button)
        {

            List<CartProduct> cartProducts = new List<CartProduct>();

            using (MyDbContext db = new MyDbContext())
            {
                Cart existingCart = db.Carts.FirstOrDefault(c => c.UserId == customer.UserId);
                if (existingCart != null)
                {

                    foreach (CartProduct cartProduct in db.CartProducts)
                    {
                        if (existingCart.CartId == cartProduct.CartId)
                        {
                            cartProducts.Add(cartProduct);
                        }
                    }

                    string cartMessage = string.Format("Cart ({0})", cartProducts.Count());

                    button.Text = cartMessage;

                }
                else
                {
                    button.Text = "Cart (empty)";
                }
            }

            return cartProducts;

        }

        public static void NavigateNextWindowCustomer(Form current, Form destination)
        {
            destination.Show();
            current.Close();
        }
    }
}
