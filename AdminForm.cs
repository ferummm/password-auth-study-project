using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LR1
{
    public partial class AdminForm : Form
    {
        public static User currentCheckUser;
        public static HashSet<User> newUsersSet = new HashSet<User>();
        public AdminForm()
        {
            InitializeComponent();
            foreach (User i in AuthorizeForm.usersSet)
            {
                usersListBox.Items.Add(i.Login);
            }
            save.Enabled = false;
            isBlockedBox.Enabled = false;
            isLimitedBox.Enabled = false;
        }



        private void CloseAppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUserForm newUser = new NewUserForm();
            newUser.ShowDialog();
            foreach (User user in newUsersSet)
            {
                usersListBox.Items.Add(user.Login);
            }
            newUsersSet.Clear();
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(usersListBox.SelectedItem != null)
            {
                save.Enabled = true;
                isBlockedBox.Enabled = true;
                isLimitedBox.Enabled = true;
            
                AuthorizeForm.usersSet.TryGetValue(new User(usersListBox.SelectedItem.ToString()), out currentCheckUser);
                if (currentCheckUser.Login.ToLower() == AuthorizeForm.admin_name)
                {
                    isBlockedBox.Enabled = false;
                }
                else
                {
                    isBlockedBox.Checked = currentCheckUser.IsBlocked;
                }
                isLimitedBox.Checked = currentCheckUser.IsLimited;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                AuthorizeForm.usersSet.TryGetValue(new User(usersListBox.SelectedItem.ToString()), out User oldVersionUser);

                if (currentCheckUser.Login.ToLower() != AuthorizeForm.admin_name)
                {
                    currentCheckUser.IsBlocked = isBlockedBox.Checked;
                }
                currentCheckUser.IsLimited = isLimitedBox.Checked;

                if (currentCheckUser.IsBlocked != oldVersionUser.IsBlocked || currentCheckUser.IsLimited != oldVersionUser.IsLimited)
                {
                    AuthorizeForm.usersSet.Remove(currentCheckUser);
                    AuthorizeForm.usersSet.Add(currentCheckUser);
                    AuthorizeForm.currentUser = currentCheckUser;
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthorizeForm.currentUser.IsLimited == true)
            {
                MessageBox.Show("Пароль должен содержать строчные и прописные буквы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }


    }
}
