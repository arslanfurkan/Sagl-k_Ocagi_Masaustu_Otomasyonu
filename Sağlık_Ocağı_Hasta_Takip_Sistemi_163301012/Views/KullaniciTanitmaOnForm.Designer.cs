namespace Sağlık_Ocağı_Hasta_Takip_Sistemi_163301012.Views
{
    partial class KullaniciTanitmaOnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKullanicilar = new System.Windows.Forms.ComboBox();
            this.buttonKullaniciEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 54);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHATS - Kullanıcı Tanıtma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Kodu ";
            // 
            // comboBoxKullanicilar
            // 
            this.comboBoxKullanicilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKullanicilar.FormattingEnabled = true;
            this.comboBoxKullanicilar.Location = new System.Drawing.Point(177, 67);
            this.comboBoxKullanicilar.Name = "comboBoxKullanicilar";
            this.comboBoxKullanicilar.Size = new System.Drawing.Size(175, 24);
            this.comboBoxKullanicilar.TabIndex = 9;
            this.comboBoxKullanicilar.SelectedIndexChanged += new System.EventHandler(this.comboBoxKullanicilar_SelectedIndexChanged);
            this.comboBoxKullanicilar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKullanicilar_KeyDown);
            // 
            // buttonKullaniciEkle
            // 
            this.buttonKullaniciEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonKullaniciEkle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKullaniciEkle.ForeColor = System.Drawing.Color.Green;
            this.buttonKullaniciEkle.Location = new System.Drawing.Point(106, 111);
            this.buttonKullaniciEkle.Name = "buttonKullaniciEkle";
            this.buttonKullaniciEkle.Size = new System.Drawing.Size(152, 38);
            this.buttonKullaniciEkle.TabIndex = 10;
            this.buttonKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.buttonKullaniciEkle.UseVisualStyleBackColor = false;
            this.buttonKullaniciEkle.Click += new System.EventHandler(this.buttonKullaniciEkle_Click);
            // 
            // KullaniciTanitmaOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 161);
            this.Controls.Add(this.buttonKullaniciEkle);
            this.Controls.Add(this.comboBoxKullanicilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciTanitmaOnForm";
            this.Text = "KullaniciTanitmaOnForm";
            this.Load += new System.EventHandler(this.KullaniciTanitmaOnForm_Load);
            this.Shown += new System.EventHandler(this.KullaniciTanitmaOnForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKullanicilar;
        private System.Windows.Forms.Button buttonKullaniciEkle;
    }
}