namespace BudgetManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAnnualIncome = new System.Windows.Forms.Label();
            this.lbMonthlyRemainder = new System.Windows.Forms.Label();
            this.lbMonthlyBudget = new System.Windows.Forms.Label();
            this.tbHourlyIncome = new System.Windows.Forms.TextBox();
            this.label_PerHourInput = new System.Windows.Forms.Label();
            this.label_HoursPerWeek = new System.Windows.Forms.Label();
            this.tbHoursPerWeek = new System.Windows.Forms.TextBox();
            this.cbUseWeeklyInput = new System.Windows.Forms.CheckBox();
            this.lbWeeklyIncome = new System.Windows.Forms.Label();
            this.tbWeeklyIncome = new System.Windows.Forms.TextBox();
            this.lbExpenses = new System.Windows.Forms.Label();
            this.lbRent = new System.Windows.Forms.Label();
            this.tbRent = new System.Windows.Forms.TextBox();
            this.tbGrocery = new System.Windows.Forms.TextBox();
            this.lbGrocery = new System.Windows.Forms.Label();
            this.tbUtilities = new System.Windows.Forms.TextBox();
            this.lbUtilities = new System.Windows.Forms.Label();
            this.lbCar = new System.Windows.Forms.Label();
            this.tbCar = new System.Windows.Forms.TextBox();
            this.lbHBA = new System.Windows.Forms.Label();
            this.tbHBA = new System.Windows.Forms.TextBox();
            this.tbNecessities = new System.Windows.Forms.TextBox();
            this.lbNecessities = new System.Windows.Forms.Label();
            this.tbExtra = new System.Windows.Forms.TextBox();
            this.lbExtra = new System.Windows.Forms.Label();
            this.tbInsurance = new System.Windows.Forms.TextBox();
            this.lbInsurance = new System.Windows.Forms.Label();
            this.lbTaxRate = new System.Windows.Forms.Label();
            this.tbTaxRate = new System.Windows.Forms.TextBox();
            this.lbVer = new System.Windows.Forms.Label();
            this.cbDarkMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbAnnualIncome
            // 
            this.lbAnnualIncome.AutoSize = true;
            this.lbAnnualIncome.Location = new System.Drawing.Point(62, 236);
            this.lbAnnualIncome.Name = "lbAnnualIncome";
            this.lbAnnualIncome.Size = new System.Drawing.Size(138, 13);
            this.lbAnnualIncome.TabIndex = 0;
            this.lbAnnualIncome.Text = "Annual Income After Taxes:";
            // 
            // lbMonthlyRemainder
            // 
            this.lbMonthlyRemainder.AutoSize = true;
            this.lbMonthlyRemainder.Location = new System.Drawing.Point(62, 281);
            this.lbMonthlyRemainder.Name = "lbMonthlyRemainder";
            this.lbMonthlyRemainder.Size = new System.Drawing.Size(101, 13);
            this.lbMonthlyRemainder.TabIndex = 1;
            this.lbMonthlyRemainder.Text = "Monthly Remainder:";
            // 
            // lbMonthlyBudget
            // 
            this.lbMonthlyBudget.AutoSize = true;
            this.lbMonthlyBudget.Location = new System.Drawing.Point(62, 259);
            this.lbMonthlyBudget.Name = "lbMonthlyBudget";
            this.lbMonthlyBudget.Size = new System.Drawing.Size(84, 13);
            this.lbMonthlyBudget.TabIndex = 2;
            this.lbMonthlyBudget.Text = "Monthly Budget:";
            // 
            // tbHourlyIncome
            // 
            this.tbHourlyIncome.Location = new System.Drawing.Point(108, 6);
            this.tbHourlyIncome.Name = "tbHourlyIncome";
            this.tbHourlyIncome.Size = new System.Drawing.Size(100, 20);
            this.tbHourlyIncome.TabIndex = 3;
            this.tbHourlyIncome.TextChanged += new System.EventHandler(this.perHourInputBox_TextChanged);
            // 
            // label_PerHourInput
            // 
            this.label_PerHourInput.AutoSize = true;
            this.label_PerHourInput.Location = new System.Drawing.Point(12, 9);
            this.label_PerHourInput.Name = "label_PerHourInput";
            this.label_PerHourInput.Size = new System.Drawing.Size(90, 13);
            this.label_PerHourInput.TabIndex = 4;
            this.label_PerHourInput.Text = "Income Per Hour:";
            // 
            // label_HoursPerWeek
            // 
            this.label_HoursPerWeek.AutoSize = true;
            this.label_HoursPerWeek.Location = new System.Drawing.Point(12, 40);
            this.label_HoursPerWeek.Name = "label_HoursPerWeek";
            this.label_HoursPerWeek.Size = new System.Drawing.Size(89, 13);
            this.label_HoursPerWeek.TabIndex = 5;
            this.label_HoursPerWeek.Text = "Hours Per Week:";
            // 
            // tbHoursPerWeek
            // 
            this.tbHoursPerWeek.Location = new System.Drawing.Point(107, 37);
            this.tbHoursPerWeek.Name = "tbHoursPerWeek";
            this.tbHoursPerWeek.Size = new System.Drawing.Size(100, 20);
            this.tbHoursPerWeek.TabIndex = 6;
            this.tbHoursPerWeek.TextChanged += new System.EventHandler(this.tbHoursPerWeek_TextChanged);
            // 
            // cbUseWeeklyInput
            // 
            this.cbUseWeeklyInput.AutoSize = true;
            this.cbUseWeeklyInput.ForeColor = System.Drawing.Color.Black;
            this.cbUseWeeklyInput.Location = new System.Drawing.Point(216, 9);
            this.cbUseWeeklyInput.Name = "cbUseWeeklyInput";
            this.cbUseWeeklyInput.Size = new System.Drawing.Size(111, 17);
            this.cbUseWeeklyInput.TabIndex = 7;
            this.cbUseWeeklyInput.Text = "Use Weekly Input";
            this.cbUseWeeklyInput.UseVisualStyleBackColor = true;
            this.cbUseWeeklyInput.CheckedChanged += new System.EventHandler(this.cbUseWeeklyInput_CheckedChanged);
            // 
            // lbWeeklyIncome
            // 
            this.lbWeeklyIncome.AutoSize = true;
            this.lbWeeklyIncome.Location = new System.Drawing.Point(53, 9);
            this.lbWeeklyIncome.Name = "lbWeeklyIncome";
            this.lbWeeklyIncome.Size = new System.Drawing.Size(84, 13);
            this.lbWeeklyIncome.TabIndex = 8;
            this.lbWeeklyIncome.Text = "Weekly Income:";
            // 
            // tbWeeklyIncome
            // 
            this.tbWeeklyIncome.Location = new System.Drawing.Point(46, 25);
            this.tbWeeklyIncome.Name = "tbWeeklyIncome";
            this.tbWeeklyIncome.Size = new System.Drawing.Size(100, 20);
            this.tbWeeklyIncome.TabIndex = 9;
            this.tbWeeklyIncome.TextChanged += new System.EventHandler(this.tbWeeklyIncome_TextChanged);
            // 
            // lbExpenses
            // 
            this.lbExpenses.AutoSize = true;
            this.lbExpenses.Location = new System.Drawing.Point(333, 13);
            this.lbExpenses.Name = "lbExpenses";
            this.lbExpenses.Size = new System.Drawing.Size(108, 13);
            this.lbExpenses.TabIndex = 10;
            this.lbExpenses.Text = "Expenses Per Month:";
            // 
            // lbRent
            // 
            this.lbRent.AutoSize = true;
            this.lbRent.Location = new System.Drawing.Point(333, 40);
            this.lbRent.Name = "lbRent";
            this.lbRent.Size = new System.Drawing.Size(33, 13);
            this.lbRent.TabIndex = 11;
            this.lbRent.Text = "Rent:";
            // 
            // tbRent
            // 
            this.tbRent.Location = new System.Drawing.Point(336, 56);
            this.tbRent.Name = "tbRent";
            this.tbRent.Size = new System.Drawing.Size(100, 20);
            this.tbRent.TabIndex = 12;
            this.tbRent.TextChanged += new System.EventHandler(this.tbRent_TextChanged);
            // 
            // tbGrocery
            // 
            this.tbGrocery.Location = new System.Drawing.Point(336, 97);
            this.tbGrocery.Name = "tbGrocery";
            this.tbGrocery.Size = new System.Drawing.Size(100, 20);
            this.tbGrocery.TabIndex = 13;
            this.tbGrocery.TextChanged += new System.EventHandler(this.tbGrocery_TextChanged);
            // 
            // lbGrocery
            // 
            this.lbGrocery.AutoSize = true;
            this.lbGrocery.Location = new System.Drawing.Point(333, 79);
            this.lbGrocery.Name = "lbGrocery";
            this.lbGrocery.Size = new System.Drawing.Size(47, 13);
            this.lbGrocery.TabIndex = 14;
            this.lbGrocery.Text = "Grocery:";
            // 
            // tbUtilities
            // 
            this.tbUtilities.Location = new System.Drawing.Point(336, 136);
            this.tbUtilities.Name = "tbUtilities";
            this.tbUtilities.Size = new System.Drawing.Size(100, 20);
            this.tbUtilities.TabIndex = 15;
            this.tbUtilities.TextChanged += new System.EventHandler(this.tbUtilities_TextChanged);
            // 
            // lbUtilities
            // 
            this.lbUtilities.AutoSize = true;
            this.lbUtilities.Location = new System.Drawing.Point(333, 120);
            this.lbUtilities.Name = "lbUtilities";
            this.lbUtilities.Size = new System.Drawing.Size(43, 13);
            this.lbUtilities.TabIndex = 16;
            this.lbUtilities.Text = "Utilities:";
            // 
            // lbCar
            // 
            this.lbCar.AutoSize = true;
            this.lbCar.Location = new System.Drawing.Point(333, 159);
            this.lbCar.Name = "lbCar";
            this.lbCar.Size = new System.Drawing.Size(50, 13);
            this.lbCar.TabIndex = 17;
            this.lbCar.Text = "Car Cost:";
            // 
            // tbCar
            // 
            this.tbCar.Location = new System.Drawing.Point(336, 175);
            this.tbCar.Name = "tbCar";
            this.tbCar.Size = new System.Drawing.Size(100, 20);
            this.tbCar.TabIndex = 18;
            this.tbCar.TextChanged += new System.EventHandler(this.tbCar_TextChanged);
            // 
            // lbHBA
            // 
            this.lbHBA.AutoSize = true;
            this.lbHBA.Location = new System.Drawing.Point(333, 198);
            this.lbHBA.Name = "lbHBA";
            this.lbHBA.Size = new System.Drawing.Size(56, 13);
            this.lbHBA.TabIndex = 19;
            this.lbHBA.Text = "HBA Cost:";
            // 
            // tbHBA
            // 
            this.tbHBA.Location = new System.Drawing.Point(336, 214);
            this.tbHBA.Name = "tbHBA";
            this.tbHBA.Size = new System.Drawing.Size(100, 20);
            this.tbHBA.TabIndex = 20;
            this.tbHBA.TextChanged += new System.EventHandler(this.tbHBA_TextChanged);
            // 
            // tbNecessities
            // 
            this.tbNecessities.Location = new System.Drawing.Point(336, 256);
            this.tbNecessities.Name = "tbNecessities";
            this.tbNecessities.Size = new System.Drawing.Size(100, 20);
            this.tbNecessities.TabIndex = 21;
            this.tbNecessities.TextChanged += new System.EventHandler(this.tbNecessities_TextChanged);
            // 
            // lbNecessities
            // 
            this.lbNecessities.AutoSize = true;
            this.lbNecessities.Location = new System.Drawing.Point(333, 240);
            this.lbNecessities.Name = "lbNecessities";
            this.lbNecessities.Size = new System.Drawing.Size(64, 13);
            this.lbNecessities.TabIndex = 22;
            this.lbNecessities.Text = "Necessities:";
            // 
            // tbExtra
            // 
            this.tbExtra.Location = new System.Drawing.Point(336, 336);
            this.tbExtra.Name = "tbExtra";
            this.tbExtra.Size = new System.Drawing.Size(100, 20);
            this.tbExtra.TabIndex = 23;
            this.tbExtra.TextChanged += new System.EventHandler(this.tbExtra_TextChanged);
            // 
            // lbExtra
            // 
            this.lbExtra.AutoSize = true;
            this.lbExtra.Location = new System.Drawing.Point(333, 320);
            this.lbExtra.Name = "lbExtra";
            this.lbExtra.Size = new System.Drawing.Size(34, 13);
            this.lbExtra.TabIndex = 24;
            this.lbExtra.Text = "Extra:";
            // 
            // tbInsurance
            // 
            this.tbInsurance.Location = new System.Drawing.Point(336, 297);
            this.tbInsurance.Name = "tbInsurance";
            this.tbInsurance.Size = new System.Drawing.Size(100, 20);
            this.tbInsurance.TabIndex = 25;
            this.tbInsurance.TextChanged += new System.EventHandler(this.tbInsurance_TextChanged);
            // 
            // lbInsurance
            // 
            this.lbInsurance.AutoSize = true;
            this.lbInsurance.Location = new System.Drawing.Point(333, 281);
            this.lbInsurance.Name = "lbInsurance";
            this.lbInsurance.Size = new System.Drawing.Size(57, 13);
            this.lbInsurance.TabIndex = 26;
            this.lbInsurance.Text = "Insurance:";
            // 
            // lbTaxRate
            // 
            this.lbTaxRate.AutoSize = true;
            this.lbTaxRate.Location = new System.Drawing.Point(84, 120);
            this.lbTaxRate.Name = "lbTaxRate";
            this.lbTaxRate.Size = new System.Drawing.Size(62, 13);
            this.lbTaxRate.TabIndex = 28;
            this.lbTaxRate.Text = "Tax Rate %";
            // 
            // tbTaxRate
            // 
            this.tbTaxRate.Location = new System.Drawing.Point(65, 136);
            this.tbTaxRate.Name = "tbTaxRate";
            this.tbTaxRate.Size = new System.Drawing.Size(100, 20);
            this.tbTaxRate.TabIndex = 29;
            this.tbTaxRate.TextChanged += new System.EventHandler(this.tbTaxRate_TextChanged);
            // 
            // lbVer
            // 
            this.lbVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVer.AutoSize = true;
            this.lbVer.Location = new System.Drawing.Point(473, 428);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(41, 13);
            this.lbVer.TabIndex = 30;
            this.lbVer.Text = "Ver 0.5";
            // 
            // cbDarkMode
            // 
            this.cbDarkMode.AutoSize = true;
            this.cbDarkMode.ForeColor = System.Drawing.Color.Black;
            this.cbDarkMode.Location = new System.Drawing.Point(12, 427);
            this.cbDarkMode.Name = "cbDarkMode";
            this.cbDarkMode.Size = new System.Drawing.Size(79, 17);
            this.cbDarkMode.TabIndex = 31;
            this.cbDarkMode.Text = "Dark Mode";
            this.cbDarkMode.CheckedChanged += new System.EventHandler(this.cbDarkMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.cbDarkMode);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.tbTaxRate);
            this.Controls.Add(this.lbTaxRate);
            this.Controls.Add(this.lbInsurance);
            this.Controls.Add(this.tbInsurance);
            this.Controls.Add(this.lbExtra);
            this.Controls.Add(this.tbExtra);
            this.Controls.Add(this.lbNecessities);
            this.Controls.Add(this.tbNecessities);
            this.Controls.Add(this.tbHBA);
            this.Controls.Add(this.lbHBA);
            this.Controls.Add(this.tbCar);
            this.Controls.Add(this.lbCar);
            this.Controls.Add(this.lbUtilities);
            this.Controls.Add(this.tbUtilities);
            this.Controls.Add(this.lbGrocery);
            this.Controls.Add(this.tbGrocery);
            this.Controls.Add(this.tbRent);
            this.Controls.Add(this.lbRent);
            this.Controls.Add(this.lbExpenses);
            this.Controls.Add(this.tbWeeklyIncome);
            this.Controls.Add(this.lbWeeklyIncome);
            this.Controls.Add(this.cbUseWeeklyInput);
            this.Controls.Add(this.tbHoursPerWeek);
            this.Controls.Add(this.label_HoursPerWeek);
            this.Controls.Add(this.label_PerHourInput);
            this.Controls.Add(this.tbHourlyIncome);
            this.Controls.Add(this.lbMonthlyBudget);
            this.Controls.Add(this.lbMonthlyRemainder);
            this.Controls.Add(this.lbAnnualIncome);
            this.Name = "Form1";
            this.Text = "Budget Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnnualIncome;
        private System.Windows.Forms.Label lbMonthlyRemainder;
        private System.Windows.Forms.Label lbMonthlyBudget;
        private System.Windows.Forms.TextBox tbHourlyIncome;
        private System.Windows.Forms.Label label_PerHourInput;
        private System.Windows.Forms.Label label_HoursPerWeek;
        private System.Windows.Forms.TextBox tbHoursPerWeek;
        private System.Windows.Forms.CheckBox cbUseWeeklyInput;
        private System.Windows.Forms.Label lbWeeklyIncome;
        private System.Windows.Forms.TextBox tbWeeklyIncome;
        private System.Windows.Forms.Label lbExpenses;
        private System.Windows.Forms.Label lbRent;
        private System.Windows.Forms.TextBox tbRent;
        private System.Windows.Forms.TextBox tbGrocery;
        private System.Windows.Forms.Label lbGrocery;
        private System.Windows.Forms.TextBox tbUtilities;
        private System.Windows.Forms.Label lbUtilities;
        private System.Windows.Forms.Label lbCar;
        private System.Windows.Forms.TextBox tbCar;
        private System.Windows.Forms.Label lbHBA;
        private System.Windows.Forms.TextBox tbHBA;
        private System.Windows.Forms.TextBox tbNecessities;
        private System.Windows.Forms.Label lbNecessities;
        private System.Windows.Forms.TextBox tbExtra;
        private System.Windows.Forms.Label lbExtra;
        private System.Windows.Forms.TextBox tbInsurance;
        private System.Windows.Forms.Label lbInsurance;
        private System.Windows.Forms.Label lbTaxRate;
        private System.Windows.Forms.TextBox tbTaxRate;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.CheckBox cbDarkMode;
    }
}

