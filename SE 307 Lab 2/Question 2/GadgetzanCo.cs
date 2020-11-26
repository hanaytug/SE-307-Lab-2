using System;

namespace SE_307_Lab_2
{
    public class GadgetzanCo
    {
        private int _productNumber;
        public int ProductNumber { get => _productNumber; set => _productNumber = value; }

        private string _productName;
        public string ProductName { get => _productName; set => _productName = value; }

        private double _price;
        public double Price { get => _price; set => _price = value; }

        private int _quantity;
        public int Quantity { get => _quantity; set => _quantity = value; }


        public GadgetzanCo()
        {
            _productNumber = 1000;
            _productName = "item";
            _price = 0;
            _quantity = 0;

        }

        public GadgetzanCo(int productNumber, string productName, double price, int quantity)
        {
            _productNumber = productNumber;
            _productName = productName;
            _price = price;
            _quantity = quantity;
        }

        private double CalculateCost()
        {
            return Price * Quantity;
        }

        public void DisplayCost()
        {
            Console.WriteLine("Product Number : " + ProductNumber);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Unit Price : " + Price);
            Console.WriteLine("Quantity : " + Quantity);
            Console.WriteLine("Total Cost : " + CalculateCost());
            Console.WriteLine("--------------------------------");
        }
    }
}