namespace CustomerDatabaseUI
{
    partial class AddCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.forenameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.forenameTextbox = new System.Windows.Forms.TextBox();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.surnameTextbox = new System.Windows.Forms.TextBox();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Customer";
            // 
            // forenameLabel
            // 
            this.forenameLabel.AutoSize = true;
            this.forenameLabel.Location = new System.Drawing.Point(14, 59);
            this.forenameLabel.Name = "forenameLabel";
            this.forenameLabel.Size = new System.Drawing.Size(54, 13);
            this.forenameLabel.TabIndex = 1;
            this.forenameLabel.Text = "Forename";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(14, 99);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(14, 135);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "URL";
            // 
            // forenameTextbox
            // 
            this.forenameTextbox.Location = new System.Drawing.Point(85, 56);
            this.forenameTextbox.Name = "forenameTextbox";
            this.forenameTextbox.Size = new System.Drawing.Size(154, 20);
            this.forenameTextbox.TabIndex = 5;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(85, 173);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(154, 20);
            this.urlTextbox.TabIndex = 6;
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(85, 135);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(154, 20);
            this.idTextbox.TabIndex = 7;
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Location = new System.Drawing.Point(85, 99);
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(154, 20);
            this.surnameTextbox.TabIndex = 8;
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Location = new System.Drawing.Point(85, 213);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(122, 41);
            this.createCustomerButton.TabIndex = 9;
            this.createCustomerButton.Text = "Create Customer";
            this.createCustomerButton.UseVisualStyleBackColor = true;
            this.createCustomerButton.Click += new System.EventHandler(this.createCustomerButton_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 307);
            this.Controls.Add(this.createCustomerButton);
            this.Controls.Add(this.surnameTextbox);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.urlTextbox);
            this.Controls.Add(this.forenameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.forenameLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forenameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox forenameTextbox;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox surnameTextbox;
        private System.Windows.Forms.Button createCustomerButton;
    }
}

