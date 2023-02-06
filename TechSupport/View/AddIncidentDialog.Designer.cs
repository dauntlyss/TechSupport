namespace TechSupport.View
{
    partial class AddIncidentDialog
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
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.descriptionErrorMessageLabel = new System.Windows.Forms.Label();
            this.titleErrorMessageLabel = new System.Windows.Forms.Label();
            this.customerIDErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLabel.Location = new System.Drawing.Point(95, 50);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(110, 20);
            this.customerIdLabel.TabIndex = 0;
            this.customerIdLabel.Text = "Customer ID";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(95, 132);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(43, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(95, 203);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(245, 50);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(299, 20);
            this.customerIDTextBox.TabIndex = 3;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(245, 132);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(299, 20);
            this.titleTextBox.TabIndex = 4;
            this.titleTextBox.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(245, 203);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(299, 108);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(245, 360);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(133, 45);
            this.addIncidentButton.TabIndex = 6;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(411, 360);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 45);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // descriptionErrorMessageLabel
            // 
            this.descriptionErrorMessageLabel.AutoSize = true;
            this.descriptionErrorMessageLabel.Location = new System.Drawing.Point(242, 323);
            this.descriptionErrorMessageLabel.Name = "descriptionErrorMessageLabel";
            this.descriptionErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionErrorMessageLabel.TabIndex = 10;
            // 
            // titleErrorMessageLabel
            // 
            this.titleErrorMessageLabel.AutoSize = true;
            this.titleErrorMessageLabel.Location = new System.Drawing.Point(242, 166);
            this.titleErrorMessageLabel.Name = "titleErrorMessageLabel";
            this.titleErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.titleErrorMessageLabel.TabIndex = 11;
            // 
            // customerIDErrorMessageLabel
            // 
            this.customerIDErrorMessageLabel.AutoSize = true;
            this.customerIDErrorMessageLabel.Location = new System.Drawing.Point(242, 83);
            this.customerIDErrorMessageLabel.Name = "customerIDErrorMessageLabel";
            this.customerIDErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.customerIDErrorMessageLabel.TabIndex = 12;
            // 
            // AddIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.customerIDErrorMessageLabel);
            this.Controls.Add(this.titleErrorMessageLabel);
            this.Controls.Add(this.descriptionErrorMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.customerIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncidentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label descriptionErrorMessageLabel;
        private System.Windows.Forms.Label titleErrorMessageLabel;
        private System.Windows.Forms.Label customerIDErrorMessageLabel;
    }
}