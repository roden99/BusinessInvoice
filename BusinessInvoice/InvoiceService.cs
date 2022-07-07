using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusinessInvoice
{
   public class InvoiceService : DataAccess
    {


        public async Task<Boolean> AddInvoice(CustomerInvoice invModel, DataGridView dg)
        {

            IDbConnection con = new SqlConnection(conClientManagementDB);
            con.Open();
            IDbTransaction tran = con.BeginTransaction();
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("InvoiceNumber", invModel.InvoiceNumber);

                param.Add("Reference", invModel.Reference);
                param.Add("IssueDate", invModel.IssueDate);
                param.Add("DueDate", invModel.DueDate);

               int InvoiceID= await SqlMapper.ExecuteScalarAsync<int>(con, "sp_Add_Invoice", param, tran, commandType: CommandType.StoredProcedure);


                for (int i = 0; i < dg.Rows.Count; i++)
                {

                    param = new DynamicParameters();
                    param.Add("InvoiceID", InvoiceID);
                    param.Add("Description", dg["ColDescription",i].Value.ToString());
                    param.Add("Quantity", dg["Colqty", i].Value.ToString());
                    param.Add("Unitprice", dg["ColUnitprice", i].Value.ToString());
                    param.Add("Discount",dg["ColDiscount",i].Value.ToString());
                    param.Add("TaxRate",dg["ColTaxRate",i].Value.ToString());

                    
                    await SqlMapper.ExecuteScalarAsync<int>(con, "sp_Add_InvoiceItems", param, tran, commandType: CommandType.StoredProcedure);
                    
                }




                tran.Commit();
                con.Close();
                return true;

            }


            catch(Exception Error)
            {
                MessageBox.Show(Error.Message,"System Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tran.Rollback();
                return false;

            }

        }
    }
}
