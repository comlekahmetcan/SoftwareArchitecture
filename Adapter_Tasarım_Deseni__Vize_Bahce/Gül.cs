using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Tasarım_Deseni__Vize_Bahce
{
    public class Gül : ICicek
    {
        private string renk;
        private string adi;
        private string yer;

        public Gül()
        {
            renk = "Beyaz";
            adi = "Akgül";
            yer = "Anadolu";
        }

        public string Cicekler()
        {
            return "\nGülün rengi:" + renk + "\nGülün adi:" + adi + "\nYetistigi yer" + yer;
        }
    }
}
