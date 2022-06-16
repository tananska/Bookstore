namespace Bookstore_Shop
{
    partial class Order
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
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.showPriceLabel = new System.Windows.Forms.Label();
            this.goToProductsButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Location = new System.Drawing.Point(181, 301);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(75, 23);
            this.makeOrderButton.TabIndex = 1;
            this.makeOrderButton.Text = "Make Order";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(469, 81);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(119, 101);
            this.commentTextBox.TabIndex = 2;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(466, 56);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(51, 13);
            this.commentLabel.TabIndex = 3;
            this.commentLabel.Text = "Comment";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(466, 257);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // showPriceLabel
            // 
            this.showPriceLabel.AutoSize = true;
            this.showPriceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showPriceLabel.Location = new System.Drawing.Point(526, 257);
            this.showPriceLabel.Name = "showPriceLabel";
            this.showPriceLabel.Size = new System.Drawing.Size(16, 13);
            this.showPriceLabel.TabIndex = 5;
            this.showPriceLabel.Text = "   ";
            // 
            // goToProductsButton
            // 
            this.goToProductsButton.Location = new System.Drawing.Point(24, 12);
            this.goToProductsButton.Name = "goToProductsButton";
            this.goToProductsButton.Size = new System.Drawing.Size(102, 23);
            this.goToProductsButton.TabIndex = 6;
            this.goToProductsButton.Text = "Go to Products";
            this.goToProductsButton.UseVisualStyleBackColor = true;
            this.goToProductsButton.Click += new System.EventHandler(this.goToProductsButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(24, 62);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(406, 212);
            this.orderListBox.TabIndex = 7;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 348);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.goToProductsButton);
            this.Controls.Add(this.showPriceLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.makeOrderButton);
            
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label showPriceLabel;
        private System.Windows.Forms.Button goToProductsButton;
        private System.Windows.Forms.ListBox orderListBox;
    }
}