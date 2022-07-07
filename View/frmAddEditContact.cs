using BusinessInvoice;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmAddEditContact : DevExpress.XtraEditors.XtraForm
    {
        public int ID { get; set; } = 0;
        CustomerService customerService = new CustomerService();
        private Customer oldData { get; set; }
        public frmAddEditContact()
        {
            InitializeComponent();
        }

        private async void frmAddEditContact_Load(object sender, EventArgs e)
        {
            if (ID > 0)
                await GetCustomerDetail();
        }

        public async Task GetCustomerDetail()
        {
            SplashScreenManager.ShowForm(this, typeof(frmLoader), true, true, ParentFormState.Locked);
            Customer customer = new Customer();
            customer = await customerService.GetCustomerByID(ID);
            if (customer != null)
            {
                oldData = customer;

                txtCompanyName.Text = customer.CompanyName;
                if (customer.AccountNumber != "")
                {
                    labelControl2.Visible = true;
                    txtAccountNo.Visible = true;
                }
                txtAccountNo.Text = customer.AccountNumber;
                txtPersonFirstName.Text = customer.PrimaryPersonFirstName;
                txtPersonLastName.Text = customer.PrimaryPersonLastName;
                txtEmail.Text = customer.Email;
                txtPhoneCountry.Text = customer.PhoneCountry;
                txtPhoneArea.Text = customer.PhoneArea;
                txtPhoneNumber.Text = customer.PhoneNumber;
                txtFoxCountry.Text = customer.FoxCountry;
                txtFoxArea.Text = customer.FoxArea;
                txtFoxNumber.Text = customer.FoxNumber;
                txtMobileCountry.Text = customer.MobileCountry;
                txtMobileArea.Text = customer.MobileArea;
                txtMobileNumber.Text = customer.MobileNumber;
                txtDDialCountry.Text = customer.DirectDialCountry;
                txtDDialArea.Text = customer.DirectDialArea;
                txtDDialNumber.Text = customer.DirectDialNumber;
                txtSkypeName.Text = customer.SkypeName;
                txtWebsite.Text = customer.Website;
                txtPostalAttention.Text = customer.PostalAttention;
                txtPostalAddress.Text = customer.PostalAddress;
                txtPostalCityTown.Text = customer.PostalCityTown;
                txtPostalStateRegion.Text = customer.PostalStateRegion;
                txtPostalZIP.Text = customer.PostalZIP;
                txtPostalCountry.Text = customer.PostalCountry;
                txtStreetAttention.Text = customer.StreetAttention;
                txtStreetAddress.Text = customer.StreetAddress;
                txtStreetCityTown.Text = customer.StreetCityTown;
                txtStreetStateRegion.Text = customer.StreetStateRegion;
                txtStreetZIP.Text = customer.StreetZIP;
                txtStreetCountry.Text = customer.StreetCountry;
                SplashScreenManager.CloseForm();
            }
            else
            {
                MessageBox.Show("Customer Detail not found.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SplashScreenManager.CloseForm();
                this.Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(txtCompanyName.Text.Trim() == "")
            {
                highlighter1.SetHighlightColor(txtCompanyName, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                lblContactNameValidator.Visible = true;
                isValid = false;
            }
            if (txtEmail.Text.Trim() != "")
            {
                if (!IsValid(txtEmail.Text))
                {
                    highlighter1.SetHighlightColor(txtEmail, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    lblEmailValidator.Visible = true;
                    isValid = false;
                }
            }

            if(isValid)
            {
                SplashScreenManager.ShowForm(this, typeof(frmLoader), true, true, ParentFormState.Locked);
                frmMain main = (frmMain)Application.OpenForms["frmMain"];
                Customer customer = new Customer
                {
                    ID = ID,
                    CompanyName = txtCompanyName.Text,
                    AccountNumber = txtAccountNo.Text,
                    PrimaryPersonFirstName = txtPersonFirstName.Text,
                    PrimaryPersonLastName = txtPersonLastName.Text,
                    Email = txtEmail.Text,
                    PhoneCountry = txtPhoneCountry.Text,
                    PhoneArea = txtPhoneArea.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    FoxCountry = txtFoxCountry.Text,
                    FoxArea = txtFoxArea.Text,
                    FoxNumber = txtFoxNumber.Text,
                    MobileCountry = txtMobileCountry.Text,
                    MobileArea = txtMobileArea.Text,
                    MobileNumber = txtMobileNumber.Text,
                    DirectDialCountry = txtDDialCountry.Text,
                    DirectDialArea = txtDDialArea.Text,
                    DirectDialNumber = txtDDialNumber.Text,
                    SkypeName = txtSkypeName.Text,
                    Website = txtWebsite.Text,
                    PostalAttention = txtPostalAttention.Text,
                    PostalAddress = txtPostalAddress.Text,
                    PostalCityTown = txtPostalCityTown.Text,
                    PostalStateRegion = txtPostalStateRegion.Text,
                    PostalZIP = txtPostalZIP.Text,
                    PostalCountry = txtPostalCountry.Text,
                    StreetAttention = txtStreetAttention.Text,
                    StreetAddress = txtStreetAddress.Text,
                    StreetCityTown = txtStreetCityTown.Text,
                    StreetStateRegion = txtStreetStateRegion.Text,
                    StreetZIP = txtStreetZIP.Text,
                    StreetCountry = txtStreetCountry.Text,
                    CreatedBy = main.loggedInUser.Username,
                    ModifiedBy = main.loggedInUser.Username
                };

                frmContactList contactList = (frmContactList)Application.OpenForms["frmContactList"];
                if (ID <= 0) // ADD
                {
                    CustomerLog customerLog = new CustomerLog
                    {
                        GroupID = "ADD-" + DateTime.Now.ToString("HHmmssffffff"),
                        Description = "Customer has been added.",
                        UserName = main.loggedInUser.Username
                    };

                    if (!(await customerService.GetCustomerByCompanyName(txtCompanyName.Text.Trim())).Any())
                    {
                        if (await customerService.AddCustomer(customer, customerLog) > 0)
                        {
                            MessageBox.Show("Contact was successfully saved.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await contactList.LoadContact();

                            this.Controls.Clear();
                            this.InitializeComponent();
                        }
                        else
                        {
                            MessageBox.Show("Error saving contact.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Contact Name already exists. Please enter a different Contact Name.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    List<CustomerLog> customerLogs = new List<CustomerLog>();
                    customerLogs = await GenerateAutditModel(oldData, customer);
                    if(customerLogs.Count > 0)
                    {
                        customerLogs.ForEach(x => x.CustomerID = customer.ID);
                        if (await customerService.UpdateCustomer(customer, customerLogs))
                        {
                            MessageBox.Show("Contact was successfully updated.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No changes made.", "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                SplashScreenManager.CloseForm();
            }
        }

        public async Task<List<CustomerLog>> GenerateAutditModel<T>(T Oldmodel, T Newmodel)
        {
            frmMain main = (frmMain)Application.OpenForms["frmMain"];
            string groupID = "UPDATE-" + DateTime.Now.ToString("HHmmssffffff");
            List<CustomerLog> customerLogs = new List<CustomerLog>();
            var properties = Newmodel.GetType().GetProperties();
            foreach (var item in properties)
            {
                if (item.Name.ToUpper() != "CREATEDBY" && item.Name.ToUpper() != "DATECREATED" && item.Name.ToUpper() != "MODIFIEDBY" && item.Name.ToUpper() != "DATEMODIFIED")
                {
                    if (Newmodel.GetType().GetProperty(item.Name).GetValue(Newmodel)?.ToString().Trim() != Oldmodel.GetType().GetProperty(item.Name).GetValue(Oldmodel)?.ToString().Trim())
                    {
                        string desc = item.Name + " (" + Oldmodel.GetType().GetProperty(item.Name).GetValue(Oldmodel)?.ToString() + " -> " + Newmodel.GetType().GetProperty(item.Name).GetValue(Newmodel)?.ToString() + ") has been updated.";
                        customerLogs.Add(new CustomerLog
                        {
                            GroupID = groupID,
                            Description = desc,
                            UserName = main.loggedInUser.Username
                        });
                    }
                }
            }
            return customerLogs;
        }

        private static bool IsValid(string email)
        {
            string regex = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        private void lnkAddAcctNo_Click(object sender, EventArgs e)
        {
            txtAccountNo.Visible = true;
            labelControl2.Visible = true;
            lnkAddAcctNo.Visible = false;
        }

        private void lnkSameAsPostal_Click(object sender, EventArgs e)
        {
            txtStreetAttention.Text = txtPostalAttention.Text;
            txtStreetAddress.Text = txtPostalAddress.Text;
            txtStreetCityTown.Text = txtPostalCityTown.Text;
            txtStreetStateRegion.Text = txtPostalStateRegion.Text;
            txtStreetZIP.Text = txtPostalZIP.Text;
            txtStreetCountry.Text = txtPostalCountry.Text;
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Trim() != "")
            {
                highlighter1.SetHighlightColor(txtCompanyName, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                lblContactNameValidator.Visible = false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() != "")
            {
                if (IsValid(txtEmail.Text))
                {
                    highlighter1.SetHighlightColor(txtEmail, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                    lblEmailValidator.Visible = false;
                }
            }
            else
            {
                highlighter1.SetHighlightColor(txtEmail, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                lblEmailValidator.Visible = false;
            }
        }
    }
}