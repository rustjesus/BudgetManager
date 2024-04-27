using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BudgetManager
{
    public partial class Form1 : Form
    {
        private bool usingHourlyInput = false;
        // Variables to hold costs and income data
        private float monthlyBudget, monthlyRemainder;
        private float rentCost, groceryCost, utilityCost, carCost, hbaCost, nessCost, extraCost, insCost;
        private float weeklyIncome, taxPercent, hourlyIncome, hoursPerWeek, finalAnnIncome;
        private DarkMode darkMode;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //controls
            //checkboxes
            Controls.Add(cbUseWeeklyInput);
            Controls.Add(cbDarkMode);
            //expenses
            Controls.Add(lbExpenses);
            Controls.Add(lbRent);
            Controls.Add(lbGrocery);
            Controls.Add(lbUtilities);
            Controls.Add(lbCar);
            Controls.Add(lbHBA);
            Controls.Add(lbExtra);
            Controls.Add(lbNecessities);
            Controls.Add(lbInsurance);
            //income
            Controls.Add(lbWeeklyIncome);
            Controls.Add(lbTaxRate);
            Controls.Add(label_HoursPerWeek);
            Controls.Add(label_PerHourInput);
            Controls.Add(lbAnnualIncome);
            Controls.Add(lbMonthlyBudget);
            Controls.Add(lbMonthlyRemainder);
            Controls.Add(lbVer);


            //references
            darkMode = new DarkMode();

            int dm = darkMode.LoadDarkModeSetting();
            {
                if(dm == 0)
                {
                    cbDarkMode.Checked = false;
                    darkMode.EnableRegularMode();
                }
                else
                {
                    cbDarkMode.Checked = true;
                    darkMode.EnableDarkMode();
                }
            }
            UseHourlyInput();

        }
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

        private void cbDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            darkMode.usingDarkMode = !darkMode.usingDarkMode;

            if (darkMode.usingDarkMode)
            {
                darkMode.EnableDarkMode();
                darkMode.SaveDarkModeSetting();
            }
            else
            {
                darkMode.EnableRegularMode();
                darkMode.SaveDarkModeSetting();
            }
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
            lbAnnualIncome.Text = $"{finalAnnIncome:n2}$ / Year After Taxes";

            UpdateMonthlyBudget();

        }

        private void UpdateMonthlyBudget()
        {
            monthlyBudget = finalAnnIncome / 12;
            lbMonthlyBudget.Text = $"Monthly Budget: ${monthlyBudget:n2}";

            UpdateMonthlyRemainder();
        }

        private void UpdateMonthlyRemainder()
        {
            monthlyRemainder = monthlyBudget - rentCost - groceryCost - utilityCost - carCost - hbaCost - nessCost - extraCost - insCost;
            lbMonthlyRemainder.Text = $"Monthly Remainder: ${monthlyRemainder:n2}";
        }
    }
}
