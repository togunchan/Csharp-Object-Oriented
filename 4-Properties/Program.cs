using System;

namespace _4_Properties
{
    class Product
    {
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                    this._name = value;
                else
                    // Console.WriteLine("Name alanı boş geçilemez...");
                    throw new Exception("Name alanı boş geçilemez!");
                    
            }
        }
        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value < 0){
                    this._price = 0;
                    System.Console.WriteLine("Eksi değer girilemez!");
                }

                else
                    this._price = value;
            }
        }

        // public double getPrice(){
        //     return this.price;
        // }
        // public void setPrice(double price){
        //     this.price = price;
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "Telefon";
            p.Price = 1000;

            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Price: " + p.Price);
        }
    }
}
