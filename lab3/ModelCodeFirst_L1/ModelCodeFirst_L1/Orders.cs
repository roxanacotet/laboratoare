using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCodeFirst_L1
{
    public class Orders
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
