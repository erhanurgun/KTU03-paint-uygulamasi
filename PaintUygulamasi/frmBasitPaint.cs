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
    public partial class frmBasitPaint : Form
    {
        #region 01: Miras Al
        Global global = new Global();
        Kalem kalem = new Kalem();
        Kare kare = new Kare();
        Daire daire = new Daire();
        Silgi silgi = new Silgi();
        #endregion

        public frmBasitPaint()
        {
            InitializeComponent();
        }

        private void frmBasitPaint_Load(object sender, EventArgs e)
        {
            global.tip = Global.SekilTipi.kalem;
            btnKalem.BackColor = Color.Aqua;
        }

        #region 02: Buttonlar
        private void btnKalem_Click(object sender, EventArgs e)
        {
            global.tip = Global.SekilTipi.kalem;
            btnKalem.BackColor = Color.Aqua;
            btnKare.BackColor = Color.White;
            btnDaire.BackColor = Color.White;
            btnSilgi.BackColor = Color.White;
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            global.tip = Global.SekilTipi.kare;
            btnKalem.BackColor = Color.White;
            btnKare.BackColor = Color.Aqua;
            btnDaire.BackColor = Color.White;
            btnSilgi.BackColor = Color.White;
        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            global.tip = Global.SekilTipi.daire;
            btnKalem.BackColor = Color.White;
            btnKare.BackColor = Color.White;
            btnDaire.BackColor = Color.Aqua;
            btnSilgi.BackColor = Color.White;
        }

        private void btnSilgi_Click(object sender, EventArgs e)
        {
            global.tip = Global.SekilTipi.silgi;
            btnKalem.BackColor = Color.White;
            btnKare.BackColor = Color.White;
            btnDaire.BackColor = Color.White;
            btnSilgi.BackColor = Color.Aqua;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            pboxCizimPaneli.Invalidate();
        }
        #endregion

        #region 03: Çizim Paneli
        private void pboxCizimPaneli_MouseUp(object sender, MouseEventArgs e)
        {
            global.cizimDurumu = false;
        }

        private void pboxCizimPaneli_MouseDown(object sender, MouseEventArgs e)
        {
            global.cizimDurumu = true;
            global.baslaX = e.X;
            global.baslaY = e.Y;
        }
        
        private void pboxCizimPaneli_MouseMove(object sender, MouseEventArgs e)
        {
            global.grafik = pboxCizimPaneli.CreateGraphics();

            if (global.cizimDurumu && global.tip == Global.SekilTipi.kalem)
                kalem.ciz(e, global.grafik);
            if (global.cizimDurumu && global.tip == Global.SekilTipi.silgi)
                silgi.ciz(e, global.grafik);
            if (global.cizimDurumu && global.tip == Global.SekilTipi.kare)
            {
                kare.ciz(e, global.grafik);
                global.cizimDurumu = false;
            }
            if (global.cizimDurumu && global.tip == Global.SekilTipi.daire)
            {
                daire.ciz(e, global.grafik);
                global.cizimDurumu = false;
            }
        }
        #endregion
    }
}
