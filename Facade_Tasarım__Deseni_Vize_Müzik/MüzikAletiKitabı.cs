using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    public class MüzikAletiKitabı
    {
        private IMüzikAleti telli;
        private IMüzikAleti vurmali;
        private IMüzikAleti nefesli;
        private IMüzikAleti yayli;
        private IMüzikAleti tuslu;
        private MüzikAletiKitabiBilgileri bilgiler;

        public MüzikAletiKitabı()
        {
            telli = new TelliCalgilar();
            vurmali = new VurmalıCalgilar();
            nefesli = new NefesliCalgilar();
            yayli = new YayliCalgilar();
            tuslu = new TusluCalgilar();
            bilgiler = new MüzikAletiKitabiBilgileri();
        }


        public string TelliCalgi()
        {
            return telli.MuzikAletiCesitleri() + telli.MüzikAletiKategori();
        }
        public string VurmaliCalgi()
        {
            return vurmali.MuzikAletiCesitleri() + vurmali.MüzikAletiKategori();
        }
        public string NefesliCalgi()
        {
            return nefesli.MuzikAletiCesitleri() + nefesli.MüzikAletiKategori();
        }
        public string YayliCalgi()
        {
            return yayli.MuzikAletiCesitleri() + yayli.MüzikAletiKategori();
        }
        public string TusluCalgi()
        {
            return tuslu.MuzikAletiCesitleri() + tuslu.MüzikAletiKategori();
        }
        public void Bilgi()
        {

            bilgiler.müzik_nedir = "<------Müzik Nedir?------>\nBir sesin anlamlı bir şekilde biçim ve titreşim kazanmış haline, belirli zaman" +
                " aralıkları ile hem sesin hemde sessizliğin ifade edilmesine müzik diyebiliriz.\n\n<------Ana Unsurlar Nelerdir?------>\n";
            bilgiler.müzik_aleti_nedir = "<------Müzik Aleti Nedir?------>\nÇalgı olarak da isimlendirilen müzik aleti, müzik yapmak için" +
                " kullanılan aletlerin genel ismidir.\n";
            bilgiler.bilim_dali = "<------Bilim Dalı Nedir?------>\nBu müzil aleti çeşitlerini inceleyen bilim dalına ise Organoloji denir.\n ";
            bilgiler.müzik_yazari = "<------Müzik Yazar?------>\nMüzik yazarı ve çalgı yapımcısı Victor-Charles Mahillon\n";
            bilgiler.tarih = 20;
            Console.WriteLine(bilgiler.müzik_nedir + bilgiler.Anaunsur() + bilgiler.müzik_aleti_nedir + bilgiler.bilim_dali + bilgiler.müzik_yazari +
                "Tarihi:" + bilgiler.tarih + ".yy\n");
        }
    }
}
