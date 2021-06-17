using System;

namespace struct_yapi
{
    class Program
    {
        static void Main(string[] args)
        {
           Dikdortgen dikdortgen = new Dikdortgen();
           dikdortgen.KisaKenar = 5;
           dikdortgen.UzunKenar = 4;

           Console.WriteLine("class alan hesabı: {0}", dikdortgen.AlanHesapla());

           Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
           dikdortgen_Struct.KisaKenar = 5;
           dikdortgen_Struct.UzunKenar = 4;

           Console.WriteLine("struct alan hesabı: {0}", dikdortgen_Struct.AlanHesapla()); 
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        
        public long AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesapla()
        {
            return this.KisaKenar*this.UzunKenar;
        }
    }
}
