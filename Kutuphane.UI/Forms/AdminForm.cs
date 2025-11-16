using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kutuphane.UI.Forms
{
    public partial class AdminForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public AdminForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            navPnl.Height = kitapAraBtn.Height;
            navPnl.Top = kitapAraBtn.Top;
            navPnl.Left = kitapAraBtn.Left;
            kitapAraBtn.BackColor = Color.FromArgb(18, 18, 24);

            this.pnlFormAcici.Controls.Clear();
            frmKitapAra frmkitapara = new frmKitapAra() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapara.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapara);
            frmkitapara.Show();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GorevliForm_Load(object sender, EventArgs e)
        {

        }

        private void kitapAraBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = kitapAraBtn.Height;
            navPnl.Top = kitapAraBtn.Top;
            navPnl.Left = kitapAraBtn.Left;
            kitapAraBtn.BackColor = Color.FromArgb(18, 18, 24);

            this.pnlFormAcici.Controls.Clear();
            frmKitapAra frmkitapara = new frmKitapAra() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapara.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapara);
            frmkitapara.Show();
        }
        private void kitapAraBtn_Leave(object sender, EventArgs e)
        {
            kitapAraBtn.BackColor = Color.FromArgb(0, 122, 255);
        }
        private void kitapOduncVerBtn_Click_1(object sender, EventArgs e)
        {
            kitapOduncVerBtn.BackColor = Color.FromArgb(18, 18, 24);
            navPnl.Height = kitapOduncVerBtn.Height;
            navPnl.Top = kitapOduncVerBtn.Top;
            navPnl.Left = kitapOduncVerBtn.Left;

            this.pnlFormAcici.Controls.Clear();
            frmKitapOduncVer frmkitapoduncver = new frmKitapOduncVer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapoduncver.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapoduncver);
            frmkitapoduncver.Show();
        }
        private void kitapOduncVerBtn_Leave(object sender, EventArgs e)
        {
            kitapOduncVerBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void kitapIadeAlBtn_Click_1(object sender, EventArgs e)
        {
            navPnl.Height = kitapIadeAlBtn.Height;
            navPnl.Top = kitapIadeAlBtn.Top;
            navPnl.Left = kitapIadeAlBtn.Left;
            kitapIadeAlBtn.BackColor = Color.FromArgb(18, 18, 24);
            this.pnlFormAcici.Controls.Clear();
            frmKitapIadeAl frmkitapiadeal = new frmKitapIadeAl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapiadeal.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapiadeal);
            frmkitapiadeal.Show();
        }
        private void kitapIadeAlBtn_Leave(object sender, EventArgs e)
        {
            kitapIadeAlBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void kitapEkleBtn_Click(object sender, EventArgs e)
        {
            kitapEkleBtn.BackColor = Color.FromArgb(18, 18, 24);
            navPnl.Height = kitapEkleBtn.Height;
            navPnl.Top = kitapEkleBtn.Top;
            navPnl.Left = kitapEkleBtn.Left;
            this.pnlFormAcici.Controls.Clear();
            frmKitapEkle frmkitapekle = new frmKitapEkle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmkitapekle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmkitapekle);
            frmkitapekle.Show();
        }

        private void uyeEkleBtn_Click(object sender, EventArgs e)
        {
            uyeEkleBtn.BackColor = Color.FromArgb(18, 18, 24);
            navPnl.Height = uyeEkleBtn.Height;
            navPnl.Top = uyeEkleBtn.Top;
            navPnl.Left = uyeEkleBtn.Left;
            this.pnlFormAcici.Controls.Clear();
            frmUyeEkle frmuyeekle = new frmUyeEkle() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmuyeekle.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmuyeekle);
            frmuyeekle.Show();
        }

        private void kitapEkleBtn_Leave(object sender, EventArgs e)
        {
            kitapEkleBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void uyeEkleBtn_Leave(object sender, EventArgs e)
        {
            uyeEkleBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void raporlarBtn_Leave(object sender, EventArgs e)
        {
            raporlarBtn.BackColor = Color.FromArgb(0, 122, 255);
        }

        private void raporlarBtn_Click(object sender, EventArgs e)
        {
            raporlarBtn.BackColor = Color.FromArgb(18, 18, 24);
            navPnl.Height = raporlarBtn.Height;
            navPnl.Top = raporlarBtn.Top;
            navPnl.Left = raporlarBtn.Left;
            this.pnlFormAcici.Controls.Clear();
            frmRaporlar frmraporlar = new frmRaporlar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmraporlar.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormAcici.Controls.Add(frmraporlar);
            frmraporlar.Show();
        }
    }
}
