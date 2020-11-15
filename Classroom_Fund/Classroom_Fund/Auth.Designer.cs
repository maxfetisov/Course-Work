namespace Classroom_Fund
{
    partial class Auth
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
            System.Windows.Forms.Button enter;
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.ServerInput = new System.Windows.Forms.TextBox();
            this.DBInput = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelDB = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.GroupBox();
            this.windowsCheck = new System.Windows.Forms.RadioButton();
            this.SQLServerCheck = new System.Windows.Forms.RadioButton();
            enter = new System.Windows.Forms.Button();
            this.check.SuspendLayout();
            this.SuspendLayout();
            // 
            // enter
            // 
            enter.Location = new System.Drawing.Point(103, 270);
            enter.Name = "enter";
            enter.Size = new System.Drawing.Size(75, 23);
            enter.TabIndex = 4;
            enter.Text = "Войти";
            enter.UseVisualStyleBackColor = true;
            enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(85, 192);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(78, 233);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(48, 13);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Пароль:";
            // 
            // loginInput
            // 
            this.loginInput.Enabled = false;
            this.loginInput.Location = new System.Drawing.Point(146, 189);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(100, 20);
            this.loginInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Enabled = false;
            this.passwordInput.Location = new System.Drawing.Point(146, 230);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(100, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // ServerInput
            // 
            this.ServerInput.Location = new System.Drawing.Point(147, 28);
            this.ServerInput.Name = "ServerInput";
            this.ServerInput.Size = new System.Drawing.Size(100, 20);
            this.ServerInput.TabIndex = 5;
            // 
            // DBInput
            // 
            this.DBInput.Location = new System.Drawing.Point(147, 71);
            this.DBInput.Name = "DBInput";
            this.DBInput.Size = new System.Drawing.Size(100, 20);
            this.DBInput.TabIndex = 6;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(79, 31);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(47, 13);
            this.labelServer.TabIndex = 7;
            this.labelServer.Text = "Сервер:";
            // 
            // labelDB
            // 
            this.labelDB.AutoSize = true;
            this.labelDB.Location = new System.Drawing.Point(52, 74);
            this.labelDB.Name = "labelDB";
            this.labelDB.Size = new System.Drawing.Size(75, 13);
            this.labelDB.TabIndex = 8;
            this.labelDB.Text = "База данных:";
            // 
            // check
            // 
            this.check.Controls.Add(this.SQLServerCheck);
            this.check.Controls.Add(this.windowsCheck);
            this.check.Location = new System.Drawing.Point(88, 105);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(144, 73);
            this.check.TabIndex = 9;
            this.check.TabStop = false;
            this.check.Text = "Проверка подлинности:";
            // 
            // windowsCheck
            // 
            this.windowsCheck.AutoSize = true;
            this.windowsCheck.Checked = true;
            this.windowsCheck.Location = new System.Drawing.Point(17, 20);
            this.windowsCheck.Name = "windowsCheck";
            this.windowsCheck.Size = new System.Drawing.Size(69, 17);
            this.windowsCheck.TabIndex = 0;
            this.windowsCheck.TabStop = true;
            this.windowsCheck.Text = "Windows";
            this.windowsCheck.UseVisualStyleBackColor = true;
            this.windowsCheck.CheckedChanged += new System.EventHandler(this.windowsCheck_CheckedChanged);
            // 
            // SQLServerCheck
            // 
            this.SQLServerCheck.AutoSize = true;
            this.SQLServerCheck.Location = new System.Drawing.Point(17, 43);
            this.SQLServerCheck.Name = "SQLServerCheck";
            this.SQLServerCheck.Size = new System.Drawing.Size(80, 17);
            this.SQLServerCheck.TabIndex = 1;
            this.SQLServerCheck.Text = "SQL Server";
            this.SQLServerCheck.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 324);
            this.Controls.Add(this.check);
            this.Controls.Add(this.labelDB);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.DBInput);
            this.Controls.Add(this.ServerInput);
            this.Controls.Add(enter);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.check.ResumeLayout(false);
            this.check.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox ServerInput;
        private System.Windows.Forms.TextBox DBInput;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelDB;
        private System.Windows.Forms.GroupBox check;
        private System.Windows.Forms.RadioButton SQLServerCheck;
        private System.Windows.Forms.RadioButton windowsCheck;
    }
}