using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Tasarım_Deseni__Vize_Bahce
{
    public class Meyve : IBahce
    {
        private string meyve_adi;
        private int meyve_kilogrami;

        public Meyve()
        {
            this.meyve_adi = "Kiraz";
            this.meyve_kilogrami = 100;
        }
        public string Bahcede()
        {
            return "\nBahceden alınan meyve:" + meyve_adi + "\nKaç Kilogram:" + meyve_kilogrami + "alındı.\n";
        }
    }
}
