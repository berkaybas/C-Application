using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }

        private int kartpuani = 0;
        private bool mc1 = true;
        private bool mc2 = true;
        private bool mc3 = true;
        private bool mc4 = true;
        private bool pc1 = true;
        private bool pc2 = true;
        private bool pc3 = true;
        private bool pc4 = true;

        private string[] kartlar =
        {
            "karoas", "karo2", "karo3", "karo4", "karo5", "karo6", "karo7", "karo8", "karo9", "karo10", "karobacak",
            "karokız", "karopapaz",
            "kupaas", "kupa2", "kupa3", "kupa4", "kupa5", "kupa6", "kupa7", "kupa8", "kupa9", "kupa10",
            "kupabacak", "kupakız", "kupapapaz",
            "macaas", "maca2", "maca3", "maca4", "maca5", "maca6", "maca7", "maca8", "maca9", "maca10", "macabacak",
            "macakız", "macapapaz",
            "sinekas", "sinek2", "sinek3", "sinek4", "sinek5", "sinek6", "sinek7", "sinek8", "sinek9", "sinek10",
            "sinekbacak", "sinekkız", "sinekpapaz"
        };

        private void BlackJack_Load(object sender, EventArgs e)
        {
            
        }

        void Bitti()
        {
            btnStart.Enabled = true;
            btnPass.Enabled = false;
            btnTakeCard.Enabled = false;

            myCard1.Image = null;
            myCard2.Image = null;
            myCard3.Image = null;
            myCard4.Image = null;

            pcCard1.Image = null;
            pcCard2.Image = null;
            pcCard3.Image = null;
            pcCard4.Image = null;

            kartpuani = 0;
            lblmyPoint.Text = "0";
            lblPcPoint.Text = "0";

            mc1 = true;
            mc2 = true;
            mc3 = true;
            mc4 = true;
            pc1 = true;
            pc2 = true;
            pc3 = true;
            pc4 = true;
        }

        void IlkAcilis()
        {
            myTurn();

            youTurn();

            myTurn();
            if (Convert.ToInt32(lblmyPoint.Text) + kartpuani == 21)
            {
                MessageBox.Show("Oyuncu Kazandı");
                Bitti();
            }
        }

        void KartCek(PictureBox Tbox)
        {
            Random random = new Random();
            int index = random.Next(0, kartlar.Length);
            Tbox.ImageLocation = $"C:\\Users\\asus\\Desktop\\deste\\{kartlar[index].ToString()}.png";
            PuanHesapla(index);
        }

        void PuanHesapla(int puan)
        {
            if (puan == 0 || puan == 13 || puan == 26 || puan == 39)
            {
                kartpuani = 1;
            }
            else if (puan == 1 || puan == 14 || puan == 27 || puan == 40)
            {
                kartpuani = 2;
            }
            else if (puan == 2 || puan == 15 || puan == 28 || puan == 41)
            {
                kartpuani = 3;
            }
            else if (puan == 3 || puan == 16 || puan == 29 || puan == 42)
            {
                kartpuani = 4;
            }
            else if (puan == 4 || puan == 17 || puan == 30 || puan == 43)
            {
                kartpuani = 5;
            }
            else if (puan == 5 || puan == 18 || puan == 31 || puan == 44)
            {
                kartpuani = 6;
            }
            else if (puan == 6 || puan == 19 || puan == 32 || puan == 45)
            {
                kartpuani = 7;
            }
            else if (puan == 7 || puan == 20 || puan == 33 || puan == 46)
            {
                kartpuani = 8;
            }
            else if (puan == 8 || puan == 21 || puan == 34 || puan == 47)
            {
                kartpuani = 9;
            }
            else if (puan == 9 || puan == 22 || puan == 35 || puan == 48)
            {
                kartpuani = 10;
            }
            else if (puan == 10 || puan == 23 || puan == 36 || puan == 49)
            {
                kartpuani = 10;
            }
            else if (puan == 11 || puan == 24 || puan == 37 || puan == 50)
            {
                kartpuani = 10;
            }
            else if (puan == 12 || puan == 25 || puan == 38 || puan == 51)
            {
                kartpuani = 10;
            }
        }

        void myTurn()
        {
            if (mc1)
            {
                KartCek(myCard1);
                lblmyPoint.Text = (Convert.ToInt32(lblmyPoint.Text) + kartpuani).ToString();
                mc1 = false;
            }
            else if (mc2)
            {
                KartCek(myCard2);
                lblmyPoint.Text = (Convert.ToInt32(lblmyPoint.Text) + kartpuani).ToString();
                mc2 = false;
            }
            else if (mc3)
            {
                KartCek(myCard3);
                lblmyPoint.Text = (Convert.ToInt32(lblmyPoint.Text) + kartpuani).ToString();
                mc3 = false;
            }
            else if (mc4)
            {
                KartCek(myCard4);
                lblmyPoint.Text = (Convert.ToInt32(lblmyPoint.Text) + kartpuani).ToString();
                mc4 = false;
            }
        }

        void youTurn()
        {
            if (pc1)
            {
                KartCek(pcCard1);
                lblPcPoint.Text = (Convert.ToInt32(lblPcPoint.Text) + kartpuani).ToString();
                pc1 = false;
            }
            else if (pc2)
            {
                KartCek(pcCard2);
                lblPcPoint.Text = (Convert.ToInt32(lblPcPoint.Text) + kartpuani).ToString();
                pc2 = false;
            }
            else if (pc3)
            {
                KartCek(pcCard3);
                lblPcPoint.Text = (Convert.ToInt32(lblPcPoint.Text) + kartpuani).ToString();
                pc3 = false;
            }
            else if (pc4)
            {
                KartCek(pcCard4);
                lblPcPoint.Text = (Convert.ToInt32(lblPcPoint.Text) + kartpuani).ToString();
                pc4 = false;
            }
        }

        private void btnTakeCard_Click(object sender, EventArgs e)
        {
            myTurn();
            if (Convert.ToInt32(lblmyPoint.Text) > 21)
            {
                MessageBox.Show("Kasa Kazandı");
                Bitti();
            }
            else if (Convert.ToInt32(lblmyPoint.Text) == 21)
            {
                MessageBox.Show("Oyuncu Kazandı");
                Bitti();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnTakeCard.Enabled = true;
            btnPass.Enabled = true;
            btnStart.Enabled = false;
            IlkAcilis();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            youTurn();
            if (Convert.ToInt32(lblPcPoint.Text) > 21)
            {
                MessageBox.Show("Oyuncu Kazandı");
                Bitti();
            }
            else if (Convert.ToInt32(lblPcPoint.Text) == 21)
            {
                MessageBox.Show("Kasa Kazandı");
                Bitti();
            }
            else if (Convert.ToInt32(lblPcPoint.Text) > Convert.ToInt32(lblmyPoint.Text))
            {
                MessageBox.Show("Kasa Kazandı");
                Bitti();
            }
        }
    }
}
