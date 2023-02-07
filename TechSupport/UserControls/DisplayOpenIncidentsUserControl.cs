using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control that encapsulates sthe loading of open incidents
    /// Author: Alyssa Harris
    /// Version: 2/6/23
    /// </summary>
    public partial class DisplayOpenIncidentUserControl : UserControl
    {
        #region Data Members

        private readonly IncidentController incidentController;

        #endregion

        #region Controllers

        /// <summary>
        /// constructor used to create the open incident controls
        /// </summary>
        public DisplayOpenIncidentUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        #endregion

        #region Methods

        /// <summary>
        /// method used to load the open incidents and loop
        /// </summary>
        public void RefreshOpenIncidentListView()
        {
            List<OpenIncident> openIncidentList;
            try
            {
                openIncidentList = incidentController.GetOpenIncidents();

                if (openIncidentList.Count > 0)
                {
                    openIncidentsListView.Items.Clear();
                    OpenIncident openIncident;
                    for (int i = 0; i < openIncidentList.Count; i++)
                    {
                        openIncident = openIncidentList[i];
                        openIncidentsListView.Items.Add(openIncident.ProductCode.ToString());
                        openIncidentsListView.Items[i].SubItems.Add(openIncident.DateOpened.ToShortDateString());
                        openIncidentsListView.Items[i].SubItems.Add(openIncident.Customer.ToString());
                        openIncidentsListView.Items[i].SubItems.Add(openIncident.Technician.ToString());
                        openIncidentsListView.Items[i].SubItems.Add(openIncident.Title.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("There are no open incidents.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void OpenIncidentListView_VisibleChanged(object sender, EventArgs e)
        {
            RefreshOpenIncidentListView();
        }

        #endregion
    }
}

