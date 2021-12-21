using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    public class YayliCalgilar : IMüzikAleti
    {
        public string MuzikAletiCesitleri()
        {
            Console.WriteLine("          <----------Yaylı Çalgılar---------->");
            return "Yaylı Çalgılar";
        }
        public string MüzikAletiKategori()
        {
            string cel = "1.Çello\t\t";
            string keman = "2.Keman\t\t";
            string kon = "3.Kontrbas\t\t";
            string türk = "4.Türk Yaylı Çalgılar\t\n";
            Console.WriteLine(cel + keman + kon + türk);
            return cel + keman + kon + türk;
        }
    }
}
