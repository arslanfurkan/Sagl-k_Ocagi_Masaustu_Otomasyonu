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

namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012
{
    public partial class LoginForm : Form
    {
        private SohatsContext _context;
        private AnaForm _anaForm;
        private static LoginForm loginForm;
       

        protected LoginForm(AnaForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
      
            
        }
        public static LoginForm LoginFormOlustur(AnaForm anaForm)
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm(anaForm);

            }
            else
            {
                loginForm.Location = new Point(0, 0);
                loginForm.Activate();
            }
            return loginForm;
        }
        public static void LoginFormuKapat()
        {
            if (loginForm != null)
            {
                loginForm.Close();
                loginForm = null;
                
            }
        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (InputKontrol())
            {
                string kulAdi = textBoxKullaniciAdi.Text.Trim();
                string sifre = textBoxSifre.Text.Trim();

                try
                {
                    _context = new SohatsContext();
                    Kullanici user = _context.Kullanici.FirstOrDefault(x => x.Username == kulAdi && x.Sifre == sifre);

                    bool basariliMi = (user != null) ? true : false;
                    if (basariliMi)
                    {
                        _anaForm.LoggedIn(user);
                        LoginFormuKapat();
                        Alert.OturumDurumu(basariliMi);
                    }
                    else
                        Alert.GirisEslesmeKontrol(basariliMi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
            else
            {
                Alert.EksikGirisUyarı();
            }

        }
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            _anaForm.Close();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Clear();
            textBoxSifre.Clear(); 
        }

        private bool InputKontrol()
        {
            if (textBoxKullaniciAdi.Text.Trim() == "" || textBoxSifre.Text.Trim()=="")
            {
                return false;
            }
            return true;
        }

        private void buttonGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonGiris_Click(sender, e);
        }

        private void JumpNext_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                if(tb.Name== "textBoxSifre")
                {
                    buttonGiris_Click(buttonGiris, e);
                }
                else
                {
                    if (this.GetNextControl(ActiveControl, true) != null)
                    {
                        e.Handled = true;

                        this.GetNextControl(ActiveControl, true).Focus();

                    }
                }
            }
            
        }

        private void checkBoxSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;      
            textBoxSifre.PasswordChar = cb.Checked ? '\0' : '*';
        }
    }
}
