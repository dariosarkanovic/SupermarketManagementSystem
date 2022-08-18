namespace SupermarketManagementSystem
{
    partial class Selling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selling));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerNameLabel = new System.Windows.Forms.Label();
            this.ValutaLabel = new System.Windows.Forms.Label();
            this.SellsListLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddProdButton = new Guna.UI2.WinForms.Guna2Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.RefreshButton = new Guna.UI2.WinForms.Guna2Button();
            this.SelectCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.PrintButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.QuantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BillIDLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.SellerNameLabel);
            this.panel1.Controls.Add(this.ValutaLabel);
            this.panel1.Controls.Add(this.SellsListLabel);
            this.panel1.Controls.Add(this.TotalLabel);
            this.panel1.Controls.Add(this.AmountLabel);
            this.panel1.Controls.Add(this.OrderData);
            this.panel1.Controls.Add(this.BillDataGrid);
            this.panel1.Controls.Add(this.AddProdButton);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.SelectCategoryComboBox);
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.QuantityTextBox);
            this.panel1.Controls.Add(this.QuantityLabel);
            this.panel1.Controls.Add(this.PriceTextBox);
            this.panel1.Controls.Add(this.PriceLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.BillIDLabel);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(175, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 543);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SellerNameLabel
            // 
            this.SellerNameLabel.AutoSize = true;
            this.SellerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SellerNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SellerNameLabel.Location = new System.Drawing.Point(19, 24);
            this.SellerNameLabel.Name = "SellerNameLabel";
            this.SellerNameLabel.Size = new System.Drawing.Size(65, 28);
            this.SellerNameLabel.TabIndex = 31;
            this.SellerNameLabel.Text = "Seller";
            // 
            // ValutaLabel
            // 
            this.ValutaLabel.AutoSize = true;
            this.ValutaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ValutaLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ValutaLabel.Location = new System.Drawing.Point(756, 240);
            this.ValutaLabel.Name = "ValutaLabel";
            this.ValutaLabel.Size = new System.Drawing.Size(24, 28);
            this.ValutaLabel.TabIndex = 30;
            this.ValutaLabel.Text = "$";
            // 
            // SellsListLabel
            // 
            this.SellsListLabel.AutoSize = true;
            this.SellsListLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.SellsListLabel.ForeColor = System.Drawing.Color.Transparent;
            this.SellsListLabel.Location = new System.Drawing.Point(615, 283);
            this.SellsListLabel.Name = "SellsListLabel";
            this.SellsListLabel.Size = new System.Drawing.Size(139, 41);
            this.SellsListLabel.TabIndex = 29;
            this.SellsListLabel.Text = "Sells List";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TotalLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Location = new System.Drawing.Point(702, 240);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(59, 28);
            this.TotalLabel.TabIndex = 28;
            this.TotalLabel.Text = "Total";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AmountLabel.ForeColor = System.Drawing.Color.Transparent;
            this.AmountLabel.Location = new System.Drawing.Point(556, 240);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(88, 28);
            this.AmountLabel.TabIndex = 27;
            this.AmountLabel.Text = "Amount";
            // 
            // OrderData
            // 
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.OrderData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.OrderData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderData.BackgroundColor = System.Drawing.Color.White;
            this.OrderData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.OrderData.ColumnHeadersHeight = 27;
            this.OrderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProdName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderData.DefaultCellStyle = dataGridViewCellStyle39;
            this.OrderData.EnableHeadersVisualStyles = false;
            this.OrderData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderData.Location = new System.Drawing.Point(457, 72);
            this.OrderData.Name = "OrderData";
            this.OrderData.RowHeadersVisible = false;
            this.OrderData.RowHeadersWidth = 51;
            this.OrderData.RowTemplate.Height = 24;
            this.OrderData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderData.Size = new System.Drawing.Size(465, 165);
            this.OrderData.TabIndex = 26;
            this.OrderData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OrderData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderData.ThemeStyle.HeaderStyle.Height = 27;
            this.OrderData.ThemeStyle.ReadOnly = false;
            this.OrderData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderData.ThemeStyle.RowsStyle.Height = 24;
            this.OrderData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // BillDataGrid
            // 
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            this.BillDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle40;
            this.BillDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.BillDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.BillDataGrid.ColumnHeadersHeight = 20;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDataGrid.DefaultCellStyle = dataGridViewCellStyle42;
            this.BillDataGrid.EnableHeadersVisualStyles = false;
            this.BillDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDataGrid.Location = new System.Drawing.Point(457, 327);
            this.BillDataGrid.Name = "BillDataGrid";
            this.BillDataGrid.RowHeadersVisible = false;
            this.BillDataGrid.RowHeadersWidth = 51;
            this.BillDataGrid.RowTemplate.Height = 24;
            this.BillDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDataGrid.Size = new System.Drawing.Size(465, 133);
            this.BillDataGrid.TabIndex = 25;
            this.BillDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDataGrid.ThemeStyle.HeaderStyle.Height = 20;
            this.BillDataGrid.ThemeStyle.ReadOnly = false;
            this.BillDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillDataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.BillDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillDataGrid_CellClick);
            // 
            // AddProdButton
            // 
            this.AddProdButton.BorderColor = System.Drawing.Color.CadetBlue;
            this.AddProdButton.BorderRadius = 10;
            this.AddProdButton.BorderThickness = 1;
            this.AddProdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProdButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProdButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddProdButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddProdButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddProdButton.FillColor = System.Drawing.Color.White;
            this.AddProdButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AddProdButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.AddProdButton.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddProdButton.Location = new System.Drawing.Point(126, 257);
            this.AddProdButton.Name = "AddProdButton";
            this.AddProdButton.Size = new System.Drawing.Size(183, 35);
            this.AddProdButton.TabIndex = 24;
            this.AddProdButton.Text = "Add Product";
            this.AddProdButton.Click += new System.EventHandler(this.AddProdButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(810, 14);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 23);
            this.DateLabel.TabIndex = 23;
            this.DateLabel.Text = "Date";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BorderColor = System.Drawing.Color.CadetBlue;
            this.RefreshButton.BorderRadius = 10;
            this.RefreshButton.BorderThickness = 1;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RefreshButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RefreshButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RefreshButton.FillColor = System.Drawing.Color.White;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RefreshButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.RefreshButton.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.RefreshButton.Location = new System.Drawing.Point(266, 308);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(123, 35);
            this.RefreshButton.TabIndex = 22;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SelectCategoryComboBox
            // 
            this.SelectCategoryComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategoryComboBox.ForeColor = System.Drawing.Color.CadetBlue;
            this.SelectCategoryComboBox.FormattingEnabled = true;
            this.SelectCategoryComboBox.Location = new System.Drawing.Point(41, 307);
            this.SelectCategoryComboBox.Name = "SelectCategoryComboBox";
            this.SelectCategoryComboBox.Size = new System.Drawing.Size(210, 36);
            this.SelectCategoryComboBox.TabIndex = 21;
            this.SelectCategoryComboBox.Text = "Select Category";
            this.SelectCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryComboBox2_SelectedIndexChanged);
            // 
            // DataGrid
            // 
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.DataGrid.ColumnHeadersHeight = 20;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle45;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.Location = new System.Drawing.Point(24, 349);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(401, 174);
            this.DataGrid.TabIndex = 14;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGrid.ThemeStyle.HeaderStyle.Height = 20;
            this.DataGrid.ThemeStyle.ReadOnly = false;
            this.DataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid.ThemeStyle.RowsStyle.Height = 24;
            this.DataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BorderColor = System.Drawing.Color.CadetBlue;
            this.DeleteButton.BorderRadius = 10;
            this.DeleteButton.BorderThickness = 1;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.DeleteButton.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.Location = new System.Drawing.Point(761, 478);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 45);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BorderColor = System.Drawing.Color.CadetBlue;
            this.PrintButton.BorderRadius = 10;
            this.PrintButton.BorderThickness = 1;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintButton.FillColor = System.Drawing.Color.White;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.PrintButton.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintButton.Location = new System.Drawing.Point(629, 478);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(120, 45);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "Print";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BorderColor = System.Drawing.Color.CadetBlue;
            this.AddButton.BorderRadius = 10;
            this.AddButton.BorderThickness = 1;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.White;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.AddButton.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Location = new System.Drawing.Point(497, 478);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 45);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.QuantityTextBox.BorderRadius = 10;
            this.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTextBox.DefaultText = "";
            this.QuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.QuantityTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.QuantityTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.QuantityTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.QuantityTextBox.Location = new System.Drawing.Point(172, 212);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.QuantityTextBox.PlaceholderText = "";
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.Size = new System.Drawing.Size(253, 28);
            this.QuantityTextBox.TabIndex = 8;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.QuantityLabel.ForeColor = System.Drawing.Color.Transparent;
            this.QuantityLabel.Location = new System.Drawing.Point(19, 212);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(95, 28);
            this.QuantityLabel.TabIndex = 7;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.PriceTextBox.BorderRadius = 10;
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.DefaultText = "";
            this.PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.PriceTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PriceTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PriceTextBox.Location = new System.Drawing.Point(172, 171);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.PriceTextBox.PlaceholderText = "";
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.Size = new System.Drawing.Size(253, 28);
            this.PriceTextBox.TabIndex = 6;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Location = new System.Drawing.Point(19, 171);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(59, 28);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price";
            // 
            // NameTextBox
            // 
            this.NameTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.NameTextBox.BorderRadius = 10;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.NameTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.NameTextBox.Location = new System.Drawing.Point(174, 128);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.NameTextBox.PlaceholderText = "";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(253, 28);
            this.NameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(19, 128);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(148, 28);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Product Name";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.IDTextBox.BorderRadius = 10;
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox.DefaultText = "";
            this.IDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.IDTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.IDTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.IDTextBox.Location = new System.Drawing.Point(172, 85);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.PasswordChar = '\0';
            this.IDTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.IDTextBox.PlaceholderText = "";
            this.IDTextBox.SelectedText = "";
            this.IDTextBox.Size = new System.Drawing.Size(253, 28);
            this.IDTextBox.TabIndex = 2;
            // 
            // BillIDLabel
            // 
            this.BillIDLabel.AutoSize = true;
            this.BillIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BillIDLabel.ForeColor = System.Drawing.Color.Transparent;
            this.BillIDLabel.Location = new System.Drawing.Point(19, 85);
            this.BillIDLabel.Name = "BillIDLabel";
            this.BillIDLabel.Size = new System.Drawing.Size(70, 28);
            this.BillIDLabel.TabIndex = 1;
            this.BillIDLabel.Text = "Bill ID";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Location = new System.Drawing.Point(434, 14);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(115, 41);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Selling";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LogoutLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LogoutLabel.Location = new System.Drawing.Point(21, 505);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(118, 41);
            this.LogoutLabel.TabIndex = 32;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // Selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 582);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Selling";
            this.Text = "Selling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Selling_FormClosing);
            this.Load += new System.EventHandler(this.Selling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button PrintButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2TextBox IDTextBox;
        private System.Windows.Forms.Label BillIDLabel;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2Button RefreshButton;
        private System.Windows.Forms.ComboBox SelectCategoryComboBox;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2Button AddProdButton;
        private System.Windows.Forms.Label SellsListLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label AmountLabel;
        private Guna.UI2.WinForms.Guna2DataGridView OrderData;
        private Guna.UI2.WinForms.Guna2DataGridView BillDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label ValutaLabel;
        private System.Windows.Forms.Label SellerNameLabel;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label LogoutLabel;
    }
}