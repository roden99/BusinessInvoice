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

namespace View
{
    public partial class frmInvoicing : DevExpress.XtraEditors.XtraForm
    {
        public frmInvoicing()
        {
            InitializeComponent();
        }



        public void loadInvoice()
        {

            this.customerInvoiceTableAdapter.Fill(this.dataSet1.CustomerInvoice);
        }

        private void FrmInvoicing_Load(object sender, EventArgs e)
        {
            try
            {
                this.customerInvoiceTableAdapter.Fill(this.dataSet1.CustomerInvoice);
                dgInvoiceList.Font = checkedListBoxControl2.Font;
                
            }

            catch(Exception Error)
            {
                MessageBox.Show(Error.Message,"System Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }

        }

        private void BtnCreateInvoice_Click(object sender, EventArgs e)
        {

            try
            {
          

                frmCreateInvoice createinvoice = new frmCreateInvoice();
                createinvoice.Owner = this;
                createinvoice.ShowDialog();

            }


            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}