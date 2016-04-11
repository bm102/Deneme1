using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class QuizEski1
    {

        class Circle
        {
            
            int radius;

           public Circle(int radius)
            {
                this.radius = radius;
            }
            public Circle() {
            }
            
            public int Radius
            {

                get
                {
                    return radius;
                }
                set
                {
                    if (value > 0)
                        radius = value;
                    else
                        radius = 00;
                }
            }

            public double Alan()
            {
                return 3.14 * radius * radius;
            }

            public double Cevre()
            {
                return 2 * 3.14 * radius ;
            }

        }

        static void MainEs(string[] args)
        {
            Circle circl1 = new Circle();

            circl1.Radius = 12;
            Console.WriteLine("1. daire alan : " + circl1.Alan());
            Console.WriteLine("1. daire cevre : " + circl1.Cevre());

            Circle circle2 = new Circle(24);
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. daire alan : " + circle2.Alan());
            Console.WriteLine("1. daire cevre : " + circle2.Cevre());
        }
    }
}
