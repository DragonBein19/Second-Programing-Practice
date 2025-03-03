using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Programing_Practice__SPP_
{
    public partial class LoginFromSPP : Form
    {
        private string loginUser;
        private string passUser;

        private DB db = new DB();
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public LoginFromSPP()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            loginUser = LoginTextBox.Text;
            passUser = PasswordTextBox.Text;

            MySqlCommand command = new MySqlCommand("SELECT `status` FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP",MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0) { MySqlStatucCheck(command); } else { MessageBox.Show("no"); }
        }

        private void MySqlStatucCheck(MySqlCommand command)
        {
            db.openConnection();
            object result = command.ExecuteScalar();

            switch(result)
            {
                case "student":
                    Stud_From student_form = new Stud_From();
                    student_form.Give_Data(loginUser);
                    student_form.ShowDialog();
                    break;
                case "teacher":
                    
                    Teacher_Form teacher_form = new Teacher_Form();
                    teacher_form.DataGiven(loginUser);
                    teacher_form.ShowDialog();
                    break;
                case "admin":
                    Administrator_Form administrator_form = new Administrator_Form();
                    administrator_form.ShowDialog();
                    break;
            }

            db.closeConnection();
        }
    }
}
