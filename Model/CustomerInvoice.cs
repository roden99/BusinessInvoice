using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class CustomerInvoice
    {

        public int ID { get; set; }
        public string InvoiceNumber { get; set; }
        public string Reference { get; set; }
        public string IssueDate { get; set; }
        public string DueDate { get; set; }



    }
}
