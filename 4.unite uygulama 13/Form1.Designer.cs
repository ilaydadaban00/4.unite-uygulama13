namespace _4.unite_uygulama_13
{
    partial class Form1
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
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNumaraN = new System.Windows.Forms.TextBox();
            this.txtAdSoyadN = new System.Windows.Forms.TextBox();
            this.btnSAyi = new System.Windows.Forms.Button();
            this.btnMetin = new System.Windows.Forms.Button();
            this.btnnesneEkle = new System.Windows.Forms.Button();
            this.lbSayi = new System.Windows.Forms.ListBox();
            this.lbMetin = new System.Windows.Forms.ListBox();
            this.lbNesne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(70, 24);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(264, 24);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtNumaraN
            // 
            this.txtNumaraN.Location = new System.Drawing.Point(466, 12);
            this.txtNumaraN.Name = "txtNumaraN";
            this.txtNumaraN.Size = new System.Drawing.Size(100, 20);
            this.txtNumaraN.TabIndex = 2;
            // 
            // txtAdSoyadN
            // 
            this.txtAdSoyadN.Location = new System.Drawing.Point(466, 60);
            this.txtAdSoyadN.Name = "txtAdSoyadN";
            this.txtAdSoyadN.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyadN.TabIndex = 3;
            // 
            // btnSAyi
            // 
            this.btnSAyi.Location = new System.Drawing.Point(70, 59);
            this.btnSAyi.Name = "btnSAyi";
            this.btnSAyi.Size = new System.Drawing.Size(75, 23);
            this.btnSAyi.TabIndex = 4;
            this.btnSAyi.Text = "sayi ekle";
            this.btnSAyi.UseVisualStyleBackColor = true;
            this.btnSAyi.Click += new System.EventHandler(this.btnSAyi_Click);
            // 
            // btnMetin
            // 
            this.btnMetin.Location = new System.Drawing.Point(264, 69);
            this.btnMetin.Name = "btnMetin";
            this.btnMetin.Size = new System.Drawing.Size(75, 23);
            this.btnMetin.TabIndex = 5;
            this.btnMetin.Text = "metin ekle";
            this.btnMetin.UseVisualStyleBackColor = true;
            this.btnMetin.Click += new System.EventHandler(this.btnMetin_Click);
            // 
            // btnnesneEkle
            // 
            this.btnnesneEkle.Location = new System.Drawing.Point(466, 109);
            this.btnnesneEkle.Name = "btnnesneEkle";
            this.btnnesneEkle.Size = new System.Drawing.Size(75, 23);
            this.btnnesneEkle.TabIndex = 6;
            this.btnnesneEkle.Text = "nesneEkle";
            this.btnnesneEkle.UseVisualStyleBackColor = true;
            this.btnnesneEkle.Click += new System.EventHandler(this.btnnesneEkle_Click);
            // 
            // lbSayi
            // 
            this.lbSayi.FormattingEnabled = true;
            this.lbSayi.Location = new System.Drawing.Point(50, 151);
            this.lbSayi.Name = "lbSayi";
            this.lbSayi.Size = new System.Drawing.Size(120, 199);
            this.lbSayi.TabIndex = 7;
            // 
            // lbMetin
            // 
            this.lbMetin.FormattingEnabled = true;
            this.lbMetin.Location = new System.Drawing.Point(244, 151);
            this.lbMetin.Name = "lbMetin";
            this.lbMetin.Size = new System.Drawing.Size(120, 199);
            this.lbMetin.TabIndex = 8;
            // 
            // lbNesne
            // 
            this.lbNesne.FormattingEnabled = true;
            this.lbNesne.Location = new System.Drawing.Point(446, 151);
            this.lbNesne.Name = "lbNesne";
            this.lbNesne.Size = new System.Drawing.Size(120, 199);
            this.lbNesne.TabIndex = 9;
            this.lbNesne.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNesne);
            this.Controls.Add(this.lbMetin);
            this.Controls.Add(this.lbSayi);
            this.Controls.Add(this.btnnesneEkle);
            this.Controls.Add(this.btnMetin);
            this.Controls.Add(this.btnSAyi);
            this.Controls.Add(this.txtAdSoyadN);
            this.Controls.Add(this.txtNumaraN);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtNumara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNumaraN;
        private System.Windows.Forms.TextBox txtAdSoyadN;
        private System.Windows.Forms.Button btnSAyi;
        private System.Windows.Forms.Button btnMetin;
        private System.Windows.Forms.Button btnnesneEkle;
        private System.Windows.Forms.ListBox lbSayi;
        private System.Windows.Forms.ListBox lbMetin;
        private System.Windows.Forms.ListBox lbNesne;
    }
}

