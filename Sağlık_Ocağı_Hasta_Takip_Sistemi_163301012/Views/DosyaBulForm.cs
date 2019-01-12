using Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Database;
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
    public partial class DosyaBulForm : Form
    {
        private AnaForm _anaForm = null;
        private static DosyaBulForm dosyaBulForm = null;
        private SohatsContext _context;
        private List<Hasta> bulunanHastalar = null;


        protected DosyaBulForm(AnaForm anaForm)
        {
            InitializeComponent();
            _anaForm = anaForm;
        }
        public static DosyaBulForm DosyaBulFormOlustur(AnaForm anaForm)
        {

            if (dosyaBulForm == null)
            {
                dosyaBulForm = new DosyaBulForm(anaForm);

            }
            else
            {
                dosyaBulForm.Activate();
            }
            return dosyaBulForm;
        }

        public static void DosyaBulFormuKapat()
        {
            if (IsOpen())
            {
                dosyaBulForm.Close();
                dosyaBulForm = null;
            }

        }
        public static bool IsOpen()
        {
            if (dosyaBulForm != null)
            {
                return true;
            }
            return false;
        }

        private void DosyaBulForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _anaForm._hastaIslemleriForm._dosyaBul = null;
            dosyaBulForm = null;
        }

        private void DosyaBulForm_Shown(object sender, EventArgs e)
        {
            comboBoxAramaKriter.SelectedIndex = 0;
        }

        private void comboBoxAramaKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kriter = comboBoxAramaKriter.SelectedItem.ToString();
            if(kriter=="Hasta Adı Soyadı")
            {
                textBoxAd.Visible = true;
                checkBoxVe.Visible = true;
                textBoxSoyad.Visible = true;
                textBoxOther.Visible = false;
            }
            else
            {
                textBoxAd.Visible = false;
                checkBoxVe.Visible = false;
                textBoxSoyad.Visible = false;
                textBoxOther.Visible = true;
            }
         
        }

        private void buttonBul_Click(object sender, EventArgs e)
        {
            string kriter = comboBoxAramaKriter.SelectedItem.ToString();
            try
            {
                switch (kriter)
                {
                    case "Hasta Adı Soyadı":
                        string adi = textBoxAd.Text.Trim();
                        string soyadi = textBoxSoyad.Text.Trim();
                        _context = new SohatsContext();
                        if(checkBoxVe.Checked)
                            bulunanHastalar = _context.Hasta.Where(x => x.Ad == adi && x.Soyad == soyadi).ToList();
                        else
                            bulunanHastalar = _context.Hasta.Where(x => x.Ad == adi).ToList();

                        break;
                    case "Kimlik No":
                        
                        string diger = textBoxOther.Text.Trim();
                        if (diger.Length == 11)
                        {
                            _context = new SohatsContext();
                            bulunanHastalar = _context.Hasta.Where(x => x.TckimlikNo == diger).ToList();
                        }
                        else
                        {
                            MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.","TC Kimlik No 11 hanelidir.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                      

                        break;
                    case "Kurum Sicil No":
                        string diger1 = textBoxOther.Text.Trim();
                        _context = new SohatsContext();
                        bulunanHastalar = _context.Hasta.Where(x => x.KurumSicilNo == diger1).ToList();

                        break;
                    case "Dosya No":
                        int diger2 = Convert.ToInt32(textBoxOther.Text.Trim());
                        _context = new SohatsContext();
                        bulunanHastalar = _context.Hasta.Where(x => x.DosyaNo == diger2).ToList();

                        break;
                    default:
                        MessageBox.Show("Bir sıkıntı oluştu.");
                        break;
                }
                if (bulunanHastalar == null)
                {
                    MessageBox.Show("Aranan Kriterde bir hasta bulunamadı!");
                }
                else
                {
                        GridDoldur(bulunanHastalar);                 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void textBoxOther_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void GridDoldur(List<Hasta> hasta)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < hasta.Count; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = hasta[i].TckimlikNo;
                dataGridView1.Rows[n].Cells[1].Value = hasta[i].DosyaNo;

                dataGridView1.Rows[n].Cells[2].Value = hasta[i].Ad;
                dataGridView1.Rows[n].Cells[3].Value = hasta[i].Soyad;
                dataGridView1.Rows[n].Cells[4].Value = hasta[i].DogumYeri;
                dataGridView1.Rows[n].Cells[5].Value = hasta[i].DogumTarihi;
                dataGridView1.Rows[n].Cells[6].Value = hasta[i].BabaAdi;
                dataGridView1.Rows[n].Cells[7].Value = hasta[i].AnneAdi;
                dataGridView1.Rows[n].Cells[8].Value = hasta[i].Cinsiyet;
                dataGridView1.Rows[n].Cells[9].Value = hasta[i].KanGrubu;
                dataGridView1.Rows[n].Cells[10].Value = hasta[i].MedeniHal;
                dataGridView1.Rows[n].Cells[11].Value = hasta[i].Adres;
                dataGridView1.Rows[n].Cells[12].Value = hasta[i].Tel;
                dataGridView1.Rows[n].Cells[13].Value = hasta[i].KurumSicilNo;
                dataGridView1.Rows[n].Cells[14].Value = hasta[i].KurumAdi;
                for (int j = 0; j < dataGridView1.Rows[n].Cells.Count; j++)
                {
                    dataGridView1.Rows[n].Cells[j].ReadOnly = true;
                }
            }
           
           
        }


        private void checkBoxVe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVe.Checked)
            {
                textBoxSoyad.Enabled = true;
            }
            else
            {
                textBoxSoyad.Enabled = false;
            }
        }
    }
}
