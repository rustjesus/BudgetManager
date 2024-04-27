using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BudgetManager
{
    internal class DarkMode
    {
        public bool usingDarkMode = false;
        public void SaveDarkModeSetting()
        {
            // Map the boolean darkMode to an integer (0 for false, 1 for true)
            int darkModeValue = usingDarkMode ? 1 : 0;

            // Create an anonymous object to hold our setting
            var settings = new { DarkMode = darkModeValue };

            // Convert the settings object to a JSON string
            string json = JsonConvert.SerializeObject(settings);

            // Define the path to the settings file in the application folder
            string appFolder = Application.StartupPath;
            string settingsFilePath = Path.Combine(appFolder, "darkModeSetting.json");

            // Write the JSON string to the file
            File.WriteAllText(settingsFilePath, json);
        }

        public int LoadDarkModeSetting()
        {
            // Define the path to the settings file in the application folder
            string appFolder = Application.StartupPath;
            string settingsFilePath = Path.Combine(appFolder, "darkModeSetting.json");

            // Check if the settings file exists
            if (File.Exists(settingsFilePath))
            {
                // Read the JSON string from the file
                string json = File.ReadAllText(settingsFilePath);

                // Deserialize the JSON string to an anonymous type matching the expected structure
                var settings = JsonConvert.DeserializeObject<dynamic>(json);

                // Return the DarkMode value as an integer
                return (int)settings.DarkMode;
            }
            else
            {
                SaveDarkModeSetting();
            }

            // If the file doesn't exist or an error occurs, default to 0 (false)
            return 0;
        }
        public void EnableDarkMode()
        {
            var form1 = Application.OpenForms[0];

            form1.BackColor = Color.Black;

            foreach (Control c in form1.Controls)
            {
                if (c is Label || c is CheckBox)
                {
                    c.ForeColor = Color.White;
                }
            }
        }
        public void EnableRegularMode()
        {

            var form1 = Application.OpenForms[0];

            form1.BackColor = Color.White;

            foreach (Control c in form1.Controls)
            {
                if (c is Label || c is CheckBox)
                {
                    c.ForeColor = Color.Black;
                }
            }
        }
    }
}
