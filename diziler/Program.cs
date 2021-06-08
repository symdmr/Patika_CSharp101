using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama
            string[] renkler  = new string[5];
            string[] hayvanlar ={"kedi", "köpek", "kuş", "maymun"};

            int[] dizi;
            dizi = new int [5];

            //dizilere değer atama ve erişim
            renkler[0] ="mavi";
            dizi[3] = 10;
            
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //döngüler dizi kullanımı 
            //klavyeden girilen n tane sayının ort. hesaplayan program
            Console.Write("dizinin eleman sayısını girin: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayiDizisi  = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("lütfen {0} sayısı girin", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("ortalama: "+toplam/diziUzunluğu);

        }
    }
}
