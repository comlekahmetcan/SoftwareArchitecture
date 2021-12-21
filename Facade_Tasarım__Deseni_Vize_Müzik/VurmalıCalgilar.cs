using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    public class VurmalıCalgilar : IMüzikAleti
    {
        public string MuzikAletiCesitleri()
        {
            Console.WriteLine("          <----------Vurmalı Çalgılar---------->");
            return "Vurmalı Çalgılar";
        }
        public string MüzikAletiKategori()
        {
            string bateri = "1.Bateri\t";
            string can = "2.Çanlar\t";
            string idi = "3.İdiofonlar\t";
            string vib = "4.Vibrafon\t\n";
            Console.WriteLine(bateri + can + idi + vib);
            return bateri + can + idi + vib;
        }

    }
}
