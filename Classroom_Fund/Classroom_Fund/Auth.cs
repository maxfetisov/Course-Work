using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Classroom_Fund
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            ServerInput.Text = "DESKTOP-PNOODSG\\SQLEXPRESS";
            DBInput.Text = "classroom_fund";
            loginInput.Text = "fma1";
            passwordInput.Text = "234";
        }

        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;
                if (windowsCheck.Checked)
                {
                    connectionString = $"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=\"data source={ServerInput.Text};initial catalog={DBInput.Text};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\"";
                }
                else
                {
                    connectionString = $"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=\"data source={ServerInput.Text};initial catalog={DBInput.Text};integrated security=False;User ID={loginInput.Text};Password={passwordInput.Text};MultipleActiveResultSets=True;App=EntityFramework\"";
                }
                try
                {
                    using (classroom_fundEntities context = new classroom_fundEntities(connectionString))
                    {
                        context.Database.Connection.Open();
                        context.Database.Connection.Close();
                    }
                }
                catch(SqlException)
                {
                    MessageBox.Show("Ошибка подкючения");
                    return;
                }
                Form1 form = new Form1(connectionString);
                form.Show();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения");
            }        
        }

        private void windowsCheck_CheckedChanged(object sender, EventArgs e)
        {
            passwordInput.Enabled = loginInput.Enabled = !windowsCheck.Checked;
        }
    }
}
