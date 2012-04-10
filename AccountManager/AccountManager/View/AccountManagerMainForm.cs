using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class AccountManagerMainForm : Form
    {
        private Boolean saved = true;
        private string allowedCharacterSet = "qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM0123456789";
        public AccountManagerMainForm()
        {
            InitializeComponent();
        }

        private void xmlButton_Clicked(object sender, EventArgs e)
        {
            
            if (saved)
            {
                switchXML();
            }
            else
            {
                DialogResult res = MessageBox.Show("Would you like to save your changes before switching storage", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
                if ( res == DialogResult.Yes)
                {
                    saveCurrentUser(true, 2);
                    switchXML();
                }
                else if (res == DialogResult.No)
                {
                    switchXML();
                }
                else if (res == DialogResult.Cancel)
                {
                    csvButton.Checked = true;
                }
            }
        }

        private void csvButton_Clicked(object sender, EventArgs e)
        {
            if (saved)
            {
                switchCSV();
            }
            else
            {
                DialogResult res = MessageBox.Show("Would you like to save your changes before switching storage", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
                if (res  == DialogResult.Yes)
                {
                    saveCurrentUser(true, 1);
                    switchCSV();
                }
                else if (res == DialogResult.No)
                {
                    switchCSV();
                }
                else if (res == DialogResult.Cancel)
                {
                    xmlButton.Checked = true;
                }
            }
        }

        
        private void switchXML()
        {
            saved = true;
            Controller.Persistent.Users = Controller.IO.readXML();
            refreshComboBox(Controller.Persistent.Users);
            clearAll();
            enableFields();
        }

        private void switchCSV()
        {
            saved = true;
            Controller.Persistent.Users = Controller.IO.readCSV();
            refreshComboBox(Controller.Persistent.Users);
            clearAll();
            enableFields();
        }

        private void refreshComboBox(List<Model.User> users)
        {

            usersComboBox.Items.Clear();
            int i = 0;
            string[] usernamesArray = new string[users.Count];

            foreach (Model.User u in users)
            {
                usernamesArray[i] = u.Name;
                i++;
            }
            usersComboBox.Items.AddRange(usernamesArray);
            usersComboBox.SelectedIndex = -1;
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.User user = getUserFromComboBox(); 
            if ( user != null)
            {
                reloadFields(user);
            }
        }

        private Model.User getUserFromComboBox()
        {
            if (usersComboBox.SelectedItem != null)
            {
                int i = getSelectedUserIndex();
                Model.User user = Controller.Persistent.Users.ElementAt(i);
                return user;
            }
            else
            {
                return null;
            }
        }

        private int getSelectedUserIndex()
        {
            return usersComboBox.Items.IndexOf(usersComboBox.SelectedItem);
        }

        private void reloadFields(Model.User user)
        {
            nameTextBox.Text = user.Name;
            usernameTextBox.Text = user.Username;
            passwordTextBox.Text = user.Password;
            creationDateBox.Text = user.CreationDate.ToString();
            saved = true;
        }

        private void enableFields()
        {
            nameTextBox.Enabled = true;
            usernameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
        }

        private void clearFields()
        {
            nameTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            creationDateBox.Text = "";
            statusLabel.Text = "";
            saved = true;
        }

        private void clearAll()
        {
            clearFields();
            usersComboBox.SelectedIndex = -1;
        }
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            Model.User user = getUserFromComboBox();
            if (user != null)
            {

                if (MessageBox.Show("Are you sure you want to delete " + user.Name + " from storage?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteUser(user);
                }
            }
            else 
            {
                statusLabel.Text = "To delete, select a user first.";
            }

            
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            clearAll();
            statusLabel.Text = "With the correct storage selected, fill in the white fields correctly and hit save.";
        }

        private void deleteUser(Model.User user)
        {

            Controller.Persistent.deleteUser(user, CheckedStorage());
                clearAll();
                refreshComboBox(Controller.Persistent.Users);
                statusLabel.Text = "User removed.";
                saved = true;
         
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveCurrentUser(false, 0);
        }

        private void saveCurrentUser(Boolean manStorageDetect, int manStorage)
        {

                int storage = 0;
                if (manStorageDetect)
                {
                    storage = manStorage;
                }
                else
                {
                    storage = CheckedStorage();
                }
                if (storage > 0)
                {
                    if (validateFields())
                    {
                        Model.User user = getUserFromComboBox();
                        if (user != null)
                        {
                            user.Name = nameTextBox.Text;
                            user.Username = usernameTextBox.Text;
                            user.Password = passwordTextBox.Text;
                            Controller.Persistent.editUser(user, getSelectedUserIndex(), storage);
                            refreshComboBox(Controller.Persistent.Users);
                            statusLabel.Text = "Current user edited.";
                            usersComboBox.SelectedItem = user.Name;
                            saved = true;
                        }
                        else
                        {
                            string Name = nameTextBox.Text;
                            string Username = usernameTextBox.Text;
                            string Password = passwordTextBox.Text;
                            user = new Model.User(Username, Password, Name);
                            Controller.Persistent.addUser(user, storage);
                            refreshComboBox(Controller.Persistent.Users);
                            statusLabel.Text = "New user saved.";
                            usersComboBox.SelectedItem = user.Name;
                            saved = true;
                        }
                    }
                }
                else
                {
                    statusLabel.Text = "Toggle a storage type first.";
                }
      
        }

        private int CheckedStorage()
        {
            if (xmlButton.Checked)
                return 1;
            if (csvButton.Checked)
                return 2;
            else
                return 0;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        private void AccountManagerMainForm_FormClosing(object sender, FormClosingEventArgs e) 
        {
            

            if (saved)
            {
                switchXML();
            }
            else
            {
                DialogResult res = MessageBox.Show("Would you like to save your changes before closing?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    saveCurrentUser(false, 0);
                }
                else if (res == DialogResult.No)
                {
                  
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private Boolean validateFields()
        {

            if (!validateNameTextBox())
            {
                MessageBox.Show("Name format is invalid. Must not be blank & no symbols allowed");
                saved = true;
                return false;
            }
            if (!validateUsernameTextBox())
            {
                MessageBox.Show("Username format is invalid. Must be between 4-10 chars & no symbols allowed");
                saved = true;
                return false;
            }
            if (!validatePasswordTextBox())
            {
                MessageBox.Show("Password format is invalid. Must be between 8-20 chars & no symbols allowed");
                saved = true;
                return false;
            }
                return true;
        }

        private Boolean validateNameTextBox()
        {
            char[] c = nameTextBox.Text.ToCharArray();
            if (charCheck(c) && c.Length > 0)
                return true;
            else
                return false;
        }
        private Boolean validateUsernameTextBox()
        {
            char[] c = usernameTextBox.Text.ToCharArray();
            if (charCheck(c) && c.Length >= 4 && c.Length <= 10)
                return true;
            else
                return false;
        }
        private Boolean validatePasswordTextBox()
        {
            char[] c = passwordTextBox.Text.ToCharArray();
            if (charCheck(c) && c.Length >= 8 && c.Length <= 20)
                return true;
            else
                return false;
        }

        private Boolean charCheck(char[] chars)
        {
            foreach(char c in chars)
            {
                Console.Write(c);
                if (!allowedCharacterSet.Contains(c.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private void AccountManagerMainForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Screen src = System.Windows.Forms.Screen.PrimaryScreen;

            int x = (src.WorkingArea.Width - this.Width) / 2;
            int y = (src.WorkingArea.Height - this.Height) / 2;

            this.MaximizedBounds = new Rectangle(x, y, this.Width, this.Height);
        }
    }
}
