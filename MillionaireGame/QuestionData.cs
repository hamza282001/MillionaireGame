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
    public partial class QuestionData : Form
    {
        public class Global
        {
            public static int levelno = 0;
        }

        public QuestionData()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, addQuestion1, new object[] { true });
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Global.levelno = 1;
            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand("select question_id as ID, question as QUESTION, option_1 as OPTIONA, option_2 as OPTIONB, option_3 as OPTIONC, option_4 as OPTIOND, cor_ans as ANSWER, qtype as TYPE from level_one", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        bunifuDataGridView1.DataSource = dataTable;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Global.levelno = 3;
            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand("select question_id as ID, question as QUESTION, option_1 as OPTIONA, option_2 as OPTIONB, option_3 as OPTIONC, option_4 as OPTIOND, cor_ans as ANSWER, qtype as TYPE from level_three", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        bunifuDataGridView1.DataSource = dataTable;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuestionData_Load(object sender, EventArgs e)
        {
            Global.levelno = 1;
            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand("select question_id as ID, question as QUESTION, option_1 as OPTIONA, option_2 as OPTIONB, option_3 as OPTIONC, option_4 as OPTIOND, cor_ans as ANSWER, qtype as TYPE from level_one", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        bunifuDataGridView1.DataSource = dataTable;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Global.levelno = 2;
            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                using (OracleConnection conn = new OracleConnection(oradb))
                using (OracleCommand cmd = new OracleCommand("select question_id as ID, question as QUESTION, option_1 as OPTIONA, option_2 as OPTIONB, option_3 as OPTIONC, option_4 as OPTIOND, cor_ans as ANSWER, qtype as TYPE from level_two", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        bunifuDataGridView1.DataSource = dataTable;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            // To delete a vehicle.
            try
            {
                if (Global.levelno == 1) {
                    if (bunifuDataGridView1.RowCount == 1)
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                    else
                    {
                        string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB ;Password=2001";
                        OracleConnection oraconn = new OracleConnection(oradb);
                        OracleCommand oracomm = new OracleCommand("delete from level_one where question_id= '" + bunifuDataGridView1.CurrentRow.Cells["ID"].Value + "'", oraconn);
                        oraconn.Open();
                        oracomm.ExecuteNonQuery();
                    }
                }

                else if (Global.levelno == 2) {
                    if (bunifuDataGridView1.RowCount == 1)
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                    else
                    {
                        string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB ;Password=2001";
                        OracleConnection oraconn = new OracleConnection(oradb);
                        OracleCommand oracomm = new OracleCommand("delete from level_two where question_id= '" + bunifuDataGridView1.CurrentRow.Cells["ID"].Value + "'", oraconn);
                        oraconn.Open();
                        oracomm.ExecuteNonQuery();
                    }
                }

                else if (Global.levelno == 3) {
                    if (bunifuDataGridView1.RowCount == 1)
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                    else
                    {
                        string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB ;Password=2001";
                        OracleConnection oraconn = new OracleConnection(oradb);
                        OracleCommand oracomm = new OracleCommand("delete from level_three where question_id= '" + bunifuDataGridView1.CurrentRow.Cells["ID"].Value + "'", oraconn);
                        oraconn.Open();
                        oracomm.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Child Found! Cannot delete item.");
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            addQuestion1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
