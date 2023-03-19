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
    /// User control for viewing technicians assignments
    /// </summary>
    /// Author: Alyssa Harris
    /// Version: 3/15/23
    public partial class ViewIncidentbyTechUserControl : UserControl
    {
        private Technician _technician;
        private List<Technician> _technicianList;
        private TechnicianController _technicianController;
        private List<Incident> _technicianOpenIncidentList;
        private IncidentController _incidentController;

        public ViewIncidentbyTechUserControl()
        {
            InitializeComponent();
            _technicianController = new TechnicianController();
            _incidentController = new IncidentController();

            this.emailTextBox.ReadOnly = true;
            this.phoneTextBox.ReadOnly = true;
            this.nameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void TechnicianIncidentUserControl_Load(object sender, EventArgs e)
        {
            _technicianList = _technicianController.GetAssignedTechnicians();
            nameComboBox.DataSource = _technicianList;

            _technician = _technicianList[0];

            _technicianOpenIncidentList = _incidentController.GetTechnicianOpenIncidents(_technician.TechID);
            /*PopulateDataGridView(_technicianOpenIncidentList);*/
            incidentsDataGridView.DataSource = _technicianList;
        }

        private void TechnicianNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex < 0)
            {
                return;
            }

            _technician = _technicianList[nameComboBox.SelectedIndex];

            technicianBindingSource1.Clear();

            technicianBindingSource1.Add(_technician);

            _technicianOpenIncidentList = _incidentController.GetTechnicianOpenIncidents(_technician.TechID);
            incidentsDataGridView.DataSource = _technicianList;
            /*PopulateDataGridView(_technicianOpenIncidentList);*/
        }

        private void PopulateDataGridView(List<Incident> technicianOpenIncidentList)
        {
            technicianOpenIncidentBindingSource.Clear();

            foreach (Incident go in technicianOpenIncidentList)
            {
                OpenIncidentAssigned assigned = new OpenIncidentAssigned();
                assigned.Name = go.Name;
                assigned.DateOpened = go.DateOpened.Date;
                assigned.Customer = go.Customer;
                assigned.Title = go.Title;
                technicianOpenIncidentBindingSource.Add(assigned);
            }
        }

        private void TechnicianNameComboBox_VisibleChanged(object sender, EventArgs e)
        {
            _technicianList = _technicianController.GetAssignedTechnicians();
            technicianNameComboBox.DataSource = _technicianList;

            _technician = _technicianList[0];

            _technicianOpenIncidentList = _incidentController.GetTechnicianOpenIncidents(_technician.TechID);
            PopulateDataGridView(_technicianOpenIncidentList);
        }

    }

}
