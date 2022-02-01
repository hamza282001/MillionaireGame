using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;

namespace MillionaireGame
{
    public partial class AddQuestion : UserControl
    {
        public AddQuestion()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel1, new object[] { true });

        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB ;Password=2001";
            if(QuestionData.Global.levelno == 1 ) 
            {
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand("select max(question_id) as TRI FROM level_one", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        List<object> list = (from row in dataTable.AsEnumerable() select (row["TRI"])).ToList();
                        Console.WriteLine(list.Count());
                        var o = list.Max();
                        int x = int.Parse(o.ToString()) + 1;
                        Console.WriteLine(x);
                        bunifuTextBox6.Text = x.ToString();
                    }
                }
            }

            else if (QuestionData.Global.levelno == 2)
            {
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand("select max(question_id) as TRI FROM level_two", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        List<object> list = (from row in dataTable.AsEnumerable() select (row["TRI"])).ToList();
                        Console.WriteLine(list.Count());
                        var o = list.Max();
                        int x = int.Parse(o.ToString()) + 1;
                        Console.WriteLine(x);
                        bunifuTextBox6.Text = x.ToString();
                    }
                }
            }

            else if (QuestionData.Global.levelno == 1)
            {
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand("select max(question_id) as TRI FROM level_three", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        List<object> list = (from row in dataTable.AsEnumerable() select (row["TRI"])).ToList();
                        Console.WriteLine(list.Count());
                        var o = list.Max();
                        int x = int.Parse(o.ToString()) + 1;
                        Console.WriteLine(x);
                        bunifuTextBox6.Text = x.ToString();
                    }
                }
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "" || bunifuTextBox2.Text == "" || bunifuTextBox3.Text == "" || bunifuTextBox4.Text == "" || bunifuTextBox6.Text == "" || bunifuTextBox7.Text == "" || bunifuTextBox8.Text == "")
            {
                MessageBox.Show("Please add complete details to continue.");
  
            }
            else
            {
                try
                {

                    string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB ;Password=2001";

                    if (QuestionData.Global.levelno == 1)
                    {

                        OracleConnection con = new OracleConnection(oradb);
                        con.Open();
                        String sql = "insert into level_one values('" + bunifuTextBox7.Text.Trim() + "','" + bunifuTextBox1.Text.Trim() + "','" + bunifuTextBox2.Text.Trim() + "','" + bunifuTextBox3.Text.Trim() + "','" + bunifuTextBox4.Text.Trim() + "','" + bunifuTextBox5.Text.Trim() + "','" + bunifuTextBox8.Text.Trim()+ "','" + bunifuTextBox6.Text.Trim() + "')";

                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = sql;
                        cmd.Connection = con;
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated == 0)
                        {
                            MessageBox.Show("Record not inserted");
                        }
                        else
                        {
                            MessageBox.Show("Question has been added to the level succesfully.");
                        }
                        cmd.Dispose();
                        con.Close();
                        bunifuTextBox1.Clear();
                        bunifuTextBox2.Clear();
                        bunifuTextBox3.Clear();
                        bunifuTextBox4.Clear();
                        bunifuTextBox6.Clear();
                        bunifuTextBox7.Clear();
                        bunifuTextBox8.Clear();
                        bunifuTextBox5.Clear();
                        Hide();
                    }

                    else if (QuestionData.Global.levelno == 2)
                    {

                        OracleConnection con = new OracleConnection(oradb);
                        con.Open();
                        String sql = "insert into level_two values('" + bunifuTextBox7.Text.Trim() + "','" + bunifuTextBox1.Text.Trim() + "','" + bunifuTextBox2.Text.Trim() + "','" + bunifuTextBox3.Text.Trim() + "','" + bunifuTextBox4.Text.Trim() + "','" + bunifuTextBox5.Text.Trim() + "','" + bunifuTextBox8.Text.Trim() + "','" + bunifuTextBox6.Text.Trim() + "')";

                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = sql;
                        cmd.Connection = con;
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated == 0)
                        {
                            MessageBox.Show("Record not inserted");
                        }
                        else
                        {
                            MessageBox.Show("Question has been added to the level succesfully.");
                        }
                        cmd.Dispose();
                        con.Close();
                        bunifuTextBox1.Clear();
                        bunifuTextBox2.Clear();
                        bunifuTextBox3.Clear();
                        bunifuTextBox4.Clear();
                        bunifuTextBox6.Clear();
                        bunifuTextBox7.Clear();
                        bunifuTextBox8.Clear();
                        bunifuTextBox5.Clear();
                        Hide();
                    }

                    else if (QuestionData.Global.levelno == 3)
                    {

                        OracleConnection con = new OracleConnection(oradb);
                        con.Open();
                        String sql = "insert into level_three values('" + bunifuTextBox7.Text.Trim() + "','" + bunifuTextBox1.Text.Trim() + "','" + bunifuTextBox2.Text.Trim() + "','" + bunifuTextBox3.Text.Trim() + "','" + bunifuTextBox4.Text.Trim() + "','" + bunifuTextBox5.Text.Trim() + "','" + bunifuTextBox8.Text.Trim() + "','" + bunifuTextBox6.Text.Trim() + "')";

                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = sql;
                        cmd.Connection = con;
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated == 0)
                        {
                            MessageBox.Show("Record not inserted");
                        }
                        else
                        {
                            MessageBox.Show("Question has been added to the level succesfully.");
                        }
                        cmd.Dispose();
                        con.Close();
                        bunifuTextBox1.Clear();
                        bunifuTextBox2.Clear();
                        bunifuTextBox3.Clear();
                        bunifuTextBox4.Clear();
                        bunifuTextBox6.Clear();
                        bunifuTextBox7.Clear();
                        bunifuTextBox8.Clear();
                        bunifuTextBox5.Clear();
                        Hide();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

             }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
