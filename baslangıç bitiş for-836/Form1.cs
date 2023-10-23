using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baslangıç_bitiş_for_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            int basla,  bitis;
            basla= Convert.ToInt32(txtBasla.Text);
            bitis = Convert.ToInt32(txtBitir.Text);

            for (int i= basla; i <= bitis; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
