using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class that defines the add incident dialog box.
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        private readonly AddIncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the AddIncidentDialog class.
        /// </summary>
        public AddIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new AddIncidentController();
        }

        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.customerIDTextBox.Text);
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                this.incidentController.Add(new Model.Incident(customerID, title, description));

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.ShowInvalidErrorMessage();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "CustomerID must be a number greater than 0 and fields cannot be empty.";
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }
    }
}
