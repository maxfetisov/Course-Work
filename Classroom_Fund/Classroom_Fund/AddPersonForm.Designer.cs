namespace Classroom_Fund
{
    partial class AddPersonForm
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.middleNameInput = new System.Windows.Forms.TextBox();
            this.phoneNumberInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(81, 26);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(126, 23);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 1;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(126, 66);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 20);
            this.lastNameInput.TabIndex = 2;
            // 
            // middleNameInput
            // 
            this.middleNameInput.Location = new System.Drawing.Point(126, 113);
            this.middleNameInput.Name = "middleNameInput";
            this.middleNameInput.Size = new System.Drawing.Size(100, 20);
            this.middleNameInput.TabIndex = 3;
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.Location = new System.Drawing.Point(126, 159);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberInput.TabIndex = 4;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(126, 205);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 20);
            this.addressInput.TabIndex = 5;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(54, 69);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Фамилия:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(56, 116);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.labelMiddleName.TabIndex = 7;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(17, 162);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(96, 13);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Номер телефона:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(72, 208);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 13);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Адрес:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(84, 254);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(96, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 310);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.middleNameInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.labelFirstName);
            this.Name = "AddPersonForm";
            this.Text = "Люди";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox middleNameInput;
        private System.Windows.Forms.TextBox phoneNumberInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button submitButton;
    }
}