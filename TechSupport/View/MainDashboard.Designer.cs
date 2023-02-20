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
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.updateIncidentTabPage = new System.Windows.Forms.TabPage();
            this.updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.openIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentUserControl1 = new TechSupport.UserControls.DisplayOpenIncidentUserControl();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.mainDashboardTabControl = new System.Windows.Forms.TabControl();
            this.updateIncidentTabPage.SuspendLayout();
            this.openIncidentsTabPage.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.mainDashboardTabControl.SuspendLayout();
            this.SuspendLayout();
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
            // updateIncidentTabPage
            // 
            this.updateIncidentTabPage.Controls.Add(this.updateIncidentUserControl1);
            this.updateIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.updateIncidentTabPage.Name = "updateIncidentTabPage";
            this.updateIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateIncidentTabPage.Size = new System.Drawing.Size(792, 539);
            this.updateIncidentTabPage.TabIndex = 4;
            this.updateIncidentTabPage.Text = "Update Incident";
            this.updateIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // updateIncidentUserControl1
            // 
            this.updateIncidentUserControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateIncidentUserControl1.Location = new System.Drawing.Point(92, 6);
            this.updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            this.updateIncidentUserControl1.Size = new System.Drawing.Size(636, 528);
            this.updateIncidentUserControl1.TabIndex = 0;
            // 
            // openIncidentsTabPage
            // 
            this.openIncidentsTabPage.Controls.Add(this.displayOpenIncidentUserControl1);
            this.openIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.openIncidentsTabPage.Name = "openIncidentsTabPage";
            this.openIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.openIncidentsTabPage.Size = new System.Drawing.Size(792, 539);
            this.openIncidentsTabPage.TabIndex = 3;
            this.openIncidentsTabPage.Text = "Display Open Incidents";
            this.openIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentUserControl1
            // 
            this.displayOpenIncidentUserControl1.Location = new System.Drawing.Point(5, 10);
            this.displayOpenIncidentUserControl1.Name = "displayOpenIncidentUserControl1";
            this.displayOpenIncidentUserControl1.Size = new System.Drawing.Size(781, 529);
            this.displayOpenIncidentUserControl1.TabIndex = 0;
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(792, 539);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(3, 61);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(789, 419);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // mainDashboardTabControl
            // 
            this.mainDashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.mainDashboardTabControl.Controls.Add(this.openIncidentsTabPage);
            this.mainDashboardTabControl.Controls.Add(this.updateIncidentTabPage);
            this.mainDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDashboardTabControl.Location = new System.Drawing.Point(0, 41);
            this.mainDashboardTabControl.Name = "mainDashboardTabControl";
            this.mainDashboardTabControl.SelectedIndex = 0;
            this.mainDashboardTabControl.Size = new System.Drawing.Size(800, 565);
            this.mainDashboardTabControl.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.mainDashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.updateIncidentTabPage.ResumeLayout(false);
            this.openIncidentsTabPage.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.mainDashboardTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TabPage updateIncidentTabPage;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
        private System.Windows.Forms.TabPage openIncidentsTabPage;
        private UserControls.DisplayOpenIncidentUserControl displayOpenIncidentUserControl1;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private System.Windows.Forms.TabControl mainDashboardTabControl;
    }
}