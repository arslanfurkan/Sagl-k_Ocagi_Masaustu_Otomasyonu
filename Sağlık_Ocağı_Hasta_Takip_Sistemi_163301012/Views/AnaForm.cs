using Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Database;
using Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Model;
using Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012
{
    public partial class AnaForm : Form
    {
        public LoginForm _loginForm=null;
        public KullaniciTanitmaOnForm _ktoForm=null;
        public PoliklinikTanitmaOnForm _ptoForm = null;
        public HastaIslemleriForm _hastaIslemleriForm = null;     
        private RaporlarForm _raporlarForm = null;
        public Kullanici _user = null;

        public AnaForm()
        {
            InitializeComponent();     
        }

  

    

        public void LoggedIn(Kullanici user)
        {
            this._user = user;
            menuStrip.Enabled = true;
            if(_user.Yetki)
            kullaniciTanitmaToolStripMenuItem.Visible = true;
            poliklinikTanitmaToolStripMenuItem.Visible = true;
        }
        public void LoggedOut()
        {
            _user = null;
            menuStrip.Enabled = false;
            kullaniciTanitmaToolStripMenuItem.Visible = false;
            poliklinikTanitmaToolStripMenuItem.Visible = false;
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PTOKapat();
            HIKapat();
            RaporlarKapat();
            if (_ktoForm != null)
            {
                
                if (_ktoForm._ktForm != null)
                {

                    KullaniciTanitmaForm.KTFormuKapat();
                    _ktoForm._ktForm = null;
                }
            }
            
            _ktoForm = KullaniciTanitmaOnForm.KTOFormOlustur(this);
            _ktoForm.MdiParent = this;
            _ktoForm.Show();
           

        }
        private void poliklinikTanitmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KTOKapat();
            HIKapat();
            RaporlarKapat();
            if (_ptoForm != null)
            {
                
                if (_ptoForm._ptForm != null)
                {
                    PoliklinikTanitmaForm.PTFormuKapat();
                    _ptoForm._ptForm = null;
                }

            }
          
            _ptoForm = PoliklinikTanitmaOnForm.PTOFormOlustur(this);
            _ptoForm.MdiParent = this;
            _ptoForm.Show();
          

        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CıkısYapıldı();
        }
        public void CıkısYapıldı()
        {
            LoggedOut();
            TumPencereleriKapat();
            LoginFormOlustur();
            Alert.OturumDurumu(false);

        }
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
           
        }
        private void hastaIslemleriF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaIslemleriAcılıs();
           
        }
        private void HastaIslemleriAcılıs()
        {
            KTOKapat();
            PTOKapat();
            RaporlarKapat();


            if (_hastaIslemleriForm != null)
            {

                if (_hastaIslemleriForm._hastaBilgileri != null)
                {
                    HastaBilgileriForm.HBFormuKapat();
                    _hastaIslemleriForm._hastaBilgileri = null;
                }

            }
            _hastaIslemleriForm = HastaIslemleriForm.HastaIslemleriFormuOlustur(this);
            _hastaIslemleriForm.StartPosition = FormStartPosition.CenterScreen;
            _hastaIslemleriForm.MdiParent = this;
            _hastaIslemleriForm.Show();
        }
        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KTOKapat();
            PTOKapat();
            HIKapat();

            _raporlarForm = RaporlarForm.RaporlarFormOlustur(this);
            _raporlarForm.MdiParent = this;
            _raporlarForm.Show();


        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            LoggedOut();
            LoginFormOlustur();
        }
        private void AnaForm_SizeChanged(object sender, EventArgs e)
        {
            if (_loginForm != null)
            {
                _loginForm.Hide();
                _loginForm.Show();
            }
        }
      
        private void LoginFormOlustur()
        {
            _loginForm = LoginForm.LoginFormOlustur(this);
            _loginForm.StartPosition = FormStartPosition.CenterScreen;
            _loginForm.MdiParent = this;
            _loginForm.Show();
        }

        private void TumPencereleriKapat()
        {
            PTOKapat();
            KTOKapat();
            HIKapat();
            RaporlarKapat();
            
        }
        private void PTOKapat()
        {
           
            if (_ptoForm != null)
            {

                PoliklinikTanitmaOnForm.PTOFormuKapat();
                _ptoForm = null;
            }
        }
        private void KTOKapat()
        {
            if (_ktoForm != null)
            {
                KullaniciTanitmaOnForm.KTOFormuKapat();
                _ktoForm = null;
            }

        }
        private void HIKapat()
        {
            if (_hastaIslemleriForm != null)
            {

                HastaIslemleriForm.HastaIslemleriFormuKapat();
                _hastaIslemleriForm = null;
            }
        }
        private void RaporlarKapat()
        {
            if (_raporlarForm != null)
            {

                RaporlarForm.RaporlarFormuKapat();
                _raporlarForm = null;
            }

        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                HastaIslemleriAcılıs();
            }
        }
    }
}
