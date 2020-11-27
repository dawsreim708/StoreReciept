/*Dawson reimer
 * Nov. 26, 2020
 * Store receipt
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
using System.Media;
using System.Threading;

namespace StoreReciept
{
    public partial class Form1 : Form
    {
        //setting up global variables
        double item1Price = 999.99;
        double item2Price = 399.99;
        double item3Price = 99.99;
        double totalTurboPrice = 0;
        double totalColdAirPrice = 0;
        double totalFuelInjPrice = 0;
        double taxRate = .13;
        double subtotal = 0;
        double tax = 0;
        double total = 0;
        double tendered = 0;
        double change = 0;
        int ammountItem1 = 0;
        int ammountItem2 = 0;
        int ammountItem3 = 0;

        SoundPlayer printSound = new SoundPlayer(Properties.Resources.printSound);
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
            //try to calculate totals for items purchased
        { try
            {
                ammountItem1 = Convert.ToInt32(item1Input.Text);
                ammountItem2 = Convert.ToInt32(item2Input.Text);
                ammountItem3 = Convert.ToInt32(item3Input.Text);

                totalTurboPrice = ammountItem1 * item1Price;
                totalColdAirPrice = ammountItem2 * item2Price;
                totalFuelInjPrice = ammountItem3 * item3Price;

                subtotal = totalTurboPrice + totalColdAirPrice + totalFuelInjPrice;
                tax = subtotal * taxRate;
                total = tax + subtotal;

                calculatedTotals.Text = $"{subtotal.ToString("$0.00")}\n\n{tax.ToString("$0.00")}\n\n{total.ToString("$0.00")}";
                warningLabel.Visible = false;
            }
            catch
            {
                warningLabel.Visible = true;
            }
        }

        private void CalculateChangeButton_Click(object sender, EventArgs e)
        {//use tendered to calculate change
            try { 
            tendered = Convert.ToDouble(tenderedIntput.Text);
            change = tendered - total;
            changeOutput.Text = $"{change.ToString("$0.00")}";
        }
            catch
            {
                warningLabel.Visible = true;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {//print by line with sound
            printSound.Play();

            receiptOutput.Text = $"Order number";
            receiptOutputRight.Text += $"137";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\nNovember 26, 2020";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\n\nTurbo";
            receiptOutputRight.Text += $"\n\n\nx{ammountItem1}  {totalTurboPrice.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\nCold Air Intake";
            receiptOutputRight.Text += $"\nx{ammountItem2}  {totalColdAirPrice.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\nFuel Injectors";
            receiptOutputRight.Text += $"\nx{ammountItem3}  {totalFuelInjPrice.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\n\nSubtotal";
            receiptOutputRight.Text += $"\n\n{subtotal.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\nTax";
            receiptOutputRight.Text += $"\n{tax.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\nTotal";
            receiptOutputRight.Text += $"\n{total.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\n\nTendered";
            receiptOutputRight.Text += $"\n\n{tendered.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\nChange";
            receiptOutputRight.Text += $"\n{change.ToString("$0.00")}";
            Refresh();
            Thread.Sleep(300);

            receiptOutput.Text += $"\n\nHave good day";
            Refresh();
            Thread.Sleep(300);

            printSound.Stop();

        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {//reset all variables for new order
            item1Input.Text = "";
            item2Input.Text = "";
            item3Input.Text = "";
            calculatedTotals.Text = "";
            tenderedIntput.Text = "";
            changeOutput.Text = "";
            receiptOutput.Text = "";
            receiptOutputRight.Text = "";
            subtotal = 0;
            tax = 0;
            total = 0;
            tendered = 0;
            change = 0;
            ammountItem1 = 0;
            ammountItem2 = 0;
            ammountItem3 = 0;
            totalTurboPrice = 0;
            totalColdAirPrice = 0;
            totalFuelInjPrice = 0;

        }
    }
}
