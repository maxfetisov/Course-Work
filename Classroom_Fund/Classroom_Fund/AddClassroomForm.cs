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
    public partial class AddClassroomForm : Form
    {
        private long id;
        private bool mode;
        private classroom_fundEntities context;
        public AddClassroomForm(string connectionString)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            responsibleP.DataSource =   (from p in context.person
                                        select p.first_name + ";" + p.last_name + ";" + p.middle_name + ";" + p.phone_number + ";" + p.address).ToList();
            responsibleP.SelectedItem = null;
            submitButton.Text = "Добавить";
            mode = true;
        }
        public AddClassroomForm(string connectionString, long id)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            responsibleP.DataSource = (from p in context.person
                                       select p.first_name + ";" + p.last_name + ";" + p.middle_name + ";" + p.phone_number + ";" + p.address).ToList();
            responsibleP.SelectedItem = null;
            this.id = id;
            classroom c = context.classroom.Find(id);
            floorInput.Value = c.floor_number;
            numberInput.Value = c.number;
            capacityInput.Value = c.capacity;
            safetyInput.Checked = c.compliance_with_safety_regulations;
            string pers = (from p in context.person
                           where p.id == c.responsible_person_id
                           select p.first_name + ";" + p.last_name + ";" + p.middle_name + ";" + p.phone_number + ";" + p.address).FirstOrDefault();
            foreach (string item in responsibleP.Items)
                if (pers == item)
                    responsibleP.SelectedItem = item;
            submitButton.Text = "Изменить";
            mode = false;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (responsibleP.SelectedItem != null)
            {
                if (!mode)
                {
                    try
                    {
                        string[] name = responsibleP.SelectedItem.ToString().Split(';');
                        string namef = name[0];
                        string namel = name[1];
                        string namem = name[2];
                        string phone = name[3];
                        string address = name[4];
                        long idPerson = (from p in context.person
                                         where p.first_name == namef
                                         && p.last_name == namel
                                         && p.middle_name == namem
                                         && p.phone_number == phone
                                         && p.address == address
                                         select p.id).FirstOrDefault();
                        context.classroom.Find(id).Update(new classroom((byte)floorInput.Value, idPerson, (short)numberInput.Value, (int)capacityInput.Value, safetyInput.Checked));
                        context.SaveChanges();
                        this.Close();
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
                        string[] name = responsibleP.SelectedItem.ToString().Split(';');
                        string namef = name[0];
                        string namel = name[1];
                        string namem = name[2];
                        string phone = name[3];
                        string address = name[4];
                        long idPerson = (from p in context.person
                                         where p.first_name == namef
                                         && p.last_name == namel
                                         && p.middle_name == namem
                                         && p.phone_number == phone
                                         && p.address == address
                                         select p.id).FirstOrDefault();
                        context.classroom.Add(new classroom((byte)floorInput.Value, idPerson, (short)numberInput.Value, (int)capacityInput.Value, safetyInput.Checked));
                        context.SaveChanges();
                        this.Close();
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
