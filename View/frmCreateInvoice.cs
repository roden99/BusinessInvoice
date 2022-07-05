using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model;
using BusinessInvoice;

namespace View
{
    public partial class frmCreateInvoice : DevExpress.XtraEditors.XtraForm
    {
        public frmCreateInvoice()
        {
            InitializeComponent();
        }


        CustomerInvoice inv = new CustomerInvoice();
        InvoiceService invoiceservice = new InvoiceService();

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {

        }

      

        private void FrmCreateInvoice_Load(object sender, EventArgs e)
        {
            dgInvoiceItems.Font = label5.Font;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            dgInvoiceItems.Rows.Add();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
            
                {
                    inv.InvoiceNumber = "11";
                    inv.Reference = "11";
                    inv.IssueDate = "2020-12-12";
                    inv.DueDate = "2021-01-01";
                }


               

                if (await invoiceservice.AddInvoice(inv,dgInvoiceItems))
                {

                    MessageBox.Show("Saved.", "Success");
                }

            }


            catch (Exception Error)
            {
                MessageBox.Show(Error.Message,"System Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
        }
    }
}