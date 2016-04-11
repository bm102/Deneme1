using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MyClass
    {
        int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0)
                {
                    number = 1;
                }
                else number = value;

            }
        }

            public bool hesapla()
        {
            int hesaplanan_deger = number;
            int kare_toplam = 0;
            int basamak_sayisi = 0; 

            for ( ; hesaplanan_deger >= 10 ;)
            {
                basamak_sayisi = basamakSayisi(hesaplanan_deger);

                for (int i = 0; i < basamak_sayisi; i++)
                {
                    int basamak = hesaplanan_deger % 10;
                    hesaplanan_deger = hesaplanan_deger / 10;
                    kare_toplam += basamak * basamak;
                }

                hesaplanan_deger = kare_toplam;
                kare_toplam = 0; 

            }

            if (hesaplanan_deger == 1)
            {
                return true;
            }

            return false;
        }

        public int basamakSayisi(int sayi)
        {

            if (sayi / 10 == 0)
            {
                return 1;
            }
            else return basamakSayisi(sayi / 10) + 1; 
        }


    }



    class Quiz1_2
    {
        static void Main(string[] args)
        {
            Heureux heureux = new Heureux();
            Console.WriteLine("Bir sayı giriniz: ");
            heureux.Number = Convert.ToInt32(Console.ReadLine());
            if (heureux.hesapla())
            {
                Console.WriteLine("Girilen Sayı Heureux Sayısıdır :) ");
            }
            else Console.WriteLine("Girilen sayı Heureux Sayısı Değildir :(");

        }
    }
}
