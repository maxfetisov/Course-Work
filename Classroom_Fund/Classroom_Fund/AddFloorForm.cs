using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Fund
{
    public partial class AddFloorForm : Form
    {
        private classroom_fundEntities context;
        public AddFloorForm(string connectionString)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
        }
        public AddFloorForm(string connectionString, byte num)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            numberInput.Value = num;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (departmentInput.Text.Length > 0)
            {
                try
                {
                    context.floor.Add(new floor((byte)numberInput.Value, departmentInput.Text));
                    context.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (departmentInput.Text.Length > 0)
            {
                try
                {
                    context.floor.Find(numberInput.Value).Update(new floor((byte)numberInput.Value, departmentInput.Text));
                    context.SaveChanges();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка изменения: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void numberInput_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                floor f = context.floor.Find(numberInput.Value);
                if (f != null)
                {
                    numberInput.Value = f.number;
                    departmentInput.Text = f.department_name;
                    changeButton.Enabled = true;
                    addButton.Enabled = false;
                }
                else
                {
                    departmentInput.Text = "";
                    changeButton.Enabled = false;
                    addButton.Enabled = true;
                }
            }
            catch (Exception)
            {
                departmentInput.Text = "";
                changeButton.Enabled = false;
                addButton.Enabled = true;
            }
        }
    }
}
