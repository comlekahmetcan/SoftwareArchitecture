using System;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    class Program
    {
        static void Main(string[] args)
        {
            MüzikAletiKitabı müzikkitabı = new MüzikAletiKitabı();

            müzikkitabı.Bilgi();
            müzikkitabı.TelliCalgi();
            müzikkitabı.VurmaliCalgi();
            müzikkitabı.NefesliCalgi();
            müzikkitabı.YayliCalgi();
            müzikkitabı.TusluCalgi();
            Console.ReadLine();

        }
    }
}
