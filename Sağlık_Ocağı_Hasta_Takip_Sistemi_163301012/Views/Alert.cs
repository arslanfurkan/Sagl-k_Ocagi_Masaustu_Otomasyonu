using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Model
{
    class Alert
    {

        public static void GirisEslesmeKontrol(bool basariliMi)
        {
            if (!basariliMi)
            {
                MessageBox.Show("Yanlış kullanıcı adı ve/veya şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }       
        }
        public static void EksikGirisUyarı ()
        {    
                MessageBox.Show("Kullanıcı adı ve/veya şifre kısımları boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);        
        }
        public static void LutfenPoliklinikSeciniz()
        {
            MessageBox.Show("Lütfen bir poliklinik seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void LutfenKullaniciSeciniz()
        {
            MessageBox.Show("Lütfen bir kullanıcı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void OturumDurumu(bool oturumAcikMi)
        {
            if (oturumAcikMi)
            {
                MessageBox.Show("Oturumunuz açıldı!", "Oturum Açıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Oturumunuz kapatıldı!", "Oturum Kapandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public static DialogResult Temizleme()
        {
            return MessageBox.Show("Ekrandaki sadece bazı bölgeler temizlenecektir. Onaylıyor musun?", "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public static DialogResult Guncelleme()
        {
            return MessageBox.Show("Bilgiler güncellenecektir. Onaylıyor musunuz?", "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public static DialogResult Silme()
        {
            return MessageBox.Show("İlgili kişi veritabanından silinecektir. Onaylıyor musun?", "Emin misin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public static void Eklendi()
        {
            MessageBox.Show("Kayıt başarıyla eklendi!", "Eklendi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Guncellendi()
        {
            MessageBox.Show("Kayıt başarıyla güncellendi!","Güncellendi!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void Silindi()
        {
            MessageBox.Show("Kayıt başarıyla silindi!", "Silindi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Ekleme_Input_Kontrol(string name)
        {
            MessageBox.Show(name+" kısmı boş olamaz. Mutlaka doldurulmalıdır!", "Eksik Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void TC_Eksik()
        {
            MessageBox.Show("TC Kimlik No kısmı 11 haneli olmalıdır.", "Eksik Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void TC_Ayni(string tc)
        {
            MessageBox.Show("Girilen TC Kimlik No("+tc+") kayıtlarda zaten mevcut!","Yanlış Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void KullaniciAdi_Ayni(string kulAd)
        {
            MessageBox.Show("Girilen Kullanıcı Adı(" + kulAd + ") kayıtlarda zaten mevcut!", "Yanlış Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
