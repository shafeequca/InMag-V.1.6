namespace InMag_V._16
{
    partial class frmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSlno = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblCBalance = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtCBalance = new System.Windows.Forms.TextBox();
            this.txtBillno = new System.Windows.Forms.TextBox();
            this.lblBillno = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lblItemname = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboRategroup = new System.Windows.Forms.ComboBox();
            this.lblRategroup = new System.Windows.Forms.Label();
            this.ItemGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtGrand = new System.Windows.Forms.TextBox();
            this.lblGrand = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCashEntry = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBillNoSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCustomerSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAreaSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchGrid = new System.Windows.Forms.DataGridView();
            this.cmdItemClear = new System.Windows.Forms.Button();
            this.itemView = new System.Windows.Forms.GroupBox();
            this.ItemDisplayGrid = new System.Windows.Forms.DataGridView();
            this.txtItems = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).BeginInit();
            this.itemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSlno
            // 
            this.lblSlno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlno.ForeColor = System.Drawing.Color.White;
            this.lblSlno.Location = new System.Drawing.Point(32, 191);
            this.lblSlno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlno.Name = "lblSlno";
            this.lblSlno.Size = new System.Drawing.Size(53, 23);
            this.lblSlno.TabIndex = 31;
            this.lblSlno.Text = "Sl.No";
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(29, 27);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(126, 24);
            this.lblArea.TabIndex = 34;
            this.lblArea.Text = "Area";
            // 
            // cboArea
            // 
            this.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(162, 27);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(304, 30);
            this.cboArea.TabIndex = 35;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(162, 67);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(304, 30);
            this.cboCustomer.TabIndex = 37;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(29, 67);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(126, 24);
            this.lblCustomer.TabIndex = 36;
            this.lblCustomer.Text = "Customer";
            // 
            // lblPlace
            // 
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.Color.White;
            this.lblPlace.Location = new System.Drawing.Point(29, 103);
            this.lblPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(126, 24);
            this.lblPlace.TabIndex = 38;
            this.lblPlace.Text = "Place";
            // 
            // lblCBalance
            // 
            this.lblCBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBalance.ForeColor = System.Drawing.Color.White;
            this.lblCBalance.Location = new System.Drawing.Point(29, 143);
            this.lblCBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCBalance.Name = "lblCBalance";
            this.lblCBalance.Size = new System.Drawing.Size(126, 24);
            this.lblCBalance.TabIndex = 40;
            this.lblCBalance.Text = "Current Balance";
            // 
            // txtPlace
            // 
            this.txtPlace.Enabled = false;
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(162, 105);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(304, 28);
            this.txtPlace.TabIndex = 42;
            // 
            // txtCBalance
            // 
            this.txtCBalance.Enabled = false;
            this.txtCBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCBalance.Location = new System.Drawing.Point(162, 143);
            this.txtCBalance.Name = "txtCBalance";
            this.txtCBalance.Size = new System.Drawing.Size(304, 28);
            this.txtCBalance.TabIndex = 43;
            this.txtCBalance.TextChanged += new System.EventHandler(this.txtCBalance_TextChanged);
            // 
            // txtBillno
            // 
            this.txtBillno.Enabled = false;
            this.txtBillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillno.Location = new System.Drawing.Point(693, 27);
            this.txtBillno.Name = "txtBillno";
            this.txtBillno.Size = new System.Drawing.Size(189, 28);
            this.txtBillno.TabIndex = 45;
            // 
            // lblBillno
            // 
            this.lblBillno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillno.ForeColor = System.Drawing.Color.White;
            this.lblBillno.Location = new System.Drawing.Point(530, 27);
            this.lblBillno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillno.Name = "lblBillno";
            this.lblBillno.Size = new System.Drawing.Size(156, 24);
            this.lblBillno.TabIndex = 44;
            this.lblBillno.Text = "Bill No";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(530, 67);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(156, 24);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "Date";
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(693, 69);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(189, 28);
            this.DatePicker.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(80, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Item Code";
            // 
            // lblItemname
            // 
            this.lblItemname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemname.ForeColor = System.Drawing.Color.White;
            this.lblItemname.Location = new System.Drawing.Point(192, 191);
            this.lblItemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemname.Name = "lblItemname";
            this.lblItemname.Size = new System.Drawing.Size(274, 23);
            this.lblItemname.TabIndex = 51;
            this.lblItemname.Text = "Item Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(463, 191);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(135, 23);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(593, 191);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(130, 23);
            this.lblRate.TabIndex = 53;
            this.lblRate.Text = "Rate";
            // 
            // txtItemcode
            // 
            this.txtItemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemcode.Location = new System.Drawing.Point(80, 218);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.Size = new System.Drawing.Size(112, 27);
            this.txtItemcode.TabIndex = 56;
            this.txtItemcode.TextChanged += new System.EventHandler(this.txtItemcode_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(463, 218);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(130, 27);
            this.txtQuantity.TabIndex = 58;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(593, 218);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(124, 27);
            this.txtRate.TabIndex = 59;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(716, 218);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(168, 27);
            this.txtTotal.TabIndex = 63;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(716, 191);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(168, 23);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "Total";
            // 
            // cboRategroup
            // 
            this.cboRategroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRategroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRategroup.FormattingEnabled = true;
            this.cboRategroup.Items.AddRange(new object[] {
            "Retail Price",
            "Wholesale Price"});
            this.cboRategroup.Location = new System.Drawing.Point(695, 143);
            this.cboRategroup.Name = "cboRategroup";
            this.cboRategroup.Size = new System.Drawing.Size(189, 30);
            this.cboRategroup.TabIndex = 65;
            this.cboRategroup.SelectedIndexChanged += new System.EventHandler(this.cboRategroup_SelectedIndexChanged);
            // 
            // lblRategroup
            // 
            this.lblRategroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRategroup.ForeColor = System.Drawing.Color.White;
            this.lblRategroup.Location = new System.Drawing.Point(532, 143);
            this.lblRategroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRategroup.Name = "lblRategroup";
            this.lblRategroup.Size = new System.Drawing.Size(156, 24);
            this.lblRategroup.TabIndex = 64;
            this.lblRategroup.Text = "Rate Group";
            // 
            // ItemGrid
            // 
            this.ItemGrid.AllowUserToAddRows = false;
            this.ItemGrid.AllowUserToDeleteRows = false;
            this.ItemGrid.AllowUserToResizeColumns = false;
            this.ItemGrid.AllowUserToResizeRows = false;
            this.ItemGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGrid.ColumnHeadersVisible = false;
            this.ItemGrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemGrid.Location = new System.Drawing.Point(29, 246);
            this.ItemGrid.MultiSelect = false;
            this.ItemGrid.Name = "ItemGrid";
            this.ItemGrid.ReadOnly = true;
            this.ItemGrid.RowHeadersVisible = false;
            this.ItemGrid.RowTemplate.Height = 24;
            this.ItemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGrid.Size = new System.Drawing.Size(855, 370);
            this.ItemGrid.TabIndex = 66;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(122, 24);
            this.Edit.Text = "Edit";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(122, 24);
            this.Delete.Text = "Delete";
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(195, 633);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(189, 28);
            this.txtCash.TabIndex = 68;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // lblCash
            // 
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.White;
            this.lblCash.Location = new System.Drawing.Point(26, 631);
            this.lblCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(156, 24);
            this.lblCash.TabIndex = 67;
            this.lblCash.Text = "Cash";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(195, 669);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(189, 28);
            this.txtDiscount.TabIndex = 70;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(26, 667);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(156, 24);
            this.lblDiscount.TabIndex = 69;
            this.lblDiscount.Text = "Discount";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(195, 706);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(189, 28);
            this.txtBalance.TabIndex = 72;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(29, 706);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(156, 24);
            this.lblBalance.TabIndex = 71;
            this.lblBalance.Text = "Balance";
            // 
            // txtGrand
            // 
            this.txtGrand.Enabled = false;
            this.txtGrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrand.Location = new System.Drawing.Point(650, 633);
            this.txtGrand.Name = "txtGrand";
            this.txtGrand.Size = new System.Drawing.Size(232, 28);
            this.txtGrand.TabIndex = 74;
            this.txtGrand.TextChanged += new System.EventHandler(this.txtGrand_TextChanged);
            // 
            // lblGrand
            // 
            this.lblGrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrand.ForeColor = System.Drawing.Color.White;
            this.lblGrand.Location = new System.Drawing.Point(503, 633);
            this.lblGrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.Size = new System.Drawing.Size(141, 24);
            this.lblGrand.TabIndex = 73;
            this.lblGrand.Text = "Grand Total";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(530, 697);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 31);
            this.btnPrint.TabIndex = 75;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(650, 697);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 31);
            this.btnClear.TabIndex = 76;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(770, 697);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 31);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(409, 697);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 31);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkCashEntry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.txtBillNoSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DtTo);
            this.panel1.Controls.Add(this.DtFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboCustomerSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboAreaSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(899, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 747);
            this.panel1.TabIndex = 80;
            // 
            // chkCashEntry
            // 
            this.chkCashEntry.AutoSize = true;
            this.chkCashEntry.ForeColor = System.Drawing.Color.White;
            this.chkCashEntry.Location = new System.Drawing.Point(344, 13);
            this.chkCashEntry.Name = "chkCashEntry";
            this.chkCashEntry.Size = new System.Drawing.Size(99, 21);
            this.chkCashEntry.TabIndex = 80;
            this.chkCashEntry.Text = "Cash Entry";
            this.chkCashEntry.UseVisualStyleBackColor = true;
            this.chkCashEntry.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 79;
            this.label5.Text = "Search Area";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 24);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(365, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 24);
            this.btnReset.TabIndex = 77;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBillNoSearch
            // 
            this.txtBillNoSearch.Location = new System.Drawing.Point(139, 134);
            this.txtBillNoSearch.Name = "txtBillNoSearch";
            this.txtBillNoSearch.Size = new System.Drawing.Size(143, 22);
            this.txtBillNoSearch.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 75;
            this.label4.Text = "Bill No";
            // 
            // DtTo
            // 
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(288, 106);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(155, 22);
            this.DtTo.TabIndex = 74;
            // 
            // DtFrom
            // 
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFrom.Location = new System.Drawing.Point(139, 106);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(143, 22);
            this.DtFrom.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Date Between";
            // 
            // cboCustomerSearch
            // 
            this.cboCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomerSearch.FormattingEnabled = true;
            this.cboCustomerSearch.Location = new System.Drawing.Point(139, 76);
            this.cboCustomerSearch.Name = "cboCustomerSearch";
            this.cboCustomerSearch.Size = new System.Drawing.Size(304, 24);
            this.cboCustomerSearch.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Customer";
            // 
            // cboAreaSearch
            // 
            this.cboAreaSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAreaSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAreaSearch.FormattingEnabled = true;
            this.cboAreaSearch.Location = new System.Drawing.Point(139, 46);
            this.cboAreaSearch.Name = "cboAreaSearch";
            this.cboAreaSearch.Size = new System.Drawing.Size(304, 24);
            this.cboAreaSearch.TabIndex = 69;
            this.cboAreaSearch.SelectedIndexChanged += new System.EventHandler(this.cboAreaSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Area";
            // 
            // SearchGrid
            // 
            this.SearchGrid.AllowUserToAddRows = false;
            this.SearchGrid.AllowUserToDeleteRows = false;
            this.SearchGrid.AllowUserToOrderColumns = true;
            this.SearchGrid.AllowUserToResizeColumns = false;
            this.SearchGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SearchGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGrid.Location = new System.Drawing.Point(-2, 177);
            this.SearchGrid.MultiSelect = false;
            this.SearchGrid.Name = "SearchGrid";
            this.SearchGrid.ReadOnly = true;
            this.SearchGrid.RowHeadersVisible = false;
            this.SearchGrid.RowTemplate.Height = 24;
            this.SearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchGrid.Size = new System.Drawing.Size(451, 512);
            this.SearchGrid.TabIndex = 67;
            this.SearchGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchGrid_CellClick);
            // 
            // cmdItemClear
            // 
            this.cmdItemClear.Location = new System.Drawing.Point(32, 219);
            this.cmdItemClear.Name = "cmdItemClear";
            this.cmdItemClear.Size = new System.Drawing.Size(45, 23);
            this.cmdItemClear.TabIndex = 82;
            this.cmdItemClear.Text = "---";
            this.cmdItemClear.UseVisualStyleBackColor = true;
            this.cmdItemClear.Click += new System.EventHandler(this.cmdItemClear_Click);
            // 
            // itemView
            // 
            this.itemView.BackColor = System.Drawing.Color.White;
            this.itemView.Controls.Add(this.ItemDisplayGrid);
            this.itemView.Location = new System.Drawing.Point(192, 248);
            this.itemView.Name = "itemView";
            this.itemView.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.itemView.Size = new System.Drawing.Size(601, 264);
            this.itemView.TabIndex = 83;
            this.itemView.TabStop = false;
            // 
            // ItemDisplayGrid
            // 
            this.ItemDisplayGrid.AllowUserToAddRows = false;
            this.ItemDisplayGrid.AllowUserToDeleteRows = false;
            this.ItemDisplayGrid.AllowUserToOrderColumns = true;
            this.ItemDisplayGrid.AllowUserToResizeColumns = false;
            this.ItemDisplayGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDisplayGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ItemDisplayGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDisplayGrid.BackgroundColor = System.Drawing.Color.White;
            this.ItemDisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDisplayGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDisplayGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemDisplayGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDisplayGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ItemDisplayGrid.Location = new System.Drawing.Point(3, 15);
            this.ItemDisplayGrid.MultiSelect = false;
            this.ItemDisplayGrid.Name = "ItemDisplayGrid";
            this.ItemDisplayGrid.ReadOnly = true;
            this.ItemDisplayGrid.RowHeadersVisible = false;
            this.ItemDisplayGrid.RowTemplate.Height = 24;
            this.ItemDisplayGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemDisplayGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDisplayGrid.Size = new System.Drawing.Size(595, 246);
            this.ItemDisplayGrid.TabIndex = 68;
            this.ItemDisplayGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDisplayGrid_CellClick);
            // 
            // txtItems
            // 
            this.txtItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItems.Location = new System.Drawing.Point(192, 218);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(272, 27);
            this.txtItems.TabIndex = 84;
            this.txtItems.TextChanged += new System.EventHandler(this.txtItems_TextChanged);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.itemView);
            this.Controls.Add(this.cmdItemClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtGrand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGrand);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.ItemGrid);
            this.Controls.Add(this.cboRategroup);
            this.Controls.Add(this.lblRategroup);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemcode);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtBillno);
            this.Controls.Add(this.lblBillno);
            this.Controls.Add(this.txtCBalance);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblCBalance);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblSlno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSales";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Voucher";
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).EndInit();
            this.itemView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlno;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblCBalance;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtCBalance;
        private System.Windows.Forms.TextBox txtBillno;
        private System.Windows.Forms.Label lblBillno;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblItemname;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboRategroup;
        private System.Windows.Forms.Label lblRategroup;
        private System.Windows.Forms.DataGridView ItemGrid;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtGrand;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SearchGrid;
        private System.Windows.Forms.Button cmdItemClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.TextBox txtBillNoSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCustomerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAreaSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCashEntry;
        private System.Windows.Forms.GroupBox itemView;
        private System.Windows.Forms.DataGridView ItemDisplayGrid;
        private System.Windows.Forms.TextBox txtItems;
    }
}