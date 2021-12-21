using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Tasarım__Deseni_Vize_Müzik
{
    public class MüzikAletiKitabiBilgileri : IMüzikAleti
    {
        public string müzik_nedir { get; set; }
        public string ana_unsur { get; set; }
        public string müzik_aleti_nedir { get; set; }
        public string bilim_dali { get; set; }
        public string müzik_yazari { get; set; }
        public int tarih { get; set; }
        public MüzikAletiKitabiBilgileri()
        {
            this.müzik_nedir = müzik_nedir;
            this.ana_unsur = this.Anaunsur();
            this.müzik_aleti_nedir = müzik_aleti_nedir;
            this.bilim_dali = bilim_dali;
            this.müzik_yazari = müzik_yazari;
            this.tarih = tarih;

        }


        public string Anaunsur()
        {
            string diklik = "<*Diklik Nedir?------>Bir sesin ne kadar ‘tiz’ ya da ‘pes’ olduğunu ifade eder. Örneğin her nota ismi (Do, re, mi) farklı bir dikliğe sahiptir." +
                " Aynı nota isimleri de hangi oktavda bulunduklarına bağlı olarak farklı diklikleri hangi edebilirler. Akustik olarak birimi frekanstır.\n";
            string yogunluk = "*Yoğunluk Nedir?------>Bir sesin gürlüğünü ifade eder. Müzikte nüans olarak da kullanılır (forte, piano, fortessimo vb)." +
                " Akustik olarak birimi desibeldir.\n";
            string süre = "<*Süre?------>Bir sesin ne kadar sürdüğünü ifade eder. Müzikte ikinin katları biçiminde ifade edilir (birlik, ikilik, dörtlük, sekizlik) " +
                "ancak nota değerlerinin yanlarına konan noktalar sürenin kendi değerinin yarısı kadar daha uzamasını sağlar.\n";
            string tını = "<*Tını Nedir?------>Bir sesin rengini ifade eder. Örneğin aynı oktavda aynı notayı aynı yoğunlukta ve aynı uzunlukta çalan bir kemanla bir" +
                " flüt arasındaki fark tını farkıdır. Dört özellik içinde en karmaşık olan özellik budur. Akustik olarak tını, sesin doğuşkan (harmonik) " +
                "yapısına bağlı olarak değişir.\n\n";
            return diklik + yogunluk + süre + tını;
        }

        public string MuzikAletiCesitleri()
        {
            return "MüzikAletiCesitlerine Kitap Bilgisi Eklendi";
        }

        public string MüzikAletiKategori()
        {
            return "MüzikAletiKategorisine Kitap Bilgisi Eklendi";
        }
    }
}
