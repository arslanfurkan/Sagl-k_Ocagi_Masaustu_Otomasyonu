using Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Database;
using Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Model;
using System;
 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views
{
    public partial class KullaniciTanitmaForm : Form
    {
        private AnaForm _anaForm;
        private static KullaniciTanitmaForm ktForm;
        private SohatsContext _context;
        Kullanici kullanici = null;
        private bool yetkiDegisti = false;

        protected KullaniciTanitmaForm(AnaForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;

        }

        public static KullaniciTanitmaForm KTFormOlustur(AnaForm anaForm)
        {
            if (ktForm == null)
            {
                ktForm = new KullaniciTanitmaForm(anaForm);
               
            }
            else
            {
                ktForm.Location = new Point(0, 0);
                ktForm.Activate();
            }
            return ktForm;
        }
        public static void KTFormuKapat()
        {
            if (IsOpen())
            {
                ktForm.Close();
                ktForm = null;
            }
           
        }
        public static bool IsOpen()
        {
            if (ktForm != null)
            {
                return true;
            }
            return false;
        }

        //KULLANICI ISLEMLERI
        public void KullaniciEkle(Kullanici kullanici)
        {
            this.kullanici = kullanici;
        }
        private void Kullanici_to_Arayuz_Iliskilendir()
        {
            textBoxKullaniciKodu.Text = kullanici.KullaniciKodu.ToString();

                if (kullanici.TckimlikNo != null)
                    textBoxTCKimlikNo.Text = kullanici.TckimlikNo.ToString();
                if (kullanici.DogumYeri != null)
                    textBoxDogumYeri.Text = kullanici.DogumYeri.ToString();
                if (kullanici.BabaAdi != null)
                    textBoxBabaAdi.Text = kullanici.BabaAdi.ToString();
                if (kullanici.AnneAdi != null)
                    textBoxAnneAdi.Text = kullanici.AnneAdi.ToString();
                if (kullanici.EvTel != null)
                    textBoxTelefonNo.Text = kullanici.EvTel.ToString();
                if (kullanici.CepTel != null)
                    textBoxGSM.Text = kullanici.CepTel.ToString();
                if (kullanici.Unvan != null)
                    comboBoxUnvani.SelectedItem = kullanici.Unvan.ToString();//ComboBox'a Belli basli unvanlar ekle
                if (kullanici.Ad != null)
                    textBoxAdi.Text = kullanici.Ad.ToString();
                if (kullanici.Soyad != null)
                    textBoxSoyadi.Text = kullanici.Soyad.ToString();
                if (kullanici.Maas != null)
                    textBoxMaas.Text = kullanici.Maas.ToString();
                if (kullanici.IseBaslama != null)
                    dateTimePickerIseBaslama.Value = kullanici.IseBaslama.Value;//null ise hata verirmi
                if (kullanici.DogumTarihi != null)
                    dateTimePickerDogumTarihi.Value = kullanici.DogumTarihi.Value;// aynı
                if (kullanici.Cinsiyet != null)
                    comboBoxCinsiyet.SelectedItem = kullanici.Cinsiyet.ToString();//ComboBox'a cinsiyetleri ekle
                if (kullanici.MedeniHal != null)
                    comboBoxMedeniHal.SelectedItem = kullanici.MedeniHal.ToString();// medeni durumlari ekle
                if (kullanici.KanGrubu != null)
                    comboBoxKanGrubu.SelectedItem = kullanici.KanGrubu.ToString();// kan gruplari ekle  
                if (kullanici.Adres != null)
                    richTextBoxAdres.Text = kullanici.Adres;

                checkBoxYetkiliKullanici.Checked = kullanici.Yetki;
                textBoxKullaniciAdi.Text = kullanici.Username;
                textBoxSifre.Text = kullanici.Sifre;
         }
        private void Arayuz_to_Kullanici_Iliskilendir(Kullanici kul)
        {
          

            kul.TckimlikNo = textBoxTCKimlikNo.Text.Trim();
            if (textBoxDogumYeri.Text.Trim() != "")
            {
                kul.DogumYeri = textBoxDogumYeri.Text.Trim();
            }
            else
            {
                kul.DogumYeri = null;
            }
            if (textBoxAnneAdi.Text.Trim() != "")
            {
                kul.AnneAdi = textBoxAnneAdi.Text.Trim();
            }
            else
            {
                kul.AnneAdi = null;
            }
            if (textBoxBabaAdi.Text.Trim() != "")
            {
                kul.BabaAdi = textBoxBabaAdi.Text.Trim();
            }
            else
            {
                kul.BabaAdi = null;
            }
            if (textBoxTelefonNo.Text.Trim() != "")
            {
                kul.EvTel = textBoxTelefonNo.Text.Trim();
            }
            else
            {
                kul.EvTel = null;
            }
            if (textBoxGSM.Text.Trim() != "")
            {
                kul.CepTel = textBoxGSM.Text.Trim();
            }
            else
            {
                kul.CepTel = null;
            }
            kul.Yetki = checkBoxYetkiliKullanici.Checked;
            if(comboBoxUnvani.SelectedItem!=null)
            kul.Unvan = comboBoxUnvani.SelectedItem.ToString();
            else
            {
                kul.Unvan = null;
            }
           
                kul.Ad = textBoxAdi.Text.Trim();
                kul.Soyad = textBoxSoyadi.Text.Trim();

            if (textBoxMaas.Text.Trim() != "")
            {
                kul.Maas = textBoxMaas.Text.Trim();
            }
            else
                kul.Maas = null;

            kul.IseBaslama = dateTimePickerIseBaslama.Value;
            kul.DogumTarihi = dateTimePickerDogumTarihi.Value;
            kul.Cinsiyet = comboBoxCinsiyet.SelectedItem.ToString();
            if (comboBoxKanGrubu.SelectedItem != null)
                kul.KanGrubu = comboBoxKanGrubu.SelectedItem.ToString();
            else
                kul.KanGrubu = null;

            kul.MedeniHal = comboBoxMedeniHal.SelectedItem.ToString();
            if (richTextBoxAdres.Text.Trim() != "")
            {
                kul.Adres = richTextBoxAdres.Text.Trim();
            }
            kul.Username = textBoxKullaniciAdi.Text.Trim();
            kul.Sifre = textBoxSifre.Text.Trim();

           

        }
        //ARAYUZ KONTROLLERİ
        private bool Ekleme_Input_Kontrol( )
        {
            if (textBoxTCKimlikNo.Text.Trim() == "")
            {
                Alert.Ekleme_Input_Kontrol("TC Kimlik No");
                return false;             
            }
            else
            {
                if (textBoxTCKimlikNo.Text.Length != 11)
                {
                    Alert.TC_Eksik();
                    return false;
                }
                Kullanici user=null;
                try
                {
                    _context = new SohatsContext();

                    if (kullanici != null)
                        user = _context.Kullanici.FirstOrDefault(x => x.TckimlikNo == textBoxTCKimlikNo.Text.Trim() && x.KullaniciKodu != kullanici.KullaniciKodu);
                    else
                        user = _context.Kullanici.FirstOrDefault(x => x.TckimlikNo == textBoxTCKimlikNo.Text.Trim());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                bool varMi = (user != null) ? true : false;
                // Aynı tcnin dosyada olma kisminida burda kontrol et
                if (varMi )
                {
                    Alert.TC_Ayni(textBoxTCKimlikNo.Text.Trim());
                    return false;
                }
            }
            if (textBoxAdi.Text.Trim() == "")
            {
                Alert.Ekleme_Input_Kontrol("Ad");
                return false;
            }
            if (textBoxSoyadi.Text.Trim() == "")
            {
                Alert.Ekleme_Input_Kontrol("Soyad");
                return false;
            }
            if (comboBoxUnvani.SelectedItem == null)
            {
                Alert.Ekleme_Input_Kontrol("Unvan");
                return false;
            }
            if (comboBoxKanGrubu.SelectedItem == null)
            {
                Alert.Ekleme_Input_Kontrol("Kan Grubu");
                return false;
            }
            if (comboBoxMedeniHal.SelectedItem == null)
            {
                Alert.Ekleme_Input_Kontrol("Medeni Hal");
                return false;
            }
            if (comboBoxCinsiyet.SelectedItem == null)
            {
                Alert.Ekleme_Input_Kontrol("Cinsiyet");
                return false;
            }
            if (textBoxKullaniciAdi.Text.Trim() == "")
            {
                Alert.Ekleme_Input_Kontrol("Kullanici Adi");
                return false;
            }
            else
            {
                // Aynı kullaniciAdinin dosyada olma kisminida burda kontrol et
                _context = new SohatsContext();
                Kullanici user=null;
                try
                {
                    if (kullanici != null)
                        user = _context.Kullanici.FirstOrDefault(x => x.Username == textBoxKullaniciAdi.Text.Trim() && x.KullaniciKodu != kullanici.KullaniciKodu);
                    else
                        user = _context.Kullanici.FirstOrDefault(x => x.Username == textBoxKullaniciAdi.Text.Trim());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                     
                bool varMi = (user != null) ? true : false;
                if (varMi)
                {
                    Alert.KullaniciAdi_Ayni(textBoxKullaniciAdi.Text.Trim());
                    return false;
                }
            }
            if (textBoxSifre.Text.Trim() == "")
            {
                Alert.Ekleme_Input_Kontrol("Şifre");
                return false;
            }
            return true;
       
        }

        private void EklemeVeyaDuzenleme(bool eklemeMi)
        {
            if (eklemeMi)
            {
                buttonKullaniciOlustur.Visible = true;
                buttonSil.Visible = false;
                buttonGuncelle.Visible = false;
            }
            else
            {
                buttonKullaniciOlustur.Visible = false;
                buttonSil.Visible = true;
                buttonGuncelle.Visible = true;
            }
        }
    
        //FORM EVENTLERİ 
        private void KullaniciTanitmaForm_Shown(object sender, EventArgs e)
        {
            ktForm._anaForm._ktoForm.Hide();
            if (kullanici != null)
            {
                Kullanici_to_Arayuz_Iliskilendir();
                EklemeVeyaDuzenleme(false);
            }
            else
            {
                //Yeni kullanici Ekleme Açılmış demektir
                //Bunun için dosyaki en büyük dosya nonun 1 fazlasını göster
                EklemeVeyaDuzenleme(true);

            }
        }

        private void KullaniciTanitmaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ktForm._anaForm._ktoForm.Show();
            ktForm._anaForm._ktoForm.Kullanicilar_Notify();
            ktForm = null;
        }



        private void buttonKullaniciOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ekleme_Input_Kontrol())
                {
                    SohatsContext context = new SohatsContext();
                    kullanici = new Kullanici();
                    Arayuz_to_Kullanici_Iliskilendir(kullanici);
                    context.Kullanici.Add(kullanici);
                    context.SaveChanges();
                    kullanici = _context.Kullanici.SingleOrDefault(x => x.Username == textBoxKullaniciAdi.Text.Trim());
                    textBoxKullaniciKodu.Text = kullanici.KullaniciKodu.ToString();
                    EklemeVeyaDuzenleme(false);
                    
                    Alert.Eklendi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            DialogResult dr = Alert.Temizleme();
            if (dr == DialogResult.Yes)
            {
                textBoxTCKimlikNo.Text = "";
                textBoxDogumYeri.Text = "";
                textBoxBabaAdi.Text = "";
                textBoxAnneAdi.Text = "";
                textBoxTelefonNo.Text = "";
                textBoxGSM.Text = "";
                textBoxAdi.Text = "";
                textBoxSoyadi.Text = "";
                textBoxMaas.Text = "";
                richTextBoxAdres.Text = "";
                checkBoxYetkiliKullanici.Checked = false;
            }
        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (Alert.Guncelleme() == DialogResult.Yes)
            {
                if (Ekleme_Input_Kontrol())
                {
                    try
                    {
                        _context = new SohatsContext();
                        Kullanici kul = _context.Kullanici.SingleOrDefault(x => x.KullaniciKodu == kullanici.KullaniciKodu);
                        Arayuz_to_Kullanici_Iliskilendir(kul);
                        _context.SaveChanges();
                        Alert.Guncellendi();
                        //Sistemi kullanan kişinin yetkisi değiştirildiğinde oturumun otomatik kapanması gerekir
                        if(!checkBoxYetkiliKullanici.Checked && yetkiDegisti)
                        {
                            if(kullanici.KullaniciKodu == _anaForm._user.KullaniciKodu)
                            _anaForm.CıkısYapıldı();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (Alert.Silme()==DialogResult.Yes)
            {
                try
                {                  
                    _context = new SohatsContext();
                    var kul = _context.Kullanici.SingleOrDefault(x => x.KullaniciKodu == kullanici.KullaniciKodu);

                    _context.Kullanici.Remove(kul);
                    _context.SaveChanges();
                    Alert.Silindi();
                    if (kullanici.KullaniciKodu == _anaForm._user.KullaniciKodu)
                        _anaForm.CıkısYapıldı();
                    else
                        Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }         
        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxYetkiliKullanici_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYetkiliKullanici.Checked)
            {
                yetkiDegisti = false ;
            }
            else
            {
                yetkiDegisti = true;
            }
            
        }


        private void textBoxSadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
