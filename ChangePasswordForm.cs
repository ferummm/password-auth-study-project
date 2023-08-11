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
    public partial class ChangePasswordForm : Form
    {
        public int attemptsCount = 3;
        public ChangePasswordForm()
        {
            InitializeComponent();
            if (AuthorizeForm.currentUser.IsFirstEntry == true)
            {
                cancel1.Text = "Выход";
            }
            else cancel1.Text = "Отмена";
            oldPassw.Select();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string oldPass = oldPassw.Text;
            string newPass = newPassw.Text;
            string repeatNewPass = repeatNewPassw.Text;
            if (newPass == "" || repeatNewPass == "")
            {
                MessageBox.Show("Поля не могут быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (AuthorizeForm.currentUser.HasAccess(oldPass))
                {
                    if (newPass == repeatNewPass)
                    {
                        if (!AuthorizeForm.currentUser.IsLimited || User.IsCorrectPassword(newPass))
                        {
                            AuthorizeForm.currentUser.Password = newPass;
                            AuthorizeForm.currentUser.IsFirstEntry = false;
                            AuthorizeForm.usersSet.Remove(AuthorizeForm.currentUser);
                            AuthorizeForm.usersSet.Add(AuthorizeForm.currentUser);
                            MessageBox.Show("Пароль успешно изменен.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else MessageBox.Show("Пароль должен содержать строчные и прописные буквы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        newPassw.Text = "";
                        repeatNewPassw.Text = "";
                        MessageBox.Show("Пароли не совпадают. Повторите ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    oldPassw.Text = "";
                    newPassw.Text = "";
                    repeatNewPassw.Text = "";
                    attemptsCount -= 1;
                    if (attemptsCount == 0)
                    {
                        MessageBox.Show("Не осталось попыток. Приложение будет закрыто.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                    MessageBox.Show("Введен неправильный пароль. Осталось попыток: " + attemptsCount, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
