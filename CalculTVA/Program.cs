using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculTVA
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new Form1()); 
            
            /*
          
            Console.WriteLine("Costul programului cu discountul de 10% inclus este: " + discount10 +
            ", suma la care se adauga taxa de Student Member de: " + membership + Environment.NewLine + "Cu un total de: " + (discount10 + membership) +
            " Euro + TVA");
            Console.WriteLine("Costul programului cu discountul de 5% inclus este: " + discount5 +
            ", suma la care se adauga taxa de Student Member de: " + membership + Environment.NewLine + "Cu un total de: " + (discount5 + membership) +
            " Euro + TVA");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("SISTEM DE PLATA IN RATE CU DISCOUNT DE 10%");//cred ca partea asta o sa o fac cu un switch... ca sa nu-mi afiseze toata informatia...
            double avans25 = discount10 * 0.25;
            for (int nrRate = 4; nrRate < 9; nrRate++)
            {
                Console.WriteLine("Cu discount de 10% inclus, avansul initial de 25% este de: {0} Euro + TVA);", avans25);
                double pretRata = ((discount10 - avans25) + membership) / nrRate;
                Console.WriteLine(" Si {0} rate egale a cate: {1} Euro + TVA/fiecare ",nrRate, pretRata);
            }
            double avans20 = discount10 * 0.20;
            for (int nrRate = 4; nrRate < 9; nrRate++)
            {
                Console.WriteLine("Cu discount de 10% inclus, avansul initial de 25% este de: {0} Euro + TVA);", avans20);
                double pretRata = ((discount10 - avans20) + membership) / nrRate;
                Console.WriteLine(" Si {0} rate egale a cate: {1} Euro + TVA/fiecare ", nrRate, pretRata);
            }
            Console.WriteLine("SISTEM DE PLATA IN RATE FARA DISCOUNT INCLUS");
            double av25 = totalFaraTVA * 0.25;
            double av20 = totalFaraTVA * 0.20;
            for (int nrRate = 4; nrRate < 9; nrRate++)
            {
                Console.WriteLine("Avansul initial de 25% este de: {0} Euro + TVA);", av25);
                double pretRata = (totalFaraTVA - av25) / nrRate;
                Console.WriteLine(" Si {0} rate egale a cate: {1} Euro + TVA/fiecare ", nrRate, pretRata);
            }
            for (int nrRate = 4; nrRate < 9; nrRate++)
            {
                Console.WriteLine("Avansul initial de 20% este de: {0} Euro + TVA);", av20);
                double pretRata = (totalFaraTVA - av20) / nrRate;
                Console.WriteLine(" Si {0} rate egale a cate: {1} Euro + TVA/fiecare ", nrRate, pretRata);
            }

            Console.ReadLine();
            */

        }
    }
}
