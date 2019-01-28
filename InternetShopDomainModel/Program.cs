using InternetShop.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Domain.Common
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer.Customer customer = new BusinessCustomer();
            customer.FirstName = "Alexander";
            customer.LastName = "Sidorov";
            customer.Phone = 2345678;
            customer.Deposit(1000);
            ShoppingCart shoppingCart = new ShoppingCart(customer);
            Product.Product tvProduct = new Product.TVProduct();
            tvProduct.ProductName = "Samsung";
            tvProduct.ProductPrice = 500;
            shoppingCart.AddToShoppingCart(tvProduct);
            shoppingCart.Buy();           
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " available money: " + customer.GetMoney());
            Console.ReadLine();
            

            


        }
    }
}
