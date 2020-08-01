namespace Game
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
            this.btnBilgiYarismasi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBlackJack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBilgiYarismasi
            // 
            this.btnBilgiYarismasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBilgiYarismasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiYarismasi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBilgiYarismasi.Location = new System.Drawing.Point(555, 12);
            this.btnBilgiYarismasi.Name = "btnBilgiYarismasi";
            this.btnBilgiYarismasi.Size = new System.Drawing.Size(119, 65);
            this.btnBilgiYarismasi.TabIndex = 0;
            this.btnBilgiYarismasi.Text = "Bilgi Yarışması";
            this.btnBilgiYarismasi.UseVisualStyleBackColor = false;
            this.btnBilgiYarismasi.Click += new System.EventHandler(this.btnBilgiYarismasi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBlackJack
            // 
            this.btnBlackJack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBlackJack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBlackJack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlackJack.Location = new System.Drawing.Point(385, 12);
            this.btnBlackJack.Name = "btnBlackJack";
            this.btnBlackJack.Size = new System.Drawing.Size(119, 65);
            this.btnBlackJack.TabIndex = 2;
            this.btnBlackJack.Text = "BlackJack 21";
            this.btnBlackJack.UseVisualStyleBackColor = false;
            this.btnBlackJack.Click += new System.EventHandler(this.btnBlackJack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 255);
            this.Controls.Add(this.btnBlackJack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBilgiYarismasi);
            this.Name = "Form1";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiYarismasi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBlackJack;
    }
}

