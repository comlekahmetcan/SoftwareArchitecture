using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Tasarım_Deseni__Vize_Bahce
{
    public class CicekBahceyeAdapter : IBahce
    {
        private ICicek cicek;

        public CicekBahceyeAdapter(ICicek cicek)
        {
            this.cicek = cicek;
        }

        public string Bahcede()
        {
            return cicek.Cicekler();
        }

    }
}
