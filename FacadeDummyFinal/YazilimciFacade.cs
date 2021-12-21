using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDummyFinal
{
    public class YazilimciFacade
    {
        private IYazilimaBasla web;
        private IYazilimaBasla mobil;
        private IYazilimaBasla oyun;

        public YazilimciFacade()
        {
            web = new WebGelistirme();
            mobil = new MobilGelistirme();
            oyun = new OyunGelistirme();
        }   
        
        public string WebGelistir()
        {
            return web.YazilimaBasla() + web.YazilimDilleri() + web.YazilimDilleriBilgisi() + web.YazilimProgramlari();
        }
        public string MobilGelistir()
        {
            return mobil.YazilimaBasla() + mobil.YazilimDilleri() + mobil.YazilimDilleriBilgisi() + mobil.YazilimProgramlari();
        }
        public string OyunGelistir()
        {
            return oyun.YazilimaBasla() + oyun.YazilimDilleri() + oyun.YazilimDilleriBilgisi() + oyun.YazilimProgramlari();
        }
    }
}
