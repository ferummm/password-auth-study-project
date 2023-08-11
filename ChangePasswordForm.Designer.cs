
namespace LR1
{
    partial class ChangePasswordForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPassw = new System.Windows.Forms.TextBox();
            this.newPassw = new System.Windows.Forms.TextBox();
            this.repeatNewPassw = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Повторите пароль";
            // 
            // oldPassw
            // 
            this.oldPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassw.Location = new System.Drawing.Point(184, 24);
            this.oldPassw.Name = "oldPassw";
            this.oldPassw.PasswordChar = '*';
            this.oldPassw.Size = new System.Drawing.Size(140, 26);
            this.oldPassw.TabIndex = 3;
            // 
            // newPassw
            // 
            this.newPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassw.Location = new System.Drawing.Point(184, 65);
            this.newPassw.Name = "newPassw";
            this.newPassw.PasswordChar = '*';
            this.newPassw.Size = new System.Drawing.Size(140, 26);
            this.newPassw.TabIndex = 4;
            // 
            // repeatNewPassw
            // 
            this.repeatNewPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatNewPassw.Location = new System.Drawing.Point(184, 106);
            this.repeatNewPassw.Name = "repeatNewPassw";
            this.repeatNewPassw.PasswordChar = '*';
            this.repeatNewPassw.Size = new System.Drawing.Size(140, 26);
            this.repeatNewPassw.TabIndex = 5;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(30, 154);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 36);
            this.save.TabIndex = 6;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel1
            // 
            this.cancel1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel1.Location = new System.Drawing.Point(184, 154);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(123, 36);
            this.cancel1.TabIndex = 7;
            this.cancel1.Text = "Отмена";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // ChangePasswordForm
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel1;
            this.ClientSize = new System.Drawing.Size(350, 202);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.repeatNewPassw);
            this.Controls.Add(this.newPassw);
            this.Controls.Add(this.oldPassw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPassw;
        private System.Windows.Forms.TextBox newPassw;
        private System.Windows.Forms.TextBox repeatNewPassw;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel1;
    }
}