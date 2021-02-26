using System;

namespace _1_Class_Uygulaması
{

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adet: ");
            int adet = int.Parse(Console.ReadLine());

            Product[] products = new Product[adet];

            int i = 0;
            Product prd;

            do
            {
                prd = new Product();

                Console.Write("ürün adı: ");
                prd.Name = Console.ReadLine();

                Console.Write("ürün fiyat: ");
                prd.Price = double.Parse(Console.ReadLine());

                Console.Write("açıklama: ");
                prd.Description = Console.ReadLine();

                products[i]= prd;
                i++;

            } while (adet>i);

            Console.WriteLine("************************************");

            for (int k = 0; k < adet; k++)
            {
                Console.WriteLine("Ürün adı: {0}, Ürün fiyatı: {1}, Ürün Açıklaması: {2}",products[k].Name,products[k].Price,products[k].Description);
            }

        }
    }
}
