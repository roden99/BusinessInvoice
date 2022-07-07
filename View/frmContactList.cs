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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmContactList : DevExpress.XtraEditors.XtraForm
    {
        CustomerService customerService = new CustomerService();
        public frmContactList()
        {
            InitializeComponent();
        }

        private async void frmContactList_Load(object sender, EventArgs e)
        {
            await LoadContact();
        }

        public async Task LoadContact(string NameSearch = "")
        {
            List<Customer> customers = new List<Customer>();
            customers = await customerService.GetCustomerByNameSearch(NameSearch);
            gridContact.DataSource = customers.Where(x => x.ArchivedDate == null).ToList();

            gridArchived.DataSource = customers.Where(x => x.ArchivedDate != null).ToList();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddEditContact addEditContact = new frmAddEditContact();
            addEditContact.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if(gridView1.GetSelectedRows().Length > 0)
            {
                frmAddEditContact addEditContact = new frmAddEditContact();
                addEditContact.ID = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "ID").ToString());
                if(addEditContact.ShowDialog() == DialogResult.OK)
                    await LoadContact();
            }
        }

        private async void btnArchive_Click(object sender, EventArgs e)
        {
            frmMain main = (frmMain)Application.OpenForms["frmMain"];
            Customer customer = new Customer();
            if (gridView1.GetSelectedRows().Length > 0)
            {
                if (MessageBox.Show("Are you sure do you want to archive " + gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "CompanyName") + "? The transaction history with this contact will not be deleted.", "Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SplashScreenManager.ShowForm(this, typeof(frmLoader), true, true, ParentFormState.Locked);

                    frmAddEditContact addEditContact = new frmAddEditContact();
                    customer.ID = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "ID").ToString());
                    customer.ModifiedBy = main.loggedInUser.Username;

                    CustomerLog customerLog = new CustomerLog
                    {
                        GroupID = "ARCHIVE-" + DateTime.Now.ToString("HHmmssffffff"),
                        CustomerID = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], "ID").ToString()),
                        Description = "Customer has been archived.",
                        UserName = main.loggedInUser.Username
                    };

                    if (await customerService.ArchiveCustomer(customer, customerLog))
                    {
                        MessageBox.Show("Contact was successfully archived.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadContact();
                    }
                    SplashScreenManager.CloseForm();
                }
            }
        }
    }
}