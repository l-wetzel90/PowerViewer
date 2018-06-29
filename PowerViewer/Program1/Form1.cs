//Loren Wetzel
//Program 1 - Power Viewer
//1/22/18

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class frmPower : Form
    {
        public frmPower()
        {
            InitializeComponent();
        }

        private List<Appliance> appliances = new List<Appliance>(); // list that holds appliance objects
        List<Button> allButtons = new List<Button>(); //list to hold the button objects

        private double priceKWH = 0;
        private string price;
        private double wattUsage;
        private string utilityType;
        private double perHour;
        private double perDay;
        private double perYear;
        private double totalYear = 0;
        private double totalHour = 0;
        private double totalDay = 0;
        private double totalWatts = 0;
        private double currentWatt = 0;

        private void frmPower_Load(object sender, EventArgs e)
        {
            appliances = ApplianceDA.GetAppliances();//uses applianceda to get appliance objects
            txtKwh.Text = Convert.ToString(priceKWH);
            txtCurrent.ReadOnly = true;
            txtPerDay.ReadOnly = true;
            txtPerHour.ReadOnly = true;
            txtPerYear.ReadOnly = true;

            foreach (Appliance a in appliances)
            {
                //instansiate a new button
                Button newButton = new Button();
                newButton.Text = a.AppType;
                newButton.Width = 90;
                newButton.Height = 50;
                newButton.Tag = a.Watts;
                newButton.Click += AButton_Click;
                newButton.MouseHover += ButtonHover;
                pnlAppliences.Controls.Add(newButton);//used the flow panel to put buttons in order
                allButtons.Add(newButton);
            }

        }//end form load

        private void AButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            CheckInput();
            price = txtKwh.Text;
            IsDouble();
            if (IsDouble())
            {
                priceKWH = Convert.ToDouble(txtKwh.Text);
                wattUsage = (Double)clickedButton.Tag;
                utilityType = clickedButton.Text;
                perHour = priceKWH * wattUsage / 1000;
                perDay = perHour * 24;
                perYear = perDay * 365;

                if (clickedButton.BackColor == SystemColors.Control)
                {
                    clickedButton.BackColor = Color.Green;
                    PriceLock(allButtons);
                    ButtonsOn(allButtons);

                }
                else if (clickedButton.BackColor == Color.Green)
                {
                    clickedButton.BackColor = SystemColors.Control;
                    clickedButton.UseVisualStyleBackColor = true;
                    PriceLock(allButtons);
                    ButtonsOn(allButtons);
                }
            }
            else
            {
                MessageBox.Show("You need a number for the price!!!!");
            }
        }

        private bool IsDouble()
        {
            bool isOK;
            string thePrice = txtKwh.Text;
            try
            {
                Convert.ToDouble(thePrice);
                if (Convert.ToDouble(thePrice) < 0)
                {
                    isOK = false;
                    MessageBox.Show("Really? Enter the price..");
                    txtKwh.Clear();
                    txtKwh.Focus();
                }
                isOK = true;
            }
            catch
            {
                isOK = false;
                txtKwh.Clear();
                txtKwh.Focus();
            }
            return isOK;
        }

        private void CheckInput() //changes a null textbox to the value of zero to get around a 'System.FormatException' error
        {
            if (txtKwh.Text == "")
            {
                priceKWH = 0;
                txtKwh.Text = Convert.ToString(priceKWH);
            }
        }

        private void PriceLock(List<Button> allButtons)
        {
            bool isOK = false;
            foreach (Button b in allButtons)
            {
                if (b.BackColor == Color.Green)
                {
                    isOK = true;
                }
            }
            if (isOK)
            {
                txtKwh.Enabled = false;
            }
            else
            {
                txtKwh.Enabled = true;
            }
        }

        private void ButtonsOn(List<Button> allButtons)
        {
            totalDay = 0;
            totalHour = 0;
            totalYear = 0;
            totalWatts = 0;

            foreach (Button b in allButtons)
            {
                if (b.BackColor == Color.Green)
                {
                    txtCurrent.Clear();
                    txtPerHour.Clear();
                    txtPerDay.Clear();
                    txtPerYear.Clear();
                    priceKWH = 0;
                    priceKWH = Convert.ToDouble(txtKwh.Text);
                    wattUsage = (Double)b.Tag;
                    perHour = priceKWH * wattUsage / 1000;
                    perDay = perHour * 24;
                    perYear = perDay * 365;
                    currentWatt = wattUsage;
                    totalHour += perHour;
                    totalDay += perDay;
                    totalYear += perYear;
                    totalWatts += currentWatt;
                }
            }
            txtCurrent.Text = totalWatts.ToString();
            txtPerHour.Text = totalHour.ToString("C");
            txtPerDay.Text = totalDay.ToString("C");
            txtPerYear.Text = totalYear.ToString("C");
        }

        private void ButtonHover(object sender, EventArgs e)
        {
            ToolTip aTip = new ToolTip();
            Button aButton = (Button)sender;
            string tagValue = aButton.Tag.ToString() + " Watts";
            aTip.SetToolTip(aButton, tagValue);
        }
    }
}
