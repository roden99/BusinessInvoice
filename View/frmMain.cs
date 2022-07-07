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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {


        InvoiceService invoiceservice = new InvoiceService();
        public frmMain()
        {
            InitializeComponent();
        }

        private void AccordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void AccordionControlElement2_Click_1(object sender, EventArgs e)
        {


            frmInvoicing invoicing = new frmInvoicing();
         

            invoicing.MdiParent = this;
            invoicing.Show();

           // accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            try
            {

             




            }


            catch(Exception Error)
            {

                MessageBox.Show(Error.Message,"System Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void AccordionControlElement126_Click(object sender, EventArgs e)
        {

            try
            {

                frmInvoicing invoicing = new frmInvoicing();

                invoicing.MdiParent = this;
                invoicing.Show();

            }


            catch (Exception Error)
            {

                MessageBox.Show(Error.Message, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private async void Button1_Click_1(object sender, EventArgs e)
        {


            //try
            //{

            // CustomerInvoice inv = new CustomerInvoice();
            //    {
            //        inv.InvoiceNumber = "88";
            //        inv.Reference = "88";
            //        inv.IssueDate = "2020-12-12";
            //        inv.DueDate = "2021-01-01";
            //    }


            //    if (await invoiceservice.AddInvoice(inv))
            //    {

            //        MessageBox.Show("Saved.", "Success");
            //    }
            //}

            //catch (Exception Error)
            //{

            //    MessageBox.Show(Error.Message, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}



        }
    }
}