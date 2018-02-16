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
            double totalTacosPrice=0;
            double burritosOrdered;
            double totalBurritosPrice=0;
            double refriedbeansOrdered;
            double totalRefriedbeansPrice=0;
            double fajitasOrdered;
            double totalFajitasPrice=0;
            double popsOrdered;
            double totalPopsPrice=0;
            double cheesequesadillasOrdered;
            double totalCheesequesadillasPrice=0;
            double overAllTotal=0;

            if (chkTacos.Checked)
            {
                tacosOrdered = Convert.ToDouble(txtTacosNumber.Text);
                totalTacosPrice = tacosOrdered * .99;
                lblMainTotal.Text = totalTacosPrice.ToString("c");
            }

            if (chkBurritos.Checked)
            {
                burritosOrdered = Convert.ToDouble(txtBurritosNumber.Text);
                totalBurritosPrice = burritosOrdered * 1.99;
                lblMainTotal.Text = totalBurritosPrice.ToString("c");
            }

            if (chkReFriedBeans.Checked)
            {
                refriedbeansOrdered = Convert.ToDouble(txtReFriedBeansNumber.Text);
                totalRefriedbeansPrice = refriedbeansOrdered * .50;
                lblMainTotal.Text = totalRefriedbeansPrice.ToString("c");
            }

            if (chkFajitas.Checked)
            {
                fajitasOrdered = Convert.ToDouble(txtFajitasNumber.Text);
                totalFajitasPrice = fajitasOrdered * 1.50;
                lblMainTotal.Text = totalFajitasPrice.ToString("c");
            }

            if (chkPops.Checked)
            {
                popsOrdered = Convert.ToDouble(txtPopsNumber.Text);
                totalPopsPrice = popsOrdered * 1.00;
                lblMainTotal.Text = totalPopsPrice.ToString("c");
            }
            
            if (chkCheeseQuesadillas.Checked)
            {
                cheesequesadillasOrdered = Convert.ToDouble(txtCheeseQuesadillasNumber.Text);
                totalCheesequesadillasPrice = cheesequesadillasOrdered * 1.75;
                lblMainTotal.Text = totalCheesequesadillasPrice.ToString("c");
            }

            overAllTotal = totalTacosPrice + totalBurritosPrice + totalFajitasPrice + totalPopsPrice + totalCheesequesadillasPrice;
            lblMainTotal.Text = overAllTotal.ToString("c");

            Console.WriteLine("we will now throw a NullReferenceException");
                throw new NullReferenceException("this is the exception thrown by the console app");
        }
    }
}