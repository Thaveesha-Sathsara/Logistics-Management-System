using eShiftTransportSystem;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace eShiftTransportSystem
{
    public static class DataManager
    {
        private static readonly string CustomersFilePath = "customers.json";
        private static readonly string JobsFilePath = "jobs.json";

        public static void SaveData()
        {
            try
            {
                // Save Customers
                string customersJson = JsonConvert.SerializeObject(eShiftTransportSystem.Program.Customers, Formatting.Indented);
                File.WriteAllText(CustomersFilePath, customersJson);

                // Save Jobs
                string jobsJson = JsonConvert.SerializeObject(eShiftTransportSystem.Program.Jobs, Formatting.Indented);
                File.WriteAllText(JobsFilePath, jobsJson);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error saving data: {ex.Message}", "Save Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public static void LoadData()
        {
            try
            {
                // Load Customers
                if (File.Exists(CustomersFilePath))
                {
                    string customersJson = File.ReadAllText(CustomersFilePath);
                    eShiftTransportSystem.Program.Customers = JsonConvert.DeserializeObject<List<Customer>>(customersJson) ?? new List<Customer>();
                }
                else
                {
                    eShiftTransportSystem.Program.Customers = new List<Customer>();
                }

                // Load Jobs
                if (File.Exists(JobsFilePath))
                {
                    string jobsJson = File.ReadAllText(JobsFilePath);
                    eShiftTransportSystem.Program.Jobs = JsonConvert.DeserializeObject<List<Job>>(jobsJson) ?? new List<Job>();
                }
                else
                {
                    eShiftTransportSystem.Program.Jobs = new List<Job>();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error loading data: {ex.Message}", "Load Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                // Initialize empty lists in case of load failure to prevent null reference exceptions
                eShiftTransportSystem.Program.Customers = new List<Customer>();
                eShiftTransportSystem.Program.Jobs = new List<Job>();
            }
        }
    }

}