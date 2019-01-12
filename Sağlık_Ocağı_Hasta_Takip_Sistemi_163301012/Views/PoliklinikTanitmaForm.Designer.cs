namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views
{
    partial class PoliklinikTanitmaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPoliklinikAdi = new System.Windows.Forms.TextBox();
            this.checkBoxGecerli = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.panelDuzenle = new System.Windows.Forms.Panel();
            this.panelEkleme = new System.Windows.Forms.Panel();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.panelDuzenle.SuspendLayout();
            this.panelEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // textBoxPoliklinikAdi
            // 
            this.textBoxPoliklinikAdi.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPoliklinikAdi.Location = new System.Drawing.Point(153, 50);
            this.textBoxPoliklinikAdi.MaxLength = 50;
            this.textBoxPoliklinikAdi.Name = "textBoxPoliklinikAdi";
            this.textBoxPoliklinikAdi.Size = new System.Drawing.Size(233, 28);
            this.textBoxPoliklinikAdi.TabIndex = 1;
            // 
            // checkBoxGecerli
            // 
            this.checkBoxGecerli.AutoSize = true;
            this.checkBoxGecerli.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGecerli.Location = new System.Drawing.Point(153, 95);
            this.checkBoxGecerli.Name = "checkBoxGecerli";
            this.checkBoxGecerli.Size = new System.Drawing.Size(139, 21);
            this.checkBoxGecerli.TabIndex = 2;
            this.checkBoxGecerli.Text = "Geçerli/Geçersiz";
            this.checkBoxGecerli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // richTextBoxAciklama
            // 
            this.richTextBoxAciklama.Location = new System.Drawing.Point(25, 184);
            this.richTextBoxAciklama.MaxLength = 255;
            this.richTextBoxAciklama.Name = "richTextBoxAciklama";
            this.richTextBoxAciklama.Size = new System.Drawing.Size(361, 188);
            this.richTextBoxAciklama.TabIndex = 3;
            this.richTextBoxAciklama.Text = "";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGuncelle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.Green;
            this.buttonGuncelle.Location = new System.Drawing.Point(15, 13);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(107, 47);
            this.buttonGuncelle.TabIndex = 4;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSil.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonSil.ForeColor = System.Drawing.Color.Red;
            this.buttonSil.Location = new System.Drawing.Point(128, 13);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(107, 47);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCikis.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonCikis.Location = new System.Drawing.Point(279, 391);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(107, 47);
            this.buttonCikis.TabIndex = 4;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // panelDuzenle
            // 
            this.panelDuzenle.Controls.Add(this.buttonSil);
            this.panelDuzenle.Controls.Add(this.buttonGuncelle);
            this.panelDuzenle.Location = new System.Drawing.Point(25, 378);
            this.panelDuzenle.Name = "panelDuzenle";
            this.panelDuzenle.Size = new System.Drawing.Size(248, 70);
            this.panelDuzenle.TabIndex = 5;
            // 
            // panelEkleme
            // 
            this.panelEkleme.Controls.Add(this.buttonEkle);
            this.panelEkleme.Location = new System.Drawing.Point(25, 378);
            this.panelEkleme.Name = "panelEkleme";
            this.panelEkleme.Size = new System.Drawing.Size(248, 70);
            this.panelEkleme.TabIndex = 5;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEkle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.Color.Green;
            this.buttonEkle.Location = new System.Drawing.Point(15, 13);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(107, 47);
            this.buttonEkle.TabIndex = 4;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // PoliklinikTanitmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.richTextBoxAciklama);
            this.Controls.Add(this.checkBoxGecerli);
            this.Controls.Add(this.textBoxPoliklinikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelEkleme);
            this.Controls.Add(this.panelDuzenle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PoliklinikTanitmaForm";
            this.Text = "Poliklinik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoliklinikTanitmaForm_FormClosing);
            this.Shown += new System.EventHandler(this.PoliklinikTanitmaForm_Shown);
            this.panelDuzenle.ResumeLayout(false);
            this.panelEkleme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPoliklinikAdi;
        private System.Windows.Forms.CheckBox checkBoxGecerli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxAciklama;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Panel panelDuzenle;
        private System.Windows.Forms.Panel panelEkleme;
        private System.Windows.Forms.Button buttonEkle;
    }
}