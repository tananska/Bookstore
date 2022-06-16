namespace Bookstore_Shop
{
    partial class Administration
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.productTabPage = new System.Windows.Forms.TabPage();
            this.goToProductsButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.discriminatorLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriminatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet1 = new Bookstore_Shop.BookStoreDataSet1();
            this.adminsTabPage = new System.Windows.Forms.TabPage();
            this.goToAccountButton = new System.Windows.Forms.Button();
            this.addAdminButton = new System.Windows.Forms.Button();
            this.adminPhoneLabel = new System.Windows.Forms.Label();
            this.adminAddressLabel = new System.Windows.Forms.Label();
            this.adminConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.adminPasswordLabel = new System.Windows.Forms.Label();
            this.adminEmailLabel = new System.Windows.Forms.Label();
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.adminPhoneTextBox = new System.Windows.Forms.TextBox();
            this.adminAddressTextBox = new System.Windows.Forms.TextBox();
            this.adminCofirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminEmailTextBox = new System.Windows.Forms.TextBox();
            this.adminNameTextBox = new System.Windows.Forms.TextBox();
            this.adminsListView = new System.Windows.Forms.ListView();
            this.bookstoreDBDataSet = new Bookstore_Shop.BookstoreDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Bookstore_Shop.BookstoreDBDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new Bookstore_Shop.BookStoreDataSetTableAdapters.ProductsTableAdapter();
            this.productsTableAdapter2 = new Bookstore_Shop.BookStoreDataSet1TableAdapters.ProductsTableAdapter();
            this.bookStoreDataSet5 = new Bookstore_Shop.BookStoreDataSet5();
            this.productsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter3 = new Bookstore_Shop.BookStoreDataSet5TableAdapters.ProductsTableAdapter();
            this.tabControl.SuspendLayout();
            this.productTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet1)).BeginInit();
            this.adminsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.productTabPage);
            this.tabControl.Controls.Add(this.adminsTabPage);
            this.tabControl.Location = new System.Drawing.Point(33, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(593, 437);
            this.tabControl.TabIndex = 0;
            // 
            // productTabPage
            // 
            this.productTabPage.Controls.Add(this.goToProductsButton);
            this.productTabPage.Controls.Add(this.descriptionTextBox);
            this.productTabPage.Controls.Add(this.descriptionLabel);
            this.productTabPage.Controls.Add(this.quantityNumericUpDown);
            this.productTabPage.Controls.Add(this.deleteButton);
            this.productTabPage.Controls.Add(this.clearButton);
            this.productTabPage.Controls.Add(this.updateButton);
            this.productTabPage.Controls.Add(this.addButton);
            this.productTabPage.Controls.Add(this.priceNumericUpDown);
            this.productTabPage.Controls.Add(this.typeComboBox);
            this.productTabPage.Controls.Add(this.nameTextBox);
            this.productTabPage.Controls.Add(this.barcodeTextBox);
            this.productTabPage.Controls.Add(this.discriminatorLabel);
            this.productTabPage.Controls.Add(this.priceLabel);
            this.productTabPage.Controls.Add(this.quantityLabel);
            this.productTabPage.Controls.Add(this.nameLabel);
            this.productTabPage.Controls.Add(this.barcodeLabel);
            this.productTabPage.Controls.Add(this.dataGridView1);
            this.productTabPage.Location = new System.Drawing.Point(4, 22);
            this.productTabPage.Name = "productTabPage";
            this.productTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productTabPage.Size = new System.Drawing.Size(585, 411);
            this.productTabPage.TabIndex = 0;
            this.productTabPage.Text = "Products";
            this.productTabPage.UseVisualStyleBackColor = true;
            // 
            // goToProductsButton
            // 
            this.goToProductsButton.Location = new System.Drawing.Point(457, 168);
            this.goToProductsButton.Name = "goToProductsButton";
            this.goToProductsButton.Size = new System.Drawing.Size(105, 23);
            this.goToProductsButton.TabIndex = 19;
            this.goToProductsButton.Text = "Go to Products";
            this.goToProductsButton.UseVisualStyleBackColor = true;
            this.goToProductsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(115, 96);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(27, 96);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 17;
            this.descriptionLabel.Text = "Description";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(115, 123);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.quantityNumericUpDown.TabIndex = 16;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(356, 168);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(356, 123);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(356, 71);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(356, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumericUpDown.Location = new System.Drawing.Point(115, 156);
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.priceNumericUpDown.TabIndex = 11;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Pen",
            "Pencil",
            "Notebook",
            "Eraser"});
            this.typeComboBox.Location = new System.Drawing.Point(115, 193);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeComboBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(115, 23);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.barcodeTextBox.TabIndex = 6;
            this.barcodeTextBox.TextChanged += new System.EventHandler(this.barcodeTextBox_TextChanged);
            // 
            // discriminatorLabel
            // 
            this.discriminatorLabel.AutoSize = true;
            this.discriminatorLabel.Location = new System.Drawing.Point(56, 193);
            this.discriminatorLabel.Name = "discriminatorLabel";
            this.discriminatorLabel.Size = new System.Drawing.Size(31, 13);
            this.discriminatorLabel.TabIndex = 5;
            this.discriminatorLabel.Text = "Type";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(56, 156);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(41, 123);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(52, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(40, 26);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(47, 13);
            this.barcodeLabel.TabIndex = 1;
            this.barcodeLabel.Text = "Barcode";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Description,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.discriminatorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(18, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // discriminatorDataGridViewTextBoxColumn
            // 
            this.discriminatorDataGridViewTextBoxColumn.DataPropertyName = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.HeaderText = "Discriminator";
            this.discriminatorDataGridViewTextBoxColumn.Name = "discriminatorDataGridViewTextBoxColumn";
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.bookStoreDataSet1;
            // 
            // bookStoreDataSet1
            // 
            this.bookStoreDataSet1.DataSetName = "BookStoreDataSet1";
            this.bookStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsTabPage
            // 
            this.adminsTabPage.Controls.Add(this.goToAccountButton);
            this.adminsTabPage.Controls.Add(this.addAdminButton);
            this.adminsTabPage.Controls.Add(this.adminPhoneLabel);
            this.adminsTabPage.Controls.Add(this.adminAddressLabel);
            this.adminsTabPage.Controls.Add(this.adminConfirmPasswordLabel);
            this.adminsTabPage.Controls.Add(this.adminPasswordLabel);
            this.adminsTabPage.Controls.Add(this.adminEmailLabel);
            this.adminsTabPage.Controls.Add(this.adminNameLabel);
            this.adminsTabPage.Controls.Add(this.adminPhoneTextBox);
            this.adminsTabPage.Controls.Add(this.adminAddressTextBox);
            this.adminsTabPage.Controls.Add(this.adminCofirmPasswordTextBox);
            this.adminsTabPage.Controls.Add(this.adminPasswordTextBox);
            this.adminsTabPage.Controls.Add(this.adminEmailTextBox);
            this.adminsTabPage.Controls.Add(this.adminNameTextBox);
            this.adminsTabPage.Controls.Add(this.adminsListView);
            this.adminsTabPage.Location = new System.Drawing.Point(4, 22);
            this.adminsTabPage.Name = "adminsTabPage";
            this.adminsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminsTabPage.Size = new System.Drawing.Size(585, 411);
            this.adminsTabPage.TabIndex = 1;
            this.adminsTabPage.Text = "Admins";
            this.adminsTabPage.UseVisualStyleBackColor = true;
            // 
            // goToAccountButton
            // 
            this.goToAccountButton.Location = new System.Drawing.Point(172, 355);
            this.goToAccountButton.Name = "goToAccountButton";
            this.goToAccountButton.Size = new System.Drawing.Size(100, 23);
            this.goToAccountButton.TabIndex = 25;
            this.goToAccountButton.Text = "Go to Account";
            this.goToAccountButton.UseVisualStyleBackColor = true;
            this.goToAccountButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addAdminButton
            // 
            this.addAdminButton.Location = new System.Drawing.Point(197, 314);
            this.addAdminButton.Name = "addAdminButton";
            this.addAdminButton.Size = new System.Drawing.Size(75, 23);
            this.addAdminButton.TabIndex = 24;
            this.addAdminButton.Text = "Add Admin";
            this.addAdminButton.UseVisualStyleBackColor = true;
            this.addAdminButton.Click += new System.EventHandler(this.addAdminButton_Click);
            // 
            // adminPhoneLabel
            // 
            this.adminPhoneLabel.AutoSize = true;
            this.adminPhoneLabel.Location = new System.Drawing.Point(108, 258);
            this.adminPhoneLabel.Name = "adminPhoneLabel";
            this.adminPhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.adminPhoneLabel.TabIndex = 23;
            this.adminPhoneLabel.Text = "Phone";
            // 
            // adminAddressLabel
            // 
            this.adminAddressLabel.AutoSize = true;
            this.adminAddressLabel.Location = new System.Drawing.Point(101, 221);
            this.adminAddressLabel.Name = "adminAddressLabel";
            this.adminAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.adminAddressLabel.TabIndex = 22;
            this.adminAddressLabel.Text = "Address";
            // 
            // adminConfirmPasswordLabel
            // 
            this.adminConfirmPasswordLabel.AutoSize = true;
            this.adminConfirmPasswordLabel.Location = new System.Drawing.Point(55, 189);
            this.adminConfirmPasswordLabel.Name = "adminConfirmPasswordLabel";
            this.adminConfirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.adminConfirmPasswordLabel.TabIndex = 21;
            this.adminConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.Location = new System.Drawing.Point(93, 150);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.adminPasswordLabel.TabIndex = 20;
            this.adminPasswordLabel.Text = "Password";
            // 
            // adminEmailLabel
            // 
            this.adminEmailLabel.AutoSize = true;
            this.adminEmailLabel.Location = new System.Drawing.Point(114, 112);
            this.adminEmailLabel.Name = "adminEmailLabel";
            this.adminEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.adminEmailLabel.TabIndex = 19;
            this.adminEmailLabel.Text = "Email";
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Location = new System.Drawing.Point(111, 77);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(35, 13);
            this.adminNameLabel.TabIndex = 18;
            this.adminNameLabel.Text = "Name";
            // 
            // adminPhoneTextBox
            // 
            this.adminPhoneTextBox.Location = new System.Drawing.Point(172, 258);
            this.adminPhoneTextBox.Name = "adminPhoneTextBox";
            this.adminPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminPhoneTextBox.TabIndex = 17;
            // 
            // adminAddressTextBox
            // 
            this.adminAddressTextBox.Location = new System.Drawing.Point(172, 221);
            this.adminAddressTextBox.Name = "adminAddressTextBox";
            this.adminAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminAddressTextBox.TabIndex = 16;
            // 
            // adminCofirmPasswordTextBox
            // 
            this.adminCofirmPasswordTextBox.Location = new System.Drawing.Point(172, 186);
            this.adminCofirmPasswordTextBox.Name = "adminCofirmPasswordTextBox";
            this.adminCofirmPasswordTextBox.PasswordChar = '•';
            this.adminCofirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminCofirmPasswordTextBox.TabIndex = 15;
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Location = new System.Drawing.Point(172, 150);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.PasswordChar = '•';
            this.adminPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminPasswordTextBox.TabIndex = 14;
            // 
            // adminEmailTextBox
            // 
            this.adminEmailTextBox.Location = new System.Drawing.Point(172, 112);
            this.adminEmailTextBox.Name = "adminEmailTextBox";
            this.adminEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminEmailTextBox.TabIndex = 13;
            // 
            // adminNameTextBox
            // 
            this.adminNameTextBox.Location = new System.Drawing.Point(172, 77);
            this.adminNameTextBox.Name = "adminNameTextBox";
            this.adminNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminNameTextBox.TabIndex = 12;
            // 
            // adminsListView
            // 
            this.adminsListView.Location = new System.Drawing.Point(348, 71);
            this.adminsListView.Name = "adminsListView";
            this.adminsListView.Size = new System.Drawing.Size(196, 266);
            this.adminsListView.TabIndex = 0;
            this.adminsListView.UseCompatibleStateImageBehavior = false;
            this.adminsListView.View = System.Windows.Forms.View.List;
            // 
            // bookstoreDBDataSet
            // 
            this.bookstoreDBDataSet.DataSetName = "BookstoreDBDataSet";
            this.bookstoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.bookstoreDBDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // bookStoreDataSet5
            // 
            this.bookStoreDataSet5.DataSetName = "BookStoreDataSet5";
            this.bookStoreDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource3
            // 
            this.productsBindingSource3.DataMember = "Products";
            this.productsBindingSource3.DataSource = this.bookStoreDataSet5;
            // 
            // productsTableAdapter3
            // 
            this.productsTableAdapter3.ClearBeforeFill = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 461);
            this.Controls.Add(this.tabControl);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.tabControl.ResumeLayout(false);
            this.productTabPage.ResumeLayout(false);
            this.productTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet1)).EndInit();
            this.adminsTabPage.ResumeLayout(false);
            this.adminsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage productTabPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage adminsTabPage;
        private BookstoreDBDataSet bookstoreDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private BookstoreDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private BookStoreDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Label discriminatorLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.ListView adminsListView;
        private System.Windows.Forms.Button addAdminButton;
        private System.Windows.Forms.Label adminPhoneLabel;
        private System.Windows.Forms.Label adminAddressLabel;
        private System.Windows.Forms.Label adminConfirmPasswordLabel;
        private System.Windows.Forms.Label adminPasswordLabel;
        private System.Windows.Forms.Label adminEmailLabel;
        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.TextBox adminPhoneTextBox;
        private System.Windows.Forms.TextBox adminAddressTextBox;
        private System.Windows.Forms.TextBox adminCofirmPasswordTextBox;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.TextBox adminEmailTextBox;
        private System.Windows.Forms.TextBox adminNameTextBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private BookStoreDataSet1 bookStoreDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private BookStoreDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriminatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button goToProductsButton;
        private System.Windows.Forms.Button goToAccountButton;
        private BookStoreDataSet5 bookStoreDataSet5;
        private System.Windows.Forms.BindingSource productsBindingSource3;
        private BookStoreDataSet5TableAdapters.ProductsTableAdapter productsTableAdapter3;
    }
}