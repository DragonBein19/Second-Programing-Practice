using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Programing_Practice__SPP_
{
    internal class Adding_a_new_user
    {
        private string LoginText, PasswordText, StatusText;
        private int NaOM_Grade, OOP_Grade, M_Grade, DD_Grade, R_Grade, IS_Grade;

        public void Set_Data_studentresults(int NaOM_Grade, int OOP_Grade, int M_Grade, int DD_Grade, int R_Grade, int IS_Grade)
        {
            this.NaOM_Grade = NaOM_Grade;
            this.OOP_Grade = OOP_Grade;
            this.M_Grade = M_Grade;
            this.DD_Grade = DD_Grade;
            this.R_Grade = R_Grade;
            this.IS_Grade = IS_Grade;
        }

        public void Set_Data_Users(string LoginText, string PasswordText, string StatusText)
        {
            this.LoginText = LoginText;
            this.PasswordText = PasswordText;
            this.StatusText = StatusText;
        }

        public void Data_Update(string SQLcommand_for_users, string SQLcommand_for_studentsresults, DB db)
        {
            Add_new_users(SQLcommand_for_users, db);
            if(StatusText == "student") { Add_new_studentsresults(SQLcommand_for_studentsresults, db); }
        }
        
        private void Add_new_users(string SQLcommand, DB db)
        {

            db.openConnection();
            MySqlCommand command = new MySqlCommand(SQLcommand, db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginText;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordText;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = StatusText;

            command.ExecuteNonQuery();
            db.closeConnection();
        }

        private void Add_new_studentsresults(string SQLcommand, DB db)
        {
            db.openConnection();
            MySqlCommand command = new MySqlCommand(SQLcommand, db.getConnection());
            try
            {
                command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginText;
                command.Parameters.Add("@N_a_o_M", MySqlDbType.Int32).Value = NaOM_Grade;
                command.Parameters.Add("@O_O_P", MySqlDbType.Int32).Value = OOP_Grade;
                command.Parameters.Add("@M", MySqlDbType.Int32).Value = M_Grade;
                command.Parameters.Add("@D_D", MySqlDbType.Int32).Value = DD_Grade;
                command.Parameters.Add("@R", MySqlDbType.Int32).Value = R_Grade;
                command.Parameters.Add("@I_S", MySqlDbType.Int32).Value = IS_Grade;
            }
            catch
            {
                command.Parameters.AddWithValue("@Login", LoginText);
                command.Parameters.AddWithValue("@N_a_o_M", 0);
                command.Parameters.AddWithValue("@O_O_P", 0);
                command.Parameters.AddWithValue("@M", 0);
                command.Parameters.AddWithValue("@D_D", 0);
                command.Parameters.AddWithValue("@R", 0);
                command.Parameters.AddWithValue("@I_S", 0);
            }

            command.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
