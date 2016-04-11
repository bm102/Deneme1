using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class1
    {
        struct ehliyet
        {
            public string Ad;
            public string Soyad;
            public int trafik;
            public int motor;
            public int ilkyardim;

            public void puan(int t, int m, int i)
            {
                trafik = (50 * 2 - t * 2);
                motor = (int)(40 * 2.5 - m * 2.5);
                ilkyardim = (int)(30 * 3.3 - i * 3.3);
                Console.WriteLine("adi ve soyadi:{0} {1}", Ad, Soyad);
                Console.WriteLine("trafik,motor,ilkyardim puani: {0} {1} {2}", trafik, motor, ilkyardim);
                if (trafik > 70 && motor > 70 && ilkyardim > 70)
                    Console.WriteLine("Direksiyon sinavina girebilir.");
                else
                    Console.WriteLine("Direksiyon sinavina giremez.");
            }
        }
        static void Mainn(string[] args)
        {
            int t, m, i;
            Console.Write("trafik yanlisi sayisi:");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("motor yanlisi sayisi:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("ilkyardim yanlisi sayisi:");
            i = Convert.ToInt32(Console.ReadLine());
            ehliyet kisi1 = new ehliyet();

            kisi1.Ad = "Liva";
            kisi1.Soyad = "Tezcan";
            kisi1.puan(t, m, i);

        }
    }

}

