using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{ 
    class happynumber
{
    
        public int basamakBul(int sayi)
        {
                if (sayi == 0)
                    return 0;
                else
                    return 1 + basamakBul(sayi / 10);
            }
    
        

        public void number(int sayi)
    {
        int toplam = 0, a, n = 0, j;



    
        n = basamakBul(sayi);
        Console.WriteLine("sayi {0} basamaklidir12", n);


        for (a = 1; a < sayi; a++)
        {
            n = basamakBul(sayi);
            int[] d = new int[n];


            for (j = 0; j < n; j++)
            {
                d[j] = sayi % 10;
                sayi = (sayi - d[j]) / 10;
                d[j] = d[j] * d[j];
                toplam = toplam + d[j];
            }


            if (toplam < 10)
            {
                if (toplam == 1)
                {
                    Console.Write("sayi happy numberdir ");
                    break;
                }
                else
                {
                    Console.Write("sayi happy number degildir");
                    break;
                }
            }
            else
                sayi = toplam;

            toplam = 0;
        }
    }
}


class Program1
{
    static void MainEsk(string[] args)
    {
        int sayi;
        Console.WriteLine("Bir sayi giriniz :");
        sayi = Convert.ToInt32(Console.ReadLine());
        happynumber c = new happynumber();
        c.number(sayi);
        Console.ReadLine();
    }
}
}

