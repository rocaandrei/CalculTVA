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
        private double sumaTotala;
        private double sumaDiscount5;
        private double sumaDiscount10;
        private double Rate4CuDiscount5;
        private double avans25;
        private double rata;
        private double restPentruRate;
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
            if (cb4Rate.Checked)
            {
                if (rbDiscount5.Checked)
                {
                    sumaTotala = sumaDiscount5 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 4;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 4 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else if (rbDiscount10.Checked)
                {
                    sumaTotala = sumaDiscount10 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 4;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 4 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else
                {
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 4;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 4 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
            }
            else if (cb5Rate.Checked)
            {
                if (rbDiscount5.Checked)
                {
                    sumaTotala = sumaDiscount5 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 5;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 5 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else if (rbDiscount10.Checked)
                {
                    sumaTotala = sumaDiscount10 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 5;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 5 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else
                {
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 5;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 5 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
            }
            else if (cb6Rate.Checked)
            {
                if (rbDiscount5.Checked)
                {
                    sumaTotala = sumaDiscount5 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 6;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 6 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else if (rbDiscount10.Checked)
                {
                    sumaTotala = sumaDiscount10 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 6;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 6 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else
                {
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 6;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 6 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
            }
            else if (cb7Rate.Checked)
            {
                if (rbDiscount5.Checked)
                {
                    sumaTotala = sumaDiscount5 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 7;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 7 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else if (rbDiscount10.Checked)
                {
                    sumaTotala = sumaDiscount10 + int.Parse(tbTaxaMembershipFaraTVA.Text);
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 7;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 7 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
                else
                {
                    avans25 = sumaTotala * 0.25;
                    restPentruRate = sumaTotala - avans25;
                    rata = restPentruRate / 7;
                    labelSumaTotalaInRate.Text = "Avans initial de 25% de: " + avans25.ToString() + " Euro + TV si 7 rate a cate: " + rata.ToString() + " Euro + TVA/fiecare";
                }
            }
            else
                labelSumaTotalaInRate.Text = "Nu s-a selectat varianta de plata in rate.";
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            labelSumaTotalaFaraTVA.Text = "pending...";
            tbSumaTotalaFaraTVA.Text = "pending...";
            tbTaxaMembershipFaraTVA.Text = "pending...";
            labelSumaCuDiscount.Text = "pending...";
            labelSumaTotalaInRate.Text = "pending...";
            rbDiscount5.Checked = false;
            rbDiscount10.Checked = false;
            cb4Rate.Checked = false;
            cb5Rate.Checked = false;
            cb6Rate.Checked = false;
            cb7Rate.Checked = false;
            labelSumaCuDiscount.Text = "pending...";


        }
    }
}
