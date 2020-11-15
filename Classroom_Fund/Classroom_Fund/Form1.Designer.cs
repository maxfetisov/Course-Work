namespace Classroom_Fund
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infoDGV = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.changeTable = new System.Windows.Forms.ToolStripComboBox();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.changeButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.floorMin = new System.Windows.Forms.NumericUpDown();
            this.floorMax = new System.Windows.Forms.NumericUpDown();
            this.labelFloor1 = new System.Windows.Forms.Label();
            this.labelFloor2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoDGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorMax)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDGV
            // 
            this.infoDGV.AllowUserToAddRows = false;
            this.infoDGV.AllowUserToDeleteRows = false;
            this.infoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDGV.Location = new System.Drawing.Point(0, 28);
            this.infoDGV.Name = "infoDGV";
            this.infoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infoDGV.Size = new System.Drawing.Size(800, 423);
            this.infoDGV.TabIndex = 0;
            this.infoDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infoDGV_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTable,
            this.AddButton,
            this.changeButton,
            this.deleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // changeTable
            // 
            this.changeTable.AutoCompleteCustomSource.AddRange(new string[] {
            "Выборка",
            "Аудитории",
            "Этажи",
            "Компании",
            "Люди",
            "Акты аренды"});
            this.changeTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeTable.Items.AddRange(new object[] {
            "Аудитории",
            "Этажи",
            "Компании",
            "Люди",
            "Акты аренды"});
            this.changeTable.Name = "changeTable";
            this.changeTable.Size = new System.Drawing.Size(121, 25);
            this.changeTable.SelectedIndexChanged += new System.EventHandler(this.changeTable_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(103, 22);
            this.AddButton.Text = "Добавить запись";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeButton.Image = ((System.Drawing.Image)(resources.GetObject("changeButton.Image")));
            this.changeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(105, 22);
            this.changeButton.Text = "Изменить запись";
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 22);
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // floorMin
            // 
            this.floorMin.Location = new System.Drawing.Point(647, 5);
            this.floorMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.floorMin.Name = "floorMin";
            this.floorMin.Size = new System.Drawing.Size(55, 20);
            this.floorMin.TabIndex = 2;
            this.floorMin.ValueChanged += new System.EventHandler(this.floorMin_ValueChanged);
            // 
            // floorMax
            // 
            this.floorMax.Location = new System.Drawing.Point(733, 5);
            this.floorMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.floorMax.Name = "floorMax";
            this.floorMax.Size = new System.Drawing.Size(55, 20);
            this.floorMax.TabIndex = 3;
            this.floorMax.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.floorMax.ValueChanged += new System.EventHandler(this.floorMax_ValueChanged);
            // 
            // labelFloor1
            // 
            this.labelFloor1.AutoSize = true;
            this.labelFloor1.Location = new System.Drawing.Point(596, 7);
            this.labelFloor1.Name = "labelFloor1";
            this.labelFloor1.Size = new System.Drawing.Size(45, 13);
            this.labelFloor1.TabIndex = 4;
            this.labelFloor1.Text = "Этаж: с";
            // 
            // labelFloor2
            // 
            this.labelFloor2.AutoSize = true;
            this.labelFloor2.Location = new System.Drawing.Point(708, 7);
            this.labelFloor2.Name = "labelFloor2";
            this.labelFloor2.Size = new System.Drawing.Size(19, 13);
            this.labelFloor2.TabIndex = 5;
            this.labelFloor2.Text = "до";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFloor2);
            this.Controls.Add(this.labelFloor1);
            this.Controls.Add(this.floorMax);
            this.Controls.Add(this.floorMin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.infoDGV);
            this.Name = "Form1";
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.infoDGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDGV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox changeTable;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton changeButton;
        private System.Windows.Forms.NumericUpDown floorMin;
        private System.Windows.Forms.NumericUpDown floorMax;
        private System.Windows.Forms.Label labelFloor1;
        private System.Windows.Forms.Label labelFloor2;
    }
}

