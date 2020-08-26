using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            tbxSifreli.Clear();
            string metin = tbxNormal.Text;
            byte[] veriDizisi = ASCIIEncoding.ASCII.GetBytes(metin);
            string sifreli = Convert.ToBase64String(veriDizisi);
            tbxSifreli.Text = sifreli;
        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            tbxNormal.Clear();
            string metincoz = tbxSifreli.Text;
            byte[] veriDiziCoz = Convert.FromBase64String(metincoz);
            string cozulen = ASCIIEncoding.ASCII.GetString(veriDiziCoz);
            tbxNormal.Text = cozulen;
        }

       
        private void btnRastgele_Click(object sender, EventArgs e)
        {
            int[] dizi = {33,35,36,38,43,48,49,50,51,52,53,54,55,56,57,63,64
            ,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86
            ,87,88,89,90,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113
            ,114,115,116,117,118,119,120,121,122};
            
            tbxRastgele.Clear();
            Random rnd = new Random();
            int d = rnd.Next(11, 19);
            for (int a = 0; a < d; a++)
            {
                int i = rnd.Next(dizi.Count());
                char krt = Convert.ToChar(dizi[i]);
                tbxRastgele.Text += krt.ToString();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (tbxRastgele.Text != null)
            {
                Clipboard.Clear();
                Clipboard.SetText(tbxRastgele.Text);
            }           
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {
            if (tbxSifreli.Text != null)
            {
                Clipboard.Clear();
                Clipboard.SetText(tbxSifreli.Text);
            }
        }
    }
}
