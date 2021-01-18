using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        public static List<Musteri> musteriListe = new List<Musteri>();
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();


            Console.WriteLine("Test Bank");

            MusteriManager musteriManager = new MusteriManager();

            while (true)
            {
                Console.WriteLine("-------------Müşteri İşlemleri-------------");
                Console.WriteLine("1 - Müsteri Ekleme\n2 - Müşteri Silme\n3 - Müşteri Listeleme\nLütfen seçiminizi belirtiniz.");

                int selection1;
                var UserInput1 = Console.ReadKey();
                Console.WriteLine();
                if (char.IsDigit(UserInput1.KeyChar))
                {
                    selection1 = int.Parse(UserInput1.KeyChar.ToString());
                    if (selection1 > 0 && selection1 < 4)
                    {
                        switch (selection1)
                        {
                            case 1:

                                musteriManager.Add(musteri);


                                break;
                            case 2:

                                break;
                            case 3:
                                musteriManager.Liste(musteriListe);
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Yanlış seçim yaptınız.");
                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız.");
                }

                Console.WriteLine("Çıkmak için : 0");
                int selection2;
                var UserInput2 = Console.ReadKey();
                Console.WriteLine();
                if (char.IsDigit(UserInput2.KeyChar))
                {
                    selection2 = int.Parse(UserInput2.KeyChar.ToString());
                    if (selection2 > -1 && selection2 < 2)
                    {
                        if(selection2 == 0)
                        {
                            break;
                        }
                    }
                }

            }





        }

    }

}
