using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDummyFinal
{
    public class WebGelistirme : IYazilimaBasla
    {
        public string Web_dilleri { get; set; }
        public string Webdili_bilgi { get; set; }
        public string Web_programlari { get; set; }
        public string YazilimaBasla()
        {
            return "Web programlamaya nereden başlanacağı ile ilgili bilgiler verildi.";
        }
        public string Algoritma()
        {
            return "Web progralama için kullanılacak algoritmalar.";
        }
        public string YazilimDilleri()
        {
            //Burada web yazilim dilleri gösterildi.
            return this.Web_dilleri;
        }

        public string YazilimDilleriBilgisi()
        {
            //Burada web yazilim dilleri ile ilgili bilgiler verilmiştir.
            return this.Webdili_bilgi;
        }

        public string YazilimProgramlari()
        {
            //Burada yazilim dillerini web geliştirme için kullanacağımız programlar verilmiştir.   
            return this.Web_programlari;
        }
        public string RehberOlustur()
        {
            return "Rehber Oluşturuldu.";
        }
    }
}
