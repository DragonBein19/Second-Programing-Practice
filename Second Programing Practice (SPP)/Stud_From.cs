using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Programing_Practice__SPP_
{
    public partial class Stud_From : Form
    {

        private string login;

        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private string command1_text = "SELECT * FROM `studentsresults` WHERE `Login` = @L";

        public Stud_From()
        {
            InitializeComponent();
        }

        public void Give_Data(string login)
        {
            this.login = login;
            GridShowData();
        }

        private void GridShowData()
        {
            MySqlCommand Command1 = new MySqlCommand(command1_text, db.getConnection());
            Command1.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = Command1;
            adapter.Fill(table);

            NaOM_TextBox.Text = table.Rows[0]["N_a_O_M"].ToString();
            OOP_TextBox.Text = table.Rows[0]["O_O_P"].ToString();
            M_TextBox.Text = table.Rows[0]["M"].ToString();
            DD_TeztBox.Text = table.Rows[0]["D_D"].ToString();
            R_TextBox.Text = table.Rows[0]["R"].ToString();
            IS_TextBox.Text = table.Rows[0]["I_S"].ToString();
        }
    }
}
