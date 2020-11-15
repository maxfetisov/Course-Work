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
    public partial class AddActOfRentingForm : Form
    {
        private long id;
        private bool mode;
        private classroom_fundEntities context;
        public AddActOfRentingForm(string connectionString)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            firmCB.DataSource = (from fr in context.firm
                                 select fr.name + ";" + fr.contact_phone_number + ";" + fr.contact_first_name + ";" + fr.contact_last_name + ";" + fr.contact_middle_name).ToList();
            firmCB.SelectedItem = null;
            submitButton.Text = "Добавить";
            mode = true;
        }
        public AddActOfRentingForm(string connectionString, long id)
        {
            InitializeComponent();
            context = new classroom_fundEntities(connectionString);
            firmCB.DataSource = (from fr in context.firm
                                 select fr.name + ";" + fr.contact_phone_number + ";" + fr.contact_first_name + ";" + fr.contact_last_name + ";" + fr.contact_middle_name).ToList();
            firmCB.SelectedItem = null;
            this.id = id;
            act_of_renting a = context.act_of_renting.Find(id);
            floorInput.Value = a.floor_number;
            startSateDTP.Value = a.start_date;
            endDateDTP.Value = a.end_date;
            sumInput.Value = a.sum_of_money;
            string f = (from fr in context.firm
                        where fr.id == a.firm_id
                        select fr.name + ";" + fr.contact_phone_number + ";" + fr.contact_first_name + ";" + fr.contact_last_name + ";" + fr.contact_middle_name).FirstOrDefault();
            foreach (string item in firmCB.Items)
                if (f == item)
                    firmCB.SelectedItem = item;
            submitButton.Text = "Изменить";
            mode = false;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (firmCB.SelectedItem != null)
            {
                if (!mode)
                {
                    try
                    {
                        string[] name = firmCB.SelectedItem.ToString().Split(';');
                        string fname = name[0];
                        string phone = name[1];
                        string cnamef = name[2];
                        string cnamel = name[3];
                        string cnamem = name[4];
                        long idFirm = (from f in context.firm
                                       where f.name == fname
                                       && f.contact_phone_number == phone
                                       && f.contact_first_name == cnamef
                                       && f.contact_last_name == cnamel
                                       && f.contact_middle_name == cnamem
                                       select f.id).FirstOrDefault();
                        context.act_of_renting.Find(id).Update(new act_of_renting(idFirm, (byte)floorInput.Value, startSateDTP.Value, endDateDTP.Value, sumInput.Value));
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
                        string[] name = firmCB.SelectedItem.ToString().Split(';');
                        string fname = name[0];
                        string phone = name[1];
                        string cnamef = name[2];
                        string cnamel = name[3];
                        string cnamem = name[4];
                        long idFirm = (from f in context.firm
                                       where f.name == fname
                                       && f.contact_phone_number == phone
                                       && f.contact_first_name == cnamef
                                       && f.contact_last_name == cnamel
                                       && f.contact_middle_name == cnamem
                                       select f.id).FirstOrDefault();
                        context.act_of_renting.Add(new act_of_renting(idFirm, (byte)floorInput.Value, startSateDTP.Value, endDateDTP.Value, sumInput.Value));
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
