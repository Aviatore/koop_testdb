using System;

namespace Koop.Models
{
    public class CoopOrderHistory
    {
        public Int64 CoopId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime OrderStopDate { get; set; }
        public string Price { get; set; }
        public string OrderStatusName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}