using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Quiz1_1
    {
        class Heureux
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
                    if (value > 0)
                    {
                        number = value;
                    }
                    else number = 1; 
                }
            }

            public bool hesapla()
            {

                int basamak_sayisi;
                int hesaplanan_sayi = number;
                int hesaplanan_kare = 0; 

                for ( ; hesaplanan_sayi >= 10; )
                {
                    
                    basamak_sayisi = basamakBul(hesaplanan_sayi);
                 

                    for (int i = 0; i < basamak_sayisi; i++)
                    {
                        int basamak = hesaplanan_sayi % 10;
                        hesaplanan_sayi = hesaplanan_sayi / 10;

                        hesaplanan_kare += basamak * basamak;
                    }

                    hesaplanan_sayi = hesaplanan_kare;
                    hesaplanan_kare = 0; 
                }

                
                    if (hesaplanan_sayi == 1)
                    {
                        return true;
                    }
                    else return false;
               
            }

            public int basamakBul(int sayi)
            {
                if (sayi / 10 == 0)
                {
                    return 1;
                }
                else return basamakBul(sayi / 10) + 1; 
            }
        }


        static void MainQuiz1_1(string[] args)
        {
            Heureux heureux = new Heureux();
            Console.WriteLine("Bir Sayı Giriniz: ");
            heureux.Number = Convert.ToInt32(Console.ReadLine());
            if (heureux.hesapla())
            {
                Console.WriteLine("Girilen Sayı Heureux Sayısıdır :) ");

            }else Console.WriteLine("Girilen Sayı Heureux Sayısı Değildir :( ");

        }
    }
}
