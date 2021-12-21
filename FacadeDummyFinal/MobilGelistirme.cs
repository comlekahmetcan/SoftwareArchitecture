using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDummyFinal
{
    public class MobilGelistirme : IYazilimaBasla
    {
        public string Mobil_dilleri { get; set; }
        public string Mobildili_bilgi { get; set; }
        public string Mobil_programlari { get; set; }
        public string YazilimaBasla()
        {
            return "Mobil programlamaya nereden başlanacağı ile ilgili bilgiler verildi.";
        }
        public string Algoritma()
        {
            return "Mobil progralama için kullanılacak algoritmalar.";
        }

        public string YazilimDilleri()
        {
            //Burada mobil yazilim dilleri gösterildi.
            return this.Mobil_dilleri;
        }

        public string YazilimDilleriBilgisi()
        {
            //Burada mobil yazilim dilleri ile ilgili bilgiler verilmiştir.
            return this.Mobildili_bilgi;
        }

        public string YazilimProgramlari()
        {
            //Burada yazilim dillerini mobil geliştirme için kullanacağımız programlar verilmiştir. 
            return this.Mobil_programlari;
        }
        public string RehberOlustur()
        {
            return "Rehber Oluşturuldu.";
        }
    }
}
