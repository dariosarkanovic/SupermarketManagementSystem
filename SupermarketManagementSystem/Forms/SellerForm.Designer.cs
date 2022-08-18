namespace SupermarketManagementSystem
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.EditButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.PhoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.PhoneLabel);
            this.panel1.Controls.Add(this.AgeTextBox);
            this.panel1.Controls.Add(this.AgeLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.IDTextBox);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(187, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 543);
            this.panel1.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.PasswordTextBox.BorderRadius = 10;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PasswordTextBox.Location = new System.Drawing.Point(165, 328);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.PasswordTextBox.PlaceholderText = "";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(253, 32);
            this.PasswordTextBox.TabIndex = 18;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Location = new System.Drawing.Point(19, 323);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(139, 37);
            this.PasswordLabel.TabIndex = 17;
            this.PasswordLabel.Text = "Password";
            // 
            // DataGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid.ColumnHeadersHeight = 20;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.Location = new System.Drawing.Point(429, 90);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(493, 439);
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
            this.DeleteButton.Location = new System.Drawing.Point(298, 397);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 45);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BorderColor = System.Drawing.Color.CadetBlue;
            this.EditButton.BorderRadius = 10;
            this.EditButton.BorderThickness = 1;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditButton.FillColor = System.Drawing.Color.White;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.EditButton.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditButton.Location = new System.Drawing.Point(155, 397);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(120, 45);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.AddButton.Location = new System.Drawing.Point(16, 397);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 45);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.PhoneTextBox.BorderRadius = 10;
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTextBox.DefaultText = "";
            this.PhoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PhoneTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PhoneTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PhoneTextBox.Location = new System.Drawing.Point(165, 267);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PasswordChar = '\0';
            this.PhoneTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.PhoneTextBox.PlaceholderText = "";
            this.PhoneTextBox.SelectedText = "";
            this.PhoneTextBox.Size = new System.Drawing.Size(253, 32);
            this.PhoneTextBox.TabIndex = 8;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.PhoneLabel.ForeColor = System.Drawing.Color.Transparent;
            this.PhoneLabel.Location = new System.Drawing.Point(19, 262);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(98, 37);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BorderColor = System.Drawing.Color.CadetBlue;
            this.AgeTextBox.BorderRadius = 10;
            this.AgeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTextBox.DefaultText = "";
            this.AgeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTextBox.FocusedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AgeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AgeTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AgeTextBox.Location = new System.Drawing.Point(165, 207);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.PasswordChar = '\0';
            this.AgeTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.AgeTextBox.PlaceholderText = "";
            this.AgeTextBox.SelectedText = "";
            this.AgeTextBox.Size = new System.Drawing.Size(253, 32);
            this.AgeTextBox.TabIndex = 6;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.AgeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.AgeLabel.Location = new System.Drawing.Point(19, 202);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(68, 37);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Age";
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
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.NameTextBox.Location = new System.Drawing.Point(165, 149);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.NameTextBox.PlaceholderText = "";
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.Size = new System.Drawing.Size(253, 32);
            this.NameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.NameLabel.Location = new System.Drawing.Point(19, 144);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(93, 37);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
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
            this.IDTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.IDTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.IDTextBox.Location = new System.Drawing.Point(165, 90);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.PasswordChar = '\0';
            this.IDTextBox.PlaceholderForeColor = System.Drawing.Color.CadetBlue;
            this.IDTextBox.PlaceholderText = "";
            this.IDTextBox.SelectedText = "";
            this.IDTextBox.Size = new System.Drawing.Size(253, 32);
            this.IDTextBox.TabIndex = 2;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.IDLabel.ForeColor = System.Drawing.Color.Transparent;
            this.IDLabel.Location = new System.Drawing.Point(19, 85);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(46, 37);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Location = new System.Drawing.Point(350, 14);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(232, 41);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Manage Sellers";
            // 
            // CategoryButton
            // 
            this.CategoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryButton.FlatAppearance.BorderSize = 0;
            this.CategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.CategoryButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.CategoryButton.Location = new System.Drawing.Point(12, 155);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(158, 43);
            this.CategoryButton.TabIndex = 5;
            this.CategoryButton.Text = "Category";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductButton.FlatAppearance.BorderSize = 0;
            this.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.ProductButton.ForeColor = System.Drawing.Color.CadetBlue;
            this.ProductButton.Location = new System.Drawing.Point(12, 106);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(146, 43);
            this.ProductButton.TabIndex = 4;
            this.ProductButton.Text = "Product";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.LogoutLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LogoutLabel.Location = new System.Drawing.Point(22, 504);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(118, 41);
            this.LogoutLabel.TabIndex = 34;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.Click += new System.EventHandler(this.LogoutLabel_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 582);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.panel1);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellerForm_FormClosing);
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private Guna.UI2.WinForms.Guna2TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button ProductButton;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LogoutLabel;
    }
}