namespace TechSupport.UserControls
{
    partial class AddIncidentUserControl
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
            this.customerIDErrorMessageLabel = new System.Windows.Forms.Label();
            this.titleErrorMessageLabel = new System.Windows.Forms.Label();
            this.descriptionErrorMessageLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.successMessageLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerIDErrorMessageLabel
            // 
            this.customerIDErrorMessageLabel.AutoSize = true;
            this.customerIDErrorMessageLabel.Location = new System.Drawing.Point(243, 56);
            this.customerIDErrorMessageLabel.Name = "customerIDErrorMessageLabel";
            this.customerIDErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.customerIDErrorMessageLabel.TabIndex = 23;
            // 
            // titleErrorMessageLabel
            // 
            this.titleErrorMessageLabel.AutoSize = true;
            this.titleErrorMessageLabel.Location = new System.Drawing.Point(246, 175);
            this.titleErrorMessageLabel.Name = "titleErrorMessageLabel";
            this.titleErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.titleErrorMessageLabel.TabIndex = 22;
            // 
            // descriptionErrorMessageLabel
            // 
            this.descriptionErrorMessageLabel.AutoSize = true;
            this.descriptionErrorMessageLabel.Location = new System.Drawing.Point(243, 317);
            this.descriptionErrorMessageLabel.Name = "descriptionErrorMessageLabel";
            this.descriptionErrorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.descriptionErrorMessageLabel.TabIndex = 21;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(412, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 45);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(246, 340);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(133, 45);
            this.addIncidentButton.TabIndex = 19;
            this.addIncidentButton.Text = "Add";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.addIncidentButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(249, 197);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(299, 108);
            this.descriptionTextBox.TabIndex = 18;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.UserInputChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(249, 141);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(299, 20);
            this.titleTextBox.TabIndex = 17;
            this.titleTextBox.TextChanged += new System.EventHandler(this.UserInputChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(96, 197);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(105, 20);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(96, 141);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(48, 20);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "Title:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(96, 23);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(91, 20);
            this.customerLabel.TabIndex = 13;
            this.customerLabel.Text = "Customer:";
            // 
            // successMessageLabel
            // 
            this.successMessageLabel.AutoSize = true;
            this.successMessageLabel.Location = new System.Drawing.Point(246, 317);
            this.successMessageLabel.Name = "successMessageLabel";
            this.successMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.successMessageLabel.TabIndex = 24;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(249, 25);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(299, 21);
            this.customerComboBox.TabIndex = 27;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(249, 81);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(299, 21);
            this.productComboBox.TabIndex = 28;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(96, 82);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(76, 20);
            this.productLabel.TabIndex = 29;
            this.productLabel.Text = "Product:";
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.successMessageLabel);
            this.Controls.Add(this.customerIDErrorMessageLabel);
            this.Controls.Add(this.titleErrorMessageLabel);
            this.Controls.Add(this.descriptionErrorMessageLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.customerLabel);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(671, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIDErrorMessageLabel;
        private System.Windows.Forms.Label titleErrorMessageLabel;
        private System.Windows.Forms.Label descriptionErrorMessageLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label successMessageLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label productLabel;
    }
}
