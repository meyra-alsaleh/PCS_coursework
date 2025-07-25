using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnackBar
{
    internal class Snack
    {
        private double costPrice;
        private bool isVegetarian;
        private string name;
        private int numberInStock;

        public Snack(string name,double costPrice, int numberInStock, bool isVegeterian )
        {
            this.name = name;
            this.costPrice = costPrice;
            this.numberInStock = numberInStock;
            this.isVegetarian = isVegeterian;
        }
        

        public string GetInfo()
        {
            string isVeggie;

            isVeggie = this.isVegetarian ? "Yes" : "No";

            return "Name: " + this.name + "\nPrice: " + this.costPrice + "\nNumber in stock: " + this.numberInStock + "\nVegeterian: " + isVeggie;
        }
    }
}
