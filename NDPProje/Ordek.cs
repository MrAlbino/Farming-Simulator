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
    class Ordek: Abstract,IFonksiyonlar
    {
        public int ordekCani;
        public int ordekParasi;
        public int ordekYumurtaSayisi;

        public override void OlumSesleriCal()
        {
            SoundPlayer ordekSesi = new SoundPlayer();

            ordekSesi.SoundLocation = @"D:\visual\NDPProje\hayvanDosyalar\Hayvan Ciftligi Dosyalar\ordek.wav";

            ordekSesi.Play();
        }
        public override void CanlarıFulle()
        {
            ordekCani = 100;
        }
        public override void CanAzaltma()
        {
            ordekCani -= 3;
        }
        public override void CanBelirleme()
        {
            ordekCani = 100;
        }
    }
}
