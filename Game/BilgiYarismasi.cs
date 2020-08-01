using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class BilgiYarismasi : Form
    {
        public BilgiYarismasi()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Sorular;integrated security=true");
        private int now = 5;
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = true;
            YeniSoru();
        }

        private void EnableFalse()
        {
            btnB.Enabled = false;
            btnA.Enabled = false;
            btnD.Enabled = false;
            btnC.Enabled = false;
        }

        private void EnableTrue()
        {
            btnB.Enabled = true;
            btnA.Enabled = true;
            btnD.Enabled = true;
            btnC.Enabled = true;
        }

        private void BitirmeKontrol()
        {
            if (lblNow.Text == "0")
            {
                btnNext.Text = "Bitir";
            }
        }
        private void YeniSoru()
        {
            if (now == 0)
            {
                //EnableFalse();
                btnNext.Enabled = false;
                btnRestart.Enabled = true;
                MessageBox.Show("Sorular bitti yeniden başlamak için 'Yeniden Başla' butonuna basınız.");
            }
            else
            {
                EnableTrue();

                now--;
                lblNow.Text = now.ToString();

                bool kontrol = true;
                while (true)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("select * from Sorular order by NEWID()", sqlConnection);
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dataReader["Soru"].ToString() != textBox1.Text)
                        {
                            btnA.Text = dataReader["A"].ToString();
                            btnB.Text = dataReader["B"].ToString();
                            btnC.Text = dataReader["C"].ToString();
                            btnD.Text = dataReader["D"].ToString();
                            textBox1.Text = dataReader["Soru"].ToString();
                            lblDogru.Text = dataReader["Dogru"].ToString();

                            sqlConnection.Close();
                            kontrol = false;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }

                ColorReset();
            }
        }

        private void ColorReset()
        {
            btnA.BackColor = Color.Yellow;
            btnB.BackColor = Color.Yellow;
            btnC.BackColor = Color.Yellow;
            btnD.BackColor = Color.Yellow;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == lblDogru.Text)
            {
                BitirmeKontrol();
                lblTruePoint.Text = (Convert.ToInt32(lblTruePoint.Text) + 1).ToString();
                btnA.BackColor = Color.LawnGreen;
                EnableFalse();
            }
            else
            {
                BitirmeKontrol();
                lblFalsePoint.Text = (Convert.ToInt32(lblFalsePoint.Text) + 1).ToString();
                btnA.BackColor = Color.Red;
                EnableFalse();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == lblDogru.Text)
            {
                BitirmeKontrol();
                lblTruePoint.Text = (Convert.ToInt32(lblTruePoint.Text) + 1).ToString();
                btnB.BackColor = Color.LawnGreen;
                EnableFalse();
            }
            else
            {
                BitirmeKontrol();
                lblFalsePoint.Text = (Convert.ToInt32(lblFalsePoint.Text) + 1).ToString();
                btnB.BackColor = Color.Red;
                EnableFalse();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == lblDogru.Text)
            {
                BitirmeKontrol();
                lblTruePoint.Text = (Convert.ToInt32(lblTruePoint.Text) + 1).ToString();
                btnC.BackColor = Color.LawnGreen;
                EnableFalse();
            }
            else
            {
                BitirmeKontrol();
                lblFalsePoint.Text = (Convert.ToInt32(lblFalsePoint.Text) + 1).ToString();
                btnC.BackColor = Color.Red;
                EnableFalse();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == lblDogru.Text)
            {
                BitirmeKontrol();
                lblTruePoint.Text = (Convert.ToInt32(lblTruePoint.Text) + 1).ToString();
                btnD.BackColor = Color.LawnGreen;
                EnableFalse();
            }
            else
            {
                BitirmeKontrol();
                lblFalsePoint.Text = (Convert.ToInt32(lblFalsePoint.Text) + 1).ToString();
                btnD.BackColor = Color.Red;
                EnableFalse();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            YeniSoru();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            now = 5;
            lblTruePoint.Text = "0";
            lblFalsePoint.Text = "0";
            btnNext.Text = "Yeni Soru";
            btnNext.Enabled = true;
            btnRestart.Enabled = false;
            YeniSoru();
        }
    }
}
