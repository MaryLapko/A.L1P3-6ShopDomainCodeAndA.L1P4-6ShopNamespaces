using InternetShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Domain.Finance
{
    public enum PaymentStatus
    {
        Success,
        Error
    }
    public class Payment
    {
        public List<Product.Product> Products;
        public ShoppingCart ShoppingCart;
        public Customer.Customer Customer;
        public PaymentStatus Status;
        public int Amount;

        private Payment()
        {
            Products = new List<Product.Product>();
        }
        public static void MakePayment(List<Product.Product> products, Customer.Customer customer)
        {
            Payment payment = new Payment();
            payment.Customer = customer;
            payment.Products = products;
            int amount = 0;
            foreach (Product.Product product in products)
            {
                amount += product.ProductPrice;
            }
            if (customer.GetMoney() < amount)
            {
                payment.Status = PaymentStatus.Error;
                return;
            }
            customer.Withdraw(amount);
            payment.Status = PaymentStatus.Success;
            customer.Payments.Add(payment);

        }

    }
}
