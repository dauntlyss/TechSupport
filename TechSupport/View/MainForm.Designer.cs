namespace TechSupport.View
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.searchIncidentButton = new System.Windows.Forms.Button();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(515, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(573, 23);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(40, 13);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Location = new System.Drawing.Point(126, 104);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(169, 54);
            this.addIncidentButton.TabIndex = 2;
            this.addIncidentButton.Text = "Add Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButton_Click);
            // 
            // searchIncidentButton
            // 
            this.searchIncidentButton.Location = new System.Drawing.Point(370, 104);
            this.searchIncidentButton.Name = "searchIncidentButton";
            this.searchIncidentButton.Size = new System.Drawing.Size(167, 54);
            this.searchIncidentButton.TabIndex = 3;
            this.searchIncidentButton.Text = "Search Incident";
            this.searchIncidentButton.UseVisualStyleBackColor = true;
            this.searchIncidentButton.Click += new System.EventHandler(this.SearchIncidentButton_Click);
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.AllowUserToAddRows = false;
            this.incidentDataGridView.AllowUserToDeleteRows = false;
            this.incidentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incidentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.incidentDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.incidentDataGridView.Location = new System.Drawing.Point(54, 197);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.incidentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.incidentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.incidentDataGridView.Size = new System.Drawing.Size(559, 205);
            this.incidentDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.incidentDataGridView);
            this.Controls.Add(this.searchIncidentButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button searchIncidentButton;
        private System.Windows.Forms.DataGridView incidentDataGridView;
    }
}