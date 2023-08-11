using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
            newUserLogin.Select();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string login = newUserLogin.Text;
            if (login == "")
            {
                MessageBox.Show("Логин не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (AuthorizeForm.usersSet.Contains(new User(login)))
                {
                    MessageBox.Show("Пользователь с данным именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User newUser = new User(login);
                    AuthorizeForm.usersSet.Add(newUser);
                    AdminForm.newUsersSet.Add(newUser);
                    //MessageBox.Show("Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newUserLogin.Text = "";
                }
            }
            newUserLogin.Select();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
