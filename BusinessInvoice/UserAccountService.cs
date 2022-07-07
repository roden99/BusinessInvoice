using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInvoice
{
    public class UserAccountService : DataAccess
    {
        public async Task<UserAccount> Get_UserAccount(int Id = 0, string Username = "", string Password = "")
        {
            UserAccount userAccount = new UserAccount();

            using(IDbConnection con = new SqlConnection(conClientManagementDB))
            {
                con.Open();

                DynamicParameters param = new DynamicParameters();
                if (Id > 0) param.Add("Id", Id);
                param.Add("Username", Username);
                param.Add("Password", Password);

                userAccount = (await SqlMapper.QueryAsync<UserAccount>(con, "sp_Get_UserAccount", param, commandType: CommandType.StoredProcedure)).FirstOrDefault();

                con.Close();
            }

            return userAccount;
        }
    }
}
