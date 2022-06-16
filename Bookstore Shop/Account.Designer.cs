namespace Bookstore_Shop
{
    partial class Account
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.changePasswordRadioButton = new System.Windows.Forms.RadioButton();
            this.updateRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet2 = new Bookstore_Shop.BookStoreDataSet2();
            this.logOutButton = new System.Windows.Forms.Button();
            this.goToProductsButton = new System.Windows.Forms.Button();
            this.ordersTableAdapter = new Bookstore_Shop.BookStoreDataSet2TableAdapters.OrdersTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.confirmPasswordLabel);
            this.tabPage1.Controls.Add(this.newPasswordLabel);
            this.tabPage1.Controls.Add(this.confirmPasswordTextBox);
            this.tabPage1.Controls.Add(this.passwordTextBox);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.changeButton);
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Controls.Add(this.deleteRadioButton);
            this.tabPage1.Controls.Add(this.changePasswordRadioButton);
            this.tabPage1.Controls.Add(this.updateRadioButton);
            this.tabPage1.Controls.Add(this.phoneLabel);
            this.tabPage1.Controls.Add(this.addressLabel);
            this.tabPage1.Controls.Add(this.emailLabel);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Controls.Add(this.phoneTextBox);
            this.tabPage1.Controls.Add(this.addressTextBox);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(62, 265);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPasswordLabel.TabIndex = 51;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(76, 229);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(77, 13);
            this.newPasswordLabel.TabIndex = 50;
            this.newPasswordLabel.Text = "New password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(179, 262);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '•';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordTextBox.TabIndex = 49;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(179, 226);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 48;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(375, 143);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "Delete ";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(352, 259);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(110, 23);
            this.changeButton.TabIndex = 46;
            this.changeButton.Text = "Change Password";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click_1);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(375, 143);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 45;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(352, 100);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(98, 17);
            this.deleteRadioButton.TabIndex = 44;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Delete account";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            this.deleteRadioButton.CheckedChanged += new System.EventHandler(this.deleteRadioButton_CheckedChanged_1);
            // 
            // changePasswordRadioButton
            // 
            this.changePasswordRadioButton.AutoSize = true;
            this.changePasswordRadioButton.Location = new System.Drawing.Point(352, 71);
            this.changePasswordRadioButton.Name = "changePasswordRadioButton";
            this.changePasswordRadioButton.Size = new System.Drawing.Size(110, 17);
            this.changePasswordRadioButton.TabIndex = 43;
            this.changePasswordRadioButton.TabStop = true;
            this.changePasswordRadioButton.Text = "Change password";
            this.changePasswordRadioButton.UseVisualStyleBackColor = true;
            this.changePasswordRadioButton.CheckedChanged += new System.EventHandler(this.changePasswordRadioButton_CheckedChanged_1);
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(352, 37);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(102, 17);
            this.updateRadioButton.TabIndex = 42;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Update account";
            this.updateRadioButton.UseVisualStyleBackColor = true;
            this.updateRadioButton.CheckedChanged += new System.EventHandler(this.updateRadioButton_CheckedChanged_1);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(115, 148);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 41;
            this.phoneLabel.Text = "Phone";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(108, 114);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 40;
            this.addressLabel.Text = "Address";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(121, 72);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 39;
            this.emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(118, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Name";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(179, 148);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 37;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(179, 111);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 36;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(179, 72);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(179, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 34;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bookStoreDataSet2;
            // 
            // bookStoreDataSet2
            // 
            this.bookStoreDataSet2.DataSetName = "BookStoreDataSet2";
            this.bookStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(520, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 1;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // goToProductsButton
            // 
            this.goToProductsButton.Location = new System.Drawing.Point(12, 13);
            this.goToProductsButton.Name = "goToProductsButton";
            this.goToProductsButton.Size = new System.Drawing.Size(104, 23);
            this.goToProductsButton.TabIndex = 2;
            this.goToProductsButton.Text = "Go to Products";
            this.goToProductsButton.UseVisualStyleBackColor = true;
            this.goToProductsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 398);
            this.Controls.Add(this.goToProductsButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.RadioButton changePasswordRadioButton;
        private System.Windows.Forms.RadioButton updateRadioButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button goToProductsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookStoreDataSet2 bookStoreDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private BookStoreDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;

    }
}