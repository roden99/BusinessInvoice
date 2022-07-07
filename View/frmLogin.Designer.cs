
namespace View
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.lblUsernameValidator = new DevExpress.XtraEditors.LabelControl();
            this.lblPasswordValidator = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::View.Properties.Resources.Final_New_Logo;
            this.pictureEdit1.Location = new System.Drawing.Point(22, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(330, 122);
            this.pictureEdit1.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.EditValue = "test";
            this.txtUsername.Location = new System.Drawing.Point(22, 168);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.LookAndFeel.SkinName = "The Bezier";
            this.txtUsername.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtUsername.Properties.MaxLength = 50;
            this.txtUsername.Properties.NullValuePrompt = "Username";
            this.txtUsername.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtUsername.Size = new System.Drawing.Size(330, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblUsername
            // 
            this.lblUsername.AllowHtmlString = true;
            this.lblUsername.Location = new System.Drawing.Point(22, 152);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "<color=red>*</color> Username:";
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 213);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "<color=red>*</color> Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "moon1992";
            this.txtPassword.Location = new System.Drawing.Point(22, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.LookAndFeel.SkinName = "The Bezier";
            this.txtPassword.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtPassword.Properties.MaxLength = 50;
            this.txtPassword.Properties.NullValuePrompt = "Password";
            this.txtPassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(330, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(22, 284);
            this.btnSave.LookAndFeel.SkinName = "The Bezier";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(330, 30);
            this.btnSave.TabIndex = 149;
            this.btnSave.Text = "Login";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // lblUsernameValidator
            // 
            this.lblUsernameValidator.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameValidator.Appearance.Options.UseForeColor = true;
            this.lblUsernameValidator.Location = new System.Drawing.Point(22, 190);
            this.lblUsernameValidator.Name = "lblUsernameValidator";
            this.lblUsernameValidator.Size = new System.Drawing.Size(105, 13);
            this.lblUsernameValidator.TabIndex = 150;
            this.lblUsernameValidator.Text = "Username is required.";
            this.lblUsernameValidator.Visible = false;
            // 
            // lblPasswordValidator
            // 
            this.lblPasswordValidator.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValidator.Appearance.Options.UseForeColor = true;
            this.lblPasswordValidator.Location = new System.Drawing.Point(22, 252);
            this.lblPasswordValidator.Name = "lblPasswordValidator";
            this.lblPasswordValidator.Size = new System.Drawing.Size(103, 13);
            this.lblPasswordValidator.TabIndex = 151;
            this.lblPasswordValidator.Text = "Password is required.";
            this.lblPasswordValidator.Visible = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 333);
            this.Controls.Add(this.lblPasswordValidator);
            this.Controls.Add(this.lblUsernameValidator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevExpress.XtraEditors.LabelControl lblPasswordValidator;
        private DevExpress.XtraEditors.LabelControl lblUsernameValidator;
    }
}