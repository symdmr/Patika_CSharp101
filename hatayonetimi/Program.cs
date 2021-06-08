using System;

namespace hatayonetimi
{
    class Program
    {
        static void Main(string[] args)
        {   try{
            Console.WriteLine("bir sayı gir");
            int sayi =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girmiş olduğun sayı: "+sayi);
        }
        catch(Exception ex){
            Console.WriteLine("hata" + ex.Message.ToString());
        }

        // finally{
        //     Console.WriteLine("işlem tamam");
        // }

        try
        {
            // int a = int.Parse(null);
            // int a = int.Parse("test");
            int a= int.Parse("-20000000000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("boş deger girdin");
            Console.WriteLine(ex);
        }
        catch(FormatException ex){
            Console.WriteLine("veri tiipi uygun değil");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex){
            Console.WriteLine("cok küçük ya da cok buyuk bir deger girdin");
            Console.WriteLine(ex);
        }
        finally{
            Console.WriteLine("işlem basarılı şeklide tamamlandı");
        }
            

        }
    }
}
