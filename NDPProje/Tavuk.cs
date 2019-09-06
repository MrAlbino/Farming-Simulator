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
    class Tavuk: Abstract,IFonksiyonlar
    {
        public int tavukCani;
        public int tavukParasi;
        public int tavukYumurtaSayisi;

        public override void OlumSesleriCal()
        {
            SoundPlayer tavukSesi = new SoundPlayer();

            tavukSesi.SoundLocation = @"D:\visual\NDPProje\hayvanDosyalar\Hayvan Ciftligi Dosyalar\tavuk.wav";

            tavukSesi.Play();
        }
        public override void CanlarıFulle()
        {
            tavukCani = 100;
        }
        public override void CanAzaltma()
        {
            tavukCani -= 2;
        }
        public override void CanBelirleme()
        {
            tavukCani = 100;
        }
    }
}
