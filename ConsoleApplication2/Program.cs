using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///  4 hafta soruları
/// </summary>
namespace ConsoleApplication2
{
    class Program
    {

        static int Toplam(int[] a, int index)
        {
            // Kodunuzu Buraya Yazınız...
            if (a[index] == a[a.Length - 1])
            {
                return a[a.Length - 1];
            }
            return a[index] + Toplam(a, index + 1);
        }

        //           int[] dizi = { 1, 2, 3, 9, 15, 30 };


        static void Mainn()
        {
            for (int n = 0; n < 20; n++)
            {
                Console.WriteLine(P(n));
            }

        }

        public static int f(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            return 2 * f(n - 2) + f(n - 3);

        }

        static int P(int input)
        {

            // Kodunuzu Buraya Yazınız.
            int i = 0;
            try
            {
                if (input == 0 || input == 1)
                    return input;
                else
                    return 2 * P(input - 1) + P(input - 2);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return i;
        }



        static int RecBasamak(int n)
        {
            if (n / 10 == 0)
                return 1;
            else
                return (RecBasamak(n / 10) + 1);
        }

        static int BasamakTopla(int x, int y)
        {
            return RecBasamak(x) + RecBasamak(y);
        }

        static int BasamakTopla(int x, int y, int z)
        {
            return RecBasamak(x) + RecBasamak(y) + RecBasamak(z);

        }


        static void Mainnnn(string[] args)
        {

            int[] dizi = { 1, 2, 3, 9, 15, 30 };
            Console.WriteLine(Toplam(dizi, 0));

            int x, y, z;
            Console.WriteLine("sayı giriniz");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı giriniz");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayıların basamak sayıları toplamı ={0}",
             BasamakTopla(x, y));
            Console.WriteLine("sayı giriniz");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayıların basamak sayıları toplamı ={0}", 
                BasamakTopla(x, y, z));
        }


    }


}


