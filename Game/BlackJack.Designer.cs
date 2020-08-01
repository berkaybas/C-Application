namespace Game
{
    partial class BlackJack
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
            this.btnTakeCard = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.myCard1 = new System.Windows.Forms.PictureBox();
            this.myCard2 = new System.Windows.Forms.PictureBox();
            this.myCard3 = new System.Windows.Forms.PictureBox();
            this.myCard4 = new System.Windows.Forms.PictureBox();
            this.pcCard1 = new System.Windows.Forms.PictureBox();
            this.pcCard2 = new System.Windows.Forms.PictureBox();
            this.pcCard3 = new System.Windows.Forms.PictureBox();
            this.pcCard4 = new System.Windows.Forms.PictureBox();
            this.lblmyPoint = new System.Windows.Forms.Label();
            this.lblPcPoint = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTakeCard
            // 
            this.btnTakeCard.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTakeCard.Enabled = false;
            this.btnTakeCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakeCard.ForeColor = System.Drawing.Color.Yellow;
            this.btnTakeCard.Location = new System.Drawing.Point(178, 270);
            this.btnTakeCard.Name = "btnTakeCard";
            this.btnTakeCard.Size = new System.Drawing.Size(141, 40);
            this.btnTakeCard.TabIndex = 0;
            this.btnTakeCard.Text = "Kart Çek";
            this.btnTakeCard.UseVisualStyleBackColor = false;
            this.btnTakeCard.Click += new System.EventHandler(this.btnTakeCard_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPass.Enabled = false;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPass.ForeColor = System.Drawing.Color.Yellow;
            this.btnPass.Location = new System.Drawing.Point(371, 270);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(141, 40);
            this.btnPass.TabIndex = 1;
            this.btnPass.Text = "Pas";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // myCard1
            // 
            this.myCard1.Location = new System.Drawing.Point(178, 151);
            this.myCard1.Name = "myCard1";
            this.myCard1.Size = new System.Drawing.Size(79, 96);
            this.myCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCard1.TabIndex = 2;
            this.myCard1.TabStop = false;
            // 
            // myCard2
            // 
            this.myCard2.Location = new System.Drawing.Point(263, 151);
            this.myCard2.Name = "myCard2";
            this.myCard2.Size = new System.Drawing.Size(79, 96);
            this.myCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCard2.TabIndex = 3;
            this.myCard2.TabStop = false;
            // 
            // myCard3
            // 
            this.myCard3.Location = new System.Drawing.Point(348, 151);
            this.myCard3.Name = "myCard3";
            this.myCard3.Size = new System.Drawing.Size(79, 96);
            this.myCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCard3.TabIndex = 4;
            this.myCard3.TabStop = false;
            // 
            // myCard4
            // 
            this.myCard4.Location = new System.Drawing.Point(433, 151);
            this.myCard4.Name = "myCard4";
            this.myCard4.Size = new System.Drawing.Size(79, 96);
            this.myCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCard4.TabIndex = 5;
            this.myCard4.TabStop = false;
            // 
            // pcCard1
            // 
            this.pcCard1.Location = new System.Drawing.Point(178, 12);
            this.pcCard1.Name = "pcCard1";
            this.pcCard1.Size = new System.Drawing.Size(79, 96);
            this.pcCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCard1.TabIndex = 6;
            this.pcCard1.TabStop = false;
            // 
            // pcCard2
            // 
            this.pcCard2.Location = new System.Drawing.Point(263, 12);
            this.pcCard2.Name = "pcCard2";
            this.pcCard2.Size = new System.Drawing.Size(79, 96);
            this.pcCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCard2.TabIndex = 7;
            this.pcCard2.TabStop = false;
            // 
            // pcCard3
            // 
            this.pcCard3.Location = new System.Drawing.Point(348, 12);
            this.pcCard3.Name = "pcCard3";
            this.pcCard3.Size = new System.Drawing.Size(79, 96);
            this.pcCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCard3.TabIndex = 8;
            this.pcCard3.TabStop = false;
            // 
            // pcCard4
            // 
            this.pcCard4.Location = new System.Drawing.Point(433, 12);
            this.pcCard4.Name = "pcCard4";
            this.pcCard4.Size = new System.Drawing.Size(79, 96);
            this.pcCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcCard4.TabIndex = 9;
            this.pcCard4.TabStop = false;
            // 
            // lblmyPoint
            // 
            this.lblmyPoint.AutoSize = true;
            this.lblmyPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmyPoint.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblmyPoint.Location = new System.Drawing.Point(144, 151);
            this.lblmyPoint.Name = "lblmyPoint";
            this.lblmyPoint.Size = new System.Drawing.Size(18, 20);
            this.lblmyPoint.TabIndex = 10;
            this.lblmyPoint.Text = "0";
            // 
            // lblPcPoint
            // 
            this.lblPcPoint.AutoSize = true;
            this.lblPcPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPcPoint.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblPcPoint.Location = new System.Drawing.Point(144, 88);
            this.lblPcPoint.Name = "lblPcPoint";
            this.lblPcPoint.Size = new System.Drawing.Size(18, 20);
            this.lblPcPoint.TabIndex = 11;
            this.lblPcPoint.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkCyan;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Location = new System.Drawing.Point(547, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 40);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Oyunu Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(747, 322);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPcPoint);
            this.Controls.Add(this.lblmyPoint);
            this.Controls.Add(this.pcCard4);
            this.Controls.Add(this.pcCard3);
            this.Controls.Add(this.pcCard2);
            this.Controls.Add(this.pcCard1);
            this.Controls.Add(this.myCard4);
            this.Controls.Add(this.myCard3);
            this.Controls.Add(this.myCard2);
            this.Controls.Add(this.myCard1);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnTakeCard);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCard4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakeCard;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.PictureBox myCard1;
        private System.Windows.Forms.PictureBox myCard2;
        private System.Windows.Forms.PictureBox myCard3;
        private System.Windows.Forms.PictureBox myCard4;
        private System.Windows.Forms.PictureBox pcCard1;
        private System.Windows.Forms.PictureBox pcCard2;
        private System.Windows.Forms.PictureBox pcCard3;
        private System.Windows.Forms.PictureBox pcCard4;
        private System.Windows.Forms.Label lblmyPoint;
        private System.Windows.Forms.Label lblPcPoint;
        private System.Windows.Forms.Button btnStart;
    }
}