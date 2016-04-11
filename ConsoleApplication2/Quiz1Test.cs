using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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
                    number = value;
                else
                    number = 1;
            }
        }

        public bool hesapla()
        {
            int toplam = 0, a, n = 0, j;

            n = basamakBul(number);
            Console.WriteLine("sayi {0} basamaklidir", n);


            for (a = 1; a < number; a++)
            {
                n = basamakBul(number);
                int[] d = new int[n];


                for (j = 0; j < n; j++)
                {
                    d[j] = number % 10;
                    number = (number - d[j]) / 10;
                    d[j] = d[j] * d[j];
                    toplam = toplam + d[j];
                }


                if (toplam < 10)
                {
                    if (toplam == 1)
                    {
                        return true;

                    }
                    else
                    {
                        return false;

                    }
                }
                else
                    number = toplam;

                toplam = 0;
            }
            return false;

        }

        public int basamakBul(int sayi)
        {
            if (sayi == 0)
                return 0;
            else
                return 1 + basamakBul(sayi / 10);
        }

    }




    class Quiz1Test
    {
        static void MainTeztQuiz1(string[] args)
        {

            int number;
            Console.WriteLine("Bir sayı giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
            Heureux heureux = new Heureux();
            heureux.Number = number;

            if (heureux.hesapla())
            {
                Console.WriteLine("Girilen değer Heureux Sayısıdır :)");
            }
            else Console.WriteLine("Girilen değer Heureux Sayısı Değildir");
        }

    }
}




