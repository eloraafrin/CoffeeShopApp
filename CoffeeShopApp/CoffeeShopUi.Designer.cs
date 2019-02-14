namespace CoffeeShopApp
{
    partial class CoffeeShopUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.customerNameLabel2 = new System.Windows.Forms.Label();
            this.contactLabel2 = new System.Windows.Forms.Label();
            this.customerNameTextBox1 = new System.Windows.Forms.TextBox();
            this.contactTextBox1 = new System.Windows.Forms.TextBox();
            this.addressLabel2 = new System.Windows.Forms.Label();
            this.addressTextBox1 = new System.Windows.Forms.TextBox();
            this.orderLabel2 = new System.Windows.Forms.Label();
            this.orderComboBox1 = new System.Windows.Forms.ComboBox();
            this.quantityLabel2 = new System.Windows.Forms.Label();
            this.quantityTextBox1 = new System.Windows.Forms.TextBox();
            this.paymentRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // customerNameLabel2
            // 
            this.customerNameLabel2.AutoSize = true;
            this.customerNameLabel2.Location = new System.Drawing.Point(36, 59);
            this.customerNameLabel2.Name = "customerNameLabel2";
            this.customerNameLabel2.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel2.TabIndex = 1;
            this.customerNameLabel2.Text = "Customer Name";
            // 
            // contactLabel2
            // 
            this.contactLabel2.AutoSize = true;
            this.contactLabel2.Location = new System.Drawing.Point(36, 84);
            this.contactLabel2.Name = "contactLabel2";
            this.contactLabel2.Size = new System.Drawing.Size(64, 13);
            this.contactLabel2.TabIndex = 2;
            this.contactLabel2.Text = "Contact No.";
            // 
            // customerNameTextBox1
            // 
            this.customerNameTextBox1.Location = new System.Drawing.Point(147, 59);
            this.customerNameTextBox1.Name = "customerNameTextBox1";
            this.customerNameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox1.TabIndex = 3;
            // 
            // contactTextBox1
            // 
            this.contactTextBox1.Location = new System.Drawing.Point(147, 86);
            this.contactTextBox1.Name = "contactTextBox1";
            this.contactTextBox1.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox1.TabIndex = 4;
            // 
            // addressLabel2
            // 
            this.addressLabel2.AutoSize = true;
            this.addressLabel2.Location = new System.Drawing.Point(39, 123);
            this.addressLabel2.Name = "addressLabel2";
            this.addressLabel2.Size = new System.Drawing.Size(45, 13);
            this.addressLabel2.TabIndex = 5;
            this.addressLabel2.Text = "Address";
            // 
            // addressTextBox1
            // 
            this.addressTextBox1.Location = new System.Drawing.Point(147, 123);
            this.addressTextBox1.Name = "addressTextBox1";
            this.addressTextBox1.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox1.TabIndex = 6;
            // 
            // orderLabel2
            // 
            this.orderLabel2.AutoSize = true;
            this.orderLabel2.Location = new System.Drawing.Point(42, 163);
            this.orderLabel2.Name = "orderLabel2";
            this.orderLabel2.Size = new System.Drawing.Size(33, 13);
            this.orderLabel2.TabIndex = 7;
            this.orderLabel2.Text = "Order";
            // 
            // orderComboBox1
            // 
            this.orderComboBox1.FormattingEnabled = true;
            this.orderComboBox1.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox1.Location = new System.Drawing.Point(147, 154);
            this.orderComboBox1.Name = "orderComboBox1";
            this.orderComboBox1.Size = new System.Drawing.Size(121, 21);
            this.orderComboBox1.TabIndex = 8;
            // 
            // quantityLabel2
            // 
            this.quantityLabel2.AutoSize = true;
            this.quantityLabel2.Location = new System.Drawing.Point(40, 194);
            this.quantityLabel2.Name = "quantityLabel2";
            this.quantityLabel2.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel2.TabIndex = 9;
            this.quantityLabel2.Text = "Quantity";
            // 
            // quantityTextBox1
            // 
            this.quantityTextBox1.Location = new System.Drawing.Point(147, 194);
            this.quantityTextBox1.Name = "quantityTextBox1";
            this.quantityTextBox1.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox1.TabIndex = 10;
            // 
            // paymentRichTextBox1
            // 
            this.paymentRichTextBox1.Location = new System.Drawing.Point(366, 29);
            this.paymentRichTextBox1.Name = "paymentRichTextBox1";
            this.paymentRichTextBox1.Size = new System.Drawing.Size(255, 372);
            this.paymentRichTextBox1.TabIndex = 11;
            this.paymentRichTextBox1.Text = "";
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(122, 254);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(75, 23);
            this.saveButton1.TabIndex = 12;
            this.saveButton1.Text = "Save";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(215, 254);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // CoffeeShopUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 413);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton1);
            this.Controls.Add(this.paymentRichTextBox1);
            this.Controls.Add(this.quantityTextBox1);
            this.Controls.Add(this.quantityLabel2);
            this.Controls.Add(this.orderComboBox1);
            this.Controls.Add(this.orderLabel2);
            this.Controls.Add(this.addressTextBox1);
            this.Controls.Add(this.addressLabel2);
            this.Controls.Add(this.contactTextBox1);
            this.Controls.Add(this.customerNameTextBox1);
            this.Controls.Add(this.contactLabel2);
            this.Controls.Add(this.customerNameLabel2);
            this.Controls.Add(this.label1);
            this.Name = "CoffeeShopUi";
            this.Text = "Coffee Shop";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button saveButton1;
        private System.Windows.Forms.RichTextBox paymentRichTextBox1;
        private System.Windows.Forms.TextBox quantityTextBox1;
        private System.Windows.Forms.Label quantityLabel2;
        private System.Windows.Forms.ComboBox orderComboBox1;
        private System.Windows.Forms.Label orderLabel2;
        private System.Windows.Forms.TextBox addressTextBox1;
        private System.Windows.Forms.Label addressLabel2;
        private System.Windows.Forms.TextBox contactTextBox1;
        private System.Windows.Forms.TextBox customerNameTextBox1;
        private System.Windows.Forms.Label contactLabel2;
        private System.Windows.Forms.Label customerNameLabel2;
        private System.Windows.Forms.Button showButton;

    }
}

