using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDummyFinal
{
    public class OyunGelistirme : IYazilimaBasla
    {
        public string Oyun_dilleri { get; set; }
        public string Oyundili_bilgi { get; set; }
        public string Oyun_programlari { get; set; }

        public string YazilimaBasla()
        {
            return "Oyun programlamaya nereden başlanacağı ile ilgili bilgiler verildi.";
        }
        public string Algoritma()
        {
            return "Oyun progralama için kullanılacak algoritmalar.";
        }

        public string YazilimDilleri()
        {
            //Burada oyun yazilim dilleri gösterildi.
            return this.Oyun_dilleri;
        }

        public string YazilimDilleriBilgisi()
        {
            //Burada oyun yazilim dilleri ile ilgili bilgiler verilmiştir.
            return this.Oyundili_bilgi;
        }

        public string YazilimProgramlari()
        {
            //Burada yazilim dillerini oyun geliştirme için kullanacağımız programlar verilmiştir.
            return this.Oyun_programlari;
        }
        public string RehberOlustur()
        {
            return "Rehber Oluşturuldu.";
        }
    }
}
