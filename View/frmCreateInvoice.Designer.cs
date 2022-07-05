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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtSaidate = new DevExpress.XtraEditors.DateEdit();
            this.txtSainumber = new DevExpress.XtraEditors.TextEdit();
            this.txtSection = new DevExpress.XtraEditors.LookUpEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgInvoiceItems = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTaxrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaidate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaidate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSainumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSection.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceItems)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
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
            this.panel3.Controls.Add(this.textEdit1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.dateEdit1);
            this.panel3.Controls.Add(this.txtSaidate);
            this.panel3.Controls.Add(this.txtSainumber);
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
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(584, 56);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.textEdit1.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.textEdit1.Properties.AppearanceDisabled.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceFocused.Options.UseFont = true;
            this.textEdit1.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(184, 28);
            this.textEdit1.TabIndex = 151;
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
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2020, 2, 24, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(976, 56);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dateEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.dateEdit1.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.dateEdit1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Properties.CalendarTimeProperties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.CalendarTimeProperties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "d";
            this.dateEdit1.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dateEdit1.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit1.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.Mask.EditMask = "dd-MMM-yyyy";
            this.dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit1.Properties.NullDate = "<Null>";
            this.dateEdit1.Size = new System.Drawing.Size(160, 28);
            this.dateEdit1.TabIndex = 148;
            // 
            // txtSaidate
            // 
            this.txtSaidate.EditValue = new System.DateTime(2020, 2, 24, 0, 0, 0, 0);
            this.txtSaidate.Location = new System.Drawing.Point(792, 56);
            this.txtSaidate.Name = "txtSaidate";
            this.txtSaidate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtSaidate.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSaidate.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaidate.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSaidate.Properties.Appearance.Options.UseBackColor = true;
            this.txtSaidate.Properties.Appearance.Options.UseFont = true;
            this.txtSaidate.Properties.Appearance.Options.UseForeColor = true;
            this.txtSaidate.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtSaidate.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtSaidate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSaidate.Properties.CalendarTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtSaidate.Properties.CalendarTimeProperties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaidate.Properties.CalendarTimeProperties.Appearance.Options.UseFont = true;
            this.txtSaidate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSaidate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "d";
            this.txtSaidate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSaidate.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.txtSaidate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtSaidate.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSaidate.Properties.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.txtSaidate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtSaidate.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.txtSaidate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtSaidate.Properties.Mask.EditMask = "dd-MMM-yyyy";
            this.txtSaidate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSaidate.Properties.NullDate = "<Null>";
            this.txtSaidate.Size = new System.Drawing.Size(160, 28);
            this.txtSaidate.TabIndex = 147;
            // 
            // txtSainumber
            // 
            this.txtSainumber.EditValue = "";
            this.txtSainumber.Location = new System.Drawing.Point(296, 56);
            this.txtSainumber.Name = "txtSainumber";
            this.txtSainumber.Properties.Appearance.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtSainumber.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSainumber.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSainumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtSainumber.Properties.Appearance.Options.UseFont = true;
            this.txtSainumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtSainumber.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.txtSainumber.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSainumber.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtSainumber.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtSainumber.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSainumber.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtSainumber.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSainumber.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtSainumber.Size = new System.Drawing.Size(264, 28);
            this.txtSainumber.TabIndex = 146;
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
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 602);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgInvoiceItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 562);
            this.panel1.TabIndex = 2;
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
            this.ColItem,
            this.ColDescription,
            this.Colqty,
            this.ColUnitPrice,
            this.ColDiscount,
            this.ColAccount,
            this.ColTaxrate,
            this.ColReion,
            this.ColAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
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
            this.dgInvoiceItems.Size = new System.Drawing.Size(1366, 562);
            this.dgInvoiceItems.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAddItem);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1366, 40);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel6_Paint);
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
            this.btnAddItem.Location = new System.Drawing.Point(128, 7);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(83, 26);
            this.btnAddItem.TabIndex = 121;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(176)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Invoice Items";
            // 
            // ColItem
            // 
            this.ColItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColItem.HeaderText = "Item";
            this.ColItem.Name = "ColItem";
            // 
            // ColDescription
            // 
            this.ColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            // 
            // Colqty
            // 
            this.Colqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colqty.HeaderText = "Quantity";
            this.Colqty.Name = "Colqty";
            // 
            // ColUnitPrice
            // 
            this.ColUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColUnitPrice.HeaderText = "UnitPrice";
            this.ColUnitPrice.Name = "ColUnitPrice";
            // 
            // ColDiscount
            // 
            this.ColDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDiscount.HeaderText = "Discount%";
            this.ColDiscount.Name = "ColDiscount";
            // 
            // ColAccount
            // 
            this.ColAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAccount.HeaderText = "Account";
            this.ColAccount.Name = "ColAccount";
            // 
            // ColTaxrate
            // 
            this.ColTaxrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTaxrate.HeaderText = "Tax Rate";
            this.ColTaxrate.Name = "ColTaxrate";
            // 
            // ColReion
            // 
            this.ColReion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColReion.HeaderText = "Region";
            this.ColReion.Name = "ColReion";
            // 
            // ColAmount
            // 
            this.ColAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAmount.HeaderText = "Amount";
            this.ColAmount.Name = "ColAmount";
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaidate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaidate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSainumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSection.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoiceItems)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit txtSaidate;
        private DevExpress.XtraEditors.TextEdit txtSainumber;
        public DevExpress.XtraEditors.LookUpEdit txtSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgInvoiceItems;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTaxrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
    }
}