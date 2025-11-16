using Kutuphane.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.UI.Forms
{
    public partial class frmKitapAra : Form
    {
        private readonly KitapYonetimi _kitapYonetimi;
        public frmKitapAra()
        {
            InitializeComponent();
            _kitapYonetimi = new KitapYonetimi();
            kitaplarDgw.AutoGenerateColumns = true;
            this.Load += frmKitapAra_Load;
            kitapAdiTxt.KeyDown += kitapAdiTxt_KeyDown;
        }

        private void frmKitapAra_Load(object sender, EventArgs e)
        {
            
            TumKitaplariYukle();
        }
        public void TumKitaplariYukle()
        {
            var kitapListesi = _kitapYonetimi.TumKitaplariGetir();
            kitaplarDgw.DataSource = kitapListesi;

            // Kolon ayarları
            if (kitaplarDgw.Columns["OduncDurumu"] != null)
                kitaplarDgw.Columns["OduncDurumu"].Visible = false;

            if (kitaplarDgw.Columns["OduncDurumText"] != null)
                kitaplarDgw.Columns["OduncDurumText"].HeaderText = "Ödünç Durumu";
        }
        private void kitapAdiTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KitaplariYukle();
                e.SuppressKeyPress = true; // Enter tuşunun "ding" sesini engelle
            }
        }
        private void KitaplariYukle()
        {
            string aranan = kitapAdiTxt.Text.Trim();
            var kitapListesi = _kitapYonetimi.KitapAra(aranan);
            kitaplarDgw.DataSource = kitapListesi;

            if (kitaplarDgw.Columns["OduncDurumu"] != null)
                kitaplarDgw.Columns["OduncDurumu"].Visible = false;

            if (kitaplarDgw.Columns["OduncDurumText"] != null)
                kitaplarDgw.Columns["OduncDurumText"].HeaderText = "Ödünç Durumu";
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            kitapAdiTxt.Clear();
        }
    }
}
