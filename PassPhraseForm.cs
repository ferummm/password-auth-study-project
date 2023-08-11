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
    public partial class PassPhraseForm : Form
    {
        public PassPhraseForm()
        {
            InitializeComponent();
            PassPhrase1.Select();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа будет закрыта.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassPhrase1.Text.Length < 8)
                    throw new ArgumentException("Парольная фраза короче требуемой длины.");
                else
                {
                    AuthorizeForm.SetPP = true;
                    //memory file open
                    //decrypt to memory file
                    //seek to begin
                    
                    AuthorizeForm.ms = new MemoryStream();
                    UsersFile.Decrypt(AuthorizeForm.ms, PassPhrase1.Text);
                    AuthorizeForm.ms.Seek(0, SeekOrigin.Begin);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
      
    }
}
