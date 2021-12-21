using System;

namespace FacadeDummyFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            YazilimciFacade yazilimci = new YazilimciFacade();
            yazilimci.WebGelistir();
            yazilimci.MobilGelistir();
            yazilimci.OyunGelistir();
            Console.ReadLine();
        }
    }
}
