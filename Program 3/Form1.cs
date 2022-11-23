// Grading ID: S7105
// Program #3
// Due date: 4/01/2021
// CIS 199-02
// This program calculates
// cost of delivery for orders
// of vegetables based on user
// input of farm, item number
// and quantity in pounds.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {


        // declaring arrays using given values from instructions


            string[] farm = { "NE", "NW", "SE", "SW" };     // Northeast, Northwest,
                                                            // Southeast, Southwest farms

            double[] shipmentFee = { 0.06, 0.0717, 0.07, 0.0874 };  // shipment fees for farms


            int[] itemNumber = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };     // item numbers for veggies
                                                                                        // (potatoes, carrots, tomatoes,
                                                                                        //  peppers, eggplants, onions, garlic)

            double[] costPerPound = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };     // cost per pound for veggies


            int[] poundLowLimits = { 0, 6, 11, 21 };        // lower limit ranges for  for discount quantity (in lbs.)

            double[] discounts = { 0.00, 0.05, 0.10, 0.15 };    // % discounts for corresponding ranges


            bool farmValid = false;         // checks if farm selection is valid
            bool itemNumValid = false;      // checks if item number input is valid
            bool quantityValid = false;     // checks if quantity input is valid
            bool discountValid = false;     // checks if discount is valid

            string farmSelection = "NA",    // string value for farm selection from array values
                   farmInput = "NA";        // string value for user selection

            double shipFeeSelection = 0,        // final value to correspond to shimpment fee array match
                   costPPoundSelection = 0,     // final value to correspond to cost per pound array match
                   discountSelection = 0,       // final value to correspond to discount array match

                   initialCost,                 // total for initial cost
                   discountedCost,              // total for discounted cost
                   shipmentCost,                // total for shipment cost
                   totalCost;                   // total cost using all previously gathered totals

            int itemNumSelection = 0,           // final value to correspond to iterm number array match
                itemNumInput,                   // user input item number
                quantityInput,                  // user input quantity (in lbs.)
                i = 0;                          // index value


        // check for valid input values/selection:


        // valid farm selection in combo box?

           if (farmComboBox.SelectedIndex >= 0)
           {
               
                farmInput = farmComboBox.Text;
                farmValid = true;
            }
           else
           {
                MessageBox.Show("Select valid farm");
           }
        
        // valid item number input?
           
           if (int.TryParse(itemInputTextBox.Text, out itemNumInput) 
               && itemNumInput >= 10001 
               && itemNumInput <= 10007)
           {
                itemNumValid = true;
           }
           else
           {
                MessageBox.Show("Enter a valid item number");
           }

        // valid quantity input?

           if (int.TryParse(quantityInputTextBox.Text, out quantityInput) 
                && quantityInput >= 0)
           {
                quantityValid = true;
           }
           else
           {
                MessageBox.Show("Enter a valid quantity");
           }


        // get item costs (steps 1-3):


        // step 1: get item number and quantity for initial cost

            for (i = 0; i < itemNumber.Length; i++)
            {
                if (itemNumValid == true && itemNumInput == itemNumber[i])
                {
                    itemNumSelection = itemNumber[i];
                    costPPoundSelection = costPerPound[i];
                }
            }

        // calculate initial cost using item number search & cost per pound

            initialCost = costPPoundSelection * quantityInput;
            initialCostOutputLabel.Text = $"{initialCost:C2}";


        // step 2: check for discount

            i = poundLowLimits.Length - 1;

            while (i > 0 && !discountValid)
            {
                if (quantityValid && quantityInput >= poundLowLimits[i])
                {
                    discountValid = true;
                }
                else
                {
                    --i;
                }
            }

            if (discountValid == true)
            {
                discountSelection = discounts[i];
            }

        // calculate discount using while loop above

            discountedCost = initialCost - (initialCost * discountSelection);
            discountedCostOutputLabel.Text = $"{discountedCost:C2}";

        // step 3: get farm selection and shipment fee using initial cost and/or discounted cost

            for (i = 0; i < farm.Length; i++)
            {
                
                if (farmValid && farmInput == farm[i])
                {
                    farmSelection = farm[i];
                    shipFeeSelection = shipmentFee[i];
                }
            }

        //calculate shipment fee

            shipmentCost = discountedCost * shipFeeSelection;
            shipmentCostOutputLabel.Text = $"{shipmentCost:C2}";

        // total price calculations

            totalCost = discountedCost + shipmentCost;
            totalPriceOutputLabel.Text = $"{totalCost:C2}";

        }
    }
}
