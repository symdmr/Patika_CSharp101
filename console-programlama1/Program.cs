using System; //kullanılcak kütüphaneleri vs yazıyorsun, bunu silersen aşağıda console.writeline gibi komutların başına hep system yamak zorunda kalırsın

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args) //main metot programın başladığı ve bittiği yer. ilk satırla çalışır son satırla biter
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba, " + name + " " + surname);


        }
    }
}
