using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace intro_PizzacıSiparişEkranı
{
    public partial class frmPizzaciEkrani : Form
    {
        public frmPizzaciEkrani()
        {
            InitializeComponent();
        }

        #region Global Değişkenler
        double araToplam = 0;
        double listBoxİcinde = 0;
        double cmbİcinde = 0;
        double checkBoxİcinde = 0;
        double tempTotalNumericİcin = 0;
        double rdoİcinde = 0;
        double toplamTutar = 0;
        double geciciAraToplam = 0;

        string radioBoxSecim = "";
        string[] ekstralar = new string[6];
        string ekstalarTopla = "";

        ArrayList silinecekleriTut = new ArrayList();

        bool acKapa = true;

        #endregion

        #region ListBox'a Ekle Kontrolleri

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ekstalarTopla = "";


            if ((double)nmrAdet.Value == 1) //Hiç bir değer ekle butonuna basılmamasına karşın ilk 
                //değerden devam etsin
            {
                geciciAraToplam = araToplam;
            }

            if (lstCesit.SelectedIndex == 0)
            //Başlangıç Form'unda 0'ıncı index'ine konumlanıyor fakat değer eklemiyordu. 
            //Bende elle değer ekledim
            {
                geciciAraToplam += 2 * (double)nmrAdet.Value;
            }

            for (int i = 0; i < ekstralar.Length; i++)
            {
                if (ekstralar[i] != null)
                {
                    ekstalarTopla += ekstralar[i] + ", ";
                }

            }

            if (ekstalarTopla == "")
            {
                ekstalarTopla = "----,,";
            }


            //NumericUpDown'da değer arttırtan sonra nesnelerle işlem yaptığımda ekrana anlık değeri 
            //yansıtıyor,
            //fakat toplam sonuca yansıtmıyordu. Bende böyle bi şart sağladım.
            if (geciciAraToplam != Convert.ToDouble(lblTutarSonuc.Text))
            {
                geciciAraToplam = listBoxİcinde * (double)nmrAdet.Value
                    + cmbİcinde * (double)nmrAdet.Value + checkBoxİcinde * (double)nmrAdet.Value
                + rdoİcinde * (double)nmrAdet.Value;
            }


            lstSiparisDetayı.Items.Add(nmrAdet.Value.ToString() + "\t" + cmbEbat.SelectedItem.ToString() + "\t" + lstCesit.SelectedItem.ToString()
                 + "\t" + radioBoxSecim + "\t" + geciciAraToplam.ToString() + " TL" + "\t" + ekstalarTopla.Remove(ekstalarTopla.Length - 2));





            toplamTutar += geciciAraToplam;


            silinecekleriTut.Add(geciciAraToplam); //silme fonksiyonunda toplamdan silinecek 
            //fiyat değerlerini toplar ve index değerine göre hem ekrandan hem de arraylist içinden siler


            lblToplam.Visible = true;

            lblToplam.Text = toplamTutar.ToString() + " TL";


        }
        #endregion

        #region Çeşitlerin Kontrolleri - ListBox'tan Seçim



        private void lstCesit_MouseClick(object sender, MouseEventArgs e)
        {

            if (lstCesit.SelectedItem == "Classic")
            {
                listBoxİcinde = 2;
            }
            else

           if (lstCesit.SelectedItem == "Turkish")
            {
                listBoxİcinde = 3;
            }
            else


            if (lstCesit.SelectedItem == "Ekstra Kavanoz")
            {
                listBoxİcinde = 4;
            }
            else


            if (lstCesit.SelectedItem == "Kumrucuk")
            {
                listBoxİcinde = 5;
            }
            else

            if (lstCesit.SelectedItem == "Biberli")
            {
                listBoxİcinde = 6;
            }
            else

            if (lstCesit.SelectedItem == "Mexicanli")
            {
                listBoxİcinde = 7;
            }
            else


            if (lstCesit.SelectedItem == "KizilSkin")
            {
                listBoxİcinde = 8;
            }

            araToplamHesapla();


        }
        #endregion

        #region Kalın Hamur / İnce Hamur Kontrolleri - RadioButtons

        private void rdoInceKenar_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoInceKenar.Checked == true)
            {
                rdoİcinde += 8;
                radioBoxSecim = "İnce Kenar";

            }
            else
            {
                rdoİcinde -= 8;

            }

            araToplamHesapla();

        }

        private void rdoKalinKenar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKalinKenar.Checked == true)
            {
                radioBoxSecim = "Kalın Kenar";

            }

        }

        #endregion

        #region Ebatların Kontrolleri - ComboBox

        private void cmbEbat_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblTutarSonuc.Visible = true;
            lblTL.Visible = true;

            if (cmbEbat.SelectedIndex == 1)
            {
                cmbİcinde = 10;
            }


            if (cmbEbat.SelectedItem == "Büyük")
            {
                cmbİcinde = 13;
            }


            if (cmbEbat.SelectedItem == "Küçük")
            {

                cmbİcinde = 7;
            }

            araToplamHesapla();

        }
        #endregion

        #region Ekstraların Kontrolleri - CheckBox 

        private void cbxSalam_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxSalam.Checked)
            {
                checkBoxİcinde += .5;
                ekstralar[0] = "Salam";

            }
            else
            {
                checkBoxİcinde -= .5;

                ekstralar[0] = string.Empty;
            }

            araToplamHesapla();



        }

        private void cbxSosis_CheckedChanged(object sender, EventArgs e)
        {


            if (cbxSosis.Checked)
            {
                checkBoxİcinde += .5;
                ekstralar[1] = "Sosis";
            }
            else
            {
                checkBoxİcinde -= .5;
                ekstralar[1] = string.Empty;
            }

            araToplamHesapla();


        }

        private void cbxSucuk_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxSucuk.Checked)
            {
                checkBoxİcinde += .5;
                ekstralar[2] = "Sucuk";
            }
            else
            {
                checkBoxİcinde -= .5;
                ekstralar[2] = string.Empty;
            }

            araToplamHesapla();


        }

        private void cbxJalepeno_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxJalepeno.Checked)
            {
                checkBoxİcinde += .5;
                ekstralar[3] = "Jalepeno";
            }
            else
            {
                checkBoxİcinde -= .5;
                ekstralar[3] = string.Empty;
            }

            araToplamHesapla();

        }

        private void cbxAncuez_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxAncuez.Checked)
            {
                checkBoxİcinde += .5;
                ekstralar[4] = "Ancuez";
            }
            else
            {
                checkBoxİcinde -= .5;
                ekstralar[4] = string.Empty;
            }

            araToplamHesapla();

        }

        private void cbxZeytin_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxZeytin.Checked)
            {
                checkBoxİcinde += .5;
                ekstralar[5] = "Zeytin";
            }
            else
            {
                checkBoxİcinde -= .5;
                ekstralar[5] = string.Empty;
            }


            araToplamHesapla();

        }
        #endregion

        #region Adet Kontrolleri - NumericUpDown

        private void nmrAdet_ValueChanged(object sender, EventArgs e)
        {
            acKapa = false;

            if ((double)nmrAdet.Value > 1) //Numeric değeri arttırıldığında 
            {
                araToplam = tempTotalNumericİcin;
            }

            geciciAraToplam = araToplam; //Ekrana yansıtılan toplam'a hesap yaptırmak için 


            geciciAraToplam *= (double)nmrAdet.Value;


            //**********aŞAĞIDAKİNİ = tempTotalNumericİcin; İLE DEĞİŞTRİDİN


            araToplam = tempTotalNumericİcin; //her numeric değeri değiştirildiğinde araToplam numeric'den 

            //katlanmadan alınan değer kadar olur.

            lblTutarSonuc.Text = geciciAraToplam.ToString();



        }
        #endregion

        #region Başlangıç Ekranı - Form

        private void frmPizzaciEkrani_Load(object sender, EventArgs e)
        {

            silinecekleriTut.Add(0); //Sipariş detayında ilk iki satır hazır geldiği için
            silinecekleriTut.Add(0);

            cmbEbat.SelectedItem = "Küçük";
            lstCesit.SelectedItem = "Classic";

            lblTutarSonuc.Text = "9";

            lstSiparisDetayı.Items.Add("Adet " + "\t" + "Ebat" + "\t" + "Çeşit" + "\t" + "Kenar Seçimi" + "\t" + "Tutar" + "\t" + "Ekstralar");
            lstSiparisDetayı.Items.Add(Environment.NewLine);

            if (rdoKalinKenar.Checked == true)
            {
                radioBoxSecim = "Kalın Kenar";

            }
        }
        #endregion

        #region Satır Sil Butonu

        private void btnSil_Click(object sender, EventArgs e)
        {
            silmeFonksiyonu();

        }
        #endregion

        #region Hepsini Sil Butonu


        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {


            lstCesit.SelectedIndex = 0;

            cmbEbat.SelectedItem = "Küçük";

            nmrAdet.Value = 1;

            rdoKalinKenar.Checked = true;

            cbxSalam.Checked = false;

            cbxAncuez.Checked = false;

            cbxJalepeno.Checked = false;

            cbxSosis.Checked = false;

            cbxSucuk.Checked = false;

            cbxZeytin.Checked = false;

            lstSiparisDetayı.Items.Clear();

            silinecekleriTut.Clear();

            lblToplam.Text = "";

            lblTutarSonuc.Text = "9";

            tempTotalNumericİcin = 0;
            geciciAraToplam = 9;
            toplamTutar -= toplamTutar;
            araToplam -= araToplam;
            listBoxİcinde = 2;
            cmbİcinde = 7;
            checkBoxİcinde -= checkBoxİcinde;
            rdoİcinde -= rdoİcinde;


            silinecekleriTut.Add(0); //Sipariş detayında ilk iki satır hazır geldiği için
            silinecekleriTut.Add(0);

            lstSiparisDetayı.Items.Add("Adet " + "\t" + "Ebat" + "\t" + "Çeşit" + "\t" + "Kenar Seçimi" + "\t" + "Tutar" + "\t" + "Ekstralar");
            lstSiparisDetayı.Items.Add(Environment.NewLine);
        }

        #endregion

        #region Ara Toplam Fonksiyonu

        void araToplamHesapla()
        {
            tempTotalNumericİcin = listBoxİcinde + cmbİcinde + checkBoxİcinde + rdoİcinde;

            araToplam = listBoxİcinde * (double)nmrAdet.Value
                + cmbİcinde * (double)nmrAdet.Value + checkBoxİcinde * (double)nmrAdet.Value
            + rdoİcinde * (double)nmrAdet.Value;

            lblTutarSonuc.Text = araToplam.ToString();
        }



        #endregion

        void silmeFonksiyonu()
        {
            toplamTutar -= (double)silinecekleriTut[lstSiparisDetayı.SelectedIndex];
            //o sıradaki ara toplamı al ve toplamTutar'dan çıkar.

            silinecekleriTut.RemoveAt(lstSiparisDetayı.SelectedIndex);

            lstSiparisDetayı.Items.RemoveAt(lstSiparisDetayı.SelectedIndex);

            lblToplam.Text = toplamTutar.ToString() + " TL";
        }

        private void lblDegistir_Click(object sender, EventArgs e)
        {

            lstCesit.SelectedIndex = 0;

            cmbEbat.SelectedIndex = 0;

            nmrAdet.Value = 1;

            rdoKalinKenar.Checked = true;

            cbxSalam.Checked = false;

            cbxAncuez.Checked = false;

            cbxJalepeno.Checked = false;

            cbxSosis.Checked = false;

            cbxSucuk.Checked = false;

            cbxZeytin.Checked = false;

            lblTutarSonuc.Text = "9";

            listBoxİcinde = 2;

            silmeFonksiyonu();

        }
    }


}
