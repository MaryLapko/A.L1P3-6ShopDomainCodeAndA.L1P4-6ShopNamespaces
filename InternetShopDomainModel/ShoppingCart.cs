using InternetShop.Domain.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Domain.Common
{
    public class ShoppingCart
    {
        private List<Product.Product> Products;
        public Customer.Customer Customer;

        public ShoppingCart(Customer.Customer customer)
        {
            Products = new List<Product.Product>();
            Customer = customer;
        }
        public void AddToShoppingCart(Product.Product product)
        {
            Products.Add(product);
        }

        public void Buy()
        {
            Payment.MakePayment(Products, Customer);
        }
        public void Clear()
        {
            Products.Clear();
        }
    }
}
