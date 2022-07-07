using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
    public class InvoiceItems
    {
        public string Description{ get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string Discount { get; set; }
        public string TaxRate { get; set;  }

    }
}
