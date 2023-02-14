using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control class that encapsulates the add incident controls
    /// Author: Alyssa Harris
    /// Version: 2/13/2023
    /// </summary>
    public partial class AddIncidentUserControl : UserControl
    {
        #region Data members

        private readonly IncidentController _incidentController;
        private readonly CustomerController _customerController;
        private readonly ProductController _productController;        
        private readonly RegistrationController _registrationController;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the AddIncidentDialog class.
        /// </summary>
        public AddIncidentUserControl()
        {
            this.InitializeComponent();
            this._incidentController = new IncidentController();
            this._customerController = new CustomerController();
            this._productController = new ProductController();
            this._registrationController = new RegistrationController();

            this.FillCustomerComboBox();
            this.FillProductComboBox();
        }
        #endregion

        #region Methods

        private List<ProductCodeAndName> FillProductComboBox()
        {
            List<ProductCodeAndName> products = _productController.GetAllProductCodeAndNames();
            productComboBox.DataSource = products;
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.DisplayMember = "Name";
            productComboBox.SelectedIndex = 0;
            return products;
        }

        private List<CustomerIdAndName> FillCustomerComboBox()
        {
            List<CustomerIdAndName> customers = _customerController.GetAllCustomerIDAndNames();
            customerComboBox.DataSource = customers;
            customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerComboBox.DisplayMember = "Name";
            customerComboBox.SelectedIndex = 0;
            return customers;
        }
        private void addIncidentButton_Click(object sender, EventArgs e)
        {

            try
            {
                int customerIndexSelected = customerComboBox.SelectedIndex;
                int customerIDSelected = FillCustomerComboBox()[customerIndexSelected].CustomerID;
                int productIndexSelected = productComboBox.SelectedIndex;
                string productCodeSelected = FillProductComboBox()[productIndexSelected].ProductCode;
                var title = this.titleTextBox.Text;
                var description = this.descriptionTextBox.Text;

                if (title == "") {
                    this.ShowInvalidErrorMessage();
                }
                if (description == "")
                {
                    this.ShowInvalidErrorMessage();
                }
                Incident newIncident = new Incident(customerIDSelected, productCodeSelected, title, description);
                this._incidentController.Add(newIncident);
                this.ShowSuccessMessage();
                this.ClearForm();
            }
            catch (Exception)
            {
                this.ShowInvalidErrorMessage();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.HideSuccessMessage();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
        }

        private Boolean IsRegistered()
        {
            Boolean isRegistered = this._registrationController.IsCustomerProductRegistered(FillCustomerComboBox()[customerComboBox.SelectedIndex].CustomerID, FillProductComboBox()[productComboBox.SelectedIndex].ProductCode);
            return isRegistered;
        }

        private void ShowSuccessMessage()
        {
            successMessageLabel.Text = "Incident added!";
            successMessageLabel.ForeColor = Color.Green;
        }
        private void HideSuccessMessage()
        {
            successMessageLabel.Text = "";
        }

        private void HideErrorMessage()
        {
            productErrorLabel.Text = "";
            descriptionErrorMessageLabel.Text = "";
            customerIDErrorMessageLabel.Text = "";
            titleErrorMessageLabel.Text = "";

        }

        private void ShowInvalidErrorMessage()
        {
            if (IsRegistered() == false)
            {
                productErrorLabel.Text = "No registration is associated with this product.";
                productErrorLabel.ForeColor = Color.Red;
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

        private void UserInputChanged(object sender, EventArgs e)
        {
            HideErrorMessage();
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.FillCustomerComboBox();
            this.FillProductComboBox();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.HideErrorMessage();
        }

        private void DescriptionTextBox_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void HideSuccesMessageAction(object ender, EventArgs e)
        {
            this.HideSuccessMessage();
        }
        #endregion

    }
}
