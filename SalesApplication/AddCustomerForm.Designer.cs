namespace SalesApplication
{
    partial class AddCustomerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.individualCustomerRadioButton = new System.Windows.Forms.RadioButton();
            this.corporateCustomerRadioButton = new System.Windows.Forms.RadioButton();
            this.projectedSpendLabel = new System.Windows.Forms.Label();
            this.projectedSpendTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 44);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(13, 75);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 13);
            this.regionLabel.TabIndex = 2;
            this.regionLabel.Text = "Region:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(71, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(135, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(71, 41);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(135, 20);
            this.addressTextBox.TabIndex = 2;
            // 
            // regionComboBox
            // 
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "Americas",
            "Asia",
            "Africa",
            "Australasia",
            "Europe"});
            this.regionComboBox.Location = new System.Drawing.Point(71, 72);
            this.regionComboBox.MaxDropDownItems = 5;
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(135, 21);
            this.regionComboBox.TabIndex = 3;
            // 
            // individualCustomerRadioButton
            // 
            this.individualCustomerRadioButton.AutoSize = true;
            this.individualCustomerRadioButton.Checked = true;
            this.individualCustomerRadioButton.Location = new System.Drawing.Point(16, 128);
            this.individualCustomerRadioButton.Name = "individualCustomerRadioButton";
            this.individualCustomerRadioButton.Size = new System.Drawing.Size(117, 17);
            this.individualCustomerRadioButton.TabIndex = 4;
            this.individualCustomerRadioButton.TabStop = true;
            this.individualCustomerRadioButton.Text = "Individual Customer";
            this.individualCustomerRadioButton.UseVisualStyleBackColor = true;
            this.individualCustomerRadioButton.CheckedChanged += new System.EventHandler(this.individualCustomerRadioButton_CheckedChanged);
            // 
            // corporateCustomerRadioButton
            // 
            this.corporateCustomerRadioButton.AutoSize = true;
            this.corporateCustomerRadioButton.Location = new System.Drawing.Point(16, 152);
            this.corporateCustomerRadioButton.Name = "corporateCustomerRadioButton";
            this.corporateCustomerRadioButton.Size = new System.Drawing.Size(118, 17);
            this.corporateCustomerRadioButton.TabIndex = 5;
            this.corporateCustomerRadioButton.TabStop = true;
            this.corporateCustomerRadioButton.Text = "Corporate Customer";
            this.corporateCustomerRadioButton.UseVisualStyleBackColor = true;
            this.corporateCustomerRadioButton.CheckedChanged += new System.EventHandler(this.corporateCustomerRadioButton_CheckedChanged);
            // 
            // projectedSpendLabel
            // 
            this.projectedSpendLabel.AutoSize = true;
            this.projectedSpendLabel.Location = new System.Drawing.Point(13, 180);
            this.projectedSpendLabel.Name = "projectedSpendLabel";
            this.projectedSpendLabel.Size = new System.Drawing.Size(89, 13);
            this.projectedSpendLabel.TabIndex = 8;
            this.projectedSpendLabel.Text = "Projected Spend:";
            // 
            // projectedSpendTextBox
            // 
            this.projectedSpendTextBox.Enabled = false;
            this.projectedSpendTextBox.Location = new System.Drawing.Point(119, 177);
            this.projectedSpendTextBox.Name = "projectedSpendTextBox";
            this.projectedSpendTextBox.Size = new System.Drawing.Size(87, 20);
            this.projectedSpendTextBox.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(130, 238);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddCustomerForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 273);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.projectedSpendTextBox);
            this.Controls.Add(this.projectedSpendLabel);
            this.Controls.Add(this.corporateCustomerRadioButton);
            this.Controls.Add(this.individualCustomerRadioButton);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCustomerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.RadioButton individualCustomerRadioButton;
        private System.Windows.Forms.RadioButton corporateCustomerRadioButton;
        private System.Windows.Forms.Label projectedSpendLabel;
        private System.Windows.Forms.TextBox projectedSpendTextBox;
        private System.Windows.Forms.Button okButton;
    }
}