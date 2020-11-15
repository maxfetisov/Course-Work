namespace Classroom_Fund
{
    partial class AddActOfRentingForm
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
            this.firmCB = new System.Windows.Forms.ComboBox();
            this.floorInput = new System.Windows.Forms.NumericUpDown();
            this.labelContactMN = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.startSateDTP = new System.Windows.Forms.DateTimePicker();
            this.endDateDTP = new System.Windows.Forms.DateTimePicker();
            this.sumInput = new System.Windows.Forms.NumericUpDown();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumInput)).BeginInit();
            this.SuspendLayout();
            // 
            // firmCB
            // 
            this.firmCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmCB.FormattingEnabled = true;
            this.firmCB.Location = new System.Drawing.Point(12, 224);
            this.firmCB.Name = "firmCB";
            this.firmCB.Size = new System.Drawing.Size(251, 21);
            this.firmCB.TabIndex = 61;
            // 
            // floorInput
            // 
            this.floorInput.Location = new System.Drawing.Point(132, 24);
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
            this.floorInput.Size = new System.Drawing.Size(120, 20);
            this.floorInput.TabIndex = 57;
            this.floorInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelContactMN
            // 
            this.labelContactMN.AutoSize = true;
            this.labelContactMN.Location = new System.Drawing.Point(109, 197);
            this.labelContactMN.Name = "labelContactMN";
            this.labelContactMN.Size = new System.Drawing.Size(61, 13);
            this.labelContactMN.TabIndex = 52;
            this.labelContactMN.Text = "Компания:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(75, 162);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(44, 13);
            this.labelSum.TabIndex = 51;
            this.labelSum.Text = "Сумма:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(27, 116);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(92, 13);
            this.labelEndDate.TabIndex = 50;
            this.labelEndDate.Text = "Дата окончания:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(45, 69);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(74, 13);
            this.labelStartDate.TabIndex = 49;
            this.labelStartDate.Text = "Дата начала:";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(83, 26);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(36, 13);
            this.labelFloor.TabIndex = 48;
            this.labelFloor.Text = "Этаж:";
            // 
            // startSateDTP
            // 
            this.startSateDTP.Location = new System.Drawing.Point(132, 63);
            this.startSateDTP.Name = "startSateDTP";
            this.startSateDTP.Size = new System.Drawing.Size(120, 20);
            this.startSateDTP.TabIndex = 63;
            // 
            // endDateDTP
            // 
            this.endDateDTP.Location = new System.Drawing.Point(132, 110);
            this.endDateDTP.Name = "endDateDTP";
            this.endDateDTP.Size = new System.Drawing.Size(120, 20);
            this.endDateDTP.TabIndex = 64;
            // 
            // sumInput
            // 
            this.sumInput.Location = new System.Drawing.Point(132, 160);
            this.sumInput.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.sumInput.Name = "sumInput";
            this.sumInput.Size = new System.Drawing.Size(120, 20);
            this.sumInput.TabIndex = 65;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(95, 269);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 66;
            this.submitButton.Text = " ";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddActOfRentingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 314);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.sumInput);
            this.Controls.Add(this.endDateDTP);
            this.Controls.Add(this.startSateDTP);
            this.Controls.Add(this.firmCB);
            this.Controls.Add(this.floorInput);
            this.Controls.Add(this.labelContactMN);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelFloor);
            this.Name = "AddActOfRentingForm";
            this.Text = "AddActOfRentingForm";
            ((System.ComponentModel.ISupportInitialize)(this.floorInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox firmCB;
        private System.Windows.Forms.NumericUpDown floorInput;
        private System.Windows.Forms.Label labelContactMN;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.DateTimePicker startSateDTP;
        private System.Windows.Forms.DateTimePicker endDateDTP;
        private System.Windows.Forms.NumericUpDown sumInput;
        private System.Windows.Forms.Button submitButton;
    }
}