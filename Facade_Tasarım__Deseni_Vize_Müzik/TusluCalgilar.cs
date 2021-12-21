using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    public class TusluCalgilar : IMüzikAleti
    {
        public string MuzikAletiCesitleri()
        {
            Console.WriteLine("          <----------Tuşlu Calgılar---------->");
            return "Tuşlu Çalgılar";
        }
        public string MüzikAletiKategori()
        {
            string klav = "1.Klavyeciler\t";
            string akor = "2.Akordeon\t";
            string el_klav = "3.Elektronik Klavyeler\t";
            string klavsen = "4.Klavsen\t";
            string org = "5.Org\t";
            string piyano = "6.Piyano\t\n";
            Console.WriteLine(klav + akor + el_klav + klavsen + org + piyano);
            return klav + akor + el_klav + klavsen + org + piyano;
        }
    }
}
