using System;
using System.Collections;


namespace CA__EncapsulationOdev
{
    class Program
    
    {

        static void Main(string[] args)
        {
            FenerbahceFutbolTakimi fenerbahce = new FenerbahceFutbolTakimi();

            Console.WriteLine("************************************");
            Console.WriteLine("Fenerbahçe Spor Kulübüne Hoşgeldiniz");
            Console.WriteLine("************************************");

            Console.WriteLine("Futbolcu Id:  ");
            fenerbahce.futbolcu1Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Futbolcu Adı:  ");
            fenerbahce.ad = Console.ReadLine();
            Console.WriteLine("Futbolcu Soyadı:  ");
            fenerbahce.soyad = Console.ReadLine();
            Console.WriteLine("Oynadığı Mevki:  ");
            fenerbahce.mevkii = Console.ReadLine();
            Console.WriteLine("Forma No:  ");
            fenerbahce.formaNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tercih ettiği Ayak:  ");
            fenerbahce.kullandigiAyak = Console.ReadLine();

            string sonuc = $"Id: {fenerbahce.futbolcu1Id} İsim: {fenerbahce.ad} Soyisim: {fenerbahce.soyad} Mevki: {fenerbahce.mevkii} Forma No: {fenerbahce.formaNo} Kullandığı Ayak: {fenerbahce.kullandigiAyak}";

            Console.WriteLine(sonuc);

            string[] futbolcular = {"Altay", "Lemos", "Szalai", "Peres", "Osayi", "İsmail", "Zajc", "Ferdi", "Emre", "Lincoln", "Valencia"};

            for(int i=0; i<futbolcular.Length; i++)
            {
                Console.WriteLine(futbolcular[i]);
            }

            Random rnd = new Random();
            int rastgele = rnd.Next(0, futbolcular.Length);
            Console.WriteLine("Seçilen Futbolcu : " + futbolcular[rastgele]);

            Console.ReadKey();

           int sutGucu = 75;

           if (sutGucu > 70)
            {
                Console.WriteLine("Top az farkla auta çıktı");
                Console.ReadLine();
            }


        }   
    }       
}
