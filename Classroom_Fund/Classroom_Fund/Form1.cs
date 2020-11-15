using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Classroom_Fund
{
    public partial class Form1 : Form
    {
        private classroom_fundEntities context;
        private string connectionString;
        public Form1(string connectionString)
        {
            this.connectionString = connectionString;
            context = new classroom_fundEntities(connectionString);
            string a = context.Database.Connection.ConnectionString;
            InitializeComponent();
            changeTable.SelectedIndex = 0;
        }
        public void renderDGV()
        {
            changeTable_SelectedIndexChanged(new object(), new EventArgs());
        }
        private void changeTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (changeTable.SelectedIndex)
                {
                    case 0:
                        {
                            infoDGV.DataSource = (from c in context.classroom
                                                  join p in context.person on c.responsible_person_id equals p.id
                                                  select new { c.number, p.last_name, c.floor_number, c.capacity, c.compliance_with_safety_regulations }).ToList();
                            infoDGV.Columns[0].HeaderText = "Номер";
                            infoDGV.Columns[1].HeaderText = "Фамилия ответственного за аудиторию";
                            infoDGV.Columns[2].HeaderText = "Номер этажа";
                            infoDGV.Columns[3].HeaderText = "Вместительность";
                            infoDGV.Columns[4].HeaderText = "Соответствие правилам безопасности";
                            labelFloor1.Visible = false;
                            labelFloor2.Visible = false;
                            floorMin.Visible = false;
                            floorMax.Visible = false;
                            break;
                        }
                    case 1:
                        {
                            infoDGV.DataSource = (from f in context.floor
                                                  select new { f.number, f.department_name }).ToList();
                            infoDGV.Columns[0].HeaderText = "Номер";
                            infoDGV.Columns[1].HeaderText = "Название отдела";
                            labelFloor1.Visible = true;
                            labelFloor2.Visible = true;
                            floorMin.Visible = true;
                            floorMax.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            infoDGV.DataSource = (from f in context.firm
                                                  select new { f.name, f.contact_phone_number, f.contact_first_name, f.contact_last_name, f.contact_middle_name }).ToList();
                            infoDGV.Columns[0].HeaderText = "Название";
                            infoDGV.Columns[1].HeaderText = "Контактный телефон";
                            infoDGV.Columns[2].HeaderText = "Имя контактного лица";
                            infoDGV.Columns[3].HeaderText = "Фамилия контактного лица";
                            infoDGV.Columns[4].HeaderText = "Отчество контактного лица";
                            labelFloor1.Visible = false;
                            labelFloor2.Visible = false;
                            floorMin.Visible = false;
                            floorMax.Visible = false;
                            break;
                        }
                    case 3:
                        {
                            infoDGV.DataSource = (from p in context.person
                                                  select new { p.first_name, p.last_name, p.middle_name, p.phone_number, p.address }).ToList();
                            infoDGV.Columns[0].HeaderText = "Имя";
                            infoDGV.Columns[1].HeaderText = "Фаимилия";
                            infoDGV.Columns[2].HeaderText = "Отчество";
                            infoDGV.Columns[3].HeaderText = "Телефон";
                            infoDGV.Columns[4].HeaderText = "Адрес";
                            labelFloor1.Visible = false;
                            labelFloor2.Visible = false;
                            floorMin.Visible = false;
                            floorMax.Visible = false;
                            break;
                        }
                    case 4:
                        {
                            infoDGV.DataSource = (from a in context.act_of_renting
                                                  join f in context.firm on a.firm_id equals f.id
                                                  select new { f.name, a.floor_number, a.start_date, a.end_date, a.sum_of_money }).ToList();
                            infoDGV.Columns[0].HeaderText = "Название компании";
                            infoDGV.Columns[1].HeaderText = "Номер этажа";
                            infoDGV.Columns[2].HeaderText = "Дата начала";
                            infoDGV.Columns[3].HeaderText = "Дата окончания";
                            infoDGV.Columns[4].HeaderText = "Сумма оплаты";
                            labelFloor1.Visible = false;
                            labelFloor2.Visible = false;
                            floorMin.Visible = false;
                            floorMax.Visible = false;
                            break;
                        }
                    default:
                        {
                            throw new Exception("Выход за предел выбора таблиц");
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (changeTable.SelectedIndex)
                {
                    case 0:
                        {
                            AddClassroomForm form = new AddClassroomForm(connectionString);
                            form.FormClosed += changeTable_SelectedIndexChanged;
                            form.Show();
                            break;
                        }
                    case 1:
                        {
                            AddFloorForm form = new AddFloorForm(connectionString);
                            form.FormClosed += changeTable_SelectedIndexChanged;
                            form.Show();
                            break;
                        }
                    case 2:
                        {
                            AddFirmForm form = new AddFirmForm(connectionString);
                            form.FormClosed += changeTable_SelectedIndexChanged;
                            form.Show();
                            break;
                        }
                    case 3:
                        {
                            AddPersonForm form = new AddPersonForm(connectionString);
                            form.FormClosed += changeTable_SelectedIndexChanged;
                            form.Show();
                            break;
                        }
                    case 4:
                        {
                            AddActOfRentingForm form = new AddActOfRentingForm(connectionString);
                            form.FormClosed += changeTable_SelectedIndexChanged;
                            form.Show();
                            break;
                        }
                    default:
                        {
                            throw new Exception("Выход за предел выбора таблиц");
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            switch (changeTable.SelectedIndex)
            {
                case 0:
                    {
                        if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            for (int i = 0; i < infoDGV.SelectedRows.Count; i++)
                            {
                                short number = Convert.ToInt16(infoDGV.SelectedRows[i].Cells[0].Value);
                                byte floor = Convert.ToByte(infoDGV.SelectedRows[i].Cells[2].Value);
                                context.classroom.Remove(context.classroom.Find((from c in context.classroom
                                                                                 where c.number == number
                                                                                 && c.floor_number == floor
                                                                                 select c.id).FirstOrDefault()));
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            for (int i = 0; i < infoDGV.SelectedRows.Count; i++)
                            {
                                byte num = Convert.ToByte(infoDGV.SelectedRows[i].Cells[0].Value);
                                context.floor.Remove(context.floor.Find(num));
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            for (int i = 0; i < infoDGV.SelectedRows.Count; i++)
                            {
                                string name = infoDGV.SelectedRows[i].Cells[0].Value.ToString();
                                string phone = infoDGV.SelectedRows[i].Cells[1].Value.ToString();
                                string contactFN = infoDGV.SelectedRows[i].Cells[2].Value.ToString();
                                string contactLN = infoDGV.SelectedRows[i].Cells[3].Value.ToString();
                                string contactMN = infoDGV.SelectedRows[i].Cells[4].Value.ToString();
                                context.firm.Remove(context.firm.Find((from f in context.firm
                                                                       where f.name == name
                                                                       && f.contact_phone_number == phone
                                                                       && f.contact_first_name == contactFN
                                                                       && f.contact_last_name == contactLN
                                                                       && f.contact_middle_name == contactMN
                                                                       select f.id).FirstOrDefault()));
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту(и) запись(и)?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            for (int i = 0; i < infoDGV.SelectedRows.Count; i++)
                            {
                                string firstName = infoDGV.SelectedRows[i].Cells[0].Value.ToString();
                                string lastName = infoDGV.SelectedRows[i].Cells[1].Value.ToString();
                                string middleName = infoDGV.SelectedRows[i].Cells[2].Value.ToString();
                                context.person.Remove(context.person.Find((from p in context.person
                                                                           where p.first_name == firstName
                                                                           && p.last_name == lastName
                                                                           && p.middle_name == middleName
                                                                           select p.id).FirstOrDefault()));
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            for (int i = 0; i < infoDGV.SelectedRows.Count; i++)
                            {
                                string firmName = infoDGV.SelectedRows[i].Cells[0].Value.ToString();
                                byte floorNumber = Convert.ToByte(infoDGV.SelectedRows[i].Cells[1].Value);
                                DateTime startDate = Convert.ToDateTime(infoDGV.SelectedRows[i].Cells[2].Value);
                                DateTime endDate = Convert.ToDateTime(infoDGV.SelectedRows[i].Cells[3].Value);
                                decimal sum = Convert.ToDecimal(infoDGV.SelectedRows[i].Cells[4].Value);
                                context.act_of_renting.Remove(context.act_of_renting.Find((from aor in context.act_of_renting
                                                                                           join fr in context.firm on aor.firm_id equals fr.id
                                                                                           where fr.name == firmName
                                                                                           && aor.floor_number == floorNumber
                                                                                           && aor.start_date == startDate
                                                                                           && aor.end_date == endDate
                                                                                           && aor.sum_of_money == sum
                                                                                           select aor.id).FirstOrDefault()));
                            }
                        }
                        break;
                    }
                default:
                    {
                        throw new Exception("Выход за предел выбора таблиц");
                    }
            }
            context.SaveChanges();
            renderDGV();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            switch (changeTable.SelectedIndex)
            {
                case 0:
                    {
                        short number = Convert.ToInt16(infoDGV.SelectedRows[0].Cells[0].Value);
                        byte floor = Convert.ToByte(infoDGV.SelectedRows[0].Cells[2].Value);
                        AddClassroomForm form = new AddClassroomForm(connectionString, (from c in context.classroom
                                                                                        where c.number == number
                                                                                        && c.floor_number == floor
                                                                                        select c.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 1:
                    {
                        byte num = Convert.ToByte(infoDGV.SelectedRows[0].Cells[0].Value);
                        AddFloorForm form = new AddFloorForm(connectionString, num);
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 2:
                    {
                        string name = infoDGV.SelectedRows[0].Cells[0].Value.ToString();
                        string phone = infoDGV.SelectedRows[0].Cells[1].Value.ToString();
                        string contactFN = infoDGV.SelectedRows[0].Cells[2].Value.ToString();
                        string contactLN = infoDGV.SelectedRows[0].Cells[3].Value.ToString();
                        string contactMN = infoDGV.SelectedRows[0].Cells[4].Value.ToString();
                        AddFirmForm form = new AddFirmForm(connectionString, (from f in context.firm
                                                                              where f.name == name
                                                                              && f.contact_phone_number == phone
                                                                              && f.contact_first_name == contactFN
                                                                              && f.contact_last_name == contactLN
                                                                              && f.contact_middle_name == contactMN
                                                                              select f.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 3:
                    {
                        string firstName = infoDGV.SelectedRows[0].Cells[0].Value.ToString();
                        string lastName = infoDGV.SelectedRows[0].Cells[1].Value.ToString();
                        string middleName = infoDGV.SelectedRows[0].Cells[2].Value.ToString();
                        AddPersonForm form = new AddPersonForm(connectionString, (from p in context.person
                                                                                  where p.first_name == firstName
                                                                                  && p.last_name == lastName
                                                                                  && p.middle_name == middleName
                                                                                  select p.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 4:
                    {
                        string firmName = infoDGV.SelectedRows[0].Cells[0].Value.ToString();
                        byte floorNumber = Convert.ToByte(infoDGV.SelectedRows[0].Cells[1].Value);
                        DateTime startDate = Convert.ToDateTime(infoDGV.SelectedRows[0].Cells[2].Value);
                        DateTime endDate = Convert.ToDateTime(infoDGV.SelectedRows[0].Cells[3].Value);
                        decimal sum = Convert.ToDecimal(infoDGV.SelectedRows[0].Cells[4].Value);
                        AddActOfRentingForm form = new AddActOfRentingForm(connectionString, (from aor in context.act_of_renting
                                                                                              join fr in context.firm on aor.firm_id equals fr.id
                                                                                              where fr.name == firmName
                                                                                              && aor.floor_number == floorNumber
                                                                                              && aor.start_date == startDate
                                                                                              && aor.end_date == endDate
                                                                                              && aor.sum_of_money == sum
                                                                                              select aor.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                default:
                    {
                        throw new Exception("Выход за предел выбора таблиц");
                    }
            }
        }

        private void infoDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (changeTable.SelectedIndex)
            {
                case 0:
                    {
                        short number = Convert.ToInt16(infoDGV.Rows[e.RowIndex].Cells[0].Value);
                        byte floor = Convert.ToByte(infoDGV.Rows[e.RowIndex].Cells[2].Value);
                        AddClassroomForm form = new AddClassroomForm(connectionString, (from c in context.classroom
                                                                                        where c.number == number
                                                                                        && c.floor_number == floor
                                                                                        select c.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 1:
                    {
                        byte num = Convert.ToByte(infoDGV.SelectedRows[0].Cells[0].Value);
                        AddFloorForm form = new AddFloorForm(connectionString, num);
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 2:
                    {
                        string name = infoDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string phone = infoDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string contactFN = infoDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string contactLN = infoDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string contactMN = infoDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                        AddFirmForm form = new AddFirmForm(connectionString, (from f in context.firm
                                                                              where f.name == name
                                                                              && f.contact_phone_number == phone
                                                                              && f.contact_first_name == contactFN
                                                                              && f.contact_last_name == contactLN
                                                                              && f.contact_middle_name == contactMN
                                                                              select f.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 3:
                    {
                        string firstName = infoDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string lastName = infoDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string middleName = infoDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                        AddPersonForm form = new AddPersonForm(connectionString, (from p in context.person
                                                                                  where p.first_name == firstName
                                                                                  && p.last_name == lastName
                                                                                  && p.middle_name == middleName
                                                                                  select p.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                case 4:
                    {
                        string firmName = infoDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                        byte floorNumber = Convert.ToByte(infoDGV.Rows[e.RowIndex].Cells[1].Value);
                        DateTime startDate = Convert.ToDateTime(infoDGV.Rows[e.RowIndex].Cells[2].Value);
                        DateTime endDate = Convert.ToDateTime(infoDGV.Rows[e.RowIndex].Cells[3].Value);
                        decimal sum = Convert.ToDecimal(infoDGV.Rows[e.RowIndex].Cells[4].Value);
                        AddActOfRentingForm form = new AddActOfRentingForm(connectionString, (from aor in context.act_of_renting
                                                                                              join fr in context.firm on aor.firm_id equals fr.id
                                                                                              where fr.name == firmName
                                                                                              && aor.floor_number == floorNumber
                                                                                              && aor.start_date == startDate
                                                                                              && aor.end_date == endDate
                                                                                              && aor.sum_of_money == sum
                                                                                              select aor.id).FirstOrDefault());
                        form.FormClosed += changeTable_SelectedIndexChanged;
                        form.Show();
                        break;
                    }
                default:
                    {
                        throw new Exception("Выход за предел выбора таблиц");
                    }
            }
        }

        private void floorMin_ValueChanged(object sender, EventArgs e)
        {
            FloorUpdate();
        }

        private void floorMax_ValueChanged(object sender, EventArgs e)
        {
            FloorUpdate();
        }
        private void FloorUpdate() 
        {
            infoDGV.DataSource = context.floor.SqlQuery($"exec floor_range {floorMin.Value}, {floorMax.Value}").ToList();
            infoDGV.Columns[2].Visible = infoDGV.Columns[3].Visible = false;
        }
    }
}
