using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUygulamasi
{
    public partial class frmPaint : Form
    {
        private GlobalDegisken gDegisken = new GlobalDegisken();
        private SerbestCizgi sCizgi = new SerbestCizgi();

        public void isButton(Button btn)
        {
            foreach (Control x in gboxAracPaneli.Controls)
                if (x.GetType() == typeof(Button))
                    x.BackColor = Color.White;

            btn.BackColor = Color.Aqua;
        }

        // TODO: Yarım Bırakıldı
        #region 01: Class
        public class GlobalDegisken
        {
            public int ilkX, ilkY, sonX, sonY;
            public bool cizimDurumu;
            public int kalinlik = 3, genislik = 100, yukseklik = 100;

            public Color renk;
            public Pen kalem1, kalem2;
            public SolidBrush firca1, firca2;
            public Graphics grafik;
            public Control kontrol;
            public Point iNokta, sNokta;
            public SekilTipi tip;
        }

        public enum SekilTipi
        {
            ucgen = 1,
            dortgen = 2,
            daire = 3,
            duz = 4,
            serbest = 5,
            sil = 6
        }

        abstract public class Cizim : GlobalDegisken
        {
            public abstract void Ciz(MouseEventArgs e);
        }

        public class SerbestCizgi : Cizim
        {
            public override void Ciz(MouseEventArgs e)
            {
                
            }
        }

        // TODO: Daha Sonra Tamamlanacaklar
        #region Taslaklar:
        //public class DuzCizgi : Cizim
        //{
        //    public override void Ciz(int genislik, int yukseklik)
        //    {

        //    }
        //}

        //public class Daire : Cizim
        //{
        //    public override void Ciz(int genislik, int yukseklik)
        //    {

        //    }
        //}

        //public class Dortgen : Cizim
        //{
        //    public override void Ciz(int genislik, int yukseklik)
        //    {

        //    }
        //}

        //public class Ucgen : Cizim
        //{
        //    public override void Ciz(int genislik, int yukseklik)
        //    {

        //    }
        //}
        #endregion

        #endregion

        public frmPaint()
        {
            InitializeComponent();
        }

        private void frmPaint_Load(object sender, EventArgs e)
        {
            gDegisken.kalinlik = Int32.Parse(numTxtKalinlik.Text);
        }

        private void numTxtKalinlik_ValueChanged(object sender, EventArgs e)
        {
            gDegisken.kalinlik = Int32.Parse(numTxtKalinlik.Text);
        }
        private void chbIciniDoldur_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIciniDoldur.Checked)
            {
                pboxSekilIci.BackColor = gDegisken.renk;
                pboxSekilIci.Enabled = true;
            }
            else
            {
                gDegisken.renk = pboxSekilIci.BackColor;
                pboxSekilIci.BackColor = BackColor;
                pboxSekilIci.Enabled = false;
            }
        }

        // Tamamlandı...
        #region 02: PictureBox : Renkler
        private void pboxKalemRengi_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pboxKalemRengi.BackColor = colorDialog1.Color;
        }

        private void pboxSekilKenari_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pboxSekilKenari.BackColor = colorDialog1.Color;
        }

        private void pboxSekilIci_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && pboxSekilIci.Enabled)
                pboxSekilIci.BackColor = colorDialog1.Color;
        }
        #endregion

        // Tamamlandı...
        #region 03: Button
        private void btnUcgen_Click(object sender, EventArgs e)
        {
            gDegisken.tip = SekilTipi.ucgen;
            isButton(btnUcgen);
        }

        private void btnDortgen_Click(object sender, EventArgs e)
        {
            gDegisken.tip = SekilTipi.dortgen;
            isButton(btnDortgen);
        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            gDegisken.tip = SekilTipi.daire;
            isButton(btnDaire);
        }

        private void btnDuzCizgi_Click(object sender, EventArgs e)
        {
            gDegisken.tip = SekilTipi.duz;
            isButton(btnDuzCizgi);
        }

        private void btnSerbestCizim_Click(object sender, EventArgs e)
        {
            gDegisken.tip = SekilTipi.serbest;
            isButton(btnSerbestCizim);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gDegisken.tip = SekilTipi.sil;
            isButton(btnSil);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            pboxCizimAlani.Invalidate();
        }
        #endregion

        // TODO: Yarım Bırakıldı
        #region 04: PictureBox : pboxCizimAlani()
        private void pboxCizimAlani_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
                gDegisken.cizimDurumu = false;
        }

        private Point p;
        private void pboxCizimAlani_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                gDegisken.cizimDurumu = true;
                gDegisken.ilkX = e.X;
                gDegisken.ilkY = e.Y;

                lblIlkX.Text = e.X.ToString();
                lblIlkY.Text = e.Y.ToString();
            }
        }

        private void pboxCizimAlani_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                lblSonX.Text = gDegisken.ilkX.ToString();
                lblSonY.Text = gDegisken.ilkY.ToString();

                if (gDegisken.tip == SekilTipi.sil)
                    gDegisken.kalem1 = new Pen(pboxCizimAlani.BackColor, gDegisken.kalinlik);
                else
                {
                    gDegisken.kalem1 = new Pen(pboxKalemRengi.BackColor, gDegisken.kalinlik);
                    gDegisken.kalem2 = new Pen(pboxSekilKenari.BackColor, gDegisken.kalinlik);
                }
                gDegisken.grafik = pboxCizimAlani.CreateGraphics();
                gDegisken.iNokta = new Point(gDegisken.ilkX, gDegisken.ilkY);
                gDegisken.sNokta = new Point(e.X, e.Y);
                gDegisken.firca1 = new SolidBrush(pboxSekilKenari.BackColor);
                gDegisken.firca2 = new SolidBrush(pboxSekilIci.BackColor);

                int oran = gDegisken.kalinlik;
                var sekil1 = new Rectangle(e.X, e.Y, gDegisken.genislik, gDegisken.yukseklik);
                var sekil2 = new Rectangle(e.X + oran, e.Y + oran, gDegisken.genislik - oran * 2, gDegisken.yukseklik - oran * 2);

                //gDegisken.sonX = e.X;
                //gDegisken.sonY = e.Y;
                //gDegisken.genislik = gDegisken.ilkX - gDegisken.sonX;
                //gDegisken.yukseklik = gDegisken.ilkY - gDegisken.sonY;

                // Silme Butonu
                if (gDegisken.cizimDurumu && gDegisken.tip == SekilTipi.sil)
                    gDegisken.grafik.DrawLine(gDegisken.kalem1, gDegisken.iNokta, gDegisken.sNokta);

                // Serbest Çizim Butonu
                if (gDegisken.cizimDurumu && gDegisken.tip == SekilTipi.serbest)
                    gDegisken.grafik.DrawLine(gDegisken.kalem1, gDegisken.iNokta, gDegisken.sNokta);

                // Dörtgen Çizime Butonu
                if (gDegisken.cizimDurumu && gDegisken.tip == SekilTipi.dortgen)
                {
                    if (chbIciniDoldur.Checked)
                    {
                        gDegisken.grafik.FillRectangle(gDegisken.firca1, sekil1);
                        gDegisken.grafik.FillRectangle(gDegisken.firca2, sekil2);
                    }
                    else
                        gDegisken.grafik.DrawRectangle(gDegisken.kalem2, sekil1);
                    gDegisken.cizimDurumu = false;
                }

                // Daire Çizime Butonu
                if (gDegisken.cizimDurumu && gDegisken.tip == SekilTipi.daire)
                {
                    if (chbIciniDoldur.Checked)
                    {
                        gDegisken.grafik.FillEllipse(gDegisken.firca1, sekil1);
                        gDegisken.grafik.FillEllipse(gDegisken.firca2, sekil2);
                    }
                    else
                        gDegisken.grafik.DrawEllipse(gDegisken.kalem2, sekil1);
                    gDegisken.cizimDurumu = false;
                }

                // Üçgen Çizime Butonu
                if (gDegisken.cizimDurumu && gDegisken.tip == SekilTipi.ucgen)
                {
                    PointF nokta1 = new PointF(120.0F, 20.0F);
                    PointF nokta2 = new PointF(240.0F, 120.0F);
                    PointF nokta3 = new PointF(120.0F, 120.0F);
                    PointF[] noktalar = { nokta1, nokta2, nokta3 };

                    gDegisken.grafik.DrawPolygon(gDegisken.kalem1, noktalar);
                }

                gDegisken.ilkX = e.X;
                gDegisken.ilkY = e.Y;
            }
        }
        #endregion
    }
}
