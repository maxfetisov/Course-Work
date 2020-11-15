namespace Classroom_Fund
{
    partial class AddFirmForm
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
            this.labelContactMN = new System.Windows.Forms.Label();
            this.labelContactLN = new System.Windows.Forms.Label();
            this.labelContactFN = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.contactMNInput = new System.Windows.Forms.TextBox();
            this.contactLNInput = new System.Windows.Forms.TextBox();
            this.contactFNInput = new System.Windows.Forms.TextBox();
            this.PhoneInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelContactMN
            // 
            this.labelContactMN.AutoSize = true;
            this.labelContactMN.Location = new System.Drawing.Point(52, 207);
            this.labelContactMN.Name = "labelContactMN";
            this.labelContactMN.Size = new System.Drawing.Size(150, 13);
            this.labelContactMN.TabIndex = 23;
            this.labelContactMN.Text = "Отчество контактного лица:";
            // 
            // labelContactLN
            // 
            this.labelContactLN.AutoSize = true;
            this.labelContactLN.Location = new System.Drawing.Point(42, 161);
            this.labelContactLN.Name = "labelContactLN";
            this.labelContactLN.Size = new System.Drawing.Size(160, 13);
            this.labelContactLN.TabIndex = 22;
            this.labelContactLN.Text = "Фамимлия контактного лица:";
            // 
            // labelContactFN
            // 
            this.labelContactFN.AutoSize = true;
            this.labelContactFN.Location = new System.Drawing.Point(77, 115);
            this.labelContactFN.Name = "labelContactFN";
            this.labelContactFN.Size = new System.Drawing.Size(125, 13);
            this.labelContactFN.TabIndex = 21;
            this.labelContactFN.Text = "Имя контактного лица:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(85, 68);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(117, 13);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "Контактный телефон:";
            // 
            // contactMNInput
            // 
            this.contactMNInput.Location = new System.Drawing.Point(215, 204);
            this.contactMNInput.Name = "contactMNInput";
            this.contactMNInput.Size = new System.Drawing.Size(100, 20);
            this.contactMNInput.TabIndex = 19;
            // 
            // contactLNInput
            // 
            this.contactLNInput.Location = new System.Drawing.Point(215, 158);
            this.contactLNInput.Name = "contactLNInput";
            this.contactLNInput.Size = new System.Drawing.Size(100, 20);
            this.contactLNInput.TabIndex = 18;
            // 
            // contactFNInput
            // 
            this.contactFNInput.Location = new System.Drawing.Point(215, 112);
            this.contactFNInput.Name = "contactFNInput";
            this.contactFNInput.Size = new System.Drawing.Size(100, 20);
            this.contactFNInput.TabIndex = 17;
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(215, 65);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.Size = new System.Drawing.Size(100, 20);
            this.PhoneInput.TabIndex = 16;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(215, 22);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 15;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(139, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = " Название:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(142, 249);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 24;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 294);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.labelContactMN);
            this.Controls.Add(this.labelContactLN);
            this.Controls.Add(this.labelContactFN);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.contactMNInput);
            this.Controls.Add(this.contactLNInput);
            this.Controls.Add(this.contactFNInput);
            this.Controls.Add(this.PhoneInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.labelName);
            this.Name = "AddFirmForm";
            this.Text = "AddFirmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelContactMN;
        private System.Windows.Forms.Label labelContactLN;
        private System.Windows.Forms.Label labelContactFN;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox contactMNInput;
        private System.Windows.Forms.TextBox contactLNInput;
        private System.Windows.Forms.TextBox contactFNInput;
        private System.Windows.Forms.TextBox PhoneInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button submitButton;
    }
}