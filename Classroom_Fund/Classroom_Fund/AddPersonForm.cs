using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_Fund
{
    public partial class AddPersonForm : Form
    {
        private long id;
        private bool mode;
        private classroom_fundEntities context;
        public AddPersonForm(string connectionString)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            submitButton.Text = "Добавить";
            mode = true;
        }
        public AddPersonForm(string connectionString, long id)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            this.id = id;
            person p = context.person.Find(id); 
            nameInput.Text = p.first_name;
            lastNameInput.Text = p.last_name;
            middleNameInput.Text = p.middle_name;
            phoneNumberInput.Text = p.phone_number;
            addressInput.Text = p.address;
            submitButton.Text = "Изменить";
            mode = false;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Length > 0 && lastNameInput.Text.Length > 0 && middleNameInput.Text.Length > 0 && phoneNumberInput.Text.Length > 0 && addressInput.Text.Length > 0)
            {
                if (!mode)
                {
                    try
                    {
                        context.person.Find(id).Update(new person(nameInput.Text, lastNameInput.Text, middleNameInput.Text, phoneNumberInput.Text, addressInput.Text));
                        context.SaveChanges();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка изменения: " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        context.person.Add(new person(nameInput.Text, lastNameInput.Text, middleNameInput.Text, phoneNumberInput.Text, addressInput.Text));
                        context.SaveChanges();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Некорретные данные");
            }
        }
    }
}