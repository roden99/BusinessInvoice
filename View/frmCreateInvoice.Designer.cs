namespace View
{
    partial class frmCreateInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDueDate = new DevExpress.XtraEditors.DateEdit();
            this.txtIssueDate = new DevExpress.XtraEditors.DateEdit();
            this.txtReference = new DevExpress.XtraEditors.TextEdit();
            this.txtSection = new DevExpress.XtraEditors.LookUpEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaxRate = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTaxrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInvoiceItems = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSection.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 698);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 40);
            this.panel2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceDisabled.BackColor = System.Drawing.Color.Black;
            this.btnSave.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSave.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSave.AppearanceDisabled.Options.UseFont = true;
            this.btnSave.AppearanceDisabled.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSave.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.AppearanceHovered.Options.UseForeColor = true;
            this.btnSave.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSave.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnSave.AppearancePressed.Options.UseFont = true;
            this.btnSave.AppearancePressed.Options.UseForeColor = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImageOptions.ImageUri.Uri = "AddItem";
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btnSave.Location = new System.Drawing.Point(1270, 0);
            this.btnSave.LookAndFeel.SkinName = "The Bezier";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtInvoiceNumber);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtDueDate);
            this.panel3.Controls.Add(this.txtIssueDate);
            this.panel3.Controls.Add(this.txtReference);
            this.panel3.Controls.Add(this.txtSection);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 96);
            this.panel3.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 93);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1366, 3);
            this.panel9.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(976, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 154;
            this.label6.Text = "Due Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(792, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 153;
            this.label3.Text = "Issue Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(584, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 152;
            this.label2.Text = "Invoice Number :";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.EditValue = "";
            this.txtInvoiceNumber.Location = new System.Drawing.Point(584, 56);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtInvoiceNumber.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInvoiceNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtInvoiceNumber.Properties.Appearance.Options.UseFont = true;
            this.txtInvoiceNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtInvoiceNumber.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtInvoiceNumber.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtInvoiceNumber.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtInvoiceNumber.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtInvoiceNumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(192, 28);
            this.txtInvoiceNumber.TabIndex = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(304, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 150;
            this.label1.Text = "Reference :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(8, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 17);
            this.label17.TabIndex = 149;
            this.label17.Text = "To :";
            // 
            // txtDueDate
            // 
            this.txtDueDate.EditValue = new System.DateTime(2020, 2, 24, 0, 0, 0, 0);
            this.txtDueDate.Location = new System.Drawing.Point(1032, 56);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtDueDate.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDueDate.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDueDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtDueDate.Properties.Appearance.Options.UseFont = true;
            this.txtDueDate.Properties.Appearance.Options.UseForeColor = true;
            this.txtDueDate.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtDueDate.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDate.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtDueDate.Properties.CalendarTimeProperties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Properties.CalendarTimeProperties.Appearance.Options.UseFont = true;
            this.txtDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDueDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "d";
            this.txtDueDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDueDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.txtDueDate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDueDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDueDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.txtDueDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDueDate.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.txtDueDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDueDate.Properties.Mask.EditMask = "dd-MMM-yyyy";
            this.txtDueDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDueDate.Properties.NullDate = "<Null>";
            this.txtDueDate.Size = new System.Drawing.Size(208, 28);
            this.txtDueDate.TabIndex = 148;
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.EditValue = new System.DateTime(2020, 2, 24, 0, 0, 0, 0);
            this.txtIssueDate.Location = new System.Drawing.Point(800, 56);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtIssueDate.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIssueDate.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueDate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtIssueDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtIssueDate.Properties.Appearance.Options.UseFont = true;
            this.txtIssueDate.Properties.Appearance.Options.UseForeColor = true;
            this.txtIssueDate.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtIssueDate.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtIssueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIssueDate.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtIssueDate.Properties.CalendarTimeProperties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueDate.Properties.CalendarTimeProperties.Appearance.Options.UseFont = true;
            this.txtIssueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIssueDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "d";
            this.txtIssueDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtIssueDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.txtIssueDate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtIssueDate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIssueDate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.txtIssueDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtIssueDate.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.txtIssueDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtIssueDate.Properties.Mask.EditMask = "dd-MMM-yyyy";
            this.txtIssueDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIssueDate.Properties.NullDate = "<Null>";
            this.txtIssueDate.Size = new System.Drawing.Size(208, 28);
            this.txtIssueDate.TabIndex = 147;
            // 
            // txtReference
            // 
            this.txtReference.EditValue = "";
            this.txtReference.Location = new System.Drawing.Point(296, 56);
            this.txtReference.Name = "txtReference";
            this.txtReference.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtReference.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtReference.Properties.Appearance.Options.UseBackColor = true;
            this.txtReference.Properties.Appearance.Options.UseFont = true;
            this.txtReference.Properties.Appearance.Options.UseForeColor = true;
            this.txtReference.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtReference.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtReference.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtReference.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtReference.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtReference.Size = new System.Drawing.Size(264, 28);
            this.txtReference.TabIndex = 146;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(8, 56);
            this.txtSection.Name = "txtSection";
            this.txtSection.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSection.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSection.Properties.Appearance.Options.UseBackColor = true;
            this.txtSection.Properties.Appearance.Options.UseFont = true;
            this.txtSection.Properties.Appearance.Options.UseForeColor = true;
            this.txtSection.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtSection.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtSection.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Properties.AppearanceDropDown.Options.UseFont = true;
            this.txtSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSection.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("officename", "officename", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtSection.Properties.DisplayMember = "officename";
            this.txtSection.Properties.NullText = "Search...";
            this.txtSection.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txtSection.Properties.ShowHeader = false;
            this.txtSection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtSection.Properties.ValueMember = "officeid";
            this.txtSection.Size = new System.Drawing.Size(264, 28);
            this.txtSection.TabIndex = 143;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1366, 24);
            this.panel5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1366, 3);
            this.panel7.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Invoice Information";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 602);
            this.panel4.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 128);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1366, 32);
            this.panel8.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(8, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 21);
            this.label12.TabIndex = 161;
            this.label12.Text = "Invoice Items";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtTaxRate);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtDiscount);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txtUnitPrice);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtQty);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtDescription);
            this.panel6.Controls.Add(this.btnAddItem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1366, 128);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel6_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 125);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1366, 3);
            this.panel10.TabIndex = 168;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1104, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 167;
            this.label10.Text = "Tax Rate :";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.EditValue = "";
            this.txtTaxRate.Location = new System.Drawing.Point(1104, 88);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtTaxRate.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxRate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTaxRate.Properties.Appearance.Options.UseBackColor = true;
            this.txtTaxRate.Properties.Appearance.Options.UseFont = true;
            this.txtTaxRate.Properties.Appearance.Options.UseForeColor = true;
            this.txtTaxRate.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtTaxRate.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxRate.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtTaxRate.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtTaxRate.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxRate.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtTaxRate.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxRate.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTaxRate.Size = new System.Drawing.Size(136, 28);
            this.txtTaxRate.TabIndex = 166;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1104, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 164;
            this.label11.Text = "Discount :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.EditValue = "";
            this.txtDiscount.Location = new System.Drawing.Point(1104, 32);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.Properties.Appearance.Options.UseBackColor = true;
            this.txtDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtDiscount.Properties.Appearance.Options.UseForeColor = true;
            this.txtDiscount.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtDiscount.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtDiscount.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtDiscount.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtDiscount.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtDiscount.Size = new System.Drawing.Size(136, 28);
            this.txtDiscount.TabIndex = 165;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(952, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 163;
            this.label9.Text = "Unit Price :";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.EditValue = "";
            this.txtUnitPrice.Location = new System.Drawing.Point(952, 88);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtUnitPrice.Properties.Appearance.Options.UseFont = true;
            this.txtUnitPrice.Properties.Appearance.Options.UseForeColor = true;
            this.txtUnitPrice.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtUnitPrice.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtUnitPrice.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtUnitPrice.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtUnitPrice.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(136, 28);
            this.txtUnitPrice.TabIndex = 162;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(952, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 161;
            this.label8.Text = "Quantity :";
            // 
            // txtQty
            // 
            this.txtQty.EditValue = "";
            this.txtQty.Location = new System.Drawing.Point(952, 32);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtQty.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Properties.Appearance.Options.UseBackColor = true;
            this.txtQty.Properties.Appearance.Options.UseFont = true;
            this.txtQty.Properties.Appearance.Options.UseForeColor = true;
            this.txtQty.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtQty.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtQty.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtQty.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtQty.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtQty.Size = new System.Drawing.Size(136, 28);
            this.txtQty.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 161;
            this.label7.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(8, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtDescription.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtDescription.Size = new System.Drawing.Size(920, 86);
            this.txtDescription.TabIndex = 153;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.Appearance.Options.UseForeColor = true;
            this.btnAddItem.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddItem.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnAddItem.AppearanceDisabled.Options.UseFont = true;
            this.btnAddItem.AppearanceDisabled.Options.UseForeColor = true;
            this.btnAddItem.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddItem.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnAddItem.AppearanceHovered.Options.UseFont = true;
            this.btnAddItem.AppearanceHovered.Options.UseForeColor = true;
            this.btnAddItem.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddItem.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.btnAddItem.AppearancePressed.Options.UseFont = true;
            this.btnAddItem.AppearancePressed.Options.UseForeColor = true;
            this.btnAddItem.AutoSize = true;
            this.btnAddItem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnAddItem.ImageOptions.ImageToTextIndent = 0;
            this.btnAddItem.Location = new System.Drawing.Point(1256, 88);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(83, 26);
            this.btnAddItem.TabIndex = 121;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgInvoiceItems);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 160);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1366, 442);
            this.panel11.TabIndex = 4;
            // 
            // ColAmount
            // 
            this.ColAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAmount.HeaderText = "Amount";
            this.ColAmount.Name = "ColAmount";
            // 
            // ColTaxrate
            // 
            this.ColTaxrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTaxrate.HeaderText = "Tax Rate";
            this.ColTaxrate.Name = "ColTaxrate";
            // 
            // ColDiscount
            // 
            this.ColDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDiscount.HeaderText = "Discount%";
            this.ColDiscount.Name = "ColDiscount";
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColUnitPrice.HeaderText = "UnitPrice";
            this.ColUnitPrice.Name = "ColUnitPrice";
            // 
            // Colqty
            // 
            this.Colqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colqty.HeaderText = "Quantity";
            this.Colqty.Name = "Colqty";
            // 
            // ColDescription
            // 
            this.ColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            // 
            // dgInvoiceItems
            // 
            this.dgInvoiceItems.AllowUserToAddRows = false;
            this.dgInvoiceItems.AllowUserToDeleteRows = false;
            this.dgInvoiceItems.AllowUserToResizeColumns = false;
            this.dgInvoiceItems.AllowUserToResizeRows = false;
            this.dgInvoiceItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoiceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDescription,
            this.Colqty,
            this.ColUnitPrice,
            this.ColDiscount,
            this.ColTaxrate,
            this.ColAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoiceItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgInvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInvoiceItems.Location = new System.Drawing.Point(0, 0);
            this.dgInvoiceItems.Name = "dgInvoiceItems";
            this.dgInvoiceItems.RowHeadersVisible = false;
            this.dgInvoiceItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgInvoiceItems.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.dgInvoiceItems.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInvoiceItems.Size = new System.Drawing.Size(1366, 442);
            this.dgInvoiceItems.TabIndex = 4;
            // 
            // frmCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 738);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateInvoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Invoice";
            this.Load += new System.EventHandler(this.FrmCreateInvoice_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIssueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSection.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.DateEdit txtDueDate;
        private DevExpress.XtraEditors.DateEdit txtIssueDate;
        private DevExpress.XtraEditors.TextEdit txtReference;
        public DevExpress.XtraEditors.LookUpEdit txtSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtInvoiceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtTaxRate;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtUnitPrice;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgInvoiceItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTaxrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
    }
}