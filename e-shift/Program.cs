using eShiftTransportSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eShiftTransportSystem
{
    static class Program
    {
        public static List<Customer> Customers = new List<Customer>();
        public static List<Job> Jobs = new List<Job>();
        public static List<Product> Products = new List<Product>();
        public static List<TransportUnit> TransportUnits = new List<TransportUnit>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Load all data when application starts
            DataManager.LoadData();

            // Add initial dummy admin/customer if lists are empty (for testing)
            if (!Customers.Any())
            {
                Customers.Add(new Customer { Id = 1, Name = "Test Customer", NIC = "12345V", Contact = "0771234567", Address = "123 Main St", Username = "cust", Password = "cust123" });
                DataManager.SaveData();
            }
            if (!TransportUnits.Any())
            {
                TransportUnits.Add(new TransportUnit { UnitId = 1, LorryNumber = "ABC-1234", DriverName = "John Doe", AssistantName = "Jane Smith", ContainerType = "Large", IsAvailable = true, CapacityInTons = 10.0, CurrentLocation = "Colombo" });
                TransportUnits.Add(new TransportUnit { UnitId = 2, LorryNumber = "XYZ-5678", DriverName = "Peter Jones", AssistantName = "Alice Brown", ContainerType = "Medium", IsAvailable = true, CapacityInTons = 5.0, CurrentLocation = "Kandy" });
                DataManager.SaveData();
            }
            // Add initial dummy product if list is empty
            if (!Products.Any())
            {
                Products.Add(new Product { ProductId = 1, Name = "Electronics", Description = "Various electronic items", Weight = 5.5 });
                Products.Add(new Product { ProductId = 2, Name = "Furniture", Description = "Home furniture", Weight = 50.0 });
                DataManager.SaveData();
            }
            // Add initial dummy job if list is empty
            if (!Jobs.Any())
            {
                Jobs.Add(new Job
                {
                    JobId = 1,
                    CustomerId = 1, // Assuming customer ID 1 exists
                    CustomerName = "Test Customer",
                    PickupLocation = "Colombo",
                    DeliveryLocation = "Galle",
                    MoveDate = DateTime.Now.AddDays(7),
                    IsAssigned = false,
                    AssignedTransportUnitId = null,
                    JobStatus = Job.JobStatusEnum.Pending,
                    TotalWeight = 55.5 // Sum of dummy products added above
                });
                DataManager.SaveData();
            }


            Application.Run(new LoginForm());

            Application.ApplicationExit += new EventHandler(OnApplicationExit);
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            DataManager.SaveData();
        }
    }
}