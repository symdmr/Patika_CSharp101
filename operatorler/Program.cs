using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atama-işlemli atama
            int x=3;
            int y =3;

            y +=2; //burda dört işlemleri böyle yazabilirsin
            x*=3;
            Console.WriteLine(y);
            Console.WriteLine(x);


            //mantıksal operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCopmleted= false;

            if(isSuccess && isCopmleted)
            Console.WriteLine("Perfect!");

            if(isSuccess || isCopmleted)
            Console.WriteLine("Great");

            if(isSuccess && !isCopmleted)
            Console.WriteLine("fine");



            //ilişkisel operatörler
            //<, >, <=, >=, ==, !=
            int a =3;
            int b =4;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);


            //aritmetik operatörler
            // +, -, *, /
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;

            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1++;
            Console.WriteLine(sonuc1);


            // % : mod alma
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
