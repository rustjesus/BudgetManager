using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class Form1 : Form
    {
        private bool usingHourlyInput = false;
        // Variables to hold costs and income data
        private float monthlyBudget, monthlyRemainder;
        private float rentCost, groceryCost, utilityCost, carCost, hbaCost, nessCost, extraCost, insCost;
        private float weeklyIncome, taxPercent, hourlyIncome, hoursPerWeek, finalAnnIncome;

        private void tbUtilities_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbUtilities.Text, out utilityCost);
            UpdateMonthlyRemainder();
        }

        private void tbCar_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbCar.Text, out carCost);
            UpdateMonthlyRemainder();

        }

        private void tbGrocery_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbGrocery.Text, out groceryCost);
            UpdateMonthlyRemainder();
        }

        private void tbRent_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(tbRent.Text, out rentCost);
            UpdateMonthlyRemainder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UseHourlyInput();
        }

        private void tbInsurance_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(tbInsurance.Text, out insCost);
            UpdateMonthlyRemainder();
        }

        private void tbHBA_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(tbHBA.Text, out hbaCost);
            UpdateMonthlyRemainder();
        }

        private void tbNecessities_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(tbNecessities.Text, out nessCost);
            UpdateMonthlyRemainder();
        }

        private void tbExtra_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(tbExtra.Text, out extraCost);
            UpdateMonthlyRemainder();
        }

        private void tbTaxRate_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(tbTaxRate.Text, out taxPercent);
            UpdateAnnualIncome();
        }

        private void cbUseWeeklyInput_CheckedChanged(object sender, EventArgs e)
        {
            usingHourlyInput = !usingHourlyInput;

            if (usingHourlyInput)
            {
                weeklyIncome = weeklyIncome;
                UseWeeklyInput();
                UpdateAnnualIncome();
            }
            else
            {
                weeklyIncome = hoursPerWeek * hourlyIncome;
                UseHourlyInput();
                UpdateAnnualIncome();
            }
        }
        public void UseWeeklyInput()
        {
            //show weekly
            lbWeeklyIncome.Visible = true;
            tbWeeklyIncome.Visible = true;
            //hide hourly
            tbHourlyIncome.Visible = false;
            tbHoursPerWeek.Visible = false;
            label_HoursPerWeek.Visible = false;
            label_PerHourInput.Visible = false;
        }
        public void UseHourlyInput()
        {
            //hide weekly
            lbWeeklyIncome.Visible = false; 
            tbWeeklyIncome.Visible = false; 
            //show hourly
            tbHourlyIncome.Visible = true;
            tbHoursPerWeek.Visible = true;
            label_HoursPerWeek.Visible = true;
            label_PerHourInput.Visible = true;
        }

        private void tbWeeklyIncome_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbWeeklyIncome.Text, out weeklyIncome);
            UpdateAnnualIncome();

        }

        private void tbHoursPerWeek_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbHoursPerWeek.Text, out hoursPerWeek);
            UpdateWeeklyIncomeHours();
        }

        private void perHourInputBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbHourlyIncome.Text, out hourlyIncome);
            UpdateWeeklyIncomeHours();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMonthlyRemainder();
            UpdateAnnualIncome();
        }


        public void UpdateWeeklyIncomeHours()
        {
            weeklyIncome = hourlyIncome * hoursPerWeek;
            UpdateAnnualIncome();
        }
        private void UpdateAnnualIncome()
        {
            float yearly = weeklyIncome * 52;
            float newTaxPercent = taxPercent / 100;
            float yearlyTaxes = yearly * newTaxPercent;
            finalAnnIncome = yearly - yearlyTaxes;
            lblAnnualIncome.Text = $"{finalAnnIncome:n2}$ / Year After Taxes";

            UpdateMonthlyBudget();

        }

        private void UpdateMonthlyBudget()
        {
            monthlyBudget = finalAnnIncome / 12;
            lblMonthlyBudget.Text = $"Monthly Budget: ${monthlyBudget:n2}";

            UpdateMonthlyRemainder();
        }

        private void UpdateMonthlyRemainder()
        {
            monthlyRemainder = monthlyBudget - rentCost - groceryCost - utilityCost - carCost - hbaCost - nessCost - extraCost - insCost;
            lblMonthlyRemainder.Text = $"Monthly Remainder: ${monthlyRemainder:n2}";
        }
    }
}
