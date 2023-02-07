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
    /// Creates tabbed maindashboard form upon login
    /// Author: Alyssa Harris
    /// Version: 2/6/2023
    /// </summary>
    public partial class MainDashboard : Form
    {
        #region Data members

        bool logOut;
        private LoginForm _currentLogin;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor used to initialize the MainDashboard class
        /// </summary>
        /// <param name="form">login form passed to main form</param>
        public MainDashboard(LoginForm newLogin)
        {
            InitializeComponent();
            _currentLogin = newLogin;
            usernameLabel.Text = _currentLogin.Username;
            logOut = false;
        }

        #endregion

        #region Methods

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logOut = true;
            _currentLogin.LogOut();
            this.Close();
        }

        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logOut)
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
