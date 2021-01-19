using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static List<Musteri> musteriListe = new List<Musteri>();
        public void Add(Musteri musteri)
        {

            Console.Write("Müşteri Adı Soyadı :");
            musteri.Name = Console.ReadLine();
            Console.Write("Müşteri Cinsiyeti : Erkek(0) Kadın(1)");
            int selection2;
            var UserInput2 = Console.ReadKey();
            Console.WriteLine();
            if (char.IsDigit(UserInput2.KeyChar))
            {
                selection2 = int.Parse(UserInput2.KeyChar.ToString());
                if (selection2 > -1 && selection2 < 2)
                {
                    switch (selection2)
                    {
                        case 0:
                            musteri.Gender = true;
                            break;
                        case 1:
                            musteri.Gender = false;
                            break;

                    }
                }
                else
                    Console.WriteLine("Yanlış seçim yaptınız.");
            }
            else
                Console.WriteLine("Yanlış seçim yaptınız.");
            Console.WriteLine("Müşteri Giriş Bakiyesi (Küsuratı virgül kullanarak belirtin):");
            try
            {
                musteri.Balance = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Değeri Yanlış Girdiniz.");
            }

            Console.WriteLine(musteri.Balance);
            Program.musteriListe.Add(musteri);
            Console.WriteLine("{0} adlı müşteri olüşturuldu.",musteri.Name);
            Console.WriteLine("********************Müsteri Bilgileri******************");
            Console.WriteLine("Müşteri ID: {0}\nMüşteri Cinsiyeti : {1}\nMüşteri Bakiye : {2}\n",musteri.Id,musteri.Gender,musteri.Balance);
            
        }

        public void Delete()
        {

        }

        public void Liste(List<Musteri> musteriListe)
        {
            foreach (var musteri in musteriListe)
            {
                Console.WriteLine("********************Müsteri Bilgileri******************");
                Console.WriteLine("Müşteri ID: {0}\nMüşteri Cinsiyeti : {1}\nMüşteri Bakiye : {2}\n", musteri.Id, musteri.Gender, musteri.Balance);
            }
        }

 
    }
}
