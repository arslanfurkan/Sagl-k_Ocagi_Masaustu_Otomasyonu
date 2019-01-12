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
    public partial class KullaniciTanitmaOnForm : Form
    {
        private AnaForm _anaForm;
        private static KullaniciTanitmaOnForm ktoForm;
        public KullaniciTanitmaForm _ktForm;
        public List<Kullanici> _kullanicilar = null;
        private SohatsContext _context;

        protected KullaniciTanitmaOnForm(AnaForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }

         public static KullaniciTanitmaOnForm KTOFormOlustur(AnaForm anaForm)
        {
            if (ktoForm == null)
            {
                ktoForm = new KullaniciTanitmaOnForm(anaForm);
               
            }
            else
            {
                ktoForm.Activate();
            }
            return ktoForm;
        }
        public static void KTOFormuKapat()
        {
            if (ktoForm._ktForm != null)
            {
                KullaniciTanitmaForm.KTFormuKapat();
            }
            ktoForm.Close();
            ktoForm = null;
        }

        private void buttonKullaniciEkle_Click(object sender, EventArgs e)
        {
            _ktForm= KullaniciTanitmaForm.KTFormOlustur(_anaForm);
            _ktForm.MdiParent = _anaForm;
            _ktForm.Show();

            
        }

        private void comboBoxKullanicilar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectionCheck();
            }
        }

        private void KullaniciTanitmaOnForm_Shown(object sender, EventArgs e)
        {     
            KullaniciTanitmaForm.KTFormuKapat();
            

     
        }

        private void KullaniciTanitmaOnForm_Load(object sender, EventArgs e)
        {
            Kullanicilar_Notify();
        }

        public void Kullanicilar_Notify()
        {  
            try
            {
                comboBoxKullanicilar.Items.Clear();
                _context = new SohatsContext();
                _kullanicilar = _context.Kullanici.ToList();
                foreach (Kullanici kul in _kullanicilar)
                {
                    comboBoxKullanicilar.Items.Add(kul.Username);
                }
                comboBoxKullanicilar.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void comboBoxKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionCheck();           
        }

        private void SelectionCheck()
        {
            if (comboBoxKullanicilar.SelectedItem != null)
            {
                string secilenUsername = comboBoxKullanicilar.SelectedItem.ToString();
                try
                {
                    _context = new SohatsContext();
                    Kullanici secilenKullanici = _context.Kullanici.FirstOrDefault(x => x.Username == secilenUsername);
                    _ktForm = KullaniciTanitmaForm.KTFormOlustur(_anaForm);
                    _ktForm.KullaniciEkle(secilenKullanici);
                    _ktForm.MdiParent = _anaForm;
                    _ktForm.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                Alert.LutfenKullaniciSeciniz();
            }
        }
    }
}
