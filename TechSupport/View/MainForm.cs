using System;
using System.Windows.Forms;
using TechSupport.Controller;


namespace TechSupport.View
{
    /// <summary>
    /// Mainform Class used to display the username of the tech support application
    /// Author: Alyssa Harris
    /// Version: 1/23/23
    /// </summary>
    public partial class MainForm : Form
    {
        bool logOut;
        private LoginForm currentLogin;
        private readonly AddIncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm(LoginForm newLogin)
        {
            InitializeComponent();
            currentLogin = newLogin;
            usernameLabel.Text = currentLogin.Username;
            incidentController = new AddIncidentController();
            RefreshIncidentDataGrid();
            logOut = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshIncidentDataGrid();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //currentLogin = new LoginForm();
            //currentLogin.Closed += (s, args) => this.Close();
            //currentLogin.Show();
            logOut = true;
            currentLogin.LogOut();
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }

        private void RefreshIncidentDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = this.incidentController.GetAllIncidents();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form addIncidentDialog = new AddIncidentDialog())
            {
                DialogResult result = addIncidentDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.RefreshIncidentDataGrid();
                }
            }
        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            using (Form searchIncidentDialog = new SearchIncidentDialog())
            {
                DialogResult result = searchIncidentDialog.ShowDialog();
            }
        }
    }
}
