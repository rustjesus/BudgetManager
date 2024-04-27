using System;

public class WeeklyToggle
{
	public WeeklyToggle()
    {
        public void UseWeeklyInput()
        {

            //hide hourly
            tbHourlyIncome.Visible = false;
            tbHoursPerWeek.Visible = false;
            label_HoursPerWeek.Visible = false;
            label_PerHourInput.Visible = false;
        }
        public void UseHourlyInput()
        {

            //show hourly
            tbHourlyIncome.Visible = true;
            tbHoursPerWeek.Visible = true;
            label_HoursPerWeek.Visible = true;
            label_PerHourInput.Visible = true;
        }
    }
}
