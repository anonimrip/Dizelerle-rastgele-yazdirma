using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] günler = {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"};
            string[] yemek = { "Nargile","Pilav","Fasulley","Guru","Marul Çorbası","Ananas suyu","Mısır","Mercimek","Tavuk","Döner","Tost","Mangalda Sucuk","patates","kızartma","kadın budu" };
            string uret = "";

            Random rastgele = new Random();
          
            for(int i=0;i<7;i++)
            {
                uret = yemek[rastgele.Next(yemek.Length)];
                Console.WriteLine(günler[i]);
                Console.WriteLine(uret);
                Console.WriteLine();
            }
            Console.ReadKey();
        
        
        }
    }
}
