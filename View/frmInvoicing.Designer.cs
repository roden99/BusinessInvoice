namespace View
{
    partial class frmInvoicing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoicing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCreateInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.checkedListBoxControl2 = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.customerInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new View.DataSet1();
            this.customerInvoiceTableAdapter = new View.DataSet1TableAdapters.CustomerInvoiceTableAdapter();
            this.dgInvoiceList = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerInvoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInvoiceBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel16.Controls.Add(this.label1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1406, 40);
            this.panel16.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVOICES";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnCreateInvoice);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1406, 40);
            this.panel5.TabIndex = 5;
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnCreateInvoice.Appearance.Options.UseFont = true;
            this.btnCreateInvoice.Appearance.Options.UseForeColor = true;
            this.btnCreateInvoice.AppearanceDisabled.BackColor = System.Drawing.Color.Black;
            this.btnCreateInvoice.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCreateInvoice.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCreateInvoice.AppearanceDisabled.Options.UseBackColor = true;
            this.btnCreateInvoice.AppearanceDisabled.Options.UseFont = true;
            this.btnCreateInvoice.AppearanceDisabled.Options.UseForeColor = true;
            this.btnCreateInvoice.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCreateInvoice.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnCreateInvoice.AppearanceHovered.Options.UseFont = true;
            this.btnCreateInvoice.AppearanceHovered.Options.UseForeColor = true;
            this.btnCreateInvoice.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCreateInvoice.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnCreateInvoice.AppearancePressed.Options.UseFont = true;
            this.btnCreateInvoice.AppearancePressed.Options.UseForeColor = true;
            this.btnCreateInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateInvoice.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCreateInvoice.ImageOptions.ImageUri.Uri = "AddItem";
            this.btnCreateInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnCreateInvoice.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnCreateInvoice.Location = new System.Drawing.Point(0, 0);
            this.btnCreateInvoice.LookAndFeel.SkinName = "The Bezier";
            this.btnCreateInvoice.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(96, 38);
            this.btnCreateInvoice.TabIndex = 10;
            this.btnCreateInvoice.Text = "Create";
            this.btnCreateInvoice.Click += new System.EventHandler(this.BtnCreateInvoice_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.textEdit1);
            this.panel6.Controls.Add(this.simpleButton2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1162, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 38);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel7.Location = new System.Drawing.Point(232, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 35);
            this.panel7.TabIndex = 129;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Silver;
            this.panel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel13.Location = new System.Drawing.Point(0, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 35);
            this.panel13.TabIndex = 128;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(8, 7);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceDisabled.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceFocused.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(152, 24);
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
            this.simpleButton2.Location = new System.Drawing.Point(160, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(64, 24);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Search...";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 38);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1406, 2);
            this.panel14.TabIndex = 1;
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
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Draft"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Awaiting Approval"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Awaiting Payment"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Paid"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Repeating")});
            this.checkedListBoxControl2.Location = new System.Drawing.Point(0, 80);
            this.checkedListBoxControl2.MultiColumn = true;
            this.checkedListBoxControl2.Name = "checkedListBoxControl2";
            this.checkedListBoxControl2.Size = new System.Drawing.Size(1406, 32);
            this.checkedListBoxControl2.TabIndex = 11;
            // 
            // customerInvoiceBindingSource
            // 
            this.customerInvoiceBindingSource.DataMember = "CustomerInvoice";
            this.customerInvoiceBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerInvoiceTableAdapter
            // 
            this.customerInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // dgInvoiceList
            // 
            this.dgInvoiceList.AllowUserToAddRows = false;
            this.dgInvoiceList.AllowUserToDeleteRows = false;
            this.dgInvoiceList.AllowUserToResizeColumns = false;
            this.dgInvoiceList.AllowUserToResizeRows = false;
            this.dgInvoiceList.AutoGenerateColumns = false;
            this.dgInvoiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.dgInvoiceList.DataSource = this.customerInvoiceBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoiceList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInvoiceList.Location = new System.Drawing.Point(0, 0);
            this.dgInvoiceList.Name = "dgInvoiceList";
            this.dgInvoiceList.RowHeadersVisible = false;
            this.dgInvoiceList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoiceList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.dgInvoiceList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvoiceList.Size = new System.Drawing.Size(1406, 602);
            this.dgInvoiceList.TabIndex = 12;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            dataGridViewCellStyle2.Format = "dd-MMM-yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.issueDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dataGridViewCellStyle3.Format = "dd-MMM-yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.dueDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // customerInvoiceBindingSource1
            // 
            this.customerInvoiceBindingSource1.DataMember = "CustomerInvoice";
            this.customerInvoiceBindingSource1.DataSource = this.dataSet1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1406, 32);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.dgInvoiceList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1406, 602);
            this.panel2.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel.AppearanceDisabled.Options.UseFont = true;
            this.btnCancel.AppearanceDisabled.Options.UseForeColor = true;
            this.btnCancel.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnCancel.AppearanceHovered.Options.UseFont = true;
            this.btnCancel.AppearanceHovered.Options.UseForeColor = true;
            this.btnCancel.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnCancel.AppearancePressed.Options.UseFont = true;
            this.btnCancel.AppearancePressed.Options.UseForeColor = true;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.ImageOptions.ImageToTextIndent = 1;
            this.btnCancel.ImageOptions.ImageUri.Uri = "Undo";
            this.btnCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 32);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Submit";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton1.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.simpleButton1.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton1.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton1.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton1.AppearanceHovered.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton1.AppearancePressed.Options.UseFont = true;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.ImageOptions.ImageToTextIndent = 1;
            this.simpleButton1.ImageOptions.ImageUri.Uri = "Undo";
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage1")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.simpleButton1.Location = new System.Drawing.Point(91, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 32);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Approve";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton3.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.simpleButton3.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton3.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton3.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton3.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton3.AppearanceHovered.Options.UseFont = true;
            this.simpleButton3.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton3.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton3.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton3.AppearancePressed.Options.UseFont = true;
            this.simpleButton3.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton3.ImageOptions.ImageToTextIndent = 1;
            this.simpleButton3.ImageOptions.ImageUri.Uri = "Undo";
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.simpleButton3.Location = new System.Drawing.Point(182, 0);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(88, 32);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "Deposit";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton4.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.simpleButton4.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton4.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton4.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton4.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton4.AppearanceHovered.Options.UseFont = true;
            this.simpleButton4.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton4.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton4.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton4.AppearancePressed.Options.UseFont = true;
            this.simpleButton4.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton4.ImageOptions.ImageToTextIndent = 1;
            this.simpleButton4.ImageOptions.ImageUri.Uri = "Undo";
            this.simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.simpleButton4.Location = new System.Drawing.Point(273, 0);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(88, 32);
            this.simpleButton4.TabIndex = 19;
            this.simpleButton4.Text = "Print";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton5.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.simpleButton5.AppearanceDisabled.Options.UseFont = true;
            this.simpleButton5.AppearanceDisabled.Options.UseForeColor = true;
            this.simpleButton5.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton5.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton5.AppearanceHovered.Options.UseFont = true;
            this.simpleButton5.AppearanceHovered.Options.UseForeColor = true;
            this.simpleButton5.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleButton5.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.simpleButton5.AppearancePressed.Options.UseFont = true;
            this.simpleButton5.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton5.ImageOptions.ImageToTextIndent = 1;
            this.simpleButton5.ImageOptions.ImageUri.Uri = "Undo";
            this.simpleButton5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.simpleButton5.Location = new System.Drawing.Point(364, 0);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(88, 32);
            this.simpleButton5.TabIndex = 20;
            this.simpleButton5.Text = "Delete";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(88, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 32);
            this.panel3.TabIndex = 129;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel4.Location = new System.Drawing.Point(179, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 32);
            this.panel4.TabIndex = 130;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel8.Location = new System.Drawing.Point(270, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 32);
            this.panel8.TabIndex = 131;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel9.Location = new System.Drawing.Point(361, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 32);
            this.panel9.TabIndex = 132;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1406, 2);
            this.panel10.TabIndex = 13;
            // 
            // frmInvoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkedListBoxControl2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel16);
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmInvoicing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInvoicing_Load);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInvoiceBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel16;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnCreateInvoice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel13;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel14;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customerInvoiceBindingSource;
        private DataSet1TableAdapters.CustomerInvoiceTableAdapter customerInvoiceTableAdapter;
        private System.Windows.Forms.DataGridView dgInvoiceList;
        private System.Windows.Forms.BindingSource customerInvoiceBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
    }
}