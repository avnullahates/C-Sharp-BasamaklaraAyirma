using System;

namespace TamsayiCozumleme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = TamsayiAl();
            SayiyiCozumleme(sayi);
        }
        private static int TamsayiAl()
        {
            Console.WriteLine("Tam sayi giriniz: ");
            try
            {
                string cevap = Console.ReadLine();
                if (cevap == "exit")
                    Environment.Exit(0);

                int sayi = Convert.ToInt32(cevap);
                return sayi;
            }
            catch (Exception)
            {
                YanlisVeriHatasi();
                return TamsayiAl();
            }
        }
        private static void YanlisVeriHatasi()
        {
            Console.WriteLine("Yanlis girdiniz. Tekrar giriniz.");
        }
        private static void SayiyiCozumleme(int sayi)
        {
            int sayac = 0;
            while (sayi > 0)
            {
                Console.WriteLine((sayi % 10) + "x" + Math.Pow(10, sayac) + "=" + (sayi % 10) * (Math.Pow(10, sayac)));
                sayi = sayi / 10;
                sayac++;
            }
        }
    }
}
