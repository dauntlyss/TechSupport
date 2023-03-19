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
        private List<OpenIncidentAssigned> _technicianOpenIncidentList;
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
        private void ViewIncidentbyTechUserControl_Load(object sender, EventArgs e)
        {
            _technicianList = _technicianController.GetAssignedTechnicians();
            nameComboBox.DataSource = _technicianList;

            _technician = _technicianList[0];

            _technicianOpenIncidentList = _incidentController.GetTechnicianOpenIncidents(_technician.TechID);
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex < 0)
            {
                return;
            }

            _technician = _technicianList[nameComboBox.SelectedIndex];

            technicianBindingSource1.Clear();

            technicianBindingSource1.Add(_technician);

            _technicianOpenIncidentList = _incidentController.GetTechnicianOpenIncidents(_technician.TechID);

        }

        private void NameComboBox_VisibleChanged(object sender, EventArgs e)
        {
            _technicianList = _technicianController.GetAssignedTechnicians();
            nameComboBox.DataSource = _technicianList;

            _technician = _technicianList[nameComboBox.SelectedIndex];

            _technicianOpenIncidentList = _incidentController.GetTechnicianOpenIncidents(_technician.TechID);
            incidentsDataGridView.DataSource = _technicianOpenIncidentList;
        }

    }

}
