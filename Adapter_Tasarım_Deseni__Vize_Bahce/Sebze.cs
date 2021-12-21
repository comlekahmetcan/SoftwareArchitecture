using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Tasarım_Deseni__Vize_Bahce
{
    public class Sebze : IBahce
    {
        private string sebze_adi;
        private int sebze_kilogrami;

        public Sebze()
        {
            this.sebze_adi = "Taze Fasulye";
            this.sebze_kilogrami = 500;
        }

        public string Bahcede()
        {
            return "\nBahceden alınan sebze:" + sebze_adi + "\nKaç Kilogram:" + sebze_kilogrami + "alındı.\n";
        }

    }
}
