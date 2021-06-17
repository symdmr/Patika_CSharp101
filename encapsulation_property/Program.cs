using System;

namespace encapsulation_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "seyma";
            ogrenci.Soyisim = "demir";
            ogrenci.No=686;

            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;


        public string Isim{
            get{return isim;}
            set{isim = value;}
        }

        public string Soyisim{get => soyisim; set => soyisim=value;}
        public int No{get => no; set => no=value;}
        public int Sinif
        {
            get => sinif; 
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("sınıf en az 1 olabilir");
                    sinif = 1;
                }
                else
                sinif =value;
            }
        }


        public Ogrenci(string isim, string soyisim, int no)
        {
            Isim = isim;
            Soyisim = soyisim;
            No = no;
            Sinif= sinif;
        }


        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("-----------------Öğrenci Bilgileri---------------");
            Console.WriteLine("öğrenci adı: {0}", this.Isim);
            Console.WriteLine("öğrenci soyadı: {0}", this.Soyisim);
            Console.WriteLine("öğrenci no: {0}", this.No);
            Console.WriteLine("öğrenci sınıfı: {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif+1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif-1;
        }

    }
}
