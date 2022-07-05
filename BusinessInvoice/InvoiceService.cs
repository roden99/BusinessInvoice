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


        public async Task<Boolean> AddInvoice(CustomerInvoice model, DataGridView dg)
        {

            IDbConnection con = new SqlConnection(conClientManagementDB);
            con.Open();
            IDbTransaction tran = con.BeginTransaction();
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("InvoiceNumber", model.InvoiceNumber);

                param.Add("Reference", model.Reference);
                param.Add("IssueDate", model.IssueDate);
                param.Add("DueDate", model.DueDate);

               int InvoiceID= await SqlMapper.ExecuteScalarAsync<int>(con, "sp_Add_Invoice", param, tran, commandType: CommandType.StoredProcedure);


                for (int i = 0; i < dg.Rows.Count; i++)
                {

                    param = new DynamicParameters();
                    param.Add("InvoiceID", InvoiceID);
                    param.Add("Description", dg["ColDescription",i].Value.ToString());
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
