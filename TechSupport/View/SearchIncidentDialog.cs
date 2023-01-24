﻿using System;
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
    /// Class that defines the search incident dialog form.
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly SearchIncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the SearchIncidentDialog class.
        /// </summary>
        public SearchIncidentDialog()
        {
            InitializeComponent();
            this.incidentController = new SearchIncidentController();
        }

        private void RefreshSearchDataGrid()
        {
            this.resultsDataGridView.DataSource = null;
            this.resultsDataGridView.DataSource = incidentController.GetSearchIncidents();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = int.Parse(this.customerIdTextBox.Text);

                this.incidentController.Search(customerID);
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

