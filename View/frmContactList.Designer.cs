
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnArchive = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewContact = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.xtcContact = new DevExpress.XtraTab.XtraTabControl();
            this.xtabCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.gridContact = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtabArchived = new DevExpress.XtraTab.XtraTabPage();
            this.gridArchived = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcContact)).BeginInit();
            this.xtcContact.SuspendLayout();
            this.xtabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtabArchived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArchived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnArchive);
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnNewContact);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1016, 40);
            this.panel5.TabIndex = 12;
            // 
            // btnArchive
            // 
            this.btnArchive.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnArchive.Appearance.Options.UseFont = true;
            this.btnArchive.Appearance.Options.UseForeColor = true;
            this.btnArchive.AppearanceDisabled.BackColor = System.Drawing.Color.Black;
            this.btnArchive.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnArchive.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnArchive.AppearanceDisabled.Options.UseBackColor = true;
            this.btnArchive.AppearanceDisabled.Options.UseFont = true;
            this.btnArchive.AppearanceDisabled.Options.UseForeColor = true;
            this.btnArchive.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnArchive.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnArchive.AppearanceHovered.Options.UseFont = true;
            this.btnArchive.AppearanceHovered.Options.UseForeColor = true;
            this.btnArchive.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnArchive.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnArchive.AppearancePressed.Options.UseFont = true;
            this.btnArchive.AppearancePressed.Options.UseForeColor = true;
            this.btnArchive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnArchive.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnArchive.ImageOptions.ImageUri.Uri = "AddItem";
            this.btnArchive.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnArchive.Location = new System.Drawing.Point(214, 0);
            this.btnArchive.LookAndFeel.SkinName = "The Bezier";
            this.btnArchive.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(109, 38);
            this.btnArchive.TabIndex = 12;
            this.btnArchive.Text = "Archive";
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseForeColor = true;
            this.btnEdit.AppearanceDisabled.BackColor = System.Drawing.Color.Black;
            this.btnEdit.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEdit.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEdit.AppearanceDisabled.Options.UseBackColor = true;
            this.btnEdit.AppearanceDisabled.Options.UseFont = true;
            this.btnEdit.AppearanceDisabled.Options.UseForeColor = true;
            this.btnEdit.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnEdit.AppearanceHovered.Options.UseFont = true;
            this.btnEdit.AppearanceHovered.Options.UseForeColor = true;
            this.btnEdit.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEdit.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnEdit.AppearancePressed.Options.UseFont = true;
            this.btnEdit.AppearancePressed.Options.UseForeColor = true;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEdit.ImageOptions.ImageUri.Uri = "AddItem";
            this.btnEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnEdit.Location = new System.Drawing.Point(141, 0);
            this.btnEdit.LookAndFeel.SkinName = "The Bezier";
            this.btnEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 38);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnNewContact.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNewContact.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnNewContact.AppearanceHovered.Options.UseFont = true;
            this.btnNewContact.AppearanceHovered.Options.UseForeColor = true;
            this.btnNewContact.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnNewContact.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnNewContact.AppearancePressed.Options.UseFont = true;
            this.btnNewContact.AppearancePressed.Options.UseForeColor = true;
            this.btnNewContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewContact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewContact.ImageOptions.Image")));
            this.btnNewContact.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNewContact.ImageOptions.ImageUri.Uri = "AddItem";
            this.btnNewContact.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnNewContact.Location = new System.Drawing.Point(0, 0);
            this.btnNewContact.LookAndFeel.SkinName = "The Bezier";
            this.btnNewContact.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(141, 38);
            this.btnNewContact.TabIndex = 10;
            this.btnNewContact.Text = "New Contact";
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textEdit1);
            this.panel6.Controls.Add(this.simpleButton2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(659, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 38);
            this.panel6.TabIndex = 9;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(10, 7);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceDisabled.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceFocused.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.textEdit1.Properties.NullValuePrompt = "Search...";
            this.textEdit1.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit1.Size = new System.Drawing.Size(314, 24);
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
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton2.Location = new System.Drawing.Point(323, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(25, 24);
            this.simpleButton2.TabIndex = 10;
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
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.panel16.Controls.Add(this.btnClose);
            this.panel16.Controls.Add(this.label1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1016, 40);
            this.panel16.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(984, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTACTS";
            // 
            // xtcContact
            // 
            this.xtcContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcContact.Location = new System.Drawing.Point(0, 80);
            this.xtcContact.Name = "xtcContact";
            this.xtcContact.SelectedTabPage = this.xtabCustomer;
            this.xtcContact.Size = new System.Drawing.Size(1016, 413);
            this.xtcContact.TabIndex = 16;
            this.xtcContact.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtabCustomer,
            this.xtabArchived});
            // 
            // xtabCustomer
            // 
            this.xtabCustomer.Controls.Add(this.gridContact);
            this.xtabCustomer.Name = "xtabCustomer";
            this.xtabCustomer.Size = new System.Drawing.Size(1014, 384);
            this.xtabCustomer.Text = "Customer";
            // 
            // gridContact
            // 
            this.gridContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContact.Location = new System.Drawing.Point(0, 0);
            this.gridContact.MainView = this.gridView1;
            this.gridContact.Name = "gridContact";
            this.gridContact.Size = new System.Drawing.Size(1014, 384);
            this.gridContact.TabIndex = 15;
            this.gridContact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CompanyName});
            this.gridView1.GridControl = this.gridContact;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "Id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // CompanyName
            // 
            this.CompanyName.Caption = "Customer Name";
            this.CompanyName.FieldName = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.OptionsColumn.AllowEdit = false;
            this.CompanyName.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CompanyName.Visible = true;
            this.CompanyName.VisibleIndex = 0;
            // 
            // xtabArchived
            // 
            this.xtabArchived.Controls.Add(this.gridArchived);
            this.xtabArchived.Name = "xtabArchived";
            this.xtabArchived.Size = new System.Drawing.Size(1014, 384);
            this.xtabArchived.Text = "Archived";
            // 
            // gridArchived
            // 
            this.gridArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridArchived.Location = new System.Drawing.Point(0, 0);
            this.gridArchived.MainView = this.gridView2;
            this.gridArchived.Name = "gridArchived";
            this.gridArchived.Size = new System.Drawing.Size(1014, 384);
            this.gridArchived.TabIndex = 16;
            this.gridArchived.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridArchived;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Customer Name";
            this.gridColumn2.FieldName = "CompanyName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // frmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1016, 493);
            this.Controls.Add(this.xtcContact);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel16);
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmContactList";
            this.Text = "Contacts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContactList_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcContact)).EndInit();
            this.xtcContact.ResumeLayout(false);
            this.xtabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtabArchived.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArchived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnNewContact;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel14;
        private DevExpress.XtraEditors.SimpleButton btnArchive;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.Panel panel16;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabControl xtcContact;
        private DevExpress.XtraTab.XtraTabPage xtabCustomer;
        private DevExpress.XtraGrid.GridControl gridContact;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyName;
        private DevExpress.XtraTab.XtraTabPage xtabArchived;
        private DevExpress.XtraGrid.GridControl gridArchived;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}