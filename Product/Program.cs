using System;
namespace Product
{
    class Program
    {
        public static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.product_id = 1;
            product1.product_name = "Telefon";
            product1.product_price = 4500;


            Product product2 = new Product();
            product2.product_id = 2;
            product2.product_name = "Bilgisayar";
            product2.product_price = 8500;


            Product product3 = new Product();
            product3.product_id = 3;
            product3.product_name = "Araba";
            product3.product_price = 270000;



            Product[] products = new Product[] { product1, product2, product3 };
     
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün : " + products[i].product_name + "\n" + "Ürünün Fiyatı : " + products[i].product_price);
            }
            Console.WriteLine("-------------------------------------------");

            foreach (Product product in products)
            {
                Console.WriteLine(product.product_name + " : " + product.product_price);
            }
            Console.WriteLine("--------------------------------------------");
              int j = 0;
            while (products.Length > j)
            {
                Console.WriteLine(products[j].product_name + " : " + products[j].product_price);
                j++;
            }


        }
    }
    class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public double product_price { get; set; }
    }
}
