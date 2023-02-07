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

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control class that encapsulates the add incident controls
    /// Author: Alyssa Harris
    /// Version: 2/6/2023
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController _incidentController;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the AddIncidentDialog class.
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
        }
        #endregion

        #region Methods
        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.customerIDTextBox.Text);
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                this._incidentController.Add(new Model.Incident(customerID, title, description));

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                this.ShowInvalidErrorMessage();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void HideErrorMessage()
        {

            descriptionErrorMessageLabel.Text = "";
            customerIDErrorMessageLabel.Text = "";
            titleErrorMessageLabel.Text = "";

        }

        private void ShowInvalidErrorMessage()
        {
            if (this.customerIDTextBox.Text == "")
            {
                customerIDErrorMessageLabel.Text = "CustomerID cannot be empty.";
                customerIDErrorMessageLabel.ForeColor = Color.Red;
            }
            else
            {
                customerIDErrorMessageLabel.Text = "CustomerID must be a number greater than 0.";
                customerIDErrorMessageLabel.ForeColor = Color.Red;
            }

            if (this.titleTextBox.Text == "")
            {
                titleErrorMessageLabel.Text = "Incident title cannot be blank.";
                titleErrorMessageLabel.ForeColor = Color.Red;
            }

            if (this.descriptionTextBox.Text == "")
            {
                descriptionErrorMessageLabel.Text = "Description cannot be blank.";
                descriptionErrorMessageLabel.ForeColor = Color.Red;
            }

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
        #endregion
    }
}
