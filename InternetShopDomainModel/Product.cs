using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Domain.Product
{
    public abstract class Product
    {
        public int ProductId;
        public string ProductName;
        public string ProductImage;
        public string ProductDescription;
        public int ProductPrice;
        public bool ProductInStock;
        public bool ProductOutOfStock;
       


    }
}
