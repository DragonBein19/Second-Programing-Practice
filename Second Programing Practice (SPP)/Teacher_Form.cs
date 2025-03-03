using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class Teacher_Form : Form
    {
        private int selectedStudentID;

        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter Adapter = new MySqlDataAdapter();

        private string command_text = "SELECT * FROM `studentsresults`";
        private string command2_text = "UPDATE `studentsresults` SET `N_a_O_M` = @NaOM, `O_O_P` = @OOP, `M` = @M, `D_D` = @DD, `R` = @R, `I_S` = @IS WHERE `ID` = @ID";

        public Teacher_Form()
        {
            InitializeComponent();
        }

        public void DataGiven(string login)
        {
            MySqlCommand command = new MySqlCommand(command_text, db.getConnection());

            Adapter.SelectCommand = command;
            Adapter.Fill(table);

            ListUpdate();
        }

        private void ListUpdate()
        {
            Students_list.Items.Clear();

            for (int i = 0; i < table.Rows.Count; i++) { Students_list.Items.Add(table.Rows[i]["Login"].ToString()); }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            db.openConnection();

            MySqlCommand command2 = new MySqlCommand(command2_text, db.getConnection());

            table.Rows[this.selectedStudentID]["N_a_O_M"] = Convert.ToInt32(NaOM_TextBox.Text);
            table.Rows[this.selectedStudentID]["O_O_P"] = Convert.ToInt32(OOP_TextBox.Text);
            table.Rows[this.selectedStudentID]["M"] = Convert.ToInt32(M_TextBox.Text);
            table.Rows[this.selectedStudentID]["D_D"] = Convert.ToInt32(DD_TextBox.Text);
            table.Rows[this.selectedStudentID]["R"] = Convert.ToInt32(R_TextBox.Text);
            table.Rows[this.selectedStudentID]["I_S"] = Convert.ToInt32(IS_TextBox.Text);

            command2.Parameters.Add("@ID", MySqlDbType.UInt32).Value = table.Rows[this.selectedStudentID]["ID"];
            command2.Parameters.AddWithValue("@NaOM", table.Rows[this.selectedStudentID]["N_a_O_M"]);
            command2.Parameters.AddWithValue("@OOP", table.Rows[this.selectedStudentID]["O_O_P"]);
            command2.Parameters.AddWithValue("@M", table.Rows[this.selectedStudentID]["M"]);
            command2.Parameters.AddWithValue("@DD", table.Rows[this.selectedStudentID]["D_D"]);
            command2.Parameters.AddWithValue("@R", table.Rows[this.selectedStudentID]["R"]);
            command2.Parameters.AddWithValue("@IS", table.Rows[this.selectedStudentID]["I_S"]);

            command2.ExecuteNonQuery();
            db.closeConnection();
        }

        private void Students_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Login"].ToString() == Students_list.SelectedItem.ToString())
                {
                    NaOM_TextBox.Text = table.Rows[i]["N_a_O_M"].ToString();
                    OOP_TextBox.Text = table.Rows[i]["O_O_P"].ToString();
                    M_TextBox.Text = table.Rows[i]["M"].ToString();
                    DD_TextBox.Text = table.Rows[i]["D_D"].ToString();
                    R_TextBox.Text = table.Rows[i]["R"].ToString();
                    IS_TextBox.Text = table.Rows[i]["I_S"].ToString();
                }
            }
        }
    }
}
