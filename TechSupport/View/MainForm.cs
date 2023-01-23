using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TechSupport.View
{
    /// <summary>
    /// Mainform Class used to display the username of the tech support application
    /// Author: Alyssa Harris
    /// Version: 1/23/23
    /// </summary>
    public partial class MainForm : Form
    {
        private LoginForm loginForm;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            usernameLabel.Text = "Jane";
        }
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
