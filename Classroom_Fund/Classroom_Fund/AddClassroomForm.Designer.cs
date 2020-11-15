namespace Classroom_Fund
{
    partial class AddClassroomForm
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
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.floorInput = new System.Windows.Forms.NumericUpDown();
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.capacityInput = new System.Windows.Forms.NumericUpDown();
            this.safetyInput = new System.Windows.Forms.CheckBox();
            this.responsibleP = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContactMN
            // 
            this.labelContactMN.AutoSize = true;
            this.labelContactMN.Location = new System.Drawing.Point(158, 192);
            this.labelContactMN.Name = "labelContactMN";
            this.labelContactMN.Size = new System.Drawing.Size(114, 13);
            this.labelContactMN.TabIndex = 37;
            this.labelContactMN.Text = "Ответственное лицо:";
            // 
            // labelContactLN
            // 
            this.labelContactLN.AutoSize = true;
            this.labelContactLN.Location = new System.Drawing.Point(85, 155);
            this.labelContactLN.Name = "labelContactLN";
            this.labelContactLN.Size = new System.Drawing.Size(207, 13);
            this.labelContactLN.TabIndex = 36;
            this.labelContactLN.Text = "Соответствие правилам безопасности:";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(112, 110);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(79, 13);
            this.labelCapacity.TabIndex = 35;
            this.labelCapacity.Text = "Вместимость:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(147, 63);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(44, 13);
            this.labelPhone.TabIndex = 34;
            this.labelPhone.Text = "Номер:";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(155, 20);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(36, 13);
            this.labelFloor.TabIndex = 28;
            this.labelFloor.Text = "Этаж:";
            // 
            // floorInput
            // 
            this.floorInput.Location = new System.Drawing.Point(204, 18);
            this.floorInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.floorInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.floorInput.Name = "floorInput";
            this.floorInput.Size = new System.Drawing.Size(100, 20);
            this.floorInput.TabIndex = 42;
            this.floorInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(204, 61);
            this.numberInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 20);
            this.numberInput.TabIndex = 43;
            // 
            // capacityInput
            // 
            this.capacityInput.Location = new System.Drawing.Point(204, 108);
            this.capacityInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.capacityInput.Name = "capacityInput";
            this.capacityInput.Size = new System.Drawing.Size(100, 20);
            this.capacityInput.TabIndex = 44;
            // 
            // safetyInput
            // 
            this.safetyInput.AutoSize = true;
            this.safetyInput.Location = new System.Drawing.Point(305, 155);
            this.safetyInput.Name = "safetyInput";
            this.safetyInput.Size = new System.Drawing.Size(15, 14);
            this.safetyInput.TabIndex = 45;
            this.safetyInput.UseVisualStyleBackColor = true;
            // 
            // responsibleP
            // 
            this.responsibleP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.responsibleP.FormattingEnabled = true;
            this.responsibleP.Location = new System.Drawing.Point(22, 223);
            this.responsibleP.Name = "responsibleP";
            this.responsibleP.Size = new System.Drawing.Size(364, 21);
            this.responsibleP.TabIndex = 46;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(150, 264);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 23);
            this.submitButton.TabIndex = 47;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 308);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.responsibleP);
            this.Controls.Add(this.safetyInput);
            this.Controls.Add(this.capacityInput);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.floorInput);
            this.Controls.Add(this.labelContactMN);
            this.Controls.Add(this.labelContactLN);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelFloor);
            this.Name = "AddClassroomForm";
            this.Text = "AddClassroomForm";
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelContactMN;
        private System.Windows.Forms.Label labelContactLN;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.NumericUpDown floorInput;
        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.NumericUpDown capacityInput;
        private System.Windows.Forms.CheckBox safetyInput;
        private System.Windows.Forms.ComboBox responsibleP;
        private System.Windows.Forms.Button submitButton;
    }
}