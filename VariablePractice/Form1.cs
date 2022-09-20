using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;

            outputLabel.Text = $"{playerName} is number {playerNumber}";

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double hours = 25;
            double pay = 18.75;

            double earned = hours * pay;

            outputLabel.Text = $"{hours} hours at ${pay} per hour equals ${earned}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * pi;

            outputLabel.Text = $"\n\nThe area of the circle with a radius of 15cm is {area}^2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel.Text = $"\n\nThe area of the room with dimensions 8.5m x 6m 51m^2";




        }

        private void button3_Click(object sender, EventArgs e)
        {

            double shirt = 12.49;
            double tax = 0.13 * shirt;
            double totalBill = shirt * tax;
            double tendered = 20;
            double change = tendered - totalBill;

            outputLabel.Text = $"\n\nBill of Sale";
            outputLabel.Text += $"\n\nShirt: {shirt}";
            outputLabel.Text += $"\n\nTax: {tax}";
            outputLabel.Text += $"\nTotal {totalBill}";
            outputLabel.Text += $"\nTendered: {tendered}";
            outputLabel.Text += $"\nChange: {change}";
        }
    }
}
