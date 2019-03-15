using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            totalTxt.Text = "";
            peopleTxt.Text = "";
            tipTxt.Text = "";
            outputLbl.Text = "";
            totalTxt.Focus();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            decimal total = 0m;
            int people = 0;
            decimal tip = 0m;

            try
            {
                total = decimal.Parse(totalTxt.Text);
                people = int.Parse(peopleTxt.Text);
                tip = decimal.Parse(tipTxt.Text);

                outputLbl.Text = "Each person on the " + total.ToString("C") + " bill \n" +
                    "owes " + (total * (tip / 100 + 1) / people).ToString("C") + ".";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
