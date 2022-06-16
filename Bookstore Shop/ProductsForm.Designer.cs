namespace Bookstore_Shop
{
    partial class ProductsForm
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
            this.penRadioButton = new System.Windows.Forms.RadioButton();
            this.pencilRadioButton = new System.Windows.Forms.RadioButton();
            this.notebookRadioButton = new System.Windows.Forms.RadioButton();
            this.eraserRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet4 = new Bookstore_Shop.BookStoreDataSet4();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataSet3 = new Bookstore_Shop.BookStoreDataSet3();
            this.productsTableAdapter = new Bookstore_Shop.BookStoreDataSet3TableAdapters.ProductsTableAdapter();
            this.accountButton = new System.Windows.Forms.Button();
            this.basketButton = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.goToOrderButton = new System.Windows.Forms.Button();
            this.productsTableAdapter1 = new Bookstore_Shop.BookStoreDataSet4TableAdapters.ProductsTableAdapter();
            this.bookStoreDataSet6 = new Bookstore_Shop.BookStoreDataSet6();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter2 = new Bookstore_Shop.BookStoreDataSet6TableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // penRadioButton
            // 
            this.penRadioButton.AutoSize = true;
            this.penRadioButton.Location = new System.Drawing.Point(54, 85);
            this.penRadioButton.Name = "penRadioButton";
            this.penRadioButton.Size = new System.Drawing.Size(44, 17);
            this.penRadioButton.TabIndex = 0;
            this.penRadioButton.TabStop = true;
            this.penRadioButton.Text = "Pen";
            this.penRadioButton.UseVisualStyleBackColor = true;
            this.penRadioButton.CheckedChanged += new System.EventHandler(this.penRadioButton_CheckedChanged);
            // 
            // pencilRadioButton
            // 
            this.pencilRadioButton.AutoSize = true;
            this.pencilRadioButton.Location = new System.Drawing.Point(54, 120);
            this.pencilRadioButton.Name = "pencilRadioButton";
            this.pencilRadioButton.Size = new System.Drawing.Size(54, 17);
            this.pencilRadioButton.TabIndex = 1;
            this.pencilRadioButton.TabStop = true;
            this.pencilRadioButton.Text = "Pencil";
            this.pencilRadioButton.UseVisualStyleBackColor = true;
            this.pencilRadioButton.CheckedChanged += new System.EventHandler(this.pencilRadioButton_CheckedChanged);
            // 
            // notebookRadioButton
            // 
            this.notebookRadioButton.AutoSize = true;
            this.notebookRadioButton.Location = new System.Drawing.Point(54, 156);
            this.notebookRadioButton.Name = "notebookRadioButton";
            this.notebookRadioButton.Size = new System.Drawing.Size(72, 17);
            this.notebookRadioButton.TabIndex = 2;
            this.notebookRadioButton.TabStop = true;
            this.notebookRadioButton.Text = "Notebook";
            this.notebookRadioButton.UseVisualStyleBackColor = true;
            this.notebookRadioButton.CheckedChanged += new System.EventHandler(this.notebookRadioButton_CheckedChanged);
            // 
            // eraserRadioButton
            // 
            this.eraserRadioButton.AutoSize = true;
            this.eraserRadioButton.Location = new System.Drawing.Point(54, 190);
            this.eraserRadioButton.Name = "eraserRadioButton";
            this.eraserRadioButton.Size = new System.Drawing.Size(55, 17);
            this.eraserRadioButton.TabIndex = 3;
            this.eraserRadioButton.TabStop = true;
            this.eraserRadioButton.Text = "Eraser";
            this.eraserRadioButton.UseVisualStyleBackColor = true;
            this.eraserRadioButton.CheckedChanged += new System.EventHandler(this.eraserRadioButton_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(171, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 219);
            this.dataGridView1.TabIndex = 4;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.bookStoreDataSet4;
            // 
            // bookStoreDataSet4
            // 
            this.bookStoreDataSet4.DataSetName = "BookStoreDataSet4";
            this.bookStoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.bookStoreDataSet3;
            // 
            // bookStoreDataSet3
            // 
            this.bookStoreDataSet3.DataSetName = "BookStoreDataSet3";
            this.bookStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // accountButton
            // 
            this.accountButton.Location = new System.Drawing.Point(12, 12);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(84, 23);
            this.accountButton.TabIndex = 5;
            this.accountButton.Text = "Go to Account";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // basketButton
            // 
            this.basketButton.Location = new System.Drawing.Point(54, 270);
            this.basketButton.Name = "basketButton";
            this.basketButton.Size = new System.Drawing.Size(89, 23);
            this.basketButton.TabIndex = 6;
            this.basketButton.Text = "Add to Basket";
            this.basketButton.UseVisualStyleBackColor = true;
            this.basketButton.Click += new System.EventHandler(this.basketButton_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(59, 226);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(84, 20);
            this.quantityNumericUpDown.TabIndex = 7;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(7, 228);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Quantity";
            // 
            // goToOrderButton
            // 
            this.goToOrderButton.Location = new System.Drawing.Point(540, 12);
            this.goToOrderButton.Name = "goToOrderButton";
            this.goToOrderButton.Size = new System.Drawing.Size(75, 23);
            this.goToOrderButton.TabIndex = 9;
            this.goToOrderButton.Text = "Go to Order";
            this.goToOrderButton.UseVisualStyleBackColor = true;
            this.goToOrderButton.Click += new System.EventHandler(this.goToOrderButton_Click);
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // bookStoreDataSet6
            // 
            this.bookStoreDataSet6.DataSetName = "BookStoreDataSet6";
            this.bookStoreDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.bookStoreDataSet6;
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 305);
            this.Controls.Add(this.goToOrderButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.basketButton);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eraserRadioButton);
            this.Controls.Add(this.notebookRadioButton);
            this.Controls.Add(this.pencilRadioButton);
            this.Controls.Add(this.penRadioButton);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton penRadioButton;
        private System.Windows.Forms.RadioButton pencilRadioButton;
        private System.Windows.Forms.RadioButton notebookRadioButton;
        private System.Windows.Forms.RadioButton eraserRadioButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BookStoreDataSet3 bookStoreDataSet3;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private BookStoreDataSet3TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button basketButton;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button goToOrderButton;
        private BookStoreDataSet4 bookStoreDataSet4;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private BookStoreDataSet4TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BookStoreDataSet6 bookStoreDataSet6;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private BookStoreDataSet6TableAdapters.ProductsTableAdapter productsTableAdapter2;

    }
}