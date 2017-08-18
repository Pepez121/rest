using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miles
{
    public partial class Miles : Form
    {
        int startingMile, endingMile, totalMiles;
        double moneyOwed;
        public Miles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the start and end value
            startingMile = Convert.ToInt16(numStarting.Value);
            endingMile = Convert.ToInt16(numEnding.Value);
            if (endingMile > startingMile)
            {
                if (radioCar.Checked == true)
                {
                    totalMiles = endingMile - startingMile;
                    moneyOwed = totalMiles * 0.39;
                    lblTotalMoney.Text = "$ " + Convert.ToString(moneyOwed);
                } else if(radioAirplane.Checked == true) {
                    totalMiles = endingMile - startingMile;
                    moneyOwed = totalMiles * 0.5;
                    lblTotalMoney.Text = "$ " + Convert.ToString(moneyOwed);
                }else
                {
                    MessageBox.Show("Select a type of vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Error: Ending value is lower then starting value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblInitial_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioVehicle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Miles_Load(object sender, EventArgs e)
        {

        }

        private void btnTotalMiles_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Total miles: " + totalMiles, "Display", MessageBoxButtons.OK);
        }
    }
}
