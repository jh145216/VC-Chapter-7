using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delgados_Taocs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double tacosOrdered;
            double totalTacosPrice;
            double burritosOrdered;
            double totalBurritosPrice;
            double refriedbreansOrdered;
            double totalRefriedbeansPrice;
            double fajitasOrdered;
            double totalFajitasPrice;
            double popsOrdered;
            double totalPopsPrice;
            double cheesequesadillasOrdered;
            double totalCheesequesadillasPrice;
            
            {
                tacosOrdered = Convert.ToDouble(txtTacosNumber.Text);
                totalTacosPrice = tacosOrdered * .99;
                lblMainTotal.Text = totalTacosPrice.ToString("c");
            }

            {
                burritosOrdered = Convert.ToDouble(txtBurritosNumber.Text);
                totalBurritosPrice = burritosOrdered * 1.99;
                lblMainTotal.Text = totalBurritosPrice.ToString("c");
            }

            {
                refriedbreansOrdered = Convert.ToDouble(txtReFriedBeansNumber.Text);
                totalRefriedbeansPrice = refriedbreansOrdered * .50;
                lblMainTotal.Text = totalRefriedbeansPrice.ToString("c");
            }

            {
                fajitasOrdered = Convert.ToDouble(txtFajitasNumber.Text);
                totalFajitasPrice = fajitasOrdered * 1.50;
                lblMainTotal.Text = totalFajitasPrice.ToString("c");
            }

            {
                popsOrdered = Convert.ToDouble(txtPopsNumber.Text);
                totalPopsPrice = popsOrdered * 1.00;
                lblMainTotal.Text = totalPopsPrice.ToString("c");
            }
            
            {
                cheesequesadillasOrdered = Convert.ToDouble(txtCheeseQuesadillasNumber.Text);
                totalCheesequesadillasPrice = cheesequesadillasOrdered * 1.75;
                lblMainTotal.Text = totalCheesequesadillasPrice.ToString("c");
            }
        }
    }
}
