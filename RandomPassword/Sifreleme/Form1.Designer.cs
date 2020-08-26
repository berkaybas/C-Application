namespace Sifreleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNormal = new System.Windows.Forms.TextBox();
            this.tbxSifreli = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.tbxRastgele = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCopy2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSifrele
            // 
            this.btnSifrele.BackColor = System.Drawing.Color.Black;
            this.btnSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.ForeColor = System.Drawing.Color.Yellow;
            this.btnSifrele.Location = new System.Drawing.Point(147, 116);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(119, 57);
            this.btnSifrele.TabIndex = 0;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = false;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnSifreCoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreCoz.ForeColor = System.Drawing.Color.Yellow;
            this.btnSifreCoz.Location = new System.Drawing.Point(272, 116);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(107, 57);
            this.btnSifreCoz.TabIndex = 1;
            this.btnSifreCoz.Text = "Şifre Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = false;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base64";
            // 
            // tbxNormal
            // 
            this.tbxNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNormal.Location = new System.Drawing.Point(106, 41);
            this.tbxNormal.Name = "tbxNormal";
            this.tbxNormal.Size = new System.Drawing.Size(273, 30);
            this.tbxNormal.TabIndex = 4;
            this.tbxNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxSifreli
            // 
            this.tbxSifreli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSifreli.Location = new System.Drawing.Point(106, 80);
            this.tbxSifreli.Name = "tbxSifreli";
            this.tbxSifreli.Size = new System.Drawing.Size(273, 30);
            this.tbxSifreli.TabIndex = 5;
            this.tbxSifreli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopy2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxNormal);
            this.groupBox1.Controls.Add(this.tbxSifreli);
            this.groupBox1.Controls.Add(this.btnSifrele);
            this.groupBox1.Controls.Add(this.btnSifreCoz);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 247);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToBase64";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(14, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BASE64 KISMINA GİRİLEN KELİMELERİN NORMAL KARŞILIĞINI VERİR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(13, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NORMAL KISMINA GİRİLEN KELİMELERİN 64 BİTLİK KARŞILIĞINI VERİR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopy);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnRastgele);
            this.groupBox3.Controls.Add(this.tbxRastgele);
            this.groupBox3.Location = new System.Drawing.Point(410, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 247);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rastgele Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "RASTGELE KARAKTER DİZİSİ VERİR";
            // 
            // btnRastgele
            // 
            this.btnRastgele.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnRastgele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRastgele.ForeColor = System.Drawing.Color.Yellow;
            this.btnRastgele.Location = new System.Drawing.Point(9, 116);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(220, 57);
            this.btnRastgele.TabIndex = 1;
            this.btnRastgele.Text = "Rastgele Şifre Oluştur";
            this.btnRastgele.UseVisualStyleBackColor = false;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // tbxRastgele
            // 
            this.tbxRastgele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxRastgele.Location = new System.Drawing.Point(6, 79);
            this.tbxRastgele.Name = "tbxRastgele";
            this.tbxRastgele.Size = new System.Drawing.Size(380, 29);
            this.tbxRastgele.TabIndex = 0;
            this.tbxRastgele.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopy.ForeColor = System.Drawing.Color.Yellow;
            this.btnCopy.Location = new System.Drawing.Point(270, 135);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(121, 38);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "KOPYALA";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCopy2
            // 
            this.btnCopy2.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnCopy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopy2.ForeColor = System.Drawing.Color.Yellow;
            this.btnCopy2.Location = new System.Drawing.Point(16, 135);
            this.btnCopy2.Name = "btnCopy2";
            this.btnCopy2.Size = new System.Drawing.Size(125, 38);
            this.btnCopy2.TabIndex = 10;
            this.btnCopy2.Text = "KOPYALA";
            this.btnCopy2.UseVisualStyleBackColor = false;
            this.btnCopy2.Click += new System.EventHandler(this.btnCopy2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(813, 315);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnSifreCoz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNormal;
        private System.Windows.Forms.TextBox tbxSifreli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.TextBox tbxRastgele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCopy2;
    }
}

