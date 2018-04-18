namespace SalesApplication
{
    partial class ViewCustomersForm
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
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.makePurchaseButton = new System.Windows.Forms.Button();
            this.valueOfPurchaseTextBox = new System.Windows.Forms.TextBox();
            this.valueOfPurchaseLabel = new System.Windows.Forms.Label();
            this.customerDetailsLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersListBox
            // 
            this.customersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(13, 13);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(369, 160);
            this.customersListBox.TabIndex = 1;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.customersListBox_SelectedIndexChanged);
            // 
            // makePurchaseButton
            // 
            this.makePurchaseButton.Enabled = false;
            this.makePurchaseButton.Location = new System.Drawing.Point(200, 224);
            this.makePurchaseButton.Name = "makePurchaseButton";
            this.makePurchaseButton.Size = new System.Drawing.Size(104, 23);
            this.makePurchaseButton.TabIndex = 4;
            this.makePurchaseButton.Text = "Make Purchase";
            this.makePurchaseButton.UseVisualStyleBackColor = true;
            this.makePurchaseButton.Click += new System.EventHandler(this.makePurchaseButton_Click);
            // 
            // valueOfPurchaseTextBox
            // 
            this.valueOfPurchaseTextBox.Enabled = false;
            this.valueOfPurchaseTextBox.Location = new System.Drawing.Point(116, 226);
            this.valueOfPurchaseTextBox.Name = "valueOfPurchaseTextBox";
            this.valueOfPurchaseTextBox.Size = new System.Drawing.Size(78, 20);
            this.valueOfPurchaseTextBox.TabIndex = 3;
            // 
            // valueOfPurchaseLabel
            // 
            this.valueOfPurchaseLabel.AutoSize = true;
            this.valueOfPurchaseLabel.Location = new System.Drawing.Point(13, 229);
            this.valueOfPurchaseLabel.Name = "valueOfPurchaseLabel";
            this.valueOfPurchaseLabel.Size = new System.Drawing.Size(97, 13);
            this.valueOfPurchaseLabel.TabIndex = 7;
            this.valueOfPurchaseLabel.Text = "Value of Purchase:";
            // 
            // customerDetailsLabel
            // 
            this.customerDetailsLabel.AutoSize = true;
            this.customerDetailsLabel.ForeColor = System.Drawing.Color.Blue;
            this.customerDetailsLabel.Location = new System.Drawing.Point(13, 186);
            this.customerDetailsLabel.Name = "customerDetailsLabel";
            this.customerDetailsLabel.Size = new System.Drawing.Size(113, 13);
            this.customerDetailsLabel.TabIndex = 10;
            this.customerDetailsLabel.Text = "No customer selected.";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(389, 12);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(104, 23);
            this.addCustomerButton.TabIndex = 2;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // ViewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 260);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerDetailsLabel);
            this.Controls.Add(this.makePurchaseButton);
            this.Controls.Add(this.valueOfPurchaseTextBox);
            this.Controls.Add(this.valueOfPurchaseLabel);
            this.Controls.Add(this.customersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewCustomersForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Customers";
            this.Load += new System.EventHandler(this.ViewCustomersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Button makePurchaseButton;
        private System.Windows.Forms.TextBox valueOfPurchaseTextBox;
        private System.Windows.Forms.Label valueOfPurchaseLabel;
        private System.Windows.Forms.Label customerDetailsLabel;
        private System.Windows.Forms.Button addCustomerButton;
    }
}