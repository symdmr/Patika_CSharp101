﻿using System;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("ocak ayındasın");
                break;
                case 2 :
                Console.WriteLine("şubat ayındasın");
                break;
                case 3:
                Console.WriteLine("mart ayındasın");
                break;
                case 4:
                Console.WriteLine("nisan ayındasın");
                break;
                default:
                Console.WriteLine("yanlış veri girildi");
                break;
            }
            switch (month)
            {   
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış mevsimindesin");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar mevsimindesin");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz mevsimindesin");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar mevsimindesin");
                    break;
                default:
                break;
            }
        }
    }
}
