using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace MillionaireGame
{
    public partial class MainMenu : Form
    {
        public static string username = "";
        public static string email = "";
        public static string friend_email = "";
        public static string id = "";
        public static string acc_no = "";

        public MainMenu()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, MainMenuPanel, new object[] { true });

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {


        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            if (bunifuTextBox1.Text != "" && bunifuTextBox6.Text != ""  && bunifuTextBox2.Text != "" && bunifuTextBox5.Text != "" && bunifuTextBox2.Text.Contains('@') && bunifuTextBox2.Text.Contains('.') && bunifuTextBox5.Text.Contains('@') && bunifuTextBox5.Text.Contains('.')) 
            {
                try
                {
                    Guid guid = Guid.NewGuid();
                    string str = guid.ToString();

                    username = bunifuTextBox1.Text;
                    email = bunifuTextBox2.Text;
                    friend_email = bunifuTextBox5.Text;
                    acc_no = bunifuTextBox6.Text;
                    id = str;

                    string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                    OracleConnection con = new OracleConnection(oradb);
                    con.Open();
                    string sql = "insert into players(player_id, player_name, player_email, player_accno, friend_email) values('" + id + "','" + username + "','" + email + "','" + acc_no + "','" + friend_email + "')";
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    SelectAudience myForm = new SelectAudience();
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    MainMenuPanel.Controls.Clear();
                    MainMenuPanel.Controls.Add(myForm);
                    myForm.Show();

                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't authenticate! Please re-enter credentials. ");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid credentials.");
            }
        }

        private void bunifuTileButton3_Click_1(object sender, EventArgs e)
        {

            if (bunifuTextBox4.Text != "" && bunifuTextBox3.Text != "" && bunifuTextBox4.Text.Contains('@') && bunifuTextBox4.Text.Contains('.'))
            {
                try
                {
                    string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                    OracleConnection conn = new OracleConnection(oradb);
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select admin_email, admin_password from admin where admin_email = '" + bunifuTextBox4.Text + "' and admin_password = '" + bunifuTextBox3.Text + "'";
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        AdminMenu myForm = new AdminMenu();
                        myForm.TopLevel = false;
                        myForm.AutoScroll = true;
                        MainMenuPanel.Controls.Clear();
                        MainMenuPanel.Controls.Add(myForm);
                        myForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid credentials.");
                    }
                    cmd.Dispose();
                    conn.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't authenticate! Please re-enter credentials. ");
                }
            }
            else 
            {
                MessageBox.Show("Please enter valid credentials.");
            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            InstructionMenu myForm = new InstructionMenu();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            MainMenuPanel.Controls.Clear();
            MainMenuPanel.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
