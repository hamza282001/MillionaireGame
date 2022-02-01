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
    public partial class SelectAudience : Form
    {
        int selection = 0;
        List<int> numberList = new List<int>();
        public SelectAudience()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel4, new object[] { true });

            audienceGallery();

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (selection == 3)
            {
                try
                {
                    string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";

                    OracleConnection conn = new OracleConnection(oradb);
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update players set aud_1 = '" + numberList[0] + "', aud_2 = '" + numberList[1] + "', aud_3 = '" + numberList[2] + "' where player_id = '" + MainMenu.id + "'";
                    int rowsUpdated = cmd.ExecuteNonQuery();

                    GameMenu myForm = new GameMenu();
                    myForm.TopLevel = false;
                    myForm.AutoScroll = true;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(myForm);
                    myForm.Show();
                }

                catch
                {
                    MessageBox.Show(" Error updating player data.");
                }
            }
            else 
            {
                MessageBox.Show("Please select 3 members from the audience.");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void audienceGallery()
        {
            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                
                
                // Audience 1
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "select * from audience where serial_no = 1"; 
                OracleDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                label1.Text = reader.GetString(1) + ", " + reader.GetValue(3).ToString();
                label3.Text = reader.GetString(2);
                label4.Text = "IQ: "+ reader.GetValue(4).ToString();

                OracleBlob imgBlob = reader.GetOracleBlob(5);
                byte[] imgBytes = new byte[imgBlob.Length];
                imgBlob.Read(imgBytes, 0, (int)imgBlob.Length);
                bunifuPictureBox1.Image = new Bitmap(imgBlob);

                // Audience 2
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select * from audience where serial_no = 2";
                OracleDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                label8.Text = reader2.GetString(1) + ", " + reader2.GetValue(3).ToString();
                label7.Text = reader2.GetString(2);
                label6.Text = "IQ: " + reader2.GetValue(4).ToString();

                OracleBlob imgBlob2 = reader2.GetOracleBlob(5);
                byte[] imgBytes2 = new byte[imgBlob2.Length];
                imgBlob2.Read(imgBytes2, 0, (int)imgBlob2.Length);
                bunifuPictureBox2.Image = new Bitmap(imgBlob2);

                // Audience 3
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "select * from audience where serial_no = 3";
                OracleDataReader reader3 = cmd3.ExecuteReader();
                reader3.Read();
                label12.Text = reader3.GetString(1) + ", " + reader3.GetValue(3).ToString();
                label11.Text = reader3.GetString(2);
                label10.Text = "IQ: " + reader3.GetValue(4).ToString();

                OracleBlob imgBlob3 = reader3.GetOracleBlob(5);
                byte[] imgBytes3 = new byte[imgBlob3.Length];
                imgBlob3.Read(imgBytes3, 0, (int)imgBlob3.Length);
                bunifuPictureBox3.Image = new Bitmap(imgBlob3);

                // Audience 4
                OracleCommand cmd4 = new OracleCommand();
                cmd4.Connection = conn;
                cmd4.CommandText = "select * from audience where serial_no = 4";
                OracleDataReader reader4 = cmd4.ExecuteReader();
                reader4.Read();
                label16.Text = reader4.GetString(1) + ", " + reader4.GetValue(3).ToString();
                label15.Text = reader4.GetString(2);
                label14.Text = "IQ: " + reader4.GetValue(4).ToString();

                OracleBlob imgBlob4 = reader4.GetOracleBlob(5);
                byte[] imgBytes4 = new byte[imgBlob4.Length];
                imgBlob4.Read(imgBytes4, 0, (int)imgBlob4.Length);
                bunifuPictureBox4.Image = new Bitmap(imgBlob4);

                // Audience 5
                OracleCommand cmd5 = new OracleCommand();
                cmd5.Connection = conn;
                cmd5.CommandText = "select * from audience where serial_no = 5";
                OracleDataReader reader5 = cmd5.ExecuteReader();
                reader5.Read();
                label20.Text = reader5.GetString(1) + ", " + reader5.GetValue(3).ToString();
                label19.Text = reader5.GetString(2);
                label18.Text = "IQ: " + reader5.GetValue(4).ToString();

                OracleBlob imgBlob5 = reader5.GetOracleBlob(5);
                byte[] imgBytes5 = new byte[imgBlob5.Length];
                imgBlob5.Read(imgBytes5, 0, (int)imgBlob5.Length);
                bunifuPictureBox5.Image = new Bitmap(imgBlob5);

                // Audience 6
                OracleCommand cmd6 = new OracleCommand();
                cmd6.Connection = conn;
                cmd6.CommandText = "select * from audience where serial_no = 6";
                OracleDataReader reader6 = cmd6.ExecuteReader();
                reader6.Read();
                label24.Text = reader6.GetString(1) + ", " + reader6.GetValue(3).ToString();
                label23.Text = reader6.GetString(2);
                label22.Text = "IQ: " + reader6.GetValue(4).ToString();

                OracleBlob imgBlob6 = reader6.GetOracleBlob(5);
                byte[] imgBytes6 = new byte[imgBlob6.Length];
                imgBlob6.Read(imgBytes6, 0, (int)imgBlob6.Length);
                bunifuPictureBox6.Image = new Bitmap(imgBlob6);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if(selection < 3)
            {
                numberList.Add(1);
                selection += 1;
                bunifuTileButton1.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton1.Enabled = false;

            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(2);
                selection += 1;
                bunifuTileButton2.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton2.Enabled = false;
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(3);
                selection += 1;
                bunifuTileButton3.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton3.Enabled = false;
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(4);
                selection += 1;
                bunifuTileButton4.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton4.Enabled = false;
            }
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(5);
                selection += 1;
                bunifuTileButton5.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton5.Enabled = false;
            }
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(6);
                selection += 1;
                bunifuTileButton6.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton6.Enabled = false;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
