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
        private float overTimeHours;
        private float overTimeRate = 1;
        private DarkMode darkMode; 
        private string currentCurrencySign = "$"; // Default currency

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCurrencyModeSetting();
            //controls (for dark mode)
            //checkboxes
            Controls.Add(menuStrip1);
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
            Controls.Add(lb_OT_MultiRate);
            Controls.Add(lb_OT_Thres);
            Controls.Add(lb_AnnIncomeBeforeTaxes);
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            currentCurrencySign = "$";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "€";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "£";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void jPYJapaneseYenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "¥";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void cNYChineseYuanToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "₹";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void swissFrancCHFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "CHF";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void russianRubleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "₽";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void brazilianRealRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "kr";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void southAfricanRandRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentCurrencySign = "₺";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();

        }

        private void singaporeDollarSToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentCurrencySign = "₩";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }

        private void dirhamدإToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentCurrencySign = " د.إ ";
            UpdateAnnualIncome();
            SaveCurrencyModeSetting();
        }
        public void SaveCurrencyModeSetting()
        {
            // Create an object to hold our setting
            var settings = new { CurrencySign = currentCurrencySign };

            // Convert the settings object to a JSON string
            string json = JsonConvert.SerializeObject(settings);

            // Define the path to the settings file in the application folder
            string appFolder = Application.StartupPath;
            string settingsFilePath = Path.Combine(appFolder, "currencySetting.json");

            // Write the JSON string to the file
            File.WriteAllText(settingsFilePath, json);
        }

        public string LoadCurrencyModeSetting()
        {
            // Define the path to the settings file in the application folder
            string appFolder = Application.StartupPath;
            string settingsFilePath = Path.Combine(appFolder, "currencySetting.json");

            // Check if the settings file exists
            if (File.Exists(settingsFilePath))
            {
                // Read the JSON string from the file
                string json = File.ReadAllText(settingsFilePath);

                // Deserialize the JSON string to an anonymous type matching the expected structure
                var settings = JsonConvert.DeserializeObject<dynamic>(json);

                // Return the CurrencySign value as a string
                return settings.CurrencySign;
            }
            else
            {
                // Save default settings if file does not exist
                SaveCurrencyModeSetting();
                return currentCurrencySign; // Assuming this is available in class scope
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
            lb_OT_MultiRate.Visible = false;
            lb_OT_Thres.Visible = false;
            tb_OT_MultiRate.Visible = false;
            tb_OT_Thres.Visible=false;
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
            lb_OT_MultiRate.Visible = true;
            lb_OT_Thres.Visible = true;
            tb_OT_MultiRate.Visible = true;
            tb_OT_Thres.Visible = true;
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
        /*
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMonthlyRemainder();
            UpdateAnnualIncome();
        }*/
        private void tb_OT_Thres_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(tb_OT_Thres.Text, out overTimeHours);
            UpdateWeeklyIncomeHours();
        }

        private void tb_OT_MultiRate_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tb_OT_MultiRate.Text, out overTimeRate);
            UpdateWeeklyIncomeHours();
        }


        public void UpdateWeeklyIncomeHours()
        {

            //over time
            float otRate = hourlyIncome * overTimeRate;
            float otIncome =  otRate * overTimeHours;
            //regular income
            float regIncome = hoursPerWeek * hourlyIncome;
            weeklyIncome = otIncome + regIncome;
            UpdateAnnualIncome();
        }
        private void UpdateAnnualIncome()
        {


            float yearly = weeklyIncome * 52;
            float newTaxPercent = taxPercent / 100;
            float yearlyTaxes = yearly * newTaxPercent;
            finalAnnIncome = yearly - yearlyTaxes;

            lb_AnnIncomeBeforeTaxes.Text = $"{currentCurrencySign}{yearly:n2} / Year Before Taxes";
            lbAnnualIncome.Text = $"{currentCurrencySign}{finalAnnIncome:n2} / Year After Taxes";

            UpdateMonthlyBudget();

        }

        private void UpdateMonthlyBudget()
        {
            monthlyBudget = finalAnnIncome / 12; 
            lbMonthlyBudget.Text = $"Monthly Budget: {currentCurrencySign}{monthlyBudget:n2}";

            UpdateMonthlyRemainder();
        }

        private void UpdateMonthlyRemainder()
        {
            monthlyRemainder = monthlyBudget - rentCost - groceryCost - utilityCost - carCost - hbaCost - nessCost - extraCost - insCost;

            lbMonthlyRemainder.Text = $"Monthly Budget: {currentCurrencySign}{monthlyRemainder:n2}";
        }
    }
}
