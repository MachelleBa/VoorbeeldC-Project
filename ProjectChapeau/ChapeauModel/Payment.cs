using System;
using System.Collections.Generic;

namespace Chapeau_Model
{
    public class Payment //Sophie
    {
        public int EmployeeId { get; set; }
        public int OrderId { get; set; }
        public double Vat { get; set; }
        public double Tip { get; set; }
        public double InitialPrice { get; set; }
        public double TotalPrice { get; set; }
        public string Comments { get; set; }
        public DateTime TimePayed { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<OrderItems> OrderItems { get; set; }

        public Payment()
        {

        }
    }
}
