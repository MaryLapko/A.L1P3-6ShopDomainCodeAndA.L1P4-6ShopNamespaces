using InternetShop.Domain.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Domain.Customer
{
    public abstract class Customer
    {
        public List<Payment> Payments = new List<Payment>();
        private int Money { get; set; }
        public int CustomerId;
        public string FirstName;
        public string LastName;
        public string Address;
        public int Phone;
        public string EmailAddress;

        public Customer()
        {
            Money = 0;
        }

        public int GetMoney()
        {
            return Money;
        }

        public void Deposit(int money)
        {
            Money += money;
        }
        
        public void Withdraw(int money)
        {
            if (Money < money)
            {
                throw new ArgumentException();
            }

            Money -= money;
        }

    }
}
