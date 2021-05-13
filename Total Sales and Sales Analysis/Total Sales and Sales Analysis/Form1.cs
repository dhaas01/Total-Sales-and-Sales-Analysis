using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales_and_Sales_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Function that will read the sales from the file into the program and determine if the
        // read values are the correct type.
        private void ReadSales(double[] salesList)
        {
            try
            {
                //Declares the StreamReader object and opens the file.
                StreamReader inputFile = File.OpenText("Sales.txt");

                //Counter
                int i = 0;

                //Reads values into the file as long as the array has open spaces and the end of the file
                // is not reached.
                while (i < salesList.Length && !inputFile.EndOfStream)
                {
                    salesList[i] = double.Parse(inputFile.ReadLine());
                    i++;
                }

                // Closes the file.
                inputFile.Close();
            }
            // Will display a message if the input read from the file is not of type double.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Displays the sales in the ListBox.
        private void DisplaySales(double[] salesList)
        {
            // Adds items into the list box until all the data from the file is entered.
            foreach (double fileinput in salesList)
            {
                salesListBox.Items.Add(fileinput.ToString("c"));
            }
        }

        // Function that calculates the total of the sales.
        private double Total(double[] salesList)
        {
            // Declares total
            double total = 0;
            
            // Calculates the total.
            for(int i = 0; i< salesList.Length; i++)
            {
                total = salesList[i] + total;
            }

            return total;
        }

        // Function calculates the average of the sales.
        private double Average(double[] salesList)
        {
            // Accounts for the calculated total from the Total funtion.
            double total;
            total = Total(salesList);

            // Calculates the average.
            double average;
            average = total / salesList.Length;

            return average;
        }

        // Function finds the largest value in the array.
        private double Largest(double[] salesList)
        {
            // Declares the largest.
            double largest = salesList[1];

            // Calculates the largest.
            for(int i= 1; i < salesList.Length; i++)
            {

                if (salesList[i] > largest)
                {
                    largest = salesList[i];
                }
            }
            return largest;
        }

        // Function finds the smallest sales.
        private double Smallest(double[] salesList)
        {
            // Defines the smallest.
            double smallest = salesList[1];

            // Calculates the smallest.
            for(int i = 1; i < salesList.Length; i++)
            {
                if (salesList[i] < smallest)
                {
                    smallest = salesList[i];
                }
            }
            return smallest;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Declares all of the needed variables.
            double totalSale;
            double averageSales;
            double largestSale;
            double smallestSale;

            // Declares and initializes the array.
            const int SIZE = 7;
            double[] salesList = new double[SIZE];

            //Calls the ReadSales function
            ReadSales(salesList);

            //Calls the DisplaySales function and displays the values in the ListBox.
            DisplaySales(salesList);

            // Calls the Total function and displays the total.
            totalSale = Total(salesList);
            calculatedTotalLabel.Text = totalSale.ToString("c");

            // Calls the average function and displays the average.
            averageSales = Average(salesList);
            averageSalesLabel.Text = averageSales.ToString("c");

            // Calls the largestSale function and displays the largest value.
            largestSale = Largest(salesList);
            largestSaleLabel.Text = largestSale.ToString("c");

            // Calls the smallestSale function and displays the smallest value.
            smallestSale = Smallest(salesList);
            smallestSaleLabel.Text = smallestSale.ToString("c");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Closes the form.
            this.Close();
        }
    }
}
