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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void changePasswButton_Click(object sender, EventArgs e)
        {
            if (AuthorizeForm.currentUser.IsLimited == true)
            {
                MessageBox.Show("Пароль должен содержать строчные и прописные буквы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();

        }


        private void CloseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
