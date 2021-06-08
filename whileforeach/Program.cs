using System;

namespace whileforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayıp consoledan girilen sayı dahil olacak şekilde ortalama hesaplayıp, console da yazdıran uygulama
            Console.WriteLine("bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac =1;
            int toplam=0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);
            
            //a-z tüm harfleri yazdırma
            char character ='a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }
            

            //foreach
            string[] arabalar = {"bmv", "alfaromeo", "volvo"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
