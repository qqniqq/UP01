using System;
namespace Hospital.Lib.Models
{
    public class RequestView
    {
        public string Id { get; set; }
        public string DepartmentName { get; set; }
        public string DrugName { get; set; }
        public int Quantity { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; }
        public string Comment { get; set; }
    }
}
