namespace Game
{
    partial class BilgiYarismasi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblTruePoint = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNow = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFalsePoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 116);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Soru";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Yellow;
            this.btnA.Enabled = false;
            this.btnA.Location = new System.Drawing.Point(12, 147);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(130, 41);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Yellow;
            this.btnB.Enabled = false;
            this.btnB.Location = new System.Drawing.Point(12, 203);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(130, 41);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Yellow;
            this.btnC.Enabled = false;
            this.btnC.Location = new System.Drawing.Point(302, 147);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(130, 41);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Yellow;
            this.btnD.Enabled = false;
            this.btnD.Location = new System.Drawing.Point(302, 203);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(130, 41);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LawnGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(661, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 41);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "BAŞLA";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuan.Location = new System.Drawing.Point(484, 147);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(68, 20);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "Doğru :";
            // 
            // lblTruePoint
            // 
            this.lblTruePoint.AutoSize = true;
            this.lblTruePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTruePoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTruePoint.Location = new System.Drawing.Point(599, 147);
            this.lblTruePoint.Name = "lblTruePoint";
            this.lblTruePoint.Size = new System.Drawing.Size(19, 20);
            this.lblTruePoint.TabIndex = 7;
            this.lblTruePoint.Text = "0";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogru.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDogru.Location = new System.Drawing.Point(733, 274);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(58, 20);
            this.lblDogru.TabIndex = 8;
            this.lblDogru.Text = "Doğru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(484, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kalan Soru";
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNow.Location = new System.Drawing.Point(524, 57);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(19, 20);
            this.lblNow.TabIndex = 10;
            this.lblNow.Text = "5";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(170, 258);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 33);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Yeni Soru";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFalsePoint
            // 
            this.lblFalsePoint.AutoSize = true;
            this.lblFalsePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFalsePoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFalsePoint.Location = new System.Drawing.Point(599, 179);
            this.lblFalsePoint.Name = "lblFalsePoint";
            this.lblFalsePoint.Size = new System.Drawing.Size(19, 20);
            this.lblFalsePoint.TabIndex = 13;
            this.lblFalsePoint.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(484, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yanlış :";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnRestart.Enabled = false;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(661, 258);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(130, 33);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Yeniden Başla";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // BilgiYarismasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(803, 303);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblFalsePoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblTruePoint);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.textBox1);
            this.Name = "BilgiYarismasi";
            this.Text = "BilgiYarismasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblTruePoint;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFalsePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestart;
    }
}