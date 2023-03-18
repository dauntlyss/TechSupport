using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User control class that encapsulates the update incident controls
    /// Author: Alyssa Harris
    /// Version: 2/19/23
    /// </summary>
    public partial class UpdateIncidentUserControl : UserControl
    {

        #region Data members

        private readonly TechnicianController _technicianController;
        private readonly IncidentController _incidentController;
        private readonly CustomerController _customerController;

        private Incident _incident;
        private int _customerID;
        private DateTime _dateOpened;
        private DateTime? _dateClosed;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that creates the update incident controls features
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            this._technicianController = new TechnicianController();
            this._incidentController = new IncidentController();
            this._customerController = new CustomerController();

            this.customerTextBox.ReadOnly = true;
            this.productTextBox.ReadOnly = true;
            this.dateOpenedTextBox.ReadOnly = true;
            this.titleTextBox.ReadOnly = true;
            this.descriptionTextBox.ReadOnly = true;

            ClearForm();
        }

        #endregion

        #region Methods

        private void PopulateTechnicianComboBox()
        {
            technicianComboBox.DataSource = GetTechnicianList();
            technicianComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            technicianComboBox.DisplayMember = "Name";
            technicianComboBox.SelectedIndex = 0;
        }
        private bool IsIncidentClosed(int incidentID)
        {
            bool incidentClosed = false;
            Incident incident = _incidentController.GetIncident(incidentID);

            if (DateTime.Parse(incident.DateClosed.ToString()).Year > 1900)
            {
                incidentClosed = true;
            }
            return incidentClosed;
        }

        private List<TechnicianIDAndName> GetTechnicianList()
        {
            List<TechnicianIDAndName> newList = _technicianController.GetAllTechnicianIDAndNames();
            newList.Insert(0, new TechnicianIDAndName(0, "-- Unassigned --"));
            return newList;
        }

        private void GetIncidentIDButton_Click(object sender, EventArgs e)
        {
            GetIncident();
        }

        private void GetIncident()
        {
            try
            {
                bool getIncidentCheck = Int32.TryParse(incidentIDTextBox.Text, out int incidentID);
                _incident = new Incident();
                string errorMessage = "";

                if (getIncidentCheck == false)
                {
                    errorMessage = "IncidentID cannot be empty and must be a number greater than 0.";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    _incident = _incidentController.GetIncident(incidentID);
                    _customerID = _incident.CustomerId;
                    _dateOpened = _incident.DateOpened;
                    _dateClosed = _incident.DateClosed;
                }

                if (getIncidentCheck == true && _incident.CustomerId > 0)
                {
                    var techID = _incident.TechID;

                    if (techID == null)
                    {
                        technicianComboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        int technicianIndex = 0;
                        technicianIndex = GetTechnicianList().FindIndex(index => index.TechID == techID);
                        technicianComboBox.SelectedIndex = technicianIndex;
                    }

                    DisplayIncidentData();

                    errorMessage = "";
                    this.ShowInvalidErrorMessage(errorMessage);

                    bool incidentClosed = this.IsIncidentClosed(incidentID);

                    if (incidentClosed == false)
                    {
                        this.EnableUpdateFormElements(true);
                    }
                    else
                    {
                        this.EnableUpdateFormElements(false);

                    }
                }
                else if (getIncidentCheck == true)
                {
                    errorMessage = "No Incident Found";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
            catch (Exception)
            {
                string errorMessage = "Invalid form entries";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void PutIncidentData(Incident incident, string addText)
        {
            incident.CustomerId = _customerID;
            incident.ProductCode = productTextBox.Text;
            incident.TechID = GetTechIDSelected();
            incident.DateOpened = _dateOpened;
            incident.DateClosed = _dateClosed;
            incident.Title = titleTextBox.Text;
            incident.Description = descriptionTextBox.Text + addText;
        }

        private void DisplayIncidentData()
        {
            customerTextBox.Text = GetCustomerName(_incident.CustomerId);
            productTextBox.Text = _incident.ProductCode.Trim();
            titleTextBox.Text = _incident.Title;
            titleTextBox.ScrollBars = ScrollBars.Vertical;
            dateOpenedTextBox.Text = _incident.DateOpened.ToShortDateString();
            descriptionTextBox.Text = _incident.Description;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            textToAddTextBox.Text = "";
            textToAddTextBox.ScrollBars = ScrollBars.Vertical;
        }

        private void EnableUpdateFormElements(bool enable)
        {
            if (enable)
            {
                this.updateButton.Enabled = true;
                this.closeButton.Enabled = true;
                this.technicianComboBox.Enabled = true;
                this.textToAddTextBox.Enabled = true;
            }
            else
            {
                this.updateButton.Enabled = false;
                this.closeButton.Enabled = false;
                this.technicianComboBox.Enabled = false;
                this.textToAddTextBox.Enabled = false;
            }

        }

        private string GetCustomerName(int customerID)
        {
            string customerName = "";
            List<Customer> customerList = _customerController.GetAllCustomers();
            if (customerList.Count > 0)
            {
                customerName = customerList[0].Name;
            }
            return customerName;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ProcessUpdate();
        }

        private int GetTechIDSelected()
        {
            int technicianIndexSelected = technicianComboBox.SelectedIndex;
            return GetTechnicianList()[technicianIndexSelected].TechID;
        }

        private string CreateAddTextConcatenation()
        {
            string concatAddText = "";
            string addTextEntered = textToAddTextBox.Text;
            if (addTextEntered.Length > 0)
            {
                concatAddText = "\r\n<" + DateTime.Now.ToString("MM/dd/yyyy") + "> " + addTextEntered;
            }
            return concatAddText;
        }

        private void ProcessUpdate()
        {
            string addTextEntered = textToAddTextBox.Text;
            string errorMessage;
            string successMessage;
            try
            {
                Incident newIncident = new Incident
                {
                    IncidentID = _incident.IncidentID
                };
                this.PutIncidentData(newIncident, CreateAddTextConcatenation());

                int newDescriptionLength = _incident.Description.Length + CreateAddTextConcatenation().Length;
                if (_incident.Description.Length >= 200 && addTextEntered.Length > 0)
                {
                    errorMessage = "Description cannot accept any more text";
                    textToAddTextBox.Text = "";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
                else if ((addTextEntered.Length > 0 || _incident.TechID != GetTechIDSelected()) &&
                    newDescriptionLength > 200 && CreateAddTextConcatenation().Length > 0)
                {
                    string message = "The new text to add exceeds allowed characters. Do you want to truncate it and proceed?";
                    string title = "Update Incident";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                    int truncatedConcatAddTextLength = 200 - _incident.Description.Length;

                    if (result == DialogResult.Yes)
                    {
                        string addText = CreateAddTextConcatenation().Substring(0, truncatedConcatAddTextLength);
                        this.PutIncidentData(newIncident, addText);
                        _incidentController.UpdateIncident(_incident, newIncident);
                        GetIncident();
                        successMessage = "Updated description with added truncated message!";
                        this.ShowSuccessMessage(successMessage);
                    }
                }
                else if ((addTextEntered.Length > 0 || _incident.TechID != GetTechIDSelected()) &&
                    newDescriptionLength <= 200 && CreateAddTextConcatenation().Length > 0)
                {
                    string addText = CreateAddTextConcatenation();
                    this.PutIncidentData(newIncident, addText);
                    _incidentController.UpdateIncident(_incident, newIncident);
                    GetIncident();
                    successMessage = "Updated description with added message!";
                    this.ShowSuccessMessage(successMessage);
                }
                else if (_incident.TechID != GetTechIDSelected())
                {
                    string addText = CreateAddTextConcatenation();
                    this.PutIncidentData(newIncident, addText);
                    _incidentController.UpdateIncident(_incident, newIncident);
                    GetIncident();
                    successMessage = "Updated technician!";
                    this.ShowSuccessMessage(successMessage);
                }
                else if (!_incidentController.UpdateIncident(_incident, newIncident))
                {
                     GetIncident();
                     errorMessage = "Description or Technician has changed by another user, so new entry cannot update.";
                     this.ShowInvalidErrorMessage(errorMessage);
                }
                else
                {
                    _incidentController.UpdateIncident(_incident, newIncident);
                    GetIncident();
                    successMessage = "Incident Updated!";
                    this.ShowSuccessMessage(successMessage);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                errorMessage = "Invalid update";
                this.ShowInvalidErrorMessage(errorMessage);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.HideSuccessMessage();
            int technicianIndexSelected = technicianComboBox.SelectedIndex;

            Incident newIncident = new Incident
            {
                IncidentID = _incident.IncidentID
            };
            this.PutIncidentData(newIncident, CreateAddTextConcatenation());

            string message = "The incident cannot be updated in this form once closed. Do you still want to close the incident?";
            string title = "Close Incident";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string errorMessage;
                    string successMessage;

                    if (GetTechnicianList()[technicianIndexSelected].TechID == 0)
                    {
                        GetIncident();
                        errorMessage = "Cannot close incident without assigning technician.";
                        this.ShowInvalidErrorMessage(errorMessage);
                    }
                    else if (!_incidentController.CloseIncident(_incident, newIncident))
                    {
                        GetIncident();
                        errorMessage = "Incident has already been closed";
                        this.ShowInvalidErrorMessage(errorMessage); 
                    }
                    else
                    {
                        _incidentController.CloseIncident(_incident, newIncident);
                        GetIncident();
                        successMessage = "Incident closed";
                        this.ShowSuccessMessage(successMessage);
                    }
                }
                catch (Exception)
                {
                    string errorMessage = "Invalid entry";
                    this.ShowInvalidErrorMessage(errorMessage);
                }
            }
        }

        private void HideErrorMessage()
        {
            errorMessageLabel.Text = "";
        }

        private void HideSuccessMessage()
        {
            successMessageLabel.Text = "";
        }

        private void ShowInvalidErrorMessage(string errorMessage)
        {
            this.HideSuccessMessage();
            errorMessageLabel.Text = errorMessage;
            errorMessageLabel.ForeColor = Color.Red;
        }

        private void ShowSuccessMessage(string successMessage)
        {
            this.HideErrorMessage();
            successMessageLabel.Text = successMessage;
            successMessageLabel.ForeColor = Color.Green;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.PopulateTechnicianComboBox();
            this.HideErrorMessage();
            this.HideSuccessMessage();
            this.incidentIDTextBox.Clear();
            this.customerTextBox.Clear();
            this.productTextBox.Clear();
            this.dateOpenedTextBox.Clear();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.textToAddTextBox.Clear();
            this.technicianComboBox.Enabled = false;
            this.textToAddTextBox.Enabled = false;
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
        }

        private void LoadForm(object sender, EventArgs e)
        {
            this.PopulateTechnicianComboBox();

            this.EnableUpdateFormElements(false);
        }

        private void IncidentIDTextBox_VisibleChanged(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void IncidentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.PopulateTechnicianComboBox();
            this.HideErrorMessage();
            this.customerTextBox.Clear();
            this.productTextBox.Clear();
            this.dateOpenedTextBox.Clear();
            this.titleTextBox.Clear();
            this.descriptionTextBox.Clear();
            this.textToAddTextBox.Clear();
            this.technicianComboBox.Enabled = false;
            this.textToAddTextBox.Enabled = false;
            this.updateButton.Enabled = false;
            this.closeButton.Enabled = false;
        }

        #endregion
    }
}
