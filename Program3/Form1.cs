//Grading ID: R7828
//Program 3
//CIS 199-01
//Due 11/5/2020
//This program calculates the cost of a transation given the product, quantity, and state sales tax

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public const int MINQUANTITY = 0; //quantity ordered cannot be less than zero
        public const int MINPRODUCTNUM = 1001; //lowest possible product number
        public const int MAXPRODUCTNUM = 1007; //maximun possible product number

        public string[] states = { "KY", "OH", "IN", "IL" }; //array containing the four states
        public double[] taxes = { .06, .0717, .07, .0874 }; //array containing the tax rates for the four states
        public int[] products = {1001,1002,1003,1004,1005,1006,1007}; //array containing the seven products
        public double[] productCosts = {7.87,9.51,10.73,9.99,11.99,5.00,4.58}; //array containing the price per unit of the seven products
        public int[] lowLimits = { 0, 5, 10, 20 }; // quantity low limits affecting which discount is applied
        public double[] discounts = { 0, .05, .10, .15 }; //discount rates based on quantity
        private void calcBtn_Click(object sender, EventArgs e) //when the button is clicked or 'enter' pressed, the program calculates the initial price, discount price, tax, and total price
        {
            if (stateListBox.SelectedIndex >= 0)
            {
                if ((int.TryParse(productTxt.Text, out int product)) && product >= MINPRODUCTNUM && product <= MAXPRODUCTNUM) //the int 'product' is used to store the entered value of the product number
                {
                    if ((int.TryParse(quantityTxt.Text, out int quantity)) && quantity >= MINQUANTITY) //the int 'quantity' is used to store the entered quantity of the order
                    {
                        //First we calculate the product cost

                        bool productFound = false; //boolean used to end the loop when the array value equals the entered product number
                        double productCost = 0; //cost of each unit sold

                        for (int i=0; i < products.Length && productFound == false; i++)
                        {
                            if (products[i] == product)
                                productFound = true;
                            productCost = productCosts[i];
                        }

                        //Next we set the sales tax rate based on the state selected

                        bool stateFound = false; //boolean used to end the loop when the array value equals the selected state
                        double taxRate = 0; //sales tax rate in the selected state

                        for (int i=0; i < states.Length && stateFound == false; i++)
                        {
                            if (states[i] == stateListBox.Text)
                                stateFound = true;
                            taxRate = taxes[i];
                        }

                        //Next we set the discount rate based on the quantity entered

                        bool quantityFound = false; //boolean used to end the loop when the quantity entered is greater than or equal to the array value, starting with the largest array values
                        double discount = 0; // discount rate based on the quantity entered

                        for (int i= lowLimits.Length - 1; i >= 0 && quantityFound == false; i--)
                        {
                            if (quantity >= lowLimits[i])
                                quantityFound = true;
                            discount = discounts[i];
                        }

                        //Next we perform calculations and output costs

                        double initialCost; //cost before discount or tax is applied
                        double discountCost; //cost after discount is applied
                        double taxCost; //total tax that must be added to the cost
                        double totalCost; //cost after discounts and taxes

                        initialCost = productCost * quantity;
                        discountCost = initialCost - (initialCost * discount);
                        taxCost = discountCost * taxRate;
                        totalCost = discountCost + taxCost;

                        intCostOutput.Text = $"{initialCost:C}";
                        discCostOutput.Text = $"{discountCost:C}";
                        taxOutput.Text = $"{taxCost:C}";
                        totalOuput.Text = $"{totalCost:C}";

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity greater than zero");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid product number between 1001 and 1007");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid state");
            }
        }
    }
}
