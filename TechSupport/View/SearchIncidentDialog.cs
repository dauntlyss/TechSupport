using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Class that defines the search incident dialog form.
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly SearchIncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the SearchIncidentDialog class.
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this._incidentController = new SearchIncidentController();
        }

        private void RefreshSearchDataGrid()
        {
            this.resultsDataGridView.DataSource = null;
            this.resultsDataGridView.DataSource = _incidentController.GetSearchIncidents();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.customerIdTextBox.Text);

                this._incidentController.Search(customerID);
                this.RefreshSearchDataGrid();
            }
            catch (Exception)
            {
                this.ShowInvalidErrorMessage();
            }
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "CustomerID must be number greater than 0 and cannot be empty.";
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
} 

