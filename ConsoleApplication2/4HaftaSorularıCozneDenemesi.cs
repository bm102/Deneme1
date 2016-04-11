using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class _4HaftaSorularıCozneDenemesi
    {
        struct Time
        {
            int hour;
            int mininutes;
            int second;
            public Time(int hour, int minutes, int second)
            {
                this.hour = hour;
                this.mininutes = minutes;
                this.second = second;
            }

            public void zamanYazdır()
            {
                Console.WriteLine("{0} saat {1} dakika {2} saniye", hour, mininutes, second);
            }

            public Time zamanFarkı(Time time1, Time time2)
            {
                Time timeDiff = new Time();
                timeDiff.hour = time1.hour - time2.hour;
                timeDiff.mininutes = time1.mininutes - time2.mininutes;
                timeDiff.second = time1.second - time2.second;
                return timeDiff;
            }

        }
        static void MainE(string[] args)
        {

            Time time1 = new Time(1, 20, 30);
            Time time2 = new Time(1, 20, 30);
            Time timeDiff = new Time();
            timeDiff.zamanFarkı(time1, time2).zamanYazdır();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(P(i));
            }

            Console.WriteLine(RecBasamak(1234));
            Console.ReadKey();

        }


        static int P(int input)
        {



            if (input == 0 || input == 1)
                return input;
            else
                return 2 * P(input - 1) + P(input - 2);


        }


        static int RecBasamak(int n)
        {
            // Kodunuzu Buraya Yazınız...    
            if (n / 10 == 0)
                return 1;
            else {
                int a = n / 10;
                return (RecBasamak(n / 10) + 1 );

            }
        }


    }
}
