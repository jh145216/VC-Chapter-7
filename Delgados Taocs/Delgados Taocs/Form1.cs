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
            /*int tacos;
            int burritos;
            int refriedbeans;
            int fajita;
            int pop;
            int cheesequesadilla;
            int yes;
            int no;*/


            if (radTacos.Checked == true)
            {
                lblMainTotal.Text = "$0.99";
            }

            if (radBurritos.Checked == true)
            {
                lblMainTotal.Text = "$1.99";
            }

            if (radReFriedBeans.Checked == true)
            {
                lblMainTotal.Text = "$0.50"; 
            }

            if (radFajita.Checked == true)
            {
                lblMainTotal.Text = "$1.50";
            }

            if (radPop.Checked == true)
            {
                lblMainTotal.Text = "$1.00";
            }

            if (radCheeseQuesadilla.Checked == true)
            {
                lblMainTotal.Text = "$1.75";
            }

            if (radYes.Checked == true)
            {
                if (radReFriedBeans.Checked == true)
                {
                    lblExtraTotal.Text = "$0.50";
                }
            }

            /*radTacos.Text = (radTacos.Text);
            radBurritos.Text = (radBurritos.Text);
            radReFriedBeans.Text = (radReFriedBeans.Text);
            radFajita.Text = (radFajita.Text);
            radPop.Text = (radPop.Text);
            int cheesequesaddilla = (radCheeseQuesadilla.Text);
            Console.WriteLine(radCheeseQuesadilla.Text);*/

        }
    }
}
