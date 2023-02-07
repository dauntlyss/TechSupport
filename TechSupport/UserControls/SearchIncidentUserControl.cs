using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User conrol that encapsulates the search incident controls
    /// Author: Alyssa Harris
    /// Version: 02/06/2023
    /// </summary>
    public partial class SearchIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController _incidentController;

        #endregion

        #region Constructors

        /// <summary>
        /// constructor used to create the search incident controls
        /// </summary>
        public SearchIncidentUserControl()
        {
            this.InitializeComponent();
            this._incidentController = new IncidentController();
        }

        #endregion

        #region Methods

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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.resultsDataGridView.DataSource = null;
            this.customerIdTextBox.Text = "";
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage()
        {
            errorMessageLabel.Text = "CustomerID must be number and cannot be empty";
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }

        #endregion
    }
}
