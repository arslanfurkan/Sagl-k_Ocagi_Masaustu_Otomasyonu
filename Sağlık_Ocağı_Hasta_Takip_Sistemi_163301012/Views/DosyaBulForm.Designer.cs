namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views
{
    partial class DosyaBulForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBul = new System.Windows.Forms.Button();
            this.checkBoxVe = new System.Windows.Forms.CheckBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.comboBoxAramaKriter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TcKimlikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosyaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BabaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnneAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanGrubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedeniHal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KurumSicilNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KurumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonBul);
            this.panel1.Controls.Add(this.checkBoxVe);
            this.panel1.Controls.Add(this.textBoxSoyad);
            this.panel1.Controls.Add(this.textBoxAd);
            this.panel1.Controls.Add(this.comboBoxAramaKriter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxOther);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 40);
            this.panel1.TabIndex = 0;
            // 
            // buttonBul
            // 
            this.buttonBul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBul.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBul.Location = new System.Drawing.Point(598, 6);
            this.buttonBul.Name = "buttonBul";
            this.buttonBul.Size = new System.Drawing.Size(90, 27);
            this.buttonBul.TabIndex = 4;
            this.buttonBul.Text = "Bul";
            this.buttonBul.UseVisualStyleBackColor = false;
            this.buttonBul.Click += new System.EventHandler(this.buttonBul_Click);
            // 
            // checkBoxVe
            // 
            this.checkBoxVe.AutoSize = true;
            this.checkBoxVe.Checked = true;
            this.checkBoxVe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxVe.Location = new System.Drawing.Point(394, 10);
            this.checkBoxVe.Name = "checkBoxVe";
            this.checkBoxVe.Size = new System.Drawing.Size(52, 23);
            this.checkBoxVe.TabIndex = 3;
            this.checkBoxVe.Text = " ve";
            this.checkBoxVe.UseVisualStyleBackColor = true;
            this.checkBoxVe.CheckedChanged += new System.EventHandler(this.checkBoxVe_CheckedChanged);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(452, 6);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(140, 27);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(247, 5);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(140, 27);
            this.textBoxAd.TabIndex = 2;
            // 
            // comboBoxAramaKriter
            // 
            this.comboBoxAramaKriter.AutoCompleteCustomSource.AddRange(new string[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.comboBoxAramaKriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAramaKriter.FormattingEnabled = true;
            this.comboBoxAramaKriter.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.comboBoxAramaKriter.Location = new System.Drawing.Point(111, 5);
            this.comboBoxAramaKriter.Name = "comboBoxAramaKriter";
            this.comboBoxAramaKriter.Size = new System.Drawing.Size(130, 28);
            this.comboBoxAramaKriter.TabIndex = 1;
            this.comboBoxAramaKriter.SelectedIndexChanged += new System.EventHandler(this.comboBoxAramaKriter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri";
            // 
            // textBoxOther
            // 
            this.textBoxOther.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOther.Location = new System.Drawing.Point(247, 5);
            this.textBoxOther.MaxLength = 20;
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(345, 27);
            this.textBoxOther.TabIndex = 2;
            this.textBoxOther.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOther_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TcKimlikNo,
            this.DosyaNo,
            this.Ad,
            this.Soyad,
            this.DogumYeri,
            this.DogumTarihi,
            this.BabaAdi,
            this.AnneAdi,
            this.Cinsiyet,
            this.KanGrubu,
            this.MedeniHal,
            this.Adres,
            this.Tel,
            this.KurumSicilNo,
            this.KurumAdi});
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 434);
            this.dataGridView1.TabIndex = 1;
            // 
            // TcKimlikNo
            // 
            this.TcKimlikNo.HeaderText = "TC Kimlik No";
            this.TcKimlikNo.Name = "TcKimlikNo";
            this.TcKimlikNo.ReadOnly = true;
            // 
            // DosyaNo
            // 
            this.DosyaNo.HeaderText = "Dosya No";
            this.DosyaNo.Name = "DosyaNo";
            this.DosyaNo.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            // 
            // DogumYeri
            // 
            this.DogumYeri.HeaderText = "Doğum Yeri";
            this.DogumYeri.Name = "DogumYeri";
            this.DogumYeri.ReadOnly = true;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            // 
            // BabaAdi
            // 
            this.BabaAdi.HeaderText = "Baba Adı";
            this.BabaAdi.Name = "BabaAdi";
            this.BabaAdi.ReadOnly = true;
            // 
            // AnneAdi
            // 
            this.AnneAdi.HeaderText = "Anne Adı";
            this.AnneAdi.Name = "AnneAdi";
            this.AnneAdi.ReadOnly = true;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            // 
            // KanGrubu
            // 
            this.KanGrubu.HeaderText = "Kan Grubu";
            this.KanGrubu.Name = "KanGrubu";
            this.KanGrubu.ReadOnly = true;
            // 
            // MedeniHal
            // 
            this.MedeniHal.HeaderText = "Medeni Hal";
            this.MedeniHal.Name = "MedeniHal";
            this.MedeniHal.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // KurumSicilNo
            // 
            this.KurumSicilNo.HeaderText = "Kurum Sicil No";
            this.KurumSicilNo.Name = "KurumSicilNo";
            this.KurumSicilNo.ReadOnly = true;
            // 
            // KurumAdi
            // 
            this.KurumAdi.HeaderText = "Kurum Adı";
            this.KurumAdi.Name = "KurumAdi";
            this.KurumAdi.ReadOnly = true;
            // 
            // DosyaBulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(718, 519);
            this.MinimumSize = new System.Drawing.Size(718, 519);
            this.Name = "DosyaBulForm";
            this.Text = "<Dosya Bul>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DosyaBulForm_FormClosing);
            this.Shown += new System.EventHandler(this.DosyaBulForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBul;
        private System.Windows.Forms.CheckBox checkBoxVe;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.ComboBox comboBoxAramaKriter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcKimlikNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosyaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumYeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BabaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnneAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanGrubu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedeniHal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn KurumSicilNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KurumAdi;
    }
}