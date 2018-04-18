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
    /// Represents the main form in the Sales application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes the form object.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            MessageBox.Show("start, byDR");
            MessageBox.Show(this.ToString());
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Opens the ViewCustomersForm form, to enable the user 
        /// to view a list of customers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewCustomersButton_Click(object sender, EventArgs e)
        {
            ViewCustomersForm form = new ViewCustomersForm();
            form.ShowDialog(this);
        }
    }
}