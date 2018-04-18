using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesApplication
{
    /// <summary>
    /// Represents a form that enables the user to add a new customer.
    /// </summary>
    public partial class AddCustomerForm : Form
    {
        // The Customer instance created by this form.
        private Customer _newCustomer;

        /// <summary>
        /// Gets the Customer instance created by this form.
        /// </summary>
        public Customer NewCustomer
        {
            get { return _newCustomer; }
        }

        /// <summary>
        /// Initializes the form object.
        /// </summary>
        public AddCustomerForm()
        {
            InitializeComponent();
            regionComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the "Individual Customer" radio button selection.
        /// Disables the controls that apply only to corporate customers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void individualCustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            projectedSpendTextBox.Enabled = false;
        }

        /// <summary>
        /// Handles the "Corporate Customer" radio button selection.
        /// Enables the controls that apply to corporate customers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void corporateCustomerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            projectedSpendTextBox.Enabled = true;
            projectedSpendTextBox.Focus();
        }

        /// <summary>
        /// Creates an IndividualCustomer or CorporateCustomer instance,
        /// and then closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                string region = regionComboBox.SelectedItem.ToString();
                string projectedSpendText = projectedSpendTextBox.Text;

                if (individualCustomerRadioButton.Checked)
                {
                    // TODO [Ex2]: Create an IndividualCustomer instance.
                    _newCustomer = new IndividualCustomer(name, address, region);
                }
                else
                {
                    decimal projectedSpend = decimal.Parse(projectedSpendText);

                    // TODO [Ex2]: Create a CorporateCustomer instance.
                    //CorporateCustomer corpCust = new CorporateCustomer(nameTextBox.Text, addressTextBox.Text, regionComboBox.SelectedItem.ToString(), decimal.Parse(projectedSpendTextBox.Text));
                    //_newCustomer = corpCust;
                    _newCustomer = new CorporateCustomer(name, address, region, projectedSpend);                            //byDR
                }
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a numeric projected spend value.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                projectedSpendTextBox.Clear();
                projectedSpendTextBox.Focus();
            }
        }
    }
}