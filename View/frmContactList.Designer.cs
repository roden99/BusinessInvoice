
namespace View
{
    partial class frmContactList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactList));
            this.checkedListBoxControl2 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNewContact = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.gridContact = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxControl2
            // 
            this.checkedListBoxControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkedListBoxControl2.Appearance.Options.UseFont = true;
            this.checkedListBoxControl2.Appearance.Options.UseForeColor = true;
            this.checkedListBoxControl2.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkedListBoxControl2.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.checkedListBoxControl2.AppearanceDisabled.Options.UseFont = true;
            this.checkedListBoxControl2.AppearanceDisabled.Options.UseForeColor = true;
            this.checkedListBoxControl2.AppearanceHighlight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkedListBoxControl2.AppearanceHighlight.ForeColor = System.Drawing.Color.Black;
            this.checkedListBoxControl2.AppearanceHighlight.Options.UseFont = true;
            this.checkedListBoxControl2.AppearanceHighlight.Options.UseForeColor = true;
            this.checkedListBoxControl2.AppearanceSelected.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkedListBoxControl2.AppearanceSelected.ForeColor = System.Drawing.Color.Black;
            this.checkedListBoxControl2.AppearanceSelected.Options.UseFont = true;
            this.checkedListBoxControl2.AppearanceSelected.Options.UseForeColor = true;
            this.checkedListBoxControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBoxControl2.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "All"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Customers"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Suppliers")});
            this.checkedListBoxControl2.Location = new System.Drawing.Point(0, 40);
            this.checkedListBoxControl2.MultiColumn = true;
            this.checkedListBoxControl2.Name = "checkedListBoxControl2";
            this.checkedListBoxControl2.Size = new System.Drawing.Size(1016, 47);
            this.checkedListBoxControl2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnNewContact);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1016, 40);
            this.panel5.TabIndex = 12;
            // 
            // btnNewContact
            // 
            this.btnNewContact.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewContact.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnNewContact.Appearance.Options.UseFont = true;
            this.btnNewContact.Appearance.Options.UseForeColor = true;
            this.btnNewContact.AppearanceDisabled.BackColor = System.Drawing.Color.Black;
            this.btnNewContact.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNewContact.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNewContact.AppearanceDisabled.Options.UseBackColor = true;
            this.btnNewContact.AppearanceDisabled.Options.UseFont = true;
            this.btnNewContact.AppearanceDisabled.Options.UseForeColor = true;
            this.btnNewContact.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNewContact.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnNewContact.AppearanceHovered.Options.UseFont = true;
            this.btnNewContact.AppearanceHovered.Options.UseForeColor = true;
            this.btnNewContact.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNewContact.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnNewContact.AppearancePressed.Options.UseFont = true;
            this.btnNewContact.AppearancePressed.Options.UseForeColor = true;
            this.btnNewContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewContact.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewContact.ImageOptions.ImageUri.Uri = "AddItem";
            this.btnNewContact.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnNewContact.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnNewContact.Location = new System.Drawing.Point(0, 0);
            this.btnNewContact.LookAndFeel.SkinName = "The Bezier";
            this.btnNewContact.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(148, 38);
            this.btnNewContact.TabIndex = 10;
            this.btnNewContact.Text = "New Contact";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textEdit1);
            this.panel6.Controls.Add(this.simpleButton2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(767, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 38);
            this.panel6.TabIndex = 9;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(7, 7);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceDisabled.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceFocused.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(166, 24);
            this.textEdit1.TabIndex = 10;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.AppearanceDisabled.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.simpleButton2.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton2.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.simpleButton2.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton2.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton2.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton2.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton2.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton2.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton2.AppearancePressed.Options.UseFont = true;
            this.simpleButton2.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton2.Location = new System.Drawing.Point(173, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(69, 24);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Search...";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 38);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1016, 2);
            this.panel14.TabIndex = 1;
            // 
            // gridContact
            // 
            this.gridContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContact.Location = new System.Drawing.Point(0, 87);
            this.gridContact.MainView = this.gridView1;
            this.gridContact.Name = "gridContact";
            this.gridContact.Size = new System.Drawing.Size(1016, 406);
            this.gridContact.TabIndex = 14;
            this.gridContact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID});
            this.gridView1.GridControl = this.gridContact;
            this.gridView1.Name = "gridView1";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // frmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 493);
            this.Controls.Add(this.gridContact);
            this.Controls.Add(this.checkedListBoxControl2);
            this.Controls.Add(this.panel5);
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmContactList";
            this.Text = "Contacts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContactList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl2;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnNewContact;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel14;
        private DevExpress.XtraGrid.GridControl gridContact;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}