﻿using System;


namespace KampIntro {


    class Program {
        static void Main(string[] args) {

            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;

            double faizOrani = 1.45;

            double dolarDun = 7.55;

            double dolarBugun = 7.55;

            bool sistemeGirisYapmisMi = true;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

             
             
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");

            }


            Console.WriteLine(kategoriEtiketi);

        }
    
    }
}
