using Kutuphane.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.BLL;
using Kutuphane.Entities;

namespace Kutuphane.UI.Forms
{
    public partial class LoginForm : Form
    {
        private KullaniciYonetimi kullaniciYonetimi;
        public LoginForm()
        {
            InitializeComponent();
           kullaniciYonetimi = new KullaniciYonetimi();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullaniciAdiTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (kullaniciAdiTxt.Text == "Kullanıcı Adı")
            {
                kullaniciAdiTxt.Clear();
            }
        }

        private void sifreTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (sifreTxt.Text == "Şifre")
            {
                sifreTxt.Clear();
                sifreTxt.PasswordChar = '*';
            }
        }
        
        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            
            #region gemini deneme
            //string kullaniciAdi = kullaniciAdiTxt.Text;
            //string sifre = sifreTxt.Text;
            //string sonuc = kullaniciBLL.GirisYap(kullaniciAdi, sifre);
            //if (sonuc.StartsWith("Hata:")) // BLL'den dönen bir hata mesajı varsa
            //{
            //    MessageBox.Show(sonuc, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else // Başarılı giriş. Sonuç, kullanıcının rolünü içerir.
            //{
            //    string rol = sonuc;
            //    Form anaForm = null;
            //    switch(rol)
            //    {
            //        case "Admin":
            //            anaForm = new AdminForm();
            //            break;
            //        case "Kullanici":
            //            anaForm = new KullaniciForm();
            //            break;
            //        case "Gorevli":                         
            //            anaForm = new GorevliForm();
            //            break;
            //        default:
            //            MessageBox.Show("Bilinmeyen rol: " + rol, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //    }
            //    if(anaForm != null)
            //    {
            //        //anaForm.FormClosed += (s, args) => this.Close();
            //        //anaForm.Show();
            //        anaForm.Show();
            //        this.Hide();
            //    }

            //    MessageBox.Show($"Hoş geldiniz! Rolünüz: {rol}", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    this.Hide();
            //}
            #endregion
            string kullaniciAdi = kullaniciAdiTxt.Text.Trim();
            string sifre = sifreTxt.Text.Trim();

            var girisSonucu = kullaniciYonetimi.GirisYap(kullaniciAdi, sifre);
            if(!girisSonucu.Basarili)
            {
                MessageBox.Show(girisSonucu.Mesaj, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }   
            var kullanici = girisSonucu.Kullanici;
            Form acilacakform = null;
            switch(kullanici.Rol)
            {
                case "Admin":
                    acilacakform = new AdminForm();
                    break;
                case "Kullanici":
                    acilacakform = new UyeForm();
                    break;
                case "Gorevli":
                acilacakform = new GorevliForm();
                break;

                    default:
                    MessageBox.Show("Bilinmeyen rol: " + kullanici.Rol, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            this.Hide();
            acilacakform.ShowDialog();
            this.Close();
        }
    }
    }


