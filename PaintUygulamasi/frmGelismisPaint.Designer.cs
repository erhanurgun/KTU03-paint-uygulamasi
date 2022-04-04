
namespace PaintUygulamasi
{
    partial class frmGelismisPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGelismisPaint));
            this.gboxCizimPaneli = new System.Windows.Forms.GroupBox();
            this.pboxCizimAlani = new System.Windows.Forms.PictureBox();
            this.gboxAracPaneli = new System.Windows.Forms.GroupBox();
            this.gboxAyarlarPaneli = new System.Windows.Forms.GroupBox();
            this.pboxKalemRengi = new System.Windows.Forms.PictureBox();
            this.pboxSekilIci = new System.Windows.Forms.PictureBox();
            this.chbIciniDoldur = new System.Windows.Forms.CheckBox();
            this.pboxSekilKenari = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numTxtKalinlik = new System.Windows.Forms.NumericUpDown();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSerbestCizim = new System.Windows.Forms.Button();
            this.btnDuzCizgi = new System.Windows.Forms.Button();
            this.btnDaire = new System.Windows.Forms.Button();
            this.btnUcgen = new System.Windows.Forms.Button();
            this.btnDortgen = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIlkX = new System.Windows.Forms.Label();
            this.lblIlkY = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSonX = new System.Windows.Forms.Label();
            this.lblSonY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboxCizimPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCizimAlani)).BeginInit();
            this.gboxAracPaneli.SuspendLayout();
            this.gboxAyarlarPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKalemRengi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSekilIci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSekilKenari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtKalinlik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCizimPaneli
            // 
            this.gboxCizimPaneli.Controls.Add(this.pboxCizimAlani);
            this.gboxCizimPaneli.Location = new System.Drawing.Point(9, 5);
            this.gboxCizimPaneli.Name = "gboxCizimPaneli";
            this.gboxCizimPaneli.Size = new System.Drawing.Size(585, 547);
            this.gboxCizimPaneli.TabIndex = 0;
            this.gboxCizimPaneli.TabStop = false;
            this.gboxCizimPaneli.Text = " Çizim Paneli ";
            // 
            // pboxCizimAlani
            // 
            this.pboxCizimAlani.BackColor = System.Drawing.Color.White;
            this.pboxCizimAlani.Location = new System.Drawing.Point(7, 18);
            this.pboxCizimAlani.Name = "pboxCizimAlani";
            this.pboxCizimAlani.Size = new System.Drawing.Size(572, 520);
            this.pboxCizimAlani.TabIndex = 0;
            this.pboxCizimAlani.TabStop = false;
            this.pboxCizimAlani.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxCizimAlani_MouseDown);
            this.pboxCizimAlani.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxCizimAlani_MouseMove);
            this.pboxCizimAlani.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pboxCizimAlani_MouseUp);
            // 
            // gboxAracPaneli
            // 
            this.gboxAracPaneli.Controls.Add(this.gboxAyarlarPaneli);
            this.gboxAracPaneli.Controls.Add(this.btnSil);
            this.gboxAracPaneli.Controls.Add(this.btnTemizle);
            this.gboxAracPaneli.Controls.Add(this.btnSerbestCizim);
            this.gboxAracPaneli.Controls.Add(this.btnDuzCizgi);
            this.gboxAracPaneli.Controls.Add(this.btnDaire);
            this.gboxAracPaneli.Controls.Add(this.btnUcgen);
            this.gboxAracPaneli.Controls.Add(this.btnDortgen);
            this.gboxAracPaneli.Location = new System.Drawing.Point(600, 5);
            this.gboxAracPaneli.Name = "gboxAracPaneli";
            this.gboxAracPaneli.Size = new System.Drawing.Size(190, 547);
            this.gboxAracPaneli.TabIndex = 0;
            this.gboxAracPaneli.TabStop = false;
            this.gboxAracPaneli.Text = " Araçlar Paneli ";
            // 
            // gboxAyarlarPaneli
            // 
            this.gboxAyarlarPaneli.Controls.Add(this.pboxKalemRengi);
            this.gboxAyarlarPaneli.Controls.Add(this.pboxSekilIci);
            this.gboxAyarlarPaneli.Controls.Add(this.chbIciniDoldur);
            this.gboxAyarlarPaneli.Controls.Add(this.pboxSekilKenari);
            this.gboxAyarlarPaneli.Controls.Add(this.label3);
            this.gboxAyarlarPaneli.Controls.Add(this.label2);
            this.gboxAyarlarPaneli.Controls.Add(this.label1);
            this.gboxAyarlarPaneli.Controls.Add(this.numTxtKalinlik);
            this.gboxAyarlarPaneli.Location = new System.Drawing.Point(8, 252);
            this.gboxAyarlarPaneli.Name = "gboxAyarlarPaneli";
            this.gboxAyarlarPaneli.Size = new System.Drawing.Size(175, 286);
            this.gboxAyarlarPaneli.TabIndex = 1;
            this.gboxAyarlarPaneli.TabStop = false;
            // 
            // pboxKalemRengi
            // 
            this.pboxKalemRengi.BackColor = System.Drawing.Color.Black;
            this.pboxKalemRengi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxKalemRengi.Location = new System.Drawing.Point(104, 54);
            this.pboxKalemRengi.Name = "pboxKalemRengi";
            this.pboxKalemRengi.Size = new System.Drawing.Size(62, 26);
            this.pboxKalemRengi.TabIndex = 4;
            this.pboxKalemRengi.TabStop = false;
            this.pboxKalemRengi.Click += new System.EventHandler(this.pboxKalemRengi_Click);
            // 
            // pboxSekilIci
            // 
            this.pboxSekilIci.BackColor = System.Drawing.Color.Aqua;
            this.pboxSekilIci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxSekilIci.Location = new System.Drawing.Point(29, 164);
            this.pboxSekilIci.Name = "pboxSekilIci";
            this.pboxSekilIci.Size = new System.Drawing.Size(117, 98);
            this.pboxSekilIci.TabIndex = 4;
            this.pboxSekilIci.TabStop = false;
            this.pboxSekilIci.Click += new System.EventHandler(this.pboxSekilIci_Click);
            // 
            // chbIciniDoldur
            // 
            this.chbIciniDoldur.AutoSize = true;
            this.chbIciniDoldur.Checked = true;
            this.chbIciniDoldur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIciniDoldur.Location = new System.Drawing.Point(11, 88);
            this.chbIciniDoldur.Name = "chbIciniDoldur";
            this.chbIciniDoldur.Size = new System.Drawing.Size(93, 20);
            this.chbIciniDoldur.TabIndex = 2;
            this.chbIciniDoldur.Text = "İçini Doldur";
            this.chbIciniDoldur.UseVisualStyleBackColor = true;
            this.chbIciniDoldur.CheckedChanged += new System.EventHandler(this.chbIciniDoldur_CheckedChanged);
            // 
            // pboxSekilKenari
            // 
            this.pboxSekilKenari.BackColor = System.Drawing.Color.Black;
            this.pboxSekilKenari.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxSekilKenari.Location = new System.Drawing.Point(11, 145);
            this.pboxSekilKenari.Name = "pboxSekilKenari";
            this.pboxSekilKenari.Size = new System.Drawing.Size(155, 135);
            this.pboxSekilKenari.TabIndex = 3;
            this.pboxSekilKenari.TabStop = false;
            this.pboxSekilKenari.Click += new System.EventHandler(this.pboxSekilKenari_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kalem Rengi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şekil Renkleri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalınlık:";
            // 
            // numTxtKalinlik
            // 
            this.numTxtKalinlik.Location = new System.Drawing.Point(65, 20);
            this.numTxtKalinlik.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTxtKalinlik.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTxtKalinlik.Name = "numTxtKalinlik";
            this.numTxtKalinlik.Size = new System.Drawing.Size(99, 21);
            this.numTxtKalinlik.TabIndex = 0;
            this.numTxtKalinlik.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTxtKalinlik.ValueChanged += new System.EventHandler(this.numTxtKalinlik_ValueChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(99, 195);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(84, 51);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(8, 195);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(84, 51);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSerbestCizim
            // 
            this.btnSerbestCizim.BackColor = System.Drawing.Color.White;
            this.btnSerbestCizim.Location = new System.Drawing.Point(8, 138);
            this.btnSerbestCizim.Name = "btnSerbestCizim";
            this.btnSerbestCizim.Size = new System.Drawing.Size(175, 51);
            this.btnSerbestCizim.TabIndex = 0;
            this.btnSerbestCizim.Text = "Serbest Çizim";
            this.btnSerbestCizim.UseVisualStyleBackColor = false;
            this.btnSerbestCizim.Click += new System.EventHandler(this.btnSerbestCizim_Click);
            // 
            // btnDuzCizgi
            // 
            this.btnDuzCizgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDuzCizgi.Location = new System.Drawing.Point(99, 80);
            this.btnDuzCizgi.Name = "btnDuzCizgi";
            this.btnDuzCizgi.Size = new System.Drawing.Size(84, 51);
            this.btnDuzCizgi.TabIndex = 0;
            this.btnDuzCizgi.Text = "Düz Çizgi";
            this.btnDuzCizgi.UseVisualStyleBackColor = false;
            this.btnDuzCizgi.Click += new System.EventHandler(this.btnDuzCizgi_Click);
            // 
            // btnDaire
            // 
            this.btnDaire.BackColor = System.Drawing.Color.White;
            this.btnDaire.Location = new System.Drawing.Point(8, 80);
            this.btnDaire.Name = "btnDaire";
            this.btnDaire.Size = new System.Drawing.Size(84, 51);
            this.btnDaire.TabIndex = 0;
            this.btnDaire.Text = "Daire";
            this.btnDaire.UseVisualStyleBackColor = false;
            this.btnDaire.Click += new System.EventHandler(this.btnDaire_Click);
            // 
            // btnUcgen
            // 
            this.btnUcgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUcgen.Location = new System.Drawing.Point(99, 22);
            this.btnUcgen.Name = "btnUcgen";
            this.btnUcgen.Size = new System.Drawing.Size(84, 51);
            this.btnUcgen.TabIndex = 0;
            this.btnUcgen.Text = "Üçgen";
            this.btnUcgen.UseVisualStyleBackColor = false;
            this.btnUcgen.Click += new System.EventHandler(this.btnUcgen_Click);
            // 
            // btnDortgen
            // 
            this.btnDortgen.BackColor = System.Drawing.Color.White;
            this.btnDortgen.Location = new System.Drawing.Point(8, 22);
            this.btnDortgen.Name = "btnDortgen";
            this.btnDortgen.Size = new System.Drawing.Size(84, 51);
            this.btnDortgen.TabIndex = 0;
            this.btnDortgen.Text = "Dötgen";
            this.btnDortgen.UseVisualStyleBackColor = false;
            this.btnDortgen.Click += new System.EventHandler(this.btnDortgen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Başlanıç Kordinatları (X,Y):";
            // 
            // lblIlkX
            // 
            this.lblIlkX.AutoSize = true;
            this.lblIlkX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIlkX.Location = new System.Drawing.Point(172, 15);
            this.lblIlkX.Name = "lblIlkX";
            this.lblIlkX.Size = new System.Drawing.Size(31, 18);
            this.lblIlkX.TabIndex = 2;
            this.lblIlkX.Text = "000";
            // 
            // lblIlkY
            // 
            this.lblIlkY.AutoSize = true;
            this.lblIlkY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIlkY.Location = new System.Drawing.Point(216, 15);
            this.lblIlkY.Name = "lblIlkY";
            this.lblIlkY.Size = new System.Drawing.Size(31, 18);
            this.lblIlkY.TabIndex = 2;
            this.lblIlkY.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(203, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = ",";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Anlık Kordinatlar (X,Y):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(731, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = ",";
            // 
            // lblSonX
            // 
            this.lblSonX.AutoSize = true;
            this.lblSonX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSonX.Location = new System.Drawing.Point(700, 14);
            this.lblSonX.Name = "lblSonX";
            this.lblSonX.Size = new System.Drawing.Size(31, 18);
            this.lblSonX.TabIndex = 2;
            this.lblSonX.Text = "000";
            // 
            // lblSonY
            // 
            this.lblSonY.AutoSize = true;
            this.lblSonY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSonY.Location = new System.Drawing.Point(744, 14);
            this.lblSonY.Name = "lblSonY";
            this.lblSonY.Size = new System.Drawing.Size(31, 18);
            this.lblSonY.TabIndex = 2;
            this.lblSonY.Text = "000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSonY);
            this.groupBox1.Controls.Add(this.lblIlkY);
            this.groupBox1.Controls.Add(this.lblIlkX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSonX);
            this.groupBox1.Location = new System.Drawing.Point(9, 552);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 41);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxAracPaneli);
            this.Controls.Add(this.gboxCizimPaneli);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v.1.0.1 - Paint Uygulaması";
            this.Load += new System.EventHandler(this.frmPaint_Load);
            this.gboxCizimPaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCizimAlani)).EndInit();
            this.gboxAracPaneli.ResumeLayout(false);
            this.gboxAyarlarPaneli.ResumeLayout(false);
            this.gboxAyarlarPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKalemRengi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSekilIci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSekilKenari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTxtKalinlik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCizimPaneli;
        private System.Windows.Forms.GroupBox gboxAracPaneli;
        private System.Windows.Forms.PictureBox pboxCizimAlani;
        private System.Windows.Forms.GroupBox gboxAyarlarPaneli;
        private System.Windows.Forms.PictureBox pboxSekilIci;
        private System.Windows.Forms.PictureBox pboxSekilKenari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTxtKalinlik;
        private System.Windows.Forms.Button btnSerbestCizim;
        private System.Windows.Forms.Button btnDuzCizgi;
        private System.Windows.Forms.Button btnDaire;
        private System.Windows.Forms.Button btnUcgen;
        private System.Windows.Forms.Button btnDortgen;
        private System.Windows.Forms.CheckBox chbIciniDoldur;
        private System.Windows.Forms.PictureBox pboxKalemRengi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIlkX;
        private System.Windows.Forms.Label lblIlkY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSonX;
        private System.Windows.Forms.Label lblSonY;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

