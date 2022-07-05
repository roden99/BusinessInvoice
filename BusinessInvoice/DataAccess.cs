using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInvoice
{
    public abstract class DataAccess
    {
        protected static string conClientManagementDB = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString.ToString();

     
    }
}
