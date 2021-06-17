using System;

namespace enumDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Çarşamba);

            int sıcaklık = 32;
            if (sıcaklık <= (int)HavaDurumu.Normal) //int ile enum değerini cast edip sayısal karşılık sağlıyoruz
            {
                Console.WriteLine("dışarıda hava normalin altında");
            }
            else
            {
                Console.WriteLine("dışarıda hava çok soğuk değil");
            }
        }
    }

    enum Gunler
    {
        Pazartesi=1, //değer atamazsa 0 dan başlar
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi = 50, //hep ardışık gider, buraya kadar 1-2-3 şeklindeydi şimdi 50-51 şeklinde
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak =35,
    }
}
