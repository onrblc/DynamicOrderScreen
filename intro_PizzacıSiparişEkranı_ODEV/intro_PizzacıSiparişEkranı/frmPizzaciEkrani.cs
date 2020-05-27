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
    public partial class frmPizzaciEkraniYEDEK : Form
    {
        public frmPizzaciEkraniYEDEK()
        {
            InitializeComponent();
        }

        #region Global Değişkenler
        double nesnelerinAraToplami = 0;
        double cesitinDegeri = 0;
        double ebatinDegeri = 0;
        double ekstralarinDegeri = 0;
        double araToplaminTekKati = 0;
        double radioDegeri = 0;
        double toplamTutar = 0;
        double anaAraToplam = 0;

        string radioBoxSecim = "";
        string[] secilenEkstralar = new string[6]; //6 çeşit ekstrayı toplayıp kontrol etmek için
        string ekstralariListele = "";

        ArrayList silinecekleriTut = new ArrayList(); //satırlar kolayca eklenip çıkarılabilsin diye


        #endregion

        #region Başlangıç Ekranı - Form

        private void frmPizzaciEkrani_Load(object sender, EventArgs e)
        {

            try
            {
                silinecekleriTut.Add(0); //Sipariş detayında ilk iki satır hazır geldiği için. Bu satırların
                                         //hazır gelmesi index değerini bozacağından, arraylistinde ilk iki değerini doldurdum.
                silinecekleriTut.Add(0);

                cmbEbat.SelectedItem = "Küçük";
                lstCesit.SelectedItem = "Classic";

                lblAraToplam.Text = "9";
                cesitinDegeri = 2;

                lstSiparisDetayı.Items.Add("Adet " + "\t" + "Ebat" + "\t" + "Çeşit" + "\t" + "Kenar Seçimi" + "\t" + "Tutar" + "\t" + "Ekstralar");
                lstSiparisDetayı.Items.Add(Environment.NewLine);

                if (rdoKalinKenar.Checked == true)
                {
                    radioBoxSecim = "Kalın Kenar";

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

            }
        }
        #endregion

        #region Çeşitlerin Kontrolleri - ListBox'tan Seçim


        private void lstCesit_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (lstCesit.SelectedItem == "Classic")
                {
                    cesitinDegeri = 2;
                }
                else

                  if (lstCesit.SelectedItem == "Turkish")
                {
                    cesitinDegeri = 3;
                }
                else


                   if (lstCesit.SelectedItem == "Ekstra Kavanoz")
                {
                    cesitinDegeri = 4;
                }
                else


                   if (lstCesit.SelectedItem == "Kumrucuk")
                {
                    cesitinDegeri = 5;
                }
                else

                   if (lstCesit.SelectedItem == "Biberli")
                {
                    cesitinDegeri = 6;
                }
                else

                   if (lstCesit.SelectedItem == "Mexicanli")
                {
                    cesitinDegeri = 7;
                }
                else


                   if (lstCesit.SelectedItem == "KizilSkin")
                {
                    cesitinDegeri = 8;
                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                

                
            }


        }
        #endregion

        #region Kalın Hamur / İnce Hamur Kontrolleri - RadioButtons

        private void rdoInceKenar_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (rdoInceKenar.Checked == true)
                {
                    radioDegeri += 8;
                    radioBoxSecim = "İnce Kenar";

                }
                else
                {
                    radioDegeri -= 8;

                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }

        }

        private void rdoKalinKenar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoKalinKenar.Checked == true)
                {
                    radioBoxSecim = "Kalın Kenar";

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }

        }

        #endregion

        #region Ebatların Kontrolleri - ComboBox

        private void cmbEbat_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                lblAraToplam.Visible = true;
                lblTL.Visible = true;

                if (cmbEbat.SelectedIndex == 1)
                {
                    ebatinDegeri = 10;
                }


                if (cmbEbat.SelectedItem == "Büyük")
                {
                    ebatinDegeri = 13;
                }


                if (cmbEbat.SelectedItem == "Küçük")
                {

                    ebatinDegeri = 7;
                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

               
            }

        }
        #endregion

        #region Ekstraların Kontrolleri - CheckBox 

        private void cbxSalam_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxSalam.Checked)
                {
                    ekstralarinDegeri += .5;
                    secilenEkstralar[0] = "Salam";

                }
                else
                {
                    ekstralarinDegeri -= .5;

                    secilenEkstralar[0] = string.Empty;
                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

               
            }



        }

        private void cbxSosis_CheckedChanged(object sender, EventArgs e)
        {


            try
            {
                if (cbxSosis.Checked)
                {
                    ekstralarinDegeri += .5;
                    secilenEkstralar[1] = "Sosis";
                }
                else
                {
                    ekstralarinDegeri -= .5;
                    secilenEkstralar[1] = string.Empty;
                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }


        }

        private void cbxSucuk_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxSucuk.Checked)
                {
                    ekstralarinDegeri += .5;
                    secilenEkstralar[2] = "Sucuk";
                }
                else
                {
                    ekstralarinDegeri -= .5;
                    secilenEkstralar[2] = string.Empty;
                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                throw;
            }


        }

        private void cbxJalepeno_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxJalepeno.Checked)
                {
                    ekstralarinDegeri += .5;
                    secilenEkstralar[3] = "Jalepeno";
                }
                else
                {
                    ekstralarinDegeri -= .5;
                    secilenEkstralar[3] = string.Empty;
                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }

        }

        private void cbxAncuez_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxAncuez.Checked)
                {
                    ekstralarinDegeri += .5;
                    secilenEkstralar[4] = "Ancuez";
                }
                else
                {
                    ekstralarinDegeri -= .5;
                    secilenEkstralar[4] = string.Empty;
                }

                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                throw;
            }

        }

        private void cbxZeytin_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbxZeytin.Checked)
                {
                    ekstralarinDegeri += .5;
                    secilenEkstralar[5] = "Zeytin";
                }
                else
                {
                    ekstralarinDegeri -= .5;
                    secilenEkstralar[5] = string.Empty;
                }


                araToplamHesapla();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }

        }
        #endregion

        #region Adet Kontrolleri - NumericUpDown

        private void nmrAdet_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                if ((double)nmrAdet.Value > 1) //Numeric değeri arttırıldığında 
                {
                    nesnelerinAraToplami = araToplaminTekKati;
                }

                anaAraToplam = nesnelerinAraToplami; //Ekrana yansıtılan toplam'a hesap yaptırmak için 


                anaAraToplam *= (double)nmrAdet.Value;


                nesnelerinAraToplami = araToplaminTekKati; //her numeric değeri değiştirildiğinde nesnelerinAraToplami numeric'den 

                //katlanmadan alınan değer kadar olur. 

                lblAraToplam.Text = anaAraToplam.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }



        }
        #endregion

        #region Ekle Butonu ve Kontrolleri

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ekstralariListele = "";

                if ((double)nmrAdet.Value == 1) //Hiç bir değer ekle butonuna basılmamasına karşın ilk 
                                                //değerden devam etsin
                {
                    anaAraToplam = nesnelerinAraToplami;
                }

                if (lstCesit.SelectedIndex == 0)
                //Başlangıç Form'unda 0'ıncı index'ine konumlanıyor fakat değer eklemiyordu. 
                //Bende elle değer ekledim
                {
                    anaAraToplam += 2 * (double)nmrAdet.Value;
                }

                #region Ekstraları Listeler ve Kontrol Eder

                for (int i = 0; i < secilenEkstralar.Length; i++)
                {
                    if (secilenEkstralar[i] != null && secilenEkstralar[i] != "" )
                    {
                        ekstralariListele += secilenEkstralar[i] + ", ";
                    }

                }

                if (ekstralariListele == "")
                {
                    ekstralariListele = "----,,";
                }
                #endregion


                //NumericUpDown'da değer arttırtan sonra nesnelerle işlem yaptığımda ekrana anlık değeri 
                //yansıtıyor,
                //fakat toplam sonuca yansıtmıyordu. Bende böyle bi şart sağladım.
                if (anaAraToplam != Convert.ToDouble(lblAraToplam.Text))
                {
                    anaAraToplam = cesitinDegeri * (double)nmrAdet.Value
                        + ebatinDegeri * (double)nmrAdet.Value + ekstralarinDegeri * (double)nmrAdet.Value
                    + radioDegeri * (double)nmrAdet.Value;
                }


                #region Sipariş Detayları.Add Komutu
                lstSiparisDetayı.Items.Add(nmrAdet.Value.ToString() + "\t" + cmbEbat.SelectedItem.ToString() + "\t" + lstCesit.SelectedItem.ToString()
                         + "\t" + radioBoxSecim + "\t" + anaAraToplam.ToString() + " TL" + "\t" + ekstralariListele.Remove(ekstralariListele
                .Length - 2));
                #endregion


                toplamTutar += anaAraToplam;

                silinecekleriTut.Add(anaAraToplam); //silme fonksiyonunda toplamdan silinecek 
                                                    //fiyat değerlerini toplar ve index değerine göre hem ekrandan hem de arraylist içinden siler


                lblToplam.Visible = true;

                lblToplam.Text = toplamTutar.ToString() + " TL";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

               
            }


        }
        #endregion

        #region Satır Sil Butonu

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                silmeFonksiyonu();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }

        }
        #endregion

        #region Hepsini Sil Butonu


        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {


            try
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

                lblAraToplam.Text = "9";

                araToplaminTekKati = 0; //her durumda kullanıcının karşılatığı ilk değerleri
                anaAraToplam = 9;
                toplamTutar -= toplamTutar;
                nesnelerinAraToplami -= nesnelerinAraToplami;
                cesitinDegeri = 2;
                ebatinDegeri = 7;
                ekstralarinDegeri -= ekstralarinDegeri;
                radioDegeri -= radioDegeri;


                silinecekleriTut.Add(0); //Sipariş detayında ilk iki satır hazır geldiği için
                silinecekleriTut.Add(0);

                lstSiparisDetayı.Items.Add("Adet " + "\t" + "Ebat" + "\t" + "Çeşit" + "\t" + "Kenar Seçimi" + "\t" + "Tutar" + "\t" + "secilenEkstralar");
                lstSiparisDetayı.Items.Add(Environment.NewLine);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

               
            }
        }

        #endregion

        #region Değiştir Butonu
        private void lblDegistir_Click(object sender, EventArgs e)
        {

            try
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

                lblAraToplam.Text = "9";

                cesitinDegeri = 2; //kullanıcının karşılaştığı Classic seçeneğinden ötürü ilk değeri

                silmeFonksiyonu();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }

        }
        #endregion


        void araToplamHesapla()
        {
            try
            {
                araToplaminTekKati = cesitinDegeri + ebatinDegeri + ekstralarinDegeri + radioDegeri;

                nesnelerinAraToplami = cesitinDegeri * (double)nmrAdet.Value
                    + ebatinDegeri * (double)nmrAdet.Value + ekstralarinDegeri * (double)nmrAdet.Value
                + radioDegeri * (double)nmrAdet.Value;

                lblAraToplam.Text = nesnelerinAraToplami.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);

                
            }
        }

        void silmeFonksiyonu()
        {
            try
            {
                if (lstCesit.SelectedIndex == 0 && lstCesit.SelectedIndex == 1)
                {
                    MessageBox.Show("Lütfen geçerli bir sipariş seçin.");
                }

                if (lstCesit.SelectedIndex == null)
                {
                    MessageBox.Show("Bir sipariş seçin.");
                }
                else
                {


                    toplamTutar -= (double)silinecekleriTut[lstSiparisDetayı.SelectedIndex];
                    //o sıradaki ara toplamı al ve toplamTutar'dan çıkar.

                    silinecekleriTut.RemoveAt(lstSiparisDetayı.SelectedIndex);

                    lstSiparisDetayı.Items.RemoveAt(lstSiparisDetayı.SelectedIndex);

                    lblToplam.Text = toplamTutar.ToString() + " TL";
                }
            }
            catch (Exception hata)
            {
               
                MessageBox.Show("Bir Sipariş Seçin!");

                //throw;
            }
        }

        
    }


}
