namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views
{
    partial class TaburcuForm
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
            this.dateTimePickerCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOdemeSekli = new System.Windows.Forms.ComboBox();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.textBoxDosyaNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVazgec = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerCikisTarihi);
            this.panel1.Controls.Add(this.dateTimePickerSevkTarihi);
            this.panel1.Controls.Add(this.comboBoxOdemeSekli);
            this.panel1.Controls.Add(this.textBoxToplamTutar);
            this.panel1.Controls.Add(this.textBoxDosyaNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 187);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerCikisTarihi
            // 
            this.dateTimePickerCikisTarihi.Enabled = false;
            this.dateTimePickerCikisTarihi.Location = new System.Drawing.Point(121, 78);
            this.dateTimePickerCikisTarihi.Name = "dateTimePickerCikisTarihi";
            this.dateTimePickerCikisTarihi.Size = new System.Drawing.Size(247, 25);
            this.dateTimePickerCikisTarihi.TabIndex = 3;
            // 
            // dateTimePickerSevkTarihi
            // 
            this.dateTimePickerSevkTarihi.Enabled = false;
            this.dateTimePickerSevkTarihi.Location = new System.Drawing.Point(121, 47);
            this.dateTimePickerSevkTarihi.Name = "dateTimePickerSevkTarihi";
            this.dateTimePickerSevkTarihi.Size = new System.Drawing.Size(247, 25);
            this.dateTimePickerSevkTarihi.TabIndex = 3;
            // 
            // comboBoxOdemeSekli
            // 
            this.comboBoxOdemeSekli.AutoCompleteCustomSource.AddRange(new string[] {
            "Nakit",
            "Kredi Kartı - taksitli",
            "Kredi Kartı - tek çekim",
            "Çek",
            "Senet"});
            this.comboBoxOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdemeSekli.FormattingEnabled = true;
            this.comboBoxOdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı - taksitli",
            "Kredi Kartı - tek çekim",
            "Çek",
            "Senet"});
            this.comboBoxOdemeSekli.Location = new System.Drawing.Point(121, 109);
            this.comboBoxOdemeSekli.Name = "comboBoxOdemeSekli";
            this.comboBoxOdemeSekli.Size = new System.Drawing.Size(248, 25);
            this.comboBoxOdemeSekli.TabIndex = 2;
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.Enabled = false;
            this.textBoxToplamTutar.Location = new System.Drawing.Point(121, 143);
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.Size = new System.Drawing.Size(248, 25);
            this.textBoxToplamTutar.TabIndex = 1;
            // 
            // textBoxDosyaNo
            // 
            this.textBoxDosyaNo.Enabled = false;
            this.textBoxDosyaNo.Location = new System.Drawing.Point(121, 16);
            this.textBoxDosyaNo.Name = "textBoxDosyaNo";
            this.textBoxDosyaNo.Size = new System.Drawing.Size(248, 25);
            this.textBoxDosyaNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Toplam Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödeme Şekli :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Çıkış Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sevk Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No :";
            // 
            // buttonVazgec
            // 
            this.buttonVazgec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVazgec.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVazgec.Location = new System.Drawing.Point(13, 198);
            this.buttonVazgec.Name = "buttonVazgec";
            this.buttonVazgec.Size = new System.Drawing.Size(143, 48);
            this.buttonVazgec.TabIndex = 1;
            this.buttonVazgec.Text = "Vazgeç";
            this.buttonVazgec.UseVisualStyleBackColor = false;
            this.buttonVazgec.Click += new System.EventHandler(this.buttonVazgec_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonKaydet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Location = new System.Drawing.Point(246, 198);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(143, 48);
            this.buttonKaydet.TabIndex = 1;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // TaburcuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 258);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonVazgec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(412, 305);
            this.MinimumSize = new System.Drawing.Size(412, 305);
            this.Name = "TaburcuForm";
            this.Text = "SOHATS - Taburcu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaburcuForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVazgec;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOdemeSekli;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.TextBox textBoxDosyaNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerSevkTarihi;
    }
}