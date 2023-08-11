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
    public partial class AuthorizeForm : Form
    {

        public const string admin_name = "admin";
        public static User currentUser;
        public const string admin_pass = "";


        public static HashSet<User> usersSet = new HashSet<User>();
        public int attemptsCount = 3;

        public static bool SetPP = false;
        public static MemoryStream ms;
        public AuthorizeForm()
        {
            InitializeComponent();
            this.attemptsLabel.Text = "Осталось попыток: " + attemptsCount;

            UsersFile uf = new UsersFile();
            if (uf.IsExist)
            {
                var PassPhraseForm = new PassPhraseForm();
                PassPhraseForm.ShowDialog();
            }    
            else
            {
                var newPassPhraseForm = new NewPassPhraseForm(1); 
                newPassPhraseForm.ShowDialog();
                
            }
            if (!SetPP)
            {
                Close();
            }

            if (!UsersFile.IsCorrectPP())
            {
                ms.Close();
                MessageBox.Show("Неверная парольная фраза. Приложение будет закрыто.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                
            }

        }


        private void About_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void Enter1_Click(object sender, EventArgs e)
        {
            if (loginBox1.Text != "" && attemptsCount != 0)
            {
                string login = loginBox1.Text;
                string password = passwBox1.Text;
                bool isExist = usersSet.TryGetValue(new User(login), out currentUser);
                if (isExist)
                {
                    if (!currentUser.IsBlocked)
                    {
                        if (currentUser.HasAccess(password))
                        {
                            this.Visible = false;
                            if (currentUser.IsFirstEntry == true)
                            {
                                MessageBox.Show("Вход в учетную запись выполняется впервые. Необходимо сменить пароль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (currentUser.IsLimited == true)
                                {
                                    MessageBox.Show("Пароль должен содержать строчные и прописные буквы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                                changePasswordForm.ShowDialog();
                                if (currentUser.IsFirstEntry)
                                {
                                    Close();
                                }
                            } else if (currentUser.IsLimited && !User.IsCorrectPassword(password))
                            {
                                MessageBox.Show("Пароль не соответствует введеным ограничениям. Необходимо сменить пароль.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Пароль должен содержать строчные и прописные буквы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                                changePasswordForm.ShowDialog();
                                if (!User.IsCorrectPassword(currentUser.Password))
                                {
                                    Close();
                                }
                            }


                            if (login.ToLower() == admin_name)
                            {
                                AdminForm adminForm = new AdminForm();
                                adminForm.ShowDialog();
                            }
                            else
                            {
                                UserForm userForm = new UserForm();
                                userForm.ShowDialog();
                            }

                            Close();
                        }
                        else
                        {
                            attemptsCount -= 1;
                            attemptsLabel.Text = "Осталось попыток: " + attemptsCount;
                            if (attemptsCount == 0)
                            {
                                MessageBox.Show("Не осталось попыток. Приложение будет закрыто.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Close();
                            }
                            else MessageBox.Show("Неверный пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователя с данным логином заблокирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Пользователя с данным логином не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Логин не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AuthorizeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ms = new MemoryStream();
            MessageBox.Show("При отказе ввода парольной фразы данные будут утеряны, программа закроется.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            using (var writer = new BinaryWriter(ms, Encoding.Unicode, true))
            {
                foreach (User user in usersSet)
                {
                    writer.Write(user.Login);
                    writer.Write(user.Password);
                    writer.Write(user.IsBlocked);
                    writer.Write(user.IsLimited);
                    writer.Write(user.IsFirstEntry);
                }
            }
            AuthorizeForm.ms.Seek(0, SeekOrigin.Begin);
            var newPassPhraseForm = new NewPassPhraseForm();
            //encrypt
            newPassPhraseForm.ShowDialog();

            ms.Close();
        }

    }
}
