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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private UserAccountService userAccountService = new UserAccountService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(txtUsername.Text.Trim() == "")
            {
                highlighter1.SetHighlightColor(txtUsername, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                lblUsernameValidator.Visible = true;
                isValid = false;
            }

            if (txtPassword.Text.Trim() == "")
            {
                highlighter1.SetHighlightColor(txtPassword, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                lblPasswordValidator.Visible = true;
                isValid = false;
            }

            if(isValid)
            {
                SplashScreenManager.ShowForm(this, typeof(frmLoader), true, true, ParentFormState.Locked);

                UserAccount userAccount = new UserAccount();
                userAccount = await userAccountService.Get_UserAccount(0, txtUsername.Text, Encryption.Encrypt(txtPassword.Text));
                if (userAccount == null)
                {
                    MessageBox.Show("Account does not exists or password is incorrect.", "Login failed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    SplashScreenManager.CloseForm();
                }
                else
                {
                    if (userAccount.IsActive)
                    {
                        frmMain main = new frmMain();
                        main.loggedInUser = userAccount;
                        SplashScreenManager.CloseForm();
                        main.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Account is inactive.", "Login failed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        SplashScreenManager.CloseForm();
                    }
                }
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() != "")
            {
                highlighter1.SetHighlightColor(txtUsername, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                lblUsernameValidator.Visible = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != "")
            {
                highlighter1.SetHighlightColor(txtPassword, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                lblPasswordValidator.Visible = false;
            }
        }
    }
}