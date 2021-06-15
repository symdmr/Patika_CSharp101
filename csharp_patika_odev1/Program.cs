using System;

namespace csharp_patika_odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).           

            // int num01;
            // Console.WriteLine("pozitif bir sayı girin: ");
            // num01 = Convert.ToInt32(Console.ReadLine());
            // if (num01<0)
            // {
            //     Console.WriteLine("pozitif sayı girmelisiniz");
            // }
            // else{
            //     Console.WriteLine("girdiğiniz sayı: "+num01);
            // }


            // //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın

            // int[] numbers = new int[4];
            
            // Console.WriteLine("ilk sayıyı girin: ");
            // numbers[0] = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("ikinci sayıyı girin: ");
            // numbers[1] = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("üçüncü sayıyı girin: ");
            // numbers[2] = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("dördüncü sayıyı girin: ");
            // numbers[3] = Convert.ToInt32(Console.ReadLine());
            
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("girilen pozitif ve çift sayılar şöyledir: ");
            //     if ( numbers[i]%2 ==0)
            //     {
            //         Console.WriteLine(numbers[i]);
            //     }
            //     if (i == 3)
            //     {
            //         break;
            //     }
            // }
            

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            // int number1;
            // int number2;
            // Console.WriteLine("pozitif iki sayı girin: ");
            // number1 = Convert.ToInt32(Console.ReadLine());
            // number2 = Convert.ToInt32(Console.ReadLine());
            // if (number1<0 || number2<0)
            // {
            //     Console.WriteLine("pozitif sayı girmelisiniz");
            // }
            // else{
            //     int[] numbers1 = new int[number1];
            //     Console.WriteLine("lütfen " + number1 + " adet pozitif sayı girin");
            //     for (int i = 0; i < number1; i++)
            //     {
            //         Convert.ToInt32(Console.ReadLine());
                   
            //     }
            //     for (int a = 0; a < number1; a++)
            //     {
            //         if (numbers1[a] % number2 == 0 || numbers1[a] == number2)
            //        {
            //            Console.WriteLine("girilen değerler arasında "
            //            + number2+ "sayısına eşit veya tam bölünen değer: "); //bu kısımda bir sorun var
            //            Console.WriteLine(numbers1[a]);
            //        }
            //        else{
            //            Console.WriteLine("girilen değerler arasında "
            //            + number2+ "sayısına eşit veya tam bölünen değer yoktur.");
            //        }
            //     }
                

            // }

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            int wordNum1;
            Console.WriteLine("pozitif sayı girin: ");
            wordNum1 = int.Parse(Console.ReadLine());
            if (wordNum1<0 || wordNum1==0)
            {
                Console.WriteLine("pozitif sayı girmelisiniz");
            }
            else{
                string[] words = new string[wordNum1];
                Console.WriteLine("lütfen " + wordNum1 + " adet kelime girin");
                for (int i = 0; i < wordNum1; i++)
                {
                   words[i] = Console.ReadLine();
                }
                Console.WriteLine("girdiğiniz kelimeler sondan başa:");
                Array.Reverse(words);
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
                
            }

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("bir cümle yazınız:");


            //devam edilecek
            
        }
    }   
}
