using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Second_Programing_Practice__SPP_
{
    public partial class Administrator_Form : Form
    {
        //Classes used.
        private DB db = new DB();
        private DB_Update update = new DB_Update();
        private Adding_a_new_user NewUserAdding = new Adding_a_new_user();

        //Table's for storing data.
        private DataTable tableUsers = new DataTable();
        private DataTable tableStudentsresults = new DataTable();

        //Adapter's for storing, update and using data.
        private MySqlDataAdapter adapter_Users = new MySqlDataAdapter();
        private MySqlDataAdapter adapter_studentsresults = new MySqlDataAdapter();
        
        //Command's for select from data base and save to table's.
        private string command_DataSetUsersList = "SELECT * FROM `users`";
        private string command_DataSetStudentsresultsList = "SELECT * FROM `studentsresults`";
        //Command's for update to table's.
        private string command_UpdateDataUsersList = "UPDATE `users` SET `login` = @login, `pass` = @pass, `status` = @status WHERE `ID` = @ID";
        private string command_UpdateStudentsresultsList = "UPDATE `studentsresults` SET `N_a_O_M` = @NaOM, `O_O_P` = @OOP, `M` = @M, `D_D` = @DD, `R` = @R, `I_S` = @IS WHERE `ID` = @ID";
        //Command's for insert to table's.
        private string command_add_users = "INSERT INTO `users`(`login`, `pass`, `status`) VALUES (@login, @pass, @status)";
        private string command_add_studentsresults = "INSERT INTO `studentsresults`(`Login`, `N_a_O_M`, `O_O_P`, `M`, `D_D`, `R`, `I_S`) VALUES (@Login, @N_a_O_M, @O_O_P, @M, @D_D, @R, @I_S)";
        //Command's for delete from table's.
        private string commnad_delete_users = "DELETE FROM `users` WHERE `ID` = @ID";
        private string commnad_delete_studentsresults = "DELETE FROM `studentsresults` WHERE `ID` = @ID";

        //For testing.
        private int Table1Index, Table2Index;       //For saving choosing user.
        private string[] UsersTextboxs_Text = new string[4];
        private string[] studentresultsTextboxs_Text = new string[8];
        int NotEqualsNumbers = 0;   //Using in the cicle where need to check are there any similar meanings.

        public Administrator_Form()
        {
            InitializeComponent();
            table_Give_Data();
        }

        //Here we receive data from data base and save all data to table's.
        private void table_Give_Data()
        {
            tableUsers.Clear();
            tableStudentsresults.Clear();

            //Command tp saving user's and student's result's data.
            MySqlCommand Give_Users_table = new MySqlCommand(command_DataSetUsersList, db.getConnection());                         
            MySqlCommand Give_Studentsresults_table = new MySqlCommand(command_DataSetStudentsresultsList, db.getConnection());     
            
            //give to adapter out command
            adapter_Users.SelectCommand = Give_Users_table;
            adapter_studentsresults.SelectCommand = Give_Studentsresults_table;

            //Open and close connection with DB were we are writing in table's data from DB.
            db.openConnection();
            adapter_Users.Fill(tableUsers);
            adapter_studentsresults.Fill(tableStudentsresults);
            db.closeConnection();

            Filling_the_Users_list();
        }

        //Set active user's and add to list.
        private void Filling_the_Users_list()
        {
            //clearing active user's inteface table before filling the list anew.
            Users_list.Items.Clear();

            //Add all adctive user's to interface table without admin account. At the end we add a button to add a new user.
            for (int i = 0; i < tableUsers.Rows.Count; i++)
            { 
                if (tableUsers.Rows[i]["status"].ToString() != "admin") 
                { 
                    Users_list.Items.Add(tableUsers.Rows[i]["login"].ToString()); 
                } 
            }
            Users_list.Items.Add("Add new");        
        }

        //The method responsible for processing information about the selected user.
        private void Users_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if the new user button is pressed
            if (Users_list.SelectedItem.ToString() != "Add new")
            {
                //We check all users by login and display the required user data in the corresponding windows.
                LoginTextBox.Text = Users_list.SelectedItem.ToString();
                for (int i = 0; i < tableUsers.Rows.Count; i++)
                {
                    if (tableUsers.Rows[i]["login"].ToString() == Users_list.SelectedItem.ToString())
                    {
                        PasswordTextBox.Text = tableUsers.Rows[i]["pass"].ToString();
                        StatusTextBox.Text = tableUsers.Rows[i]["status"].ToString();

                        //We save the corresponding ID in the internal table for possible future manipulations
                        Table1Index = i;
                        i = 1000;
                    }
                }

                //We check if the rating table is linked to the user.
                for (int i = 0; i < tableStudentsresults.Rows.Count; i++)
                {
                    if (tableStudentsresults.Rows[i]["Login"].ToString() == Users_list.SelectedItem.ToString())
                    {
                        NaOM_textbox.Text = tableStudentsresults.Rows[i]["N_a_O_M"].ToString();
                        OOP_textbox.Text = tableStudentsresults.Rows[i]["O_O_P"].ToString();
                        M_textbox.Text = tableStudentsresults.Rows[i]["M"].ToString();
                        DD_textbox.Text = tableStudentsresults.Rows[i]["D_D"].ToString();
                        R_textbox.Text = tableStudentsresults.Rows[i]["R"].ToString();
                        IS_textbox.Text = tableStudentsresults.Rows[i]["I_S"].ToString();

                        Table2Index = i;
                        i = 1000;
                    }
                    else
                    {
                        NaOM_textbox.Text = null;
                        OOP_textbox.Text = null;
                        M_textbox.Text = null;
                        DD_textbox.Text = null;
                        R_textbox.Text = null;
                        IS_textbox.Text = null;
                    }
                }
            }
            else
            {
                LoginTextBox.Text = null;
                PasswordTextBox.Text = null;
                StatusTextBox.Text = null;
                NaOM_textbox.Text = null;
                OOP_textbox.Text = null;
                M_textbox.Text = null;
                DD_textbox.Text = null;
                R_textbox.Text = null;
                IS_textbox.Text = null;

                Table1Index = -1;
                Table2Index = -1;
            }         
        }

        //We update the data of the selected user by calling the update class.
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(Table1Index > -1 || Table2Index > -1)
            {
                //We save the data in an array (this is temporary), after which we pass it along with the rest of the corresponding data to the update class.
                Set_String_Array();
                update.GetDataForUpdate(tableUsers, tableStudentsresults, Table1Index, Table2Index, studentresultsTextboxs_Text, UsersTextboxs_Text);
                update.GetSqlCommand(command_UpdateDataUsersList, command_UpdateStudentsresultsList);
                update.Call_Update_Class();
            }

            //We call this method to update internal data tables.
            table_Give_Data();
        }

        //The method responsible for deleting data from the database.
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            MySqlCommand commandUsersDelete = new MySqlCommand(commnad_delete_users, db.getConnection());
            MySqlCommand commandStudentsresultsDelete = new MySqlCommand(commnad_delete_studentsresults, db.getConnection());

            db.openConnection();
            //Depending on whether we have a teacher account or a student account, we call different tables to delete data.
            switch (tableUsers.Rows[Table1Index]["status"].ToString())
            {
                case "student":

                    commandUsersDelete.Parameters.AddWithValue("@ID", Convert.ToInt32(tableUsers.Rows[Table1Index]["ID"]));
                    commandStudentsresultsDelete.Parameters.AddWithValue("@ID", Convert.ToInt32(tableStudentsresults.Rows[Table2Index]["ID"]));

                    commandUsersDelete.ExecuteNonQuery();
                    commandStudentsresultsDelete.ExecuteNonQuery();

                    break;
                case "teacher":
                    commandUsersDelete.Parameters.AddWithValue("@ID", Convert.ToInt32(tableUsers.Rows[Table1Index]["ID"]));

                    commandUsersDelete.ExecuteNonQuery();
                    break;
            }
            db.closeConnection();

            //We call this method to update internal data tables.
            table_Give_Data();
        }

        //Add new user in database
        private void Add_Button_Click(object sender, EventArgs e)
        {
            //This cycle will check if there is a similar user with the same name.
            for (int i = 0; i < tableUsers.Rows.Count; i++)     
            {
                if (tableUsers.Rows[i]["login"].ToString() != LoginTextBox.Text.ToString()) { NotEqualsNumbers++; }
            }

            //If there is no similar user, then we add a new line to the database using this cycle.
            if (tableUsers.Rows.Count == NotEqualsNumbers)      
            {
                NewUserAdding.Set_Data_Users(LoginTextBox.Text.ToString(), PasswordTextBox.Text.ToString(), StatusTextBox.Text.ToString());
                if ("student" == StatusTextBox.Text.ToString())
                {
                    NewUserAdding.Set_Data_studentresults(Convert.ToInt32(NaOM_textbox.Text), Convert.ToInt32(OOP_textbox.Text), Convert.ToInt32(M_textbox.Text), Convert.ToInt32(DD_textbox.Text), Convert.ToInt32(R_textbox.Text), Convert.ToInt32(IS_textbox.Text));
                }
                NewUserAdding.Data_Update(command_add_users, command_add_studentsresults, db);
            }
            else
            {
                MessageBox.Show("This login is already in use");
            }

            //We call this method to update internal data tables.
            table_Give_Data();
        }

        //Method to save everything to data array.
        private void Set_String_Array()
        {
            UsersTextboxs_Text[0] = tableUsers.Rows[Table1Index]["ID"].ToString();
            UsersTextboxs_Text[1] = LoginTextBox.Text.ToString();
            UsersTextboxs_Text[2] = PasswordTextBox.Text.ToString();
            UsersTextboxs_Text[3] = StatusTextBox.Text.ToString();

            studentresultsTextboxs_Text[0] = tableStudentsresults.Rows[Table2Index]["ID"].ToString();
            studentresultsTextboxs_Text[1] = tableStudentsresults.Rows[Table2Index]["Login"].ToString();
            studentresultsTextboxs_Text[2] = NaOM_textbox.Text.ToString();
            studentresultsTextboxs_Text[3] = OOP_textbox.Text.ToString();
            studentresultsTextboxs_Text[4] = M_textbox.Text.ToString();
            studentresultsTextboxs_Text[5] = DD_textbox.Text.ToString();
            studentresultsTextboxs_Text[6] = R_textbox.Text.ToString();
            studentresultsTextboxs_Text[7] = IS_textbox.Text.ToString();
        }
    }
}
