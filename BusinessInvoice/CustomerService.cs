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
    public class CustomerService : DataAccess
    {
        public async Task<int> AddCustomer(Customer model, CustomerLog log)
        {
            int ID = 0;
            using (IDbConnection con = new SqlConnection(conClientManagementDB))
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        DynamicParameters param = new DynamicParameters();
                        param.Add("CompanyName", model.CompanyName);
                        param.Add("AccountNumber", model.AccountNumber);
                        param.Add("PrimaryPersonFirstName", model.PrimaryPersonFirstName);
                        param.Add("PrimaryPersonLastName", model.PrimaryPersonLastName);
                        param.Add("Email", model.Email);
                        param.Add("PhoneCountry", model.PhoneCountry);
                        param.Add("PhoneArea", model.PhoneArea);
                        param.Add("PhoneNumber", model.PhoneNumber);
                        param.Add("FoxCountry", model.FoxCountry);
                        param.Add("FoxArea", model.FoxArea);
                        param.Add("FoxNumber", model.FoxNumber);
                        param.Add("MobileCountry", model.MobileCountry);
                        param.Add("MobileArea", model.MobileArea);
                        param.Add("MobileNumber", model.MobileNumber);
                        param.Add("DirectDialCountry", model.DirectDialCountry);
                        param.Add("DirectDialArea", model.DirectDialArea);
                        param.Add("DirectDialNumber", model.DirectDialNumber);
                        param.Add("SkypeName", model.SkypeName);
                        param.Add("Website", model.Website);
                        param.Add("PostalAttention", model.PostalAttention);
                        param.Add("PostalAddress", model.PostalAddress);
                        param.Add("PostalCityTown", model.PostalCityTown);
                        param.Add("PostalStateRegion", model.PostalStateRegion);
                        param.Add("PostalZIP", model.PostalZIP);
                        param.Add("PostalCountry", model.PostalCountry);
                        param.Add("StreetAttention", model.StreetAttention);
                        param.Add("StreetAddress", model.StreetAddress);
                        param.Add("StreetCityTown", model.StreetCityTown);
                        param.Add("StreetStateRegion", model.StreetStateRegion);
                        param.Add("StreetZIP", model.StreetZIP);
                        param.Add("StreetCountry", model.StreetCountry);
                        param.Add("CreatedBy", model.CreatedBy);

                        ID = await SqlMapper.ExecuteScalarAsync<int>(con, "SP_TXINV_AddCustomer", param, tran, commandType: CommandType.StoredProcedure);
                        if(ID > 0)
                        {
                            param = new DynamicParameters();
                            param.Add("GroupID", log.GroupID);
                            param.Add("CustomerID", ID);
                            param.Add("Description", log.Description);
                            param.Add("UserName", log.UserName);
                            if(await SqlMapper.ExecuteScalarAsync<long>(con, "sp_TXINV_AddCustomerLog", param, tran, commandType: CommandType.StoredProcedure) > 0)
                            {
                                tran.Commit();
                            }
                            else
                            {
                                ID = 0;
                                tran.Rollback();
                            }
                        }
                        else
                        {
                            ID = 0;
                            tran.Rollback();
                        }
                    }
                    catch(Exception ex)
                    {
                        ID = 0;
                        tran.Rollback();
                    }
                }
                con.Close();
            }
            return ID;
        }

        public async Task<List<Customer>> GetCustomerByNameSearch(string NameSearch = "")
        {
            List<Customer> customers = new List<Customer>();

            using(IDbConnection con = new SqlConnection(conClientManagementDB))
            {
                con.Open();

                DynamicParameters param = new DynamicParameters();
                param.Add("NameSearch", NameSearch);
                customers = (await SqlMapper.QueryAsync<Customer>(con, "sp_TXINV_GetCustomerByNameSearch", param, commandType: CommandType.StoredProcedure)).ToList();

                con.Close();
            }

            return customers;
        }

        public async Task<List<Customer>> GetCustomerByCompanyName(string CompanyName)
        {
            List<Customer> customers = new List<Customer>();

            using (IDbConnection con = new SqlConnection(conClientManagementDB))
            {
                con.Open();

                DynamicParameters param = new DynamicParameters();
                param.Add("CompanyName", CompanyName);
                customers = (await SqlMapper.QueryAsync<Customer>(con, "sp_TXINV_GetCustomerByCompanyName", param, commandType: CommandType.StoredProcedure)).ToList();

                con.Close();
            }

            return customers;
        }

        public async Task<Customer> GetCustomerByID(int ID)
        {
            Customer customer = new Customer();

            using (IDbConnection con = new SqlConnection(conClientManagementDB))
            {
                con.Open();

                DynamicParameters param = new DynamicParameters();
                param.Add("ID", ID);
                customer = (await SqlMapper.QueryAsync<Customer>(con, "sp_TXINV_GetCustomerByID", param, commandType: CommandType.StoredProcedure)).FirstOrDefault();

                con.Close();
            }

            return customer;
        }

        public async Task<bool> UpdateCustomer(Customer model, List<CustomerLog> logs)
        {
            int rowsAffected = 0;
            bool isUpdated = false;
            using (IDbConnection con = new SqlConnection(conClientManagementDB))
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        DynamicParameters param = new DynamicParameters();
                        param.Add("ID", model.ID);
                        param.Add("CompanyName", model.CompanyName);
                        param.Add("AccountNumber", model.AccountNumber);
                        param.Add("PrimaryPersonFirstName", model.PrimaryPersonFirstName);
                        param.Add("PrimaryPersonLastName", model.PrimaryPersonLastName);
                        param.Add("Email", model.Email);
                        param.Add("PhoneCountry", model.PhoneCountry);
                        param.Add("PhoneArea", model.PhoneArea);
                        param.Add("PhoneNumber", model.PhoneNumber);
                        param.Add("FoxCountry", model.FoxCountry);
                        param.Add("FoxArea", model.FoxArea);
                        param.Add("FoxNumber", model.FoxNumber);
                        param.Add("MobileCountry", model.MobileCountry);
                        param.Add("MobileArea", model.MobileArea);
                        param.Add("MobileNumber", model.MobileNumber);
                        param.Add("DirectDialCountry", model.DirectDialCountry);
                        param.Add("DirectDialArea", model.DirectDialArea);
                        param.Add("DirectDialNumber", model.DirectDialNumber);
                        param.Add("SkypeName", model.SkypeName);
                        param.Add("Website", model.Website);
                        param.Add("PostalAttention", model.PostalAttention);
                        param.Add("PostalAddress", model.PostalAddress);
                        param.Add("PostalCityTown", model.PostalCityTown);
                        param.Add("PostalStateRegion", model.PostalStateRegion);
                        param.Add("PostalZIP", model.PostalZIP);
                        param.Add("PostalCountry", model.PostalCountry);
                        param.Add("StreetAttention", model.StreetAttention);
                        param.Add("StreetAddress", model.StreetAddress);
                        param.Add("StreetCityTown", model.StreetCityTown);
                        param.Add("StreetStateRegion", model.StreetStateRegion);
                        param.Add("StreetZIP", model.StreetZIP);
                        param.Add("StreetCountry", model.StreetCountry);
                        param.Add("ModifiedBy", model.ModifiedBy);

                        rowsAffected = await SqlMapper.ExecuteScalarAsync<int>(con, "SP_TXINV_UpdateCustomer", param, tran, commandType: CommandType.StoredProcedure);
                        if (rowsAffected == 1)
                        {
                            int logger = 0;
                            foreach (var log in logs)
                            {
                                param = new DynamicParameters();
                                param.Add("GroupID", log.GroupID);
                                param.Add("CustomerID", log.ID);
                                param.Add("Description", log.Description);
                                param.Add("UserName", log.UserName);
                                if (await SqlMapper.ExecuteScalarAsync<long>(con, "sp_TXINV_AddCustomerLog", param, tran, commandType: CommandType.StoredProcedure) > 0)
                                {
                                    logger++;
                                }
                            }

                            if(logger == logs.Count)
                            {
                                isUpdated = true;
                                tran.Commit();
                            }
                        }
                        else
                        {
                            isUpdated = false;
                            tran.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        isUpdated = false;
                        tran.Rollback();
                    }
                }
                con.Close();
            }
            return isUpdated;
        }

        public async Task<bool> ArchiveCustomer(Customer model, CustomerLog log)
        {
            int rowsAffected = 0;
            bool isUpdated = false;
            using (IDbConnection con = new SqlConnection(conClientManagementDB))
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        DynamicParameters param = new DynamicParameters();
                        param.Add("ID", model.ID);
                        rowsAffected = await SqlMapper.ExecuteScalarAsync<int>(con, "sp_TXINV_ArchiveCustomer", param, tran, commandType: CommandType.StoredProcedure);
                        if (rowsAffected == 1)
                        {
                            param = new DynamicParameters();
                            param.Add("GroupID", log.GroupID);
                            param.Add("CustomerID", log.ID);
                            param.Add("Description", log.Description);
                            param.Add("UserName", log.UserName);
                            if (await SqlMapper.ExecuteScalarAsync<long>(con, "sp_TXINV_AddCustomerLog", param, tran, commandType: CommandType.StoredProcedure) > 0)
                            {
                                isUpdated = true;
                                tran.Commit();
                            }
                        }
                        else
                        {
                            isUpdated = false;
                            tran.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        isUpdated = false;
                        tran.Rollback();
                    }
                }
                con.Close();
            }
            return isUpdated;
        }
    }
}
