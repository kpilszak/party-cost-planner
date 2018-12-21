using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace party_cost_planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, softBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();
            birthdayParty = new BirthdayParty((int)numberGuestsBirthday.Value, fancifulBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString() + " $";
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString() + " $";
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancifulDecorations = fancyBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void softBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.OnlySoftDrinksOption = softBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void numberGuestsBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberGuestsBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancifulBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancifulDecorations = fancifulBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
