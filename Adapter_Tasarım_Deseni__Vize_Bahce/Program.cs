using System;

namespace Adapter_Tasarım_Deseni__Vize_Bahce
{
    class Program
    {
        static void Main(string[] args)
        {
            Hal hal = new Hal();

            Meyve meyve = new Meyve();
            Sebze sebze = new Sebze();

            hal.YiyecekVer(meyve);
            hal.YiyecekVer(sebze);

            Gül gül = new Gül();
            CicekBahceyeAdapter adapter = new CicekBahceyeAdapter(gül);
            hal.YiyecekVer(adapter);
            Console.ReadLine();
        }
    }
}
