using System;



namespace Donguler
{


    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirnme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";
            string kurs5 = "C#";

            //array-dizi
            string[] kurslar=new string[] { "Yazılım Geliştirici Yetiştirnme Kampı", 
                "Programlamaya başlangıç için temel kurs", 
                "Java","Phyton","C#"};



            for (int i = 0; i<kurslar.Length; i++) { 

                Console.WriteLine(kurslar[i]); 
            
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu -  footer");

        }
    }
}
