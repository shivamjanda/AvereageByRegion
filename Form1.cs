/* Authoer: Shivam Janda
 * Last Modified : March 5, 2022
 * Descripton: This program takes in 7 values for 3 regions of whole numbers within the ranges of zero and 5000 and calculates the average of each region.
 *             This program also calculates the overall average.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvereageByRegion
{
    public partial class formAverageByRegion : Form
    {
        const int MaximumDays = 7;
        const int MaximumRegions = 3;
        const int MaximumUnits = 5000;

        // Declare 2d arrays of units entered based on the amount of regions and its days
        int[,] units = new int[MaximumRegions, MaximumDays];

        TextBox[] outputTextboxes;
        Label[] outputAverageLabels;

        // global variables 
        int day = 0;
        int region = 0;
        double OverallSum;
        double OverallAverage;


        public formAverageByRegion()
        {

            InitializeComponent();
            // when the form loads, create a array of textboxes and labels using the regions lists and labels
            outputTextboxes = new TextBox[] { textBoxRegion1List, textBoxRegion2List, textBoxRegion3List};
            outputAverageLabels = new Label[] { labelRegion1Average, labelRegion2Average, labelRegion3Average };
        }

        private void formAverageByRegion_Load(object sender, EventArgs e)
        {

        }

        #region "Event Handler"
        /// <summary>
        /// Resets the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetClick(object sender, EventArgs e)
        {
            // call the set deafults function
            SetDeafults();
        }

        /// <summary>
        /// Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Validates, Calculates and displays the values, average and overall averages of the regions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterClick(object sender, EventArgs e)
        {
            // container variable for validation
            int currentUnits;

            // checks whether the user entry is a whole number
            if (int.TryParse(textBoxUnitsEntry.Text, out currentUnits))
            {
                // checks if the user entry is within the range
                if (currentUnits >= 0 && currentUnits <= MaximumUnits)
                {

                    // if number is in range, add it to the array and to the output textbox for the current region.
                    units[region, day] = currentUnits;
                    outputTextboxes[region].Text += currentUnits + Environment.NewLine;

                    // increment day counter by 1
                    day++;
                    // if we are at day 7
                    if (day >= MaximumDays)
                    {
                        double sum = 0;
                        double average = 0;
                        // loop through the 2d array at that current region and add up all the values
                        for(int i = 0; i <= 6; i++)
                        {
                            sum += units[region, i];
                        }
                        // calculate the average of that region 
                        average = Math.Round((sum / 7),2);

                        // add the value of the average to the OverallSum total 
                        OverallSum += average;

                        // Displays the the average into the output label of that specfic region rounded to 2 decimal places
                        outputAverageLabels[region].Text = average.ToString();

                        // reset the day to 0 , increment the region by 1 and update the day on the form
                        day = 0;
                        labelDays.Text = "Day " + (day + 1);
                        region++;
                     
                    }
                    else
                    {
                        labelDays.Text = "Day " + (day + 1);
                    }

                    // if the entry was valid and we are done region 3
                    if (region == 3)
                    {
                        // calculate the OverallAverage of the regions rounded to 2 decmimal places
                        OverallAverage = Math.Round((OverallSum/3), 2);

                        // ouput the value to the labelAverageOutput label
                        labelAverageOutput.Text = "Average this week: " + OverallAverage.ToString();

                        // Call the higlight function that takes in the averages of all 3 regions
                        Highlight(Convert.ToDouble(labelRegion1Average.Text), Convert.ToDouble(labelRegion2Average.Text), Convert.ToDouble(labelRegion3Average.Text));

                        // disable the enter button, set the textboxUnitsEntry to read only and focus on the rest button
                        textBoxUnitsEntry.ReadOnly = true;
                        buttonEnter.Enabled = false;
                        buttonReset.Focus();
                    }

                }
                // otherwise
                else
                {
                    // focus on the textboxUnitsEntry and display error message accordingly
                    textBoxUnitsEntry.Focus();
                    MessageBox.Show("Your entry must be between 0 and " + MaximumUnits + ".");
                }
            }
            //otherwise
            else
            {
                // focus on the textboxUnitsEntry and display error message accordingly
                textBoxUnitsEntry.Focus();
                MessageBox.Show("Your entry must be a whole number.");
            }
            // Everytime the user enters a value, clear the textbox
            textBoxUnitsEntry.Clear();

        }
        #endregion

        #region "Functions"
        /// <summary>
        /// Changes the regions label color based on its value compared to the overall average
        /// </summary>
        /// <param name="AverageRegion1"></param>
        /// <param name="AverageRegion2"></param>
        /// <param name="AverageRegion3"></param>
        private void Highlight(double AverageRegion1, double AverageRegion2, double AverageRegion3)
        {
            // if the regions are greater than the value of the overall average then change its label control value to red
            if (AverageRegion1 > OverallAverage)
            {
                labelRegion1Average.BackColor = Color.Red;
            }

            if (AverageRegion2 > OverallAverage)
            {
                labelRegion2Average.BackColor = Color.Red;

            }
            if (AverageRegion3 > OverallAverage)
            {
                labelRegion3Average.BackColor = Color.Red;

            }

            // if the regions are greater than the value of the overall average then change its label control value to green
            if (AverageRegion1 < OverallAverage)
            {
                labelRegion1Average.BackColor = Color.Green;
            }
            if (AverageRegion2 < OverallAverage)
            {
                labelRegion2Average.BackColor = Color.Green;
            }
            if (AverageRegion3 < OverallAverage)
            {
                labelRegion3Average.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Sets the form to its deafult values
        /// </summary>
        public void SetDeafults()
        {
            // reset global variables to its deafult values
            day = 0;
            region = 0;
            OverallSum = 0;
            OverallAverage = 0;

            // set all controls to its deafult values when the form was loaded
            textBoxUnitsEntry.ReadOnly = false;
            buttonEnter.Enabled = true;
         
            textBoxUnitsEntry.Clear();
            textBoxRegion1List.Clear();
            textBoxRegion2List.Clear();
            textBoxRegion3List.Clear();
            labelRegion1Average.Text = String.Empty;
            labelRegion2Average.Text = String.Empty;
            labelRegion3Average.Text = String.Empty;
            labelAverageOutput.Text = String.Empty;
            labelDays.Text = "Day " + (day + 1);

            textBoxUnitsEntry.Focus();

            labelRegion1Average.BackColor = SystemColors.Control;
            labelRegion2Average.BackColor = SystemColors.Control;
            labelRegion3Average.BackColor = SystemColors.Control;
        }

        #endregion
    }
}
