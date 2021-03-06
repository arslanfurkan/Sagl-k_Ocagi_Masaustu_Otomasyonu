﻿using Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Database;
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

namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views
{
    public partial class HastaBilgileriForm : Form
    {
        private static HastaBilgileriForm hastaBilgileriForm = null;
        private AnaForm _anaForm = null;
        private Hasta _hasta = null;
        private SohatsContext _context = null;

        protected HastaBilgileriForm(AnaForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }
        public static HastaBilgileriForm HastaBilgileriFormOlustur(AnaForm anaForm)
        {
            if (hastaBilgileriForm == null)
            {
                hastaBilgileriForm = new HastaBilgileriForm(anaForm);

            }
            else
            {
                hastaBilgileriForm.Activate();
            }
            return hastaBilgileriForm;
        }
        public static void HBFormuKapat()
        {
            if (IsOpen())
            {
                hastaBilgileriForm.Close();
                hastaBilgileriForm = null;
            }

        }
        public static bool IsOpen()
        {
            if (hastaBilgileriForm != null)
            {
                return true;
            }
            return false;
        }

        public void HastaEkle(Hasta hasta)
        {
            _hasta = hasta;
        }

        private void HastaBilgileriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _anaForm._hastaIslemleriForm._hastaBilgileri = null;
            hastaBilgileriForm = null;
           
        }

        private void HastaBilgileriForm_Shown(object sender, EventArgs e)
        {   
            if (_hasta != null)
            {
                Hasta_to_Arayuz_Iliskilendir();
                EklemeVeyaDuzenleme(false);
            }
            else
            {
                //Yeni kullanici Ekleme Açılmış demektir
                //Bunun için dosyaki en büyük dosya nonun 1 fazlasını göster
                
                EklemeVeyaDuzenleme(true);

            }
        }
        private void EklemeVeyaDuzenleme(bool eklemeMi)
        {
            if (eklemeMi)
            {
                textBoxTCKimlikNo.Enabled = true;
                buttonKaydet.Visible = true;
                buttonGuncelle.Visible = false;
                buttonSil.Visible = false;
          
            }
            else
            {
                textBoxTCKimlikNo.Enabled = false;
                buttonKaydet.Visible = false;
                buttonGuncelle.Visible = true;
                buttonSil.Visible = true;
            }
        }

        private void Hasta_to_Arayuz_Iliskilendir()
        {
            textBoxDosyaNo.Text = _hasta.DosyaNo.ToString();
            textBoxTCKimlikNo.Text = _hasta.TckimlikNo;
            textBoxAdi.Text = _hasta.Ad;
            textBoxSoyadi.Text = _hasta.Soyad;
            dateTimePickerDT.Value = _hasta.DogumTarihi.Value;
            comboBoxCinsiyet.SelectedItem = _hasta.Cinsiyet;
            comboBoxKanGrubu.SelectedItem = _hasta.KanGrubu;
            comboBoxMedeniHal.SelectedItem= _hasta.MedeniHal;

            if (_hasta.DogumYeri != null)
            {
                textBoxDogumYeri.Text = _hasta.DogumYeri;
            }
          
            if (_hasta.AnneAdi != null)
            {
                textBoxAnneAdi.Text = _hasta.AnneAdi;
            }
            
            if (_hasta.BabaAdi !=null)
            {
                textBoxBabaAdi.Text = _hasta.BabaAdi;
            }

            if (_hasta.Tel != null)
            {
                textBoxTelefonNo.Text = _hasta.Tel;
            }
          
            if (_hasta.KurumSicilNo != null)
            {
                textBoxKSN.Text = _hasta.KurumSicilNo;
            }
            
         
            if (_hasta.KurumAdi != null)
            {
                textBoxKA.Text = _hasta.KurumAdi;
            }
          
            if (_hasta.YakinTel != null)
            {
                textBoxYakinTelefonNo.Text = _hasta.YakinTel;
            }
           
            if (_hasta.YakinKurumSicilNo != null)
            {
                textBoxYKSN.Text = _hasta.YakinKurumSicilNo;
            }
          
            if (_hasta.YakinKurumAdi != null)
            {
                textBoxYKA.Text = _hasta.YakinKurumAdi;
            } 

            if (_hasta.Adres != null)
            {
                richTextBoxAdres.Text = _hasta.Adres;
            }
        }
        private void Arayuz_to_Hasta_Ilıskılendir(Hasta hst)
        {
            hst.TckimlikNo = textBoxTCKimlikNo.Text.Trim();
            hst.Ad = textBoxAdi.Text.Trim();
            hst.Soyad = textBoxSoyadi.Text.Trim();
            hst.DogumTarihi = dateTimePickerDT.Value;
            hst.Cinsiyet = comboBoxCinsiyet.SelectedItem.ToString();
            hst.KanGrubu = comboBoxKanGrubu.SelectedItem.ToString();
            hst.MedeniHal = comboBoxMedeniHal.SelectedItem.ToString();

            if (textBoxDogumYeri.Text.Trim() != "")
            {
                hst.DogumYeri = textBoxDogumYeri.Text.Trim();
            }
            else
            {
                hst.DogumYeri = null;
            }
            if (textBoxAnneAdi.Text.Trim() != "")
            {
                hst.AnneAdi = textBoxAnneAdi.Text.Trim();
            }
            else
            {
                hst.AnneAdi = null;
            }
            if (textBoxBabaAdi.Text.Trim() != "")
            {
                hst.BabaAdi = textBoxBabaAdi.Text.Trim();
            }
            else
            {
                hst.BabaAdi = null;
            }
          
            if (textBoxTelefonNo.Text.Trim() != "")
            {
                hst.Tel = textBoxTelefonNo.Text.Trim();
            }
            else
            {
                hst.Tel = null;
            }
            if (textBoxKSN.Text.Trim() != "")
            {
                hst.KurumSicilNo = textBoxKSN.Text.Trim();
            }
            else
            {
                hst.KurumSicilNo = null;
            }
            if (textBoxKA.Text.Trim() != "")
            {
                hst.KurumAdi = textBoxKA.Text.Trim();
            }
            else
            {
                hst.KurumAdi = null;
            }
            if (textBoxYakinTelefonNo.Text.Trim() != "")
            {
                hst.YakinTel = textBoxYakinTelefonNo.Text.Trim();
            }
            else
            {
                hst.YakinTel = null;
            }
            if (textBoxYKSN.Text.Trim() != "")
            {
                hst.YakinKurumSicilNo = textBoxYKSN.Text.Trim();
            }
            else
            {
                hst.YakinKurumSicilNo = null;
            }
            if (textBoxYKA.Text.Trim() != "")
            {
                hst.YakinKurumAdi = textBoxYKA.Text.Trim();
            }
            else
            {
                hst.YakinKurumAdi = null;
            }

            if (richTextBoxAdres.Text.Trim() != "")
            {
                hst.Adres = richTextBoxAdres.Text.Trim();
            }
       

        }
        private bool Ekleme_Input_Kontrol()
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
                Hasta hasta = null;
                try
                {
                    _context = new SohatsContext();

                    if (_hasta != null)
                    {
                       hasta = _context.Hasta.FirstOrDefault(x => x.TckimlikNo == textBoxTCKimlikNo.Text.Trim() && x.DosyaNo != _hasta.DosyaNo);
                    }
                    else
                    {
                        hasta = _context.Hasta.FirstOrDefault(x => x.TckimlikNo == textBoxTCKimlikNo.Text.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                bool varMi = (hasta != null) ? true : false;
                // Aynı tcnin dosyada olma kisminida burda kontrol et
                if (varMi)
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
                    
            return true;
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            _hasta = null;
            EklemeVeyaDuzenleme(true);
            textBoxDosyaNo.Text ="";
           
                textBoxTCKimlikNo.Text = "";
                textBoxDogumYeri.Text = "";
                dateTimePickerDT.Value = DateTime.Now;
                comboBoxCinsiyet.SelectedIndex = -1;
                comboBoxMedeniHal.SelectedIndex = -1;
                comboBoxKanGrubu.SelectedIndex = -1;
                textBoxBabaAdi.Text = "";
                textBoxAnneAdi.Text = "";
                textBoxTelefonNo.Text = "";
                textBoxKSN.Text="";
                textBoxKA.Text = "";
                textBoxYakinTelefonNo.Text = "";
                textBoxYKSN.Text = "";
                textBoxYKA.Text = "";
                textBoxAdi.Text = "";
                textBoxSoyadi.Text = "";              
                richTextBoxAdres.Text = "";
                
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (Ekleme_Input_Kontrol())
            {
                try
                {
                    _hasta = new Hasta();
                    Arayuz_to_Hasta_Ilıskılendir(_hasta);
                    _context.Hasta.Add(_hasta);
                    _context.SaveChanges();
                    _hasta = _context.Hasta.SingleOrDefault(x => x.TckimlikNo == textBoxTCKimlikNo.Text.Trim());
                    EklemeVeyaDuzenleme(false);

                    textBoxDosyaNo.Text = _hasta.DosyaNo.ToString();
                    Alert.Eklendi();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
                        Hasta hst = _context.Hasta.SingleOrDefault(x => x.DosyaNo == _hasta.DosyaNo);
                        Arayuz_to_Hasta_Ilıskılendir(hst);
                        _context.SaveChanges();
                        _anaForm._hastaIslemleriForm._hasta = hst;
                        _anaForm._hastaIslemleriForm.Arayuz_Doldur_Bosalt();
                        Alert.Guncellendi();

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
            if (Alert.Silme() == DialogResult.Yes)
            {
                try
                {
                   _context = new SohatsContext();
                    var hst = _context.Hasta.SingleOrDefault(x => x.DosyaNo == _hasta.DosyaNo);
                    _context.Hasta.Remove(hst);
                    _context.SaveChanges();
                    _anaForm._hastaIslemleriForm._hasta = null;
                    _anaForm._hastaIslemleriForm.Arayuz_Doldur_Bosalt();
                    Close();
                    Alert.Silindi();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxSadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

    
}
