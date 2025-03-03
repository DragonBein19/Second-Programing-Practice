using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Second_Programing_Practice__SPP_
{
    internal class DB_Update
    {
        private DB db = new DB();
        private DataTable tableUsers, tableStudentsresults;
        private MySqlCommand Command_Users_Update, Command_Studentsresults_Update;

        private int tableUsers_index, tableStudentsresults_Index;
        private string[] Textboxs_text_studentresults = new string[8];
        private string[] Textboxs_text_Users = new string[4];
        
        public void Call_Update_Class()
        {
            try
            {
                UsersTableUpadate();
                if (Textboxs_text_Users[3] == "student") { StudentresultsUpdate(); }

                MessageBox.Show("Data was updated");
            }
            catch
            {
                MessageBox.Show("Error. Data not Updated");
            }
        }
        
        public void GetDataForUpdate(DataTable TableUsers, DataTable TableStudentsresults, int TableUsers_index, int TableStudentsresults_Index, string[] Textboxs_text_studentresults, string[] Textboxs_text_Users)
        {
            this.tableUsers = TableUsers;
            this.tableStudentsresults = TableStudentsresults;
            this.tableUsers_index = TableUsers_index;
            this.tableStudentsresults_Index = TableStudentsresults_Index;
            this.Textboxs_text_studentresults = Textboxs_text_studentresults;
            this.Textboxs_text_Users = Textboxs_text_Users;
        }

        public void GetSqlCommand(string CommandUsersUpdate, string CommandStudentsresultsUpdate)
        {
            Command_Users_Update = new MySqlCommand(CommandUsersUpdate, db.getConnection());
            Command_Studentsresults_Update = new MySqlCommand(CommandStudentsresultsUpdate, db.getConnection());
        }

        private void UsersTableUpadate()
        {
            try 
            {
                tableUsers.Rows[tableUsers_index]["login"] = Textboxs_text_Users[1];
                tableUsers.Rows[tableUsers_index]["pass"] = Textboxs_text_Users[2];
                tableUsers.Rows[tableUsers_index]["status"] = Textboxs_text_Users[3];

                Command_Users_Update.Parameters.AddWithValue("@ID", tableUsers.Rows[tableUsers_index]["ID"]);
                Command_Users_Update.Parameters.AddWithValue("@login", tableUsers.Rows[tableUsers_index]["login"]);
                Command_Users_Update.Parameters.AddWithValue("@pass", tableUsers.Rows[tableUsers_index]["pass"]);
                Command_Users_Update.Parameters.AddWithValue("@status", tableUsers.Rows[tableUsers_index]["status"]);
            }
            catch { MessageBox.Show("Data not updated! \nCheck Users table!"); }

            db.openConnection();
            Command_Users_Update.ExecuteNonQuery();           
            db.closeConnection();
        }

        private void StudentresultsUpdate()
        {       
            try
            {
                tableStudentsresults.Rows[tableStudentsresults_Index]["N_a_O_M"] = Textboxs_text_studentresults[2];
                tableStudentsresults.Rows[tableStudentsresults_Index]["O_O_P"] = Textboxs_text_studentresults[3];
                tableStudentsresults.Rows[tableStudentsresults_Index]["M"] = Textboxs_text_studentresults[4];
                tableStudentsresults.Rows[tableStudentsresults_Index]["D_D"] = Textboxs_text_studentresults[5];
                tableStudentsresults.Rows[tableStudentsresults_Index]["R"] = Textboxs_text_studentresults[6];
                tableStudentsresults.Rows[tableStudentsresults_Index]["I_S"] = Textboxs_text_studentresults[7];

                Command_Studentsresults_Update.Parameters.AddWithValue("@ID", tableStudentsresults.Rows[tableStudentsresults_Index]["ID"]);
                Command_Studentsresults_Update.Parameters.AddWithValue("@NaOM", tableStudentsresults.Rows[tableStudentsresults_Index]["N_a_O_M"]);
                Command_Studentsresults_Update.Parameters.AddWithValue("@OOP", tableStudentsresults.Rows[tableStudentsresults_Index]["O_O_P"]);
                Command_Studentsresults_Update.Parameters.AddWithValue("@M", tableStudentsresults.Rows[tableStudentsresults_Index]["M"]);
                Command_Studentsresults_Update.Parameters.AddWithValue("@DD", tableStudentsresults.Rows[tableStudentsresults_Index]["D_D"]);
                Command_Studentsresults_Update.Parameters.AddWithValue("@R", tableStudentsresults.Rows[tableStudentsresults_Index]["R"]);
                Command_Studentsresults_Update.Parameters.AddWithValue("@IS", tableStudentsresults.Rows[tableStudentsresults_Index]["I_S"]);
            }
            catch { MessageBox.Show("Data not updated! \nCheck studentresults table!"); }

            db.openConnection();
            Command_Studentsresults_Update.ExecuteNonQuery();          
            db.closeConnection();
        }
    }
}
