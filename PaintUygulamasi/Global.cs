using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintUygulamasi
{
    class Global
    {
        public int baslaX, baslaY;
        public bool cizimDurumu;
        public int genislik = 100, yukseklik = 100;
        public static int kalinlik = 5;

        public Pen kalem = new Pen(Color.Black, kalinlik);
        public Pen silgi = new Pen(Color.White, kalinlik);

        //public SolidBrush firca;
        //public Control kontrol;
        public Graphics grafik;
        public Point ilkNokta, sonNokta;
        public SekilTipi tip;

        public enum SekilTipi
        {
            kare, daire, kalem, silgi
        }
    }

    abstract class Cizim : Global
    {
        public abstract void ciz(MouseEventArgs e, Graphics g);
    }

    class Kalem : Cizim
    {
        public override void ciz(MouseEventArgs e, Graphics g)
        {
            ilkNokta = new Point(baslaX, baslaY);
            sonNokta = new Point(e.X, e.Y);

            g.DrawLine(kalem, ilkNokta, sonNokta);

            baslaX = e.X;
            baslaY = e.Y;
        }
    }

    class Kare : Cizim
    {
        public override void ciz(MouseEventArgs e, Graphics g)
        {
            //var sekil = new Rectangle(e.X, e.Y, genislik, yukseklik);
            //g.DrawRectangle(kalem, sekil);

            int x = e.X - 90;
            int y = e.Y - 90;

            Point[] noktalar =
            {
                new Point(x + 40,  y + 60),
                new Point(x + 40,  y + 140),
                new Point(x + 140, y + 140),
                new Point(x + 140, y + 60),
                new Point(x + 40,  y + 60)
            };

            g.DrawLines(kalem, noktalar);
        }
    }

    class Daire : Cizim
    {
        public override void ciz(MouseEventArgs e, Graphics g)
        {
            var sekil = new Rectangle(e.X, e.Y, genislik, yukseklik);
            //g.DrawEllipse(kalem, sekil);
            g.DrawArc(kalem, sekil, 360, 360);
        }
    }

    class Silgi : Cizim
    {
        public override void ciz(MouseEventArgs e, Graphics g)
        {
            ilkNokta = new Point(baslaX, baslaY);
            sonNokta = new Point(e.X, e.Y);

            g.DrawLine(silgi, ilkNokta, sonNokta);

            baslaX = e.X;
            baslaY = e.Y;
        }
    }
}
