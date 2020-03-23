using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCodeFirst_L1
{
    public class OrderDetails
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public Orders Order { get; set; }
    }
}
