namespace Classroom_Fund
{
    partial class AddFloorForm
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
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.departmentInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(114, 28);
            this.numberInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(176, 20);
            this.numberInput.TabIndex = 0;
            this.numberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberInput.ValueChanged += new System.EventHandler(this.numberInput_ValueChanged);
            // 
            // departmentInput
            // 
            this.departmentInput.Location = new System.Drawing.Point(114, 74);
            this.departmentInput.Name = "departmentInput";
            this.departmentInput.Size = new System.Drawing.Size(176, 20);
            this.departmentInput.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(157, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(10, 77);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(98, 13);
            this.labelDepartment.TabIndex = 3;
            this.labelDepartment.Text = "Название отдела:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(64, 30);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "Номер:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(76, 120);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // AddFloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 166);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.departmentInput);
            this.Controls.Add(this.numberInput);
            this.Name = "AddFloorForm";
            this.Text = "AddFloorForm";
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.TextBox departmentInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button changeButton;
    }
}