using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculTVA
{
    public partial class Form1 : Form
    {
        #region fields
        private int sumaTotala;
        private double sumaDiscount5;
        private double sumaDiscount10;
        private double Rate4CuDiscount5;
        private double avans25;
        private double rata;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        private void b1CalculTotal_Click(object sender, EventArgs e)//aici calculez total initial = cost prog + membership
        {
            sumaTotala = int.Parse(tbSumaTotalaFaraTVA.Text) + int.Parse(tbTaxaMembershipFaraTVA.Text);
            labelSumaTotalaFaraTVA.Text = sumaTotala.ToString() + " Euro + TVA";//calcul suma totala
            //si dupa focusul sa fie pe butonul suma totala 
            tbSumaTotalaFaraTVA.Focus();
        }

        private void btCalculSumaCuDiscount_Click(object sender, EventArgs e)// aici scot suma cu discount 
        {
            if (rbDiscount5.Checked == true)//suma - (suma * 0.05);
            {
                sumaDiscount5 = int.Parse(tbSumaTotalaFaraTVA.Text) - (int.Parse(tbSumaTotalaFaraTVA.Text) * 0.05);
                labelSumaCuDiscount.Text = Convert.ToString(sumaDiscount5) + " Euro + TVA";
            }
            if (rbDiscount10.Checked == true)//suma - (suma * 0.10);
            {
                sumaDiscount10 = int.Parse(tbSumaTotalaFaraTVA.Text) - (int.Parse(tbSumaTotalaFaraTVA.Text) * 0.10);
                labelSumaCuDiscount.Text = Convert.ToString(sumaDiscount10) + " Euro + TVA";
            }
        }

        private void bCalculRate_Click(object sender, EventArgs e)
        {
            if (rb4Rate.Checked == true)
            {
                if (rbDiscount5.Checked == true)
                {
                    Rate4CuDiscount5 = (sumaDiscount5 + int.Parse(tbTaxaMembershipFaraTVA.Text));
                    avans25 = Rate4CuDiscount5 * 0.25;
                    rata = (Rate4CuDiscount5 - avans25) / 4;
                    labelSumaTotalaInRate.Text = "Suma impartia in 4 rate a cate " + rata.ToString() + " Euro + TVA/fiecare, plus avans initial de: " + avans25.ToString() + " Euro + TVA.";
                }
            }
        }
    }
}
