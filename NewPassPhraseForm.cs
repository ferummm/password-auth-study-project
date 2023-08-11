using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class NewPassPhraseForm : Form
    {
        public readonly int InfoNum;
        public NewPassPhraseForm(int n)
        {
            InitializeComponent();
            InfoNum = n;
            PP1.Select();

        }
        public NewPassPhraseForm()
        {
            InitializeComponent();
            PP1.Select();
        }

        private void OKButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PP1.Text.Length < 8 || PP2.Text.Length < 8)
                {
                    throw new ArgumentException("Парольная фраза короче требуемой длины.");
                }
                else
                {
                    if (PP1.Text != PP2.Text)
                    {
                        throw new ArgumentException("Парольные фразы не совпадают.");
                    }
                    else
                    {
                       
                        //add user to set
                        //add user to memory file
                        //seek to begin
                        //encrypt memory file
                        //seek to begin
                        if (this.InfoNum == 1)
                        {
                            AuthorizeForm.SetPP = true;
                            User admin = new User(AuthorizeForm.admin_name, AuthorizeForm.admin_pass, false, true, true);
                            AuthorizeForm.usersSet.Add(admin);
                            AuthorizeForm.ms = new MemoryStream();

                            using (var writer = new BinaryWriter(AuthorizeForm.ms, Encoding.Unicode, true))
                            {
                                writer.Write(AuthorizeForm.admin_name);
                                writer.Write(AuthorizeForm.admin_pass);
                                writer.Write(false);
                                writer.Write(true);
                                writer.Write(true);
                            }
                            AuthorizeForm.ms.Seek(0, SeekOrigin.Begin);
                        }

                        UsersFile.Encrypt(AuthorizeForm.ms, PP1.Text);
                        AuthorizeForm.ms.Seek(0, SeekOrigin.Begin);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа будет закрыта.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
