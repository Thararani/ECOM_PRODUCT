using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Assignment2
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, int price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;

        }
        public void StockIncrease(int value)
        {
            Stock = Stock + value;
        }
        public void StockDecrease(int value)
        {

            if (Stock == 0)

            {

                Console.WriteLine(" Insufficient stock ");

            }

            else if (Stock >= value)

            {

                Stock = Stock - value;

            }

            else

            {

                Console.WriteLine("pls provide a  valid number");

            }
        }

    }
}
