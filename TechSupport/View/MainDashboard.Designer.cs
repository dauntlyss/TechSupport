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
            this.mainDashboardTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashboardTabControl
            // 
            this.mainDashboardTabControl.Controls.Add(this.addIncidentTabPage);
            this.mainDashboardTabControl.Controls.Add(this.loadAllIncidentsTabPage);
            this.mainDashboardTabControl.Controls.Add(this.searchIncidentsTabPage);
            this.mainDashboardTabControl.Controls.Add(this.openIncidentsTabPage);
            this.mainDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainDashboardTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainDashboardTabControl.Name = "mainDashboardTabControl";
            this.mainDashboardTabControl.SelectedIndex = 0;
            this.mainDashboardTabControl.Size = new System.Drawing.Size(800, 448);
            this.mainDashboardTabControl.TabIndex = 0;
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(792, 422);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // loadAllIncidentsTabPage
            // 
            this.loadAllIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.loadAllIncidentsTabPage.Name = "loadAllIncidentsTabPage";
            this.loadAllIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loadAllIncidentsTabPage.Size = new System.Drawing.Size(792, 422);
            this.loadAllIncidentsTabPage.TabIndex = 1;
            this.loadAllIncidentsTabPage.Text = "All Incidents";
            this.loadAllIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchIncidentsTabPage
            // 
            this.searchIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchIncidentsTabPage.Name = "searchIncidentsTabPage";
            this.searchIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchIncidentsTabPage.Size = new System.Drawing.Size(792, 422);
            this.searchIncidentsTabPage.TabIndex = 2;
            this.searchIncidentsTabPage.Text = "Search Incidents";
            this.searchIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // openIncidentsTabPage
            // 
            this.openIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.openIncidentsTabPage.Name = "openIncidentsTabPage";
            this.openIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.openIncidentsTabPage.Size = new System.Drawing.Size(792, 422);
            this.openIncidentsTabPage.TabIndex = 3;
            this.openIncidentsTabPage.Text = "Display Open Incidents";
            this.openIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainDashboardTabControl);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.mainDashboardTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashboardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private System.Windows.Forms.TabPage loadAllIncidentsTabPage;
        private System.Windows.Forms.TabPage searchIncidentsTabPage;
        private System.Windows.Forms.TabPage openIncidentsTabPage;
    }
}