/**
                    SAKARYA ÜNİVERSİTESİ
                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                   NESNEYE DAYALI PROGRAMLAMA DERSİ
                    2018-2019 BAHAR DÖNEMİ

                ÖDEV NUMARASI..........:PROJE-1
                ÖĞRENCİ ADI............:AYBERK KÖSE
                ÖĞRENCİ NUMARASI.......:B181210001
                DERSİN ALINDIĞI GRUP...:D
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    abstract class Abstract : IFonksiyonlar
    {
        public abstract void OlumSesleriCal();
        public abstract void CanAzaltma();
        public abstract void CanBelirleme();
        public abstract void CanlarıFulle();

    }
}
