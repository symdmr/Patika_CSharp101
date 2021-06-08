using System;

namespace hazır_metot_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "csharp dersi";
            string degisken2 = "csharp";

            //length
            Console.WriteLine(degisken.Length);

            //toupper, tolower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //concat
            Console.WriteLine(String.Concat(degisken, "Merhaba!"));

            //compare, compare to
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("dersi"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //Indexof
            Console.WriteLine(degisken.IndexOf("cs"));
            Console.WriteLine(degisken.IndexOf("seyma"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //ınsert
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));
            
            //padleft, padright
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(0,'-')+degisken2);

            //remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //replace
            Console.WriteLine(degisken.Replace("csharp", "C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //split
            Console.WriteLine(degisken.Split(' ')[1]);

            //substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

        }
    }
}
