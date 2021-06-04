using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(""); 

            byte b =5; //1 byte 
            sbyte c =5; //1 byte

            short s =5; //2 byte 
            ushort us = 6; //2 byte

            Int16 i16 = 2; //byte
            int i= 2; //4byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte
            
            uint ui= 2; // abyte
            long l= 4; //8 byte 
            ulong ul= 4; //8 byte

            //Reel sayı
            float f= 5; //4 byte
            double d= 5; //8 byte
            decimal de = 5; //16 byte

            char ch= '2';  // 2byte
            string str ="seyma"; // sınırsız

            bool b1 = true;

            DateTime dtn = DateTime.Now;
            Console .WriteLine(dtn);

            //object değişkenleri genel olarak tutabilir

            //stringler

            string str1 = string.Empty;
            str1= "seyma";
            string ad = "sym";
            string soyad = "dmr";
            string tam = ad+ " " + soyad;

            //integerlar
            int int1 = 3;
            int int2 = 2;
            int int3= int1*int2;

            //boolean
            bool bool1= 5>2;

            //değişken dönüşüm
            string str20 = "20";
            int int20 = 20;
            string yeniDeger =str20+int20.ToString();
            Console.WriteLine(yeniDeger); //2020 

            int int21 =int20+ Convert.ToInt32(str20);
            Console.WriteLine(int21); //40
            
            int int22 = int20 + int.Parse(str20); //40

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string  hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
