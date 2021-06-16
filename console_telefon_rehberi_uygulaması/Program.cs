using System;

namespace console_telefon_rehberi_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] rehber = new string[20][];

            for (int i = 0; i < 20; i++)
            {
                rehber[i] = new string[2]; // her satırda 2 tane sütunum var demek oluyor bu.
            }
            bool[] rehberDoluMu = new bool[20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    rehber[i][j] = "";
                }
            }
            AnaMenu(rehber, rehberDoluMu);
            Console.ReadKey();
        }// main
        #region AnaMenu
        public static void AnaMenu(string[][] diziR, bool[] diziB)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        //Console.Clear();
        AnaMenu:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("1 - Yeni Numara Kaydetmek");
            Console.WriteLine("2 - Varolan Numarayı Silmek");
            Console.WriteLine("3 - Varolan Numarayı Güncelleme");
            Console.WriteLine("4 - Rehberi Listelemek");
            Console.WriteLine("5 - Rehberde Arama Yapmak");
            int secim = 0;
            try
            {
                secim = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Lütfen Doğru Seçim Yapınız");
                System.Threading.Thread.Sleep(3000); // yanlış bir seçim yaptınız diyip 3 sn bekliyor ana menü geliyor
                goto AnaMenu;
            }

            switch (secim)
            {
                case 1:
                    numaraEkle(diziR, diziB);
                    break;
                case 2:
                    numaraSil(diziR, diziB);
                    break;
                case 3:
                    Guncelle(diziR, diziB);
                    break;
                case 4:
                    Listele(diziR, diziB);
                    break;
                // case 5:
                //     rehberdeAra(diziR, diziB);
                //     break;

            }

        }// ana menü
        #endregion // anaMenu

        #region numaraEkle

        public static void numaraEkle(string[][] dizi, bool[] diziBool)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.Clear();
            int indexBul = Array.IndexOf(diziBool, false); // dizi bool de false olan değeri bul
            Console.WriteLine("değeri false olan index: " + indexBul);

            if (indexBul != -1)
            {
                Console.WriteLine(" Lütfen isim giriniz :");
                dizi[indexBul][0] = Console.ReadLine(); // dizi de [][0] hep isimler zaten bulduğum index de yanındaki 0 a atadım ismi
                Console.WriteLine(" Lütfen soyisim giriniz :");
                dizi[indexBul][1] = Console.ReadLine();
                Console.WriteLine("  Lütfen telefon numarası giriniz :");
                dizi[indexBul][1] = Console.ReadLine();
                diziBool[indexBul] = true; // false olan değeri bulup içini doldurduk o index artık dolu benim için

                // Console.Clear();
                Console.WriteLine("Kayıt İşleminiz Başarıyla Tamamlandı");
                Console.WriteLine("İsim:" + dizi[indexBul][0]);
                Console.WriteLine("Numara:" + dizi[indexBul][1]);
                Console.WriteLine("————————————————————————————");
                AnaMenu(dizi, diziBool);
            } // if

            else
            {
                Console.Clear();
                Console.WriteLine("Hafızada yeterli alan yok!");
                Console.WriteLine("Başka işlem seçiniz\n\n");
                AnaMenu(dizi, diziBool);

            }
        }// kisiEkle

        #endregion

        #region kisiSil
        public static void numaraSil(string[][] dizi, bool[] diziBool)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            // Console.Clear();
            for (int i = 0; i < 20; i++)
            {
                if (diziBool[i] == true) // değeri true olanları yani içi dolu olanları listele
                {
                    Console.WriteLine("İsim:" + dizi[i][0]);
                    Console.WriteLine("Numara:" + dizi[i][1]);
                    Console.WriteLine("——————————————");
                } // if

            }// for listele

        adim:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");
            string arananIsim = Console.ReadLine();
            int arananIndex = -1; // 0. index old. için -1 yaptık değeri
            for (int i = 0; i < 20; i++)
            {
                if (dizi[i][0].Equals(arananIsim)) // aranan isme eşit index i bulmaya çalışıyoruz –dizide var mı ??
                {
                    Console.WriteLine("Aranan kişi listede var ve silindi ");
                    arananIndex = i; // aranan index i bulduk o şu an elimde
                }

            } // aranan var mı ?
            if (arananIndex == -1) // aranan index hala -1 ise kayıt bulunamadı diyor.
            {
                Console.WriteLine("Kayıt bulunamadı");
                goto adim;

            }
            if (arananIndex != -1) // arananindex eşit değilse -1 e yani bulduysa silmek istediğim şeyi diziBool de onun yerini false
                                   // yapıyor ve yeni eklediğim değeri false olan yerin üzerine yazıyor
            {
                diziBool[arananIndex] = false;
                dizi[arananIndex][0] = "";
            }
            AnaMenu(dizi, diziBool);

        }
        #endregion

        #region Listele

        public static void Listele(string[][] dizi, bool[] bDizi)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Console.Clear();

            for (int i = 0; i < 20; i++)
            {
                if (bDizi[i] == true)
                {
                    Console.WriteLine("İsimler:" + dizi[i][0] + "\nNumaralar:" + dizi[i][1]);
                }

            }

            AnaMenu(dizi, bDizi);
        }

        #endregion

        #region Güncelle

        public static void Guncelle(string[][] dizi, bool[] bDizi)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        //Console.Clear();
        adim:
            Console.WriteLine("Güncellemek istediğiniz adı giriniz:");
            string arananIsim = Console.ReadLine();
            int arananIndex = -1; // 0. index old. için -1 yaptık değeri
            for (int i = 0; i < 20; i++)
            {
                if (dizi[i][0].Equals(arananIsim)) // aranan isme eşit index i bulmaya çalışıyoruz –dizide var mı ??
                {
                    Console.WriteLine("Güncellenmek istenen kişi:" + dizi[i][0]);
                    arananIndex = i; // aranan index i bulduk o şu an elimde
                }

            } // aranan var mı ?
            if (arananIndex == -1) // aranan index hala -1 ise kayıt bulunamadı diyor.
            {
                Console.WriteLine("Yanlış giriş yaptınız tekrar deneyin");
                Console.Clear();
                goto adim;

            }
            if (arananIndex != -1) // arananindex eşit değilse -1 e yani bulduysa güncellemek istediğim şeyi diziBool de onun yerini false
                                   // yapıyor ve yeni eklediğim değeri false olan yerin üzerine yazıyor
            {
                Console.WriteLine("Güncelleme işlemi için isim ve numara giriniz:");
                dizi[arananIndex][0] = Console.ReadLine();
                dizi[arananIndex][1] = Console.ReadLine();
            }

            Console.Clear();
            AnaMenu(dizi, bDizi);
        }
        #endregion

        #region Çıkış
        public static void Cikis()
        {
            Console.WriteLine("Tüm işlemleri başarıyla gerçekleştirdiniz artık bi zahmet rehberi terk edin");
            Console.ReadKey();
        }

        #endregion
    }
}
