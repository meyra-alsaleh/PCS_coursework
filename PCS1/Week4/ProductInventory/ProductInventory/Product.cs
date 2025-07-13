using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    internal class Product
    {
        // Instance variables
        private int code;
        private string name;
        private double price;
        private bool inStock;
        private int quantity;

        Random randNum = new Random();

        // Constructor
        public Product (string name, double price)
        {
            this.code = randNum.Next(1000, 9999);
            this.name = name;
            this.price = price;
            this.inStock = true;
        }

        public void SetInStock()
        {
            this.inStock = true;
        }

        public double CalculatePrice(int quantity)
        {
            return quantity * this.price;
        }

        public string GetInfo()
        {
            return "Name: " + this.name + "\nCode: " + this.code + "\nPrice: " + this.price; ;
        }
    }
}
