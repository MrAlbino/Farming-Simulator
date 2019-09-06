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
    class Keci: Abstract,IFonksiyonlar
    {
        public int keciCani;
        public int keciParasi;
        public int keciSutuMiktari;

        public override void OlumSesleriCal()
        {
            SoundPlayer keciSesi = new SoundPlayer();

            keciSesi.SoundLocation = @"D:\visual\NDPProje\hayvanDosyalar\Hayvan Ciftligi Dosyalar\keci.wav";

            keciSesi.Play();
        }
        public override void CanlarıFulle()
        {
            keciCani = 100;
        }
        public override void CanAzaltma()
        {
            keciCani -= 6;

        }
        public override void CanBelirleme()
        {
            keciCani = 100;
        }

    }
}
