using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            //T -> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            
            foreach (var sayi in sayiListesi)
                     Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                     Console.WriteLine(renk);

            sayiListesi.ForEach(sayi =>Console.WriteLine(sayi));
            renkListesi.ForEach(renk =>Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk =>Console.WriteLine(renk));

            //liste içinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içinde bulundu");

            //eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("sarı"));

            //diziyi listeye cevirme
            string[] hayvanlar = {"kedi", "köpek", "kuş"};
            List<string> hayvanListesi =new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanListesi.Clear();

            //liste içinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi =new List<Kullanıcılar>();

            Kullanıcılar user1 = new Kullanıcılar();
            user1.Isim="seyma";
            user1.Soyisim = "demir";
            user1.Yas = 27;

            Kullanıcılar user2 = new Kullanıcılar();
            user2.Isim="meliksah";
            user2.Soyisim = "demir";
            user2.Yas = 24;

            kullanıcıListesi.Add(user1);
            kullanıcıListesi.Add(user2);


            List<Kullanıcılar> yeniListe =new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar(){
                Isim = "tuba",
                Soyisim="demir",
                Yas= 20
            });

            foreach (var user in kullanıcıListesi)
            {
                Console.WriteLine("adı: "+ user.Isim);
                Console.WriteLine("soyadı: "+ user.Soyisim);
                Console.WriteLine("yaşı: "+ user.Yas);
            }

            hayvanListesi.Clear();


        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim{ get =>  isim; set => isim =value;}
        public string Soyisim{ get =>  soyisim; set => soyisim =value;}
        public int Yas{ get =>  yas; set => yas =value;}

    }
}
