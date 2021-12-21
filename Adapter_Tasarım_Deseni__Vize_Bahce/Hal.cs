using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Tasarım_Deseni__Vize_Bahce
{
    public class Hal
    {
        public void YiyecekVer(IBahce bahce)
        {
            string yiyecek = bahce.Bahcede();
            Console.WriteLine("BAHÇEDEN TOPLANDI" + yiyecek);
        }

    }
}
