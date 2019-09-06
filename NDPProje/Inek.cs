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
using System.Media;

namespace NDPProje
{
    
    class Inek: Abstract,IFonksiyonlar
    {        
        public int inekCani;
        public int inekParasi;
        public int inekSutMiktari;

        public override void OlumSesleriCal()
        {
            SoundPlayer inekSesi = new SoundPlayer();

            inekSesi.SoundLocation= @"D:\visual\NDPProje\hayvanDosyalar\Hayvan Ciftligi Dosyalar\inek.wav";

            inekSesi.Play();
        }
        public override void CanBelirleme()
        {
            inekCani = 100;
        }
        public override void CanAzaltma()
        {
            inekCani -= 8;
        }

        public override void CanlarıFulle()
        {
            inekCani = 100;
        }


    }
}
