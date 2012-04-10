using System.Collections.Generic;
namespace AccountManager
{
    partial class AccountManagerMainForm
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
            this.xmlButton = new System.Windows.Forms.RadioButton();
            this.csvButton = new System.Windows.Forms.RadioButton();
            this.storageLabel = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.usersComboBoxLabel = new System.Windows.Forms.Label();
            this.togglePanel = new System.Windows.Forms.Panel();
            this.newUserButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.togglePanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // xmlButton
            // 
            this.xmlButton.AutoSize = true;
            this.xmlButton.Location = new System.Drawing.Point(145, 3);
            this.xmlButton.Name = "xmlButton";
            this.xmlButton.Size = new System.Drawing.Size(47, 17);
            this.xmlButton.TabIndex = 0;
            this.xmlButton.Text = "XML";
            this.xmlButton.UseVisualStyleBackColor = true;
            this.xmlButton.Click += new System.EventHandler(this.xmlButton_Clicked);
            // 
            // csvButton
            // 
            this.csvButton.AutoSize = true;
            this.csvButton.Location = new System.Drawing.Point(304, 3);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(46, 17);
            this.csvButton.TabIndex = 1;
            this.csvButton.Text = "CSV";
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Clicked);
            // 
            // storageLabel
            // 
            this.storageLabel.AutoSize = true;
            this.storageLabel.Location = new System.Drawing.Point(7, 2);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(78, 13);
            this.storageLabel.TabIndex = 2;
            this.storageLabel.Text = "Storage in use:";
            // 
            // usersComboBox
            // 
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(47, 38);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(330, 21);
            this.usersComboBox.TabIndex = 2;
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // usersComboBoxLabel
            // 
            this.usersComboBoxLabel.AutoSize = true;
            this.usersComboBoxLabel.Location = new System.Drawing.Point(7, 38);
            this.usersComboBoxLabel.Name = "usersComboBoxLabel";
            this.usersComboBoxLabel.Size = new System.Drawing.Size(34, 13);
            this.usersComboBoxLabel.TabIndex = 4;
            this.usersComboBoxLabel.Text = "Users";
            // 
            // togglePanel
            // 
            this.togglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.togglePanel.Controls.Add(this.usersComboBoxLabel);
            this.togglePanel.Controls.Add(this.usersComboBox);
            this.togglePanel.Controls.Add(this.storageLabel);
            this.togglePanel.Controls.Add(this.csvButton);
            this.togglePanel.Controls.Add(this.xmlButton);
            this.togglePanel.Location = new System.Drawing.Point(5, 12);
            this.togglePanel.Name = "togglePanel";
            this.togglePanel.Size = new System.Drawing.Size(399, 75);
            this.togglePanel.TabIndex = 9;
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(210, 16);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(75, 23);
            this.newUserButton.TabIndex = 8;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(305, 16);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(10, 16);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.statusLabel);
            this.buttonsPanel.Controls.Add(this.deleteUserButton);
            this.buttonsPanel.Controls.Add(this.saveButton);
            this.buttonsPanel.Controls.Add(this.newUserButton);
            this.buttonsPanel.Location = new System.Drawing.Point(5, 279);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(399, 69);
            this.buttonsPanel.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(8, 42);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 8;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(189, 150);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(194, 20);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(189, 192);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(2, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(102, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name (no symbols) :";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(2, 153);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(178, 13);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Username (4-10 chars, no symbols) :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(2, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(176, 13);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "Password (8-20 chars, no symbols) :";
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Location = new System.Drawing.Point(2, 231);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(75, 13);
            this.creationDateLabel.TabIndex = 16;
            this.creationDateLabel.Text = "Creation Date:";
            // 
            // creationDateBox
            // 
            this.creationDateBox.Enabled = false;
            this.creationDateBox.Location = new System.Drawing.Point(189, 228);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.Size = new System.Drawing.Size(194, 20);
            this.creationDateBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(189, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 20);
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // AccountManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 348);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.creationDateBox);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.togglePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountManagerMainForm";
            this.Text = "AccountManager v0.001";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountManagerMainForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountManagerMainForm_Load);
            this.togglePanel.ResumeLayout(false);
            this.togglePanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.RadioButton xmlButton;
        private System.Windows.Forms.RadioButton csvButton;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label usersComboBoxLabel;
        private System.Windows.Forms.Panel togglePanel;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.TextBox nameTextBox;



    }
}

