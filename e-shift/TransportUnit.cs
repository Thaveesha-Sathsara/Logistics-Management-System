using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShiftTransportSystem
{
    public class TransportUnit
    {
        public int UnitId { get; set; }
        public string LorryNumber { get; set; }
        public double CapacityInTons { get; set; }
        public string DriverName { get; set; }
        public string AssistantName { get; set; }
        public string ContainerType { get; set; }
        public string ContactNumber { get; set; }
        public string CurrentLocation { get; set; }

        public bool IsAvailable { get; set; } // For allocation, default to true

        // Constructor for initial values (optional but good practice)
        public TransportUnit()
        {
            IsAvailable = true; // New units are available by default
            CurrentLocation = "Depot"; // Default starting location
            // CapacityInTons and other strings would be set when adding the unit
        }

        // Override ToString for clearer display in ComboBoxes or DataGridViews
        public override string ToString()
        {
            return $"{LorryNumber} ({ContainerType}, {CapacityInTons} tons) - {(IsAvailable ? "Available" : "Assigned")}";
        }
    }
}