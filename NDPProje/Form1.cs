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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDPProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Sınıfların nesneleri oluşturuluyor
        Hayvanlar hayvanlar = new Hayvanlar();
        Keci keci = new Keci();
        Ordek ordek = new Ordek();
        Inek inek = new Inek();
        Tavuk tavuk = new Tavuk();

        private void Form1_Load(object sender, EventArgs e)
        {
            hayvanlar.kasaPara = Convert.ToInt32(kasaLabel.Text); //kasaPara değişkenini kasalabel'da yazan değere eşitliyoruz

            //Hayvanların canları 100 olarak atanıyor.
            inek.CanBelirleme();
            keci.CanBelirleme();
            ordek.CanBelirleme();
            tavuk.CanBelirleme();
        }

        private void timer1_Tick(object sender, EventArgs e) //Geçen süreyi ayarlayan ve hayvanlar ölümce ölüm mesajı çıkartan timer
        {
            hayvanlar.saniyeZamanLabel++;

            zamanLabel.Text = Convert.ToString(hayvanlar.saniyeZamanLabel) + " sn";

            //Tüm hayvanlar öldü mesajı çıkartma
            if (tavukYasamBelirtisiLabel.Text == "ÖLÜ" && ordekYasamBelirtisiLabel.Text == "ÖLÜ"
                && inekYasamBelirtisiLabel.Text == "ÖLÜ" && keciYasamBelirtisiLabel.Text == "ÖLÜ")
            {
                timer1.Enabled = false;

                MessageBox.Show("Tüm Hayvanlarınız Öldü :(");
                
            }

        }

        private void timer3_Tick(object sender, EventArgs e) //TAVUK YUMURTA sayısını hesaplayıp yazdırmak için Timer
        {
            hayvanlar.tavukSaniye++;

            if (hayvanlar.tavukSaniye % 3 == 0) 
            {
                tavuk.tavukYumurtaSayisi = hayvanlar.tavukSaniye / 3;

                tavukYumurtaLabel.Text = Convert.ToString(tavuk.tavukYumurtaSayisi)+" "+"ADET";
            }
        }

        private void timer4_Tick(object sender, EventArgs e) //ORDEK YUMURTA sayısını hesaplayıp yazdırmak için Timer
        {
            hayvanlar.ordekSaniye++;

            if (hayvanlar.ordekSaniye % 5 == 0)
            {
                ordek.ordekYumurtaSayisi = hayvanlar.ordekSaniye / 5;

                ordekYumurtaLabel.Text = Convert.ToString(ordek.ordekYumurtaSayisi)+" "+"ADET";
            }
        }

        private void timer5_Tick(object sender, EventArgs e) //INEK SUTU miktarını hesaplayıp yazdırmak için Timer
        {
            hayvanlar.inekSaniye++;

            if (hayvanlar.inekSaniye % 8 == 0)
            {
                inek.inekSutMiktari = hayvanlar.inekSaniye / 8;

                inekSutLabel.Text = Convert.ToString(inek.inekSutMiktari)+" "+"LİTRE";
            }

        }

        private void timer6_Tick(object sender, EventArgs e) //KECI SUTU miktarını hesaplayıp yazdırmak için Timer
        {
            hayvanlar.keciSaniye++;

            if (hayvanlar.keciSaniye % 7 == 0)
            {
                keci.keciSutuMiktari = hayvanlar.keciSaniye / 7;

                keciSutLabel.Text = Convert.ToString(keci.keciSutuMiktari)+" "+"LİTRE";
            }
        }
        private void tavukYemVerButton_Click(object sender, EventArgs e) //Tavuk yem ver butonuna tıklayınca tavuğun canını 100 yap.
        {
            tavuk.CanlarıFulle();
        }

        private void inekYemVerButton_Click(object sender, EventArgs e) //Inek yem ver butonuna tıklayınca ineğin canını 100 yap.
        {
            inek.CanlarıFulle();
        }

        private void ordekYemVerButton_Click(object sender, EventArgs e) //Ordek yem ver butonuna tıklayınca ördeğin canını 100 yap.
        {
            ordek.CanlarıFulle();
        }

        private void keciYemVerButton_Click(object sender, EventArgs e) //Keci yem ver butonuna tıklayınca keçinin canını 100 yap.
        {
            keci.CanlarıFulle();
        }

        private void tavukYumurtaSatButton_Click(object sender, EventArgs e) //Tavuk yumurtasını satma butonu
        {
            tavuk.tavukParasi = tavuk.tavukYumurtaSayisi*1;
           
            hayvanlar.kasaPara += tavuk.tavukParasi;

            kasaLabel.Text = Convert.ToString(hayvanlar.kasaPara)+" "+"TL";

            tavukYumurtaLabel.Text = "0";

            hayvanlar.tavukSaniye = 0; //Tavuk yumurtasını hesaplayan timer'ı sıfırlayıp baştan başlatıyoruz
            
        }

        private void ordekYumurtaSatButton_Click(object sender, EventArgs e)
        {
            ordek.ordekParasi = Convert.ToInt32(ordek.ordekYumurtaSayisi) * 3;

            hayvanlar.kasaPara += ordek.ordekParasi;

            kasaLabel.Text = Convert.ToString(hayvanlar.kasaPara)+" "+"TL";

            ordekYumurtaLabel.Text = "0";

            hayvanlar.ordekSaniye = 0;  //Ordek yumurtasını sayan timer'ı sıfırlayıp baştan başlatıyoruz.
        }

        private void inekSutuSatButton_Click(object sender, EventArgs e)
        {
            inek.inekParasi = Convert.ToInt32(inek.inekSutMiktari)*5;

            hayvanlar.kasaPara += inek.inekParasi;

            kasaLabel.Text = Convert.ToString(hayvanlar.kasaPara)+" "+"TL";

            inekSutLabel.Text = "0";

            hayvanlar.inekSaniye = 0; //Inek sütünü sayan timer'ı sıfırlayıp baştan başlatıyoruz.
        }

        private void keciSutuSatButton_Click(object sender, EventArgs e)
        {
            keci.keciParasi = Convert.ToInt32(keci.keciSutuMiktari)*8;

            hayvanlar.kasaPara += keci.keciParasi;

            kasaLabel.Text = Convert.ToString(hayvanlar.kasaPara)+" "+"TL";
            
            keciSutLabel.Text = "0";

            hayvanlar.keciSaniye = 0; //Keci sütünü sayan timer'ı sıfırlayıp baştan başlatıyoruz.
        }

        private void timer7_Tick(object sender, EventArgs e)  //Ineğin progressbar'ının işlemlerini yürüten timer
        {        
            inekProgressBar.Value = inek.inekCani;
            
            inek.CanAzaltma(); //Zamanla ineğin canını azaltan method

            if (inekProgressBar.Value == 4) //Ineğin canı 4 kalınca progressbar negatif değer almasın diye kontrol koyarak denetliyoruz.
            {
                timer7.Enabled = false;

                System.Threading.Thread.Sleep(100);

                inekProgressBar.Value = 0;
            }
            if (inekProgressBar.Value == 0) //ineğin canı 0 kalınca olacak olaylar
            {
                inek.OlumSesleriCal();

                inekYasamBelirtisiLabel.Text = "ÖLÜ";

                inekYemVerButton.Enabled = false;

                timer5.Enabled = false;
            }
        }

        private void timer8_Tick(object sender, EventArgs e) //Kecinin progressbar'ının işlemlerini yürüten timer
        {         
            keciProgressBar.Value = keci.keciCani;
            
            keci.CanAzaltma();

            if(keciProgressBar.Value==4) //Kecinin canı 4 kalınca progressbar negatif değer almasın diye kontrol koyarak denetliyoruz.
            {
                timer8.Enabled = false;

                System.Threading.Thread.Sleep(100);

                keciProgressBar.Value = 0;
            }
            if (keciProgressBar.Value == 0) //kecinin canı 0 kalınca olacak olaylar
            {
                keci.OlumSesleriCal();

                keciYasamBelirtisiLabel.Text = "ÖLÜ";

                keciYemVerButton.Enabled = false;

                timer6.Enabled = false;

            }

        }

        private void timer9_Tick(object sender, EventArgs e) //Ordeğin progressbar'ının işlemlerini yürüten Timer
        {    
            ordekProgressBar.Value = ordek.ordekCani;
           
            ordek.CanAzaltma();

            if(ordekProgressBar.Value==1) //Ordeğin canı 1 kalınca progressbar negatif değer almasın diye kontrol koyarak denetliyoruz.
            {
                timer9.Enabled = false;

                System.Threading.Thread.Sleep(100);

                ordekProgressBar.Value = 0;
            }

            if(ordekProgressBar.Value==0) //ordeğin canı 0 kalınca olacak olaylar
            {
                ordek.OlumSesleriCal();

                ordekYasamBelirtisiLabel.Text = "ÖLÜ";

                ordekYemVerButton.Enabled = false;

                timer4.Enabled = false;
            }
        }

        private void timer10_Tick(object sender, EventArgs e) //Tavugun progressbar'ının işlemlerini yürüten timer
        {          
            tavukProgressBar.Value = tavuk.tavukCani;
            
            tavuk.CanAzaltma();

            if(tavukProgressBar.Value==2) //Tavuğun canı 2 kalınca progressbar negatif değer almasın diye kontrol koyarak denetliyoruz.
            {
                timer10.Enabled = false;

                System.Threading.Thread.Sleep(100);

                tavukProgressBar.Value = 0;
            }

            if(tavukProgressBar.Value==0) //tavuğun canı 0 kalınca olacak olaylar
            {
                tavuk.OlumSesleriCal();

                tavukYasamBelirtisiLabel.Text = "ÖLÜ";

                tavukYemVerButton.Enabled = false;

                timer3.Enabled = false;
            }

        }
    } 
}
