using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    public class TelliCalgilar : IMüzikAleti
    {
        public string MuzikAletiCesitleri()
        {
            Console.WriteLine("          <----------Telli Çalgılar---------->");
            return "Telli Çalgılar";
        }

        public string MüzikAletiKategori()
        {
            string tezene = "1.Tezeneli Çalgılar";
            string yayli_telli = "2.Yaylı Çalgılar";
            string vurmali_telli = "3.Vurmalı Telli Çalgılar\n";
            Console.WriteLine(tezene + "\t" + yayli_telli + "\t" + vurmali_telli);
            return tezene + yayli_telli + vurmali_telli;
        }
    }
}
