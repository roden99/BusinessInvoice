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
        InvoiceItems invItems = new InvoiceItems();
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
            dgInvoiceItems.Font = label12.Font;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtDescription.Text=="" ||  txtQty.Text=="" || txtUnitPrice.Text=="" || txtDiscount.Text=="" || txtTaxRate.Text=="")
                {

                    MessageBox.Show("Fill up the forms properly","System Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;


                }

                else if (txtDescription.Text != "" || txtQty.Text != "" || txtUnitPrice.Text != "" || txtDiscount.Text != "" || txtTaxRate.Text != "")
                {

                    dgInvoiceItems.Rows.Add(txtDescription.Text, txtQty.Text, txtUnitPrice.Text, txtDiscount.Text, txtTaxRate.Text);
                }
                    
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message,"System Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                

                if(txtDescription.Text=="" || txtInvoiceNumber.Text=="" ||dgInvoiceItems.Rows.Count==0)
                {

                    MessageBox.Show("Fill up the forms properly","System Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;

                }


                else if(txtDescription.Text != "" && txtInvoiceNumber.Text != "" && dgInvoiceItems.Rows.Count > 0)
                {

                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Are you sure you want to create Invoice","System Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if(dr==DialogResult.No)
                    {

                        return;
                    }


                    else if(dr == DialogResult.Yes)
                    {


                        inv.InvoiceNumber = txtInvoiceNumber.Text;
                        inv.Reference = txtReference.Text;
                        inv.IssueDate = txtIssueDate.Text;
                        inv.DueDate = txtDueDate.Text;

                        if (await invoiceservice.AddInvoice(inv, dgInvoiceItems))
                        {

                            MessageBox.Show("Transaction successful", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            (this.Owner as frmInvoicing).loadInvoice();
                            this.Close();

                        }

                    }





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