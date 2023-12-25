using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_metotları1_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyut_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToUpper();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text;
            lblMesaj.Text = mesaj.ToLower();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Toplam Karakter:" + lblMesaj.Text.Length + "karakter vardır.");
            string mesaj = $" Toplam  {lblMesaj.Text.Length} karakter vardır.";
            MessageBox.Show(mesaj);
        }

        private void btnmesajVer_Click(object sender, EventArgs e)
        {
           lblMesaj.Text=$"merhaba dünya , ben {txtMesaj.Text}!";
        }

        private void btnBirlestir_Click(object sender, EventArgs e)
        {
            string mesaj1 = "merhaba dünya";
            string mesaj2 = "ben melisa";

            //string yeniMesaj = mesaj1 + mesaj2;
            string yeniMesaj = string.Concat(mesaj1,mesaj2);
            lblMesaj.Text = yeniMesaj;
        }

        private void btnSiraGetir_Click(object sender, EventArgs e)
        {
            // 5. sıradaki harfi getir.

            string mesaj = lblMesaj.Text;
            // mesaj[4] //char türündedir.

            MessageBox.Show($"6. sıradaki harf {mesaj[5]}");
           
        }

        private void btnKacis1_Click(object sender, EventArgs e)
        {
            string mesaj = "merhaba ben \"melisa\" . \r nasılsın?";
            lblMesaj.Text = mesaj;
        }

        private void btnKarsılastır_Click(object sender, EventArgs e)
        {
            string isim1 = "melisa";
            string isim2 = "melisa";
            string isim3 = "ilayda";

            bool durum1 = isim1.Equals(isim2);
            bool durum2 = isim1 == isim2;

            bool durum3 = isim1.Equals(isim3);
            bool durum4 = isim1 == isim3;

            string mesaj = $"durum1 : {durum1} --> durum2 : {durum3} \r durum3 : {durum3} --> durum4 : {durum4}";
            MessageBox.Show(mesaj);
        }

        private void btnBicim_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 100;

            string mesaj = $"{a} + {b} = {c}";
            MessageBox.Show(mesaj);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string isim1 = "Rabia";
            string isim2 = "Rabia";
            string isim3 = "Ayşe";
            string isim4 = "Zeynep";
            string isim5 = "rabia";

            int sonuc1 = String.Compare(isim1, isim2); //0
            int sonuc2 = string.Compare(isim1, isim3); //1
            int sonuc3 = string.Compare(isim1, isim4); //-1
            int sonuc4 = string.Compare(isim1, isim5); //1
            int sonuc5 = string.Compare(isim1, isim2 , true); //0
            
            //MessageBox.Show($"Sonuç : {sonuc}");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string mesaj1 = lblMesaj.Text.Remove(7);
            string mesaj2 = lblMesaj.Text.Remove(0, 4); //başlangıç , adet

            MessageBox.Show(mesaj1);
            MessageBox.Show(mesaj2);
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool durum = lblMesaj.Text.Contains(txtMesaj.Text);
            MessageBox.Show($"{txtMesaj.Text} ........ {durum}");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string mesaj = lblMesaj.Text.Replace("melisa" , txtMesaj.Text); 
            lblMesaj.Text = mesaj;
        }

        private void btnSplite_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = lblMesaj.Text.Split(' ').ToList(); //boşluk sembolüne göre ayırır.
        }
    }
}
