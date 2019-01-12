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

namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views
{
    public partial class PoliklinikTanitmaForm : Form
    {
        private AnaForm _anaForm=null;
        private static PoliklinikTanitmaForm ptForm = null;
        private SohatsContext _context = null;
        private Poliklinik _poliklinik = null;

        protected PoliklinikTanitmaForm(AnaForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }
        public static PoliklinikTanitmaForm PTFormOlustur(AnaForm anaForm)
        {
            if (ptForm == null)
            {
                ptForm = new PoliklinikTanitmaForm(anaForm);
      
            }
            else
            {
                ptForm.Activate();
            }
            return ptForm;
        }

        public static void PTFormuKapat()
        {
            if (IsOpen())
            {
                ptForm.Close();
                ptForm = null;
            }
           
        }
        public static bool IsOpen()
        {
            if (ptForm != null)
            {
                return true;
            }
            return false;
        }
        
       
        //POLİKLİNİK İSLEMLERİ
        public void PoliklinikEkle(Poliklinik pol)
        {
           _poliklinik = pol;
        }
        private void Poliklinik_To_Arayuz_Iliskilendir()
        {
            if (_poliklinik.PoliklinikAdi != null)
            {
                textBoxPoliklinikAdi.Text = _poliklinik.PoliklinikAdi;
                
            }
            checkBoxGecerli.Checked = _poliklinik.Durum;
            if (_poliklinik.Aciklama != null)
            {
                richTextBoxAciklama.Text = _poliklinik.Aciklama;
            }    
        }
        private void Arayuz_To_Poliklinik_Iliskilendir(Poliklinik pol)
        {           
            pol.PoliklinikAdi = textBoxPoliklinikAdi.Text.Trim();
            pol.Durum = checkBoxGecerli.Checked;
            if (richTextBoxAciklama.Text.Trim() != null)
            {
                pol.Aciklama = richTextBoxAciklama.Text.Trim();
            }
            else
            {
                pol.Aciklama = null;
            }
        }
        //ARAYUZ KONTROL
        private bool Input_Kontrol()
        {
            if (textBoxPoliklinikAdi.Text.Trim() == "")
            {
                Alert.Ekleme_Input_Kontrol("Poliklinik Adı");
                return false;
            }
            return true;
        }
        //FORM EVENTLERİ
        private void PoliklinikTanitmaForm_Shown(object sender, EventArgs e)
        {
            ptForm._anaForm._ptoForm.Hide();
            if (_poliklinik != null)
            {
                Poliklinik_To_Arayuz_Iliskilendir();
                EklemeMi(false);

            }
            else
            {
                EklemeMi(true);

            }

        }

        private void PoliklinikTanitmaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ptForm._anaForm._ptoForm.Show();
            ptForm._anaForm._ptoForm.Poliklinikler_Notify();
            ptForm = null;

        }
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (Alert.Guncelleme() == DialogResult.Yes)
            {
                if (Input_Kontrol())
                {
                    try
                    {
                        if (!AynisiVarMi(_poliklinik.PoliklinikId, _poliklinik.PoliklinikAdi))
                        {
                            _context = new SohatsContext();
                            var pol = _context.Poliklinik.SingleOrDefault(x => x.PoliklinikId == _poliklinik.PoliklinikId);
                            Arayuz_To_Poliklinik_Iliskilendir(pol);
                            _context.SaveChanges();
                            Alert.Guncellendi();
                        }
                        else
                        {
                            MessageBox.Show("Girilen poliklinik adı zaten kullanılmaktadır. Başka bir poliklinik adı giriniz!", "Başka bir ad girin!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        var pol = _context.Poliklinik.SingleOrDefault(x => x.PoliklinikId == _poliklinik.PoliklinikId);
                        _context.Poliklinik.Remove(pol);
                        _context.SaveChanges();
                        Alert.Silindi();
                        Close();
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void EklemeMi(bool ekleme)
        {
            if (ekleme)
            {
                panelEkleme.Visible = true;
                panelDuzenle.Visible = false;
            }
            else
            {
                panelEkleme.Visible = false;
                panelDuzenle.Visible = true;
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (Input_Kontrol())
            {
                string polAdi = textBoxPoliklinikAdi.Text.Trim();
                try
                {
                    if (!AynisiVarMi(-1,polAdi))
                    {
                        _context = new SohatsContext();
                        Poliklinik yeniPol = new Poliklinik();
                        yeniPol.PoliklinikAdi = polAdi;
                        yeniPol.Durum = checkBoxGecerli.Checked;
                        yeniPol.Aciklama = richTextBoxAciklama.Text;
                        _context.Poliklinik.Add(yeniPol);
                        _context.SaveChanges();

                        _poliklinik = _context.Poliklinik.SingleOrDefault(x => x.PoliklinikAdi == polAdi);
                        
                        Poliklinik_To_Arayuz_Iliskilendir();

                        EklemeMi(false);


                        Alert.Eklendi();


                    }
                    else
                    {
                        MessageBox.Show("Girilen poliklinik adı zaten kullanılmaktadır. Başka bir poliklinik adı giriniz!", "Başka bir ad girin!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            
        }

        private bool AynisiVarMi(int id,string polAdi)
        {
            try
            {
                _context = new SohatsContext();
                List<Poliklinik> pol = null;
                pol = _context.Poliklinik.Where(x => x.PoliklinikId != id && x.PoliklinikAdi == polAdi).ToList();
                if (pol.Count != 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
