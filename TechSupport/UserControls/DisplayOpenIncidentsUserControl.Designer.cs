namespace TechSupport.UserControls
{
    partial class DisplayOpenIncidentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openIncidentsListView = new System.Windows.Forms.ListView();
            this.productCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpenedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openIncidentsListView
            // 
            this.openIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeHeader,
            this.dateOpenedHeader,
            this.customerHeader,
            this.technicianHeader,
            this.titleHeader});
            this.openIncidentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openIncidentsListView.GridLines = true;
            this.openIncidentsListView.HideSelection = false;
            this.openIncidentsListView.Location = new System.Drawing.Point(0, 0);
            this.openIncidentsListView.Name = "openIncidentsListView";
            this.openIncidentsListView.RightToLeftLayout = true;
            this.openIncidentsListView.Size = new System.Drawing.Size(779, 385);
            this.openIncidentsListView.TabIndex = 0;
            this.openIncidentsListView.UseCompatibleStateImageBehavior = false;
            this.openIncidentsListView.View = System.Windows.Forms.View.Details;
            this.openIncidentsListView.VisibleChanged += new System.EventHandler(this.OpenIncidentListView_VisibleChanged);
            // 
            // productCodeHeader
            // 
            this.productCodeHeader.Text = "Product Code";
            this.productCodeHeader.Width = 102;
            // 
            // dateOpenedHeader
            // 
            this.dateOpenedHeader.Text = "Date Opened";
            this.dateOpenedHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateOpenedHeader.Width = 117;
            // 
            // customerHeader
            // 
            this.customerHeader.Text = "Customer";
            this.customerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerHeader.Width = 115;
            // 
            // technicianHeader
            // 
            this.technicianHeader.Text = "Technician";
            this.technicianHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.technicianHeader.Width = 115;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleHeader.Width = 320;
            // 
            // DisplayOpenIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openIncidentsListView);
            this.Name = "DisplayOpenIncidentUserControl";
            this.Size = new System.Drawing.Size(779, 385);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView openIncidentsListView;
        private System.Windows.Forms.ColumnHeader productCodeHeader;
        private System.Windows.Forms.ColumnHeader dateOpenedHeader;
        private System.Windows.Forms.ColumnHeader customerHeader;
        private System.Windows.Forms.ColumnHeader technicianHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
    }
}
