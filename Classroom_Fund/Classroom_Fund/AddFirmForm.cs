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
    public partial class AddFirmForm : Form
    {
        private long id;
        private bool mode;
        private classroom_fundEntities context;
        public AddFirmForm(string connectionString)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            submitButton.Text = "Добавить";
            mode = true;
        }
        public AddFirmForm(string connectionString, long id)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            this.id = id;
            firm f = context.firm.Find(id);
            nameInput.Text = f.name;
            PhoneInput.Text = f.contact_phone_number;
            contactFNInput.Text = f.contact_first_name;
            contactLNInput.Text = f.contact_last_name;
            contactMNInput.Text = f.contact_middle_name;
            submitButton.Text = "Изменить";
            mode = false;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Length > 0 && contactFNInput.Text.Length > 0 && contactLNInput.Text.Length > 0 && contactMNInput.Text.Length > 0 && PhoneInput.Text.Length > 0)
            {
                if (!mode)
                {
                    try
                    {
                        context.firm.Find(id).Update(new firm(nameInput.Text, PhoneInput.Text, contactFNInput.Text, contactLNInput.Text, contactMNInput.Text));
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
                        context.firm.Add(new firm(nameInput.Text, PhoneInput.Text, contactFNInput.Text, contactLNInput.Text, contactMNInput.Text));
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
                MessageBox.Show("Некорректные данные");
            }
        }
    }
}
