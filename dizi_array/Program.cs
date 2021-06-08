using System;

namespace dizi_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayıDizisi = {25,12, 45, 56, 85, 26, 28,2};

            //sırasız dizi
            foreach (var sayi in sayıDizisi)
            {
                Console.WriteLine(sayi);
            }
            
            //sıralı dizi
            Array.Sort(sayıDizisi); 

            foreach (var sayi in sayıDizisi)
            {
                Console.WriteLine(sayi);
            }

            //clear
            //sayı dizisi elemanlarını kullanarak 2. index ten itibaren 2 tane elemanı sıfırlar
            Array.Clear(sayıDizisi, 2, 2);
            foreach (var sayi in sayıDizisi)
            {
                Console.WriteLine(sayi);
            }


            //reverse
            Array.Reverse(sayıDizisi);
            foreach (var sayi in sayıDizisi)
            {
                Console.WriteLine(sayi);
            }

            //indexOf
            Console.WriteLine(Array.IndexOf(sayıDizisi,25));

            //resize
            Array.Resize<int>(ref sayıDizisi,9);
            sayıDizisi[8] = 99;

            foreach (var sayi in sayıDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
