namespace TechSupport.View
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainDashboardTabControl = new System.Windows.Forms.TabControl();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.loadAllIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.searchIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.openIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.loadIncidentUserControl1 = new TechSupport.UserControls.LoadIncidentUserControl();
            this.searchIncidentUserControl1 = new TechSupport.UserControls.SearchIncidentUserControl();
            this.displayOpenIncidentUserControl1 = new TechSupport.UserControls.DisplayOpenIncidentUserControl();
            this.mainDashboardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.loadAllIncidentsTabPage.SuspendLayout();
            this.searchIncidentsTabPage.SuspendLayout();
            this.openIncidentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashboardTabControl
            // 
            this.mainDashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.mainDashboardTabControl.Controls.Add(this.loadAllIncidentsTabPage);
            this.mainDashboardTabControl.Controls.Add(this.searchIncidentsTabPage);
            this.mainDashboardTabControl.Controls.Add(this.openIncidentsTabPage);
            this.mainDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDashboardTabControl.Location = new System.Drawing.Point(0, 25);
            this.mainDashboardTabControl.Name = "mainDashboardTabControl";
            this.mainDashboardTabControl.SelectedIndex = 0;
            this.mainDashboardTabControl.Size = new System.Drawing.Size(800, 425);
            this.mainDashboardTabControl.TabIndex = 0;
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(792, 399);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // loadAllIncidentsTabPage
            // 
            this.loadAllIncidentsTabPage.Controls.Add(this.loadIncidentUserControl1);
            this.loadAllIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.loadAllIncidentsTabPage.Name = "loadAllIncidentsTabPage";
            this.loadAllIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loadAllIncidentsTabPage.Size = new System.Drawing.Size(792, 399);
            this.loadAllIncidentsTabPage.TabIndex = 1;
            this.loadAllIncidentsTabPage.Text = "All Incidents";
            this.loadAllIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchIncidentsTabPage
            // 
            this.searchIncidentsTabPage.Controls.Add(this.searchIncidentUserControl1);
            this.searchIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchIncidentsTabPage.Name = "searchIncidentsTabPage";
            this.searchIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchIncidentsTabPage.Size = new System.Drawing.Size(792, 399);
            this.searchIncidentsTabPage.TabIndex = 2;
            this.searchIncidentsTabPage.Text = "Search Incidents";
            this.searchIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // openIncidentsTabPage
            // 
            this.openIncidentsTabPage.Controls.Add(this.displayOpenIncidentUserControl1);
            this.openIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.openIncidentsTabPage.Name = "openIncidentsTabPage";
            this.openIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.openIncidentsTabPage.Size = new System.Drawing.Size(792, 399);
            this.openIncidentsTabPage.TabIndex = 3;
            this.openIncidentsTabPage.Text = "Display Open Incidents";
            this.openIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(692, 9);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(653, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 2;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(789, 399);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // loadIncidentUserControl1
            // 
            this.loadIncidentUserControl1.Location = new System.Drawing.Point(8, 6);
            this.loadIncidentUserControl1.Name = "loadIncidentUserControl1";
            this.loadIncidentUserControl1.Size = new System.Drawing.Size(778, 390);
            this.loadIncidentUserControl1.TabIndex = 0;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(11, -3);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(781, 406);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // displayOpenIncidentUserControl1
            // 
            this.displayOpenIncidentUserControl1.Location = new System.Drawing.Point(5, 10);
            this.displayOpenIncidentUserControl1.Name = "displayOpenIncidentUserControl1";
            this.displayOpenIncidentUserControl1.Size = new System.Drawing.Size(781, 383);
            this.displayOpenIncidentUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.mainDashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.mainDashboardTabControl.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.loadAllIncidentsTabPage.ResumeLayout(false);
            this.searchIncidentsTabPage.ResumeLayout(false);
            this.openIncidentsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private System.Windows.Forms.TabPage loadAllIncidentsTabPage;
        private System.Windows.Forms.TabPage searchIncidentsTabPage;
        private System.Windows.Forms.TabPage openIncidentsTabPage;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Label usernameLabel;
        private UserControls.LoadIncidentUserControl loadIncidentUserControl1;
        private UserControls.SearchIncidentUserControl searchIncidentUserControl1;
        private UserControls.DisplayOpenIncidentUserControl displayOpenIncidentUserControl1;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
    }
}