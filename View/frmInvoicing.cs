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

        private void FrmInvoicing_Load(object sender, EventArgs e)
        {

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            frmCreateInvoice createinvoice = new frmCreateInvoice();
            createinvoice.ShowDialog();
        }
    }
}