using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShiftTransportSystem
{
    public class Job
    {
        public int JobId { get; set; }

        // Customer details related to the job
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        // Job details
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime MoveDate { get; set; }

        // Assignment details
        public bool IsAssigned { get; set; }
        public int? AssignedTransportUnitId { get; set; }

        // Job JobStatus
        public JobStatusEnum JobStatus { get; set; }

        // Weight details
        public double TotalWeight { get; set; }

        public List<Product> ProductsInJob { get; set; } = new List<Product>();

        // Enum for Job JobStatus (nested inside Job class or defined globally in the namespace)
        public enum JobStatusEnum
        {
            Pending,
            Assigned,
            InProgress,
            Completed,
            Cancelled
        }

        // Constructor
        public Job()
        {
            IsAssigned = false;
            JobStatus = JobStatusEnum.Pending;
            ProductsInJob = new List<Product>();
        }

        public override string ToString()
        {
            return $"Job ID: {JobId} - {CustomerName} ({PickupLocation} to {DeliveryLocation}) - JobStatus: {JobStatus}";
        }
    }

}
