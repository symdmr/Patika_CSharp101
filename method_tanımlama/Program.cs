using System;

namespace method_tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci  geri_donustipi  metot_adı(parametreListesi/arguman)
            //{komutlar;
            //return;}

            int a =2;
            int b =3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
        }

        static int Topla(int deger, int deger2)
        {
            return(deger+deger2);
        }
    }

    class Metotlar{
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
