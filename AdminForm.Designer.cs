
namespace LR1
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.save = new System.Windows.Forms.Button();
            this.isBlockedBox = new System.Windows.Forms.CheckBox();
            this.isLimitedBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersListBox
            // 
            this.usersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.HorizontalScrollbar = true;
            this.usersListBox.ItemHeight = 20;
            this.usersListBox.Location = new System.Drawing.Point(12, 42);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.ScrollAlwaysVisible = true;
            this.usersListBox.Size = new System.Drawing.Size(180, 224);
            this.usersListBox.Sorted = true;
            this.usersListBox.TabIndex = 0;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(230, 228);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(119, 38);
            this.save.TabIndex = 2;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // isBlockedBox
            // 
            this.isBlockedBox.AutoSize = true;
            this.isBlockedBox.Enabled = false;
            this.isBlockedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isBlockedBox.Location = new System.Drawing.Point(230, 73);
            this.isBlockedBox.Name = "isBlockedBox";
            this.isBlockedBox.Size = new System.Drawing.Size(119, 24);
            this.isBlockedBox.TabIndex = 3;
            this.isBlockedBox.Text = "Блокировка";
            this.isBlockedBox.UseVisualStyleBackColor = true;
            // 
            // isLimitedBox
            // 
            this.isLimitedBox.AutoSize = true;
            this.isLimitedBox.Enabled = false;
            this.isLimitedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isLimitedBox.Location = new System.Drawing.Point(230, 148);
            this.isLimitedBox.Name = "isLimitedBox";
            this.isLimitedBox.Size = new System.Drawing.Size(128, 24);
            this.isLimitedBox.TabIndex = 4;
            this.isLimitedBox.Text = "Ограничения";
            this.isLimitedBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.CloseAppToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.AddUserToolStripMenuItem.Text = "Добавить пользователя";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.changePasswordToolStripMenuItem.Text = "Сменить пароль";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // CloseAppToolStripMenuItem1
            // 
            this.CloseAppToolStripMenuItem1.Name = "CloseAppToolStripMenuItem1";
            this.CloseAppToolStripMenuItem1.Size = new System.Drawing.Size(263, 26);
            this.CloseAppToolStripMenuItem1.Text = "Выход";
            this.CloseAppToolStripMenuItem1.Click += new System.EventHandler(this.CloseAppToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(14, 25);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LR1.User);
            // 
            // AdminForm
            // 
            this.AcceptButton = this.save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 277);
            this.Controls.Add(this.isLimitedBox);
            this.Controls.Add(this.isBlockedBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox isBlockedBox;
        private System.Windows.Forms.CheckBox isLimitedBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAppToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}