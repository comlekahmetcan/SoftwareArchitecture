using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    public class NefesliCalgilar : IMüzikAleti
    {
        public string MuzikAletiCesitleri()
        {
            Console.WriteLine("          <----------Nefesli Çalgılar---------->");
            return "Nefesli Çalgılar";
        }

        public string MüzikAletiKategori()
        {
            string akor = "1.Akordeon\t";
            string bakır = "2.Bakır Nefesli Çalgılar\t";
            string gayda = "3.Gaydalar\t";
            string tahta = "4.Tahta Nefesli Çalgılar\t\n";
            Console.WriteLine(akor + bakır + gayda + tahta);
            return akor + bakır + gayda + tahta;

        }
    }
}
