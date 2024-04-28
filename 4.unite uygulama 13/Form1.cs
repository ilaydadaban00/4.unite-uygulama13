using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_uygulama_13
{
    public partial class Form1 : Form
    {
        List<string> adsoyadList = new List<string>();
        List<int> numaraList = new List<int>();
        List<Ogrenciler> ogrencilerlist = new List<Ogrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSAyi_Click(object sender, EventArgs e)
        {
            numaraList.Add(int.Parse(txtNumara.Text));
            lbSayi.Items.Clear();
            foreach (var item in numaraList)
            {
                lbSayi.Items.Add(item);
            }
        }

        private void btnMetin_Click(object sender, EventArgs e)
        {
           adsoyadList.Add(txtAdSoyad.Text);
            lbSayi.Items.Clear();
            foreach (var item in adsoyadList)
            {
                lbMetin.Items.Add(item);
            } }

        private void btnnesneEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenciler = new Ogrenciler();
            ogrenciler.Numara = (int.Parse(txtNumaraN.Text));
            ogrenciler.AdSoyad = txtAdSoyadN.Text;
            ogrencilerlist.Add(ogrenciler);
            lbNesne.Items.Clear();
            foreach(var  item in ogrencilerlist)
            {
                lbNesne.Items.Add(item.Numara + "" + item.AdSoyad);
            }
        }
    }
}
     
    


