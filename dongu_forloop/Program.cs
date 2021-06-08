using System;

namespace dongu_forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırır
            Console.WriteLine("bir sayı girin: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasında tek ve çift sayıların toplamını ekrana yazdır
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%2 ==1)
                {
                    tekToplam += i;
                }
                else{
                    ciftToplam += i;
                }
            }
            Console.WriteLine("tektoplam : "+tekToplam);
            Console.WriteLine("cifttoplam :"+ciftToplam);

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                  continue;
                Console.WriteLine(i);            
                
            }
        }
    }
}
