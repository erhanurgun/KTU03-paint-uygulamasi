
namespace PaintUygulamasi
{
    partial class frmBasitPaint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKalem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pboxCizimPaneli = new System.Windows.Forms.PictureBox();
            this.btnKare = new System.Windows.Forms.Button();
            this.btnDaire = new System.Windows.Forms.Button();
            this.btnSilgi = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCizimPaneli)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSilgi);
            this.groupBox1.Controls.Add(this.btnDaire);
            this.groupBox1.Controls.Add(this.btnKare);
            this.groupBox1.Controls.Add(this.btnKalem);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araçlar";
            // 
            // btnKalem
            // 
            this.btnKalem.BackColor = System.Drawing.Color.White;
            this.btnKalem.Location = new System.Drawing.Point(7, 24);
            this.btnKalem.Name = "btnKalem";
            this.btnKalem.Size = new System.Drawing.Size(99, 51);
            this.btnKalem.TabIndex = 0;
            this.btnKalem.Text = "Kalem";
            this.btnKalem.UseVisualStyleBackColor = false;
            this.btnKalem.Click += new System.EventHandler(this.btnKalem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pboxCizimPaneli);
            this.groupBox2.Location = new System.Drawing.Point(14, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çizim Paneli";
            // 
            // pboxCizimPaneli
            // 
            this.pboxCizimPaneli.BackColor = System.Drawing.Color.White;
            this.pboxCizimPaneli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxCizimPaneli.Location = new System.Drawing.Point(7, 22);
            this.pboxCizimPaneli.Name = "pboxCizimPaneli";
            this.pboxCizimPaneli.Size = new System.Drawing.Size(537, 333);
            this.pboxCizimPaneli.TabIndex = 0;
            this.pboxCizimPaneli.TabStop = false;
            this.pboxCizimPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxCizimPaneli_MouseDown);
            this.pboxCizimPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxCizimPaneli_MouseMove);
            this.pboxCizimPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pboxCizimPaneli_MouseUp);
            // 
            // btnKare
            // 
            this.btnKare.BackColor = System.Drawing.Color.White;
            this.btnKare.Location = new System.Drawing.Point(119, 24);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(99, 51);
            this.btnKare.TabIndex = 1;
            this.btnKare.Text = "Kare";
            this.btnKare.UseVisualStyleBackColor = false;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // btnDaire
            // 
            this.btnDaire.BackColor = System.Drawing.Color.White;
            this.btnDaire.Location = new System.Drawing.Point(229, 24);
            this.btnDaire.Name = "btnDaire";
            this.btnDaire.Size = new System.Drawing.Size(99, 51);
            this.btnDaire.TabIndex = 2;
            this.btnDaire.Text = "Daire";
            this.btnDaire.UseVisualStyleBackColor = false;
            this.btnDaire.Click += new System.EventHandler(this.btnDaire_Click);
            // 
            // btnSilgi
            // 
            this.btnSilgi.BackColor = System.Drawing.Color.White;
            this.btnSilgi.Location = new System.Drawing.Point(339, 24);
            this.btnSilgi.Name = "btnSilgi";
            this.btnSilgi.Size = new System.Drawing.Size(99, 51);
            this.btnSilgi.TabIndex = 3;
            this.btnSilgi.Text = "Silgi";
            this.btnSilgi.UseVisualStyleBackColor = false;
            this.btnSilgi.Click += new System.EventHandler(this.btnSilgi_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(446, 24);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(99, 51);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmBasitPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.MaximizeBox = false;
            this.Name = "frmBasitPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBasitPaint";
            this.Load += new System.EventHandler(this.frmBasitPaint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCizimPaneli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKalem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pboxCizimPaneli;
        private System.Windows.Forms.Button btnDaire;
        private System.Windows.Forms.Button btnKare;
        private System.Windows.Forms.Button btnSilgi;
        private System.Windows.Forms.Button btnTemizle;
    }
}