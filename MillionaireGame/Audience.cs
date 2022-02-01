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
    public partial class Audience : Form
    {
        public Audience()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Audience_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select aud_1,aud_2,aud_3 from players where player_id ='"+ MainMenu.id +"'";
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int audience_1 = reader.GetInt32(0);
            int audience_2 = reader.GetInt32(1);
            int audience_3 = reader.GetInt32(2);
            cmd.Dispose();
            conn.Close();

            if(audience_1 == 1)
            {
                James();
            }
            else if(audience_1 == 2)
            {
                Sarah();
            }
            else if (audience_1 == 3)
            {
                Osama();
            }
            else if (audience_1 == 4)
            {
                Omer();
            }
            else if (audience_1 == 5)
            {
                Zayd();
            }
            else
            {
                JCole();
            }

            if (audience_2 == 1)
            {
                James();
            }
            else if (audience_2 == 2)
            {
                Sarah();
            }
            else if (audience_2 == 3)
            {
                Osama();
            }
            else if (audience_2 == 4)
            {
                Omer();
            }
            else if (audience_2 == 5)
            {
                Zayd();
            }
            else
            {
                JCole();
            }


            if (audience_3 == 1)
            {
                James();
            }
            else if (audience_3 == 2)
            {
                Sarah();
            }
            else if (audience_3 == 3)
            {
                Osama();
            }
            else if (audience_3 == 4)
            {
                Omer();
            }
            else if (audience_3 == 5)
            {
                Zayd();
            }
            else
            {
                JCole();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void James()
        {
            if (GameMenu.question_type == "Physics" || GameMenu.question_type == "GK")
            {
                if (label4.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label1.Text = "James";
                        label4.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label1.Text = "James";
                        label4.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label1.Text = "James";
                        label4.Text = "C";
                    }
                    else
                    {
                        label1.Text = "James";
                        label4.Text = "D";
                    }

                }
                else if (label5.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label2.Text = "James";
                        label5.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label2.Text = "James";
                        label5.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label2.Text = "James";
                        label5.Text = "C";
                    }
                    else
                    {
                        label2.Text = "James";
                        label5.Text = "D";
                    }
                }
                else
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label3.Text = "James";
                        label7.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label3.Text = "James";
                        label7.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label3.Text = "James";
                        label7.Text = "C";
                    }
                    else
                    {
                        label3.Text = "James";
                        label7.Text = "D";
                    }
                }
            }
            else
            {
                if(label4.Text == "")
                {
                    label1.Text = "James";
                    label4.Text = "-";
                }
                else if(label5.Text == "")
                {
                    label2.Text = "James";
                    label5.Text = "-";
                }
                else
                {
                    label3.Text = "James";
                    label7.Text = "-";
                }
            }

        }

        private void Sarah()
        {
            if (GameMenu.question_type == "Computer" || GameMenu.question_type == "GK")
            {
                if (label4.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label1.Text = "Sarah";
                        label4.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label1.Text = "Sarah";
                        label4.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label1.Text = "Sarah";
                        label4.Text = "C";
                    }
                    else
                    {
                        label1.Text = "Sarah";
                        label4.Text = "D";
                    }

                }
                else if (label5.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label2.Text = "Sarah";
                        label5.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label2.Text = "Sarah";
                        label5.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label2.Text = "Sarah";
                        label5.Text = "C";
                    }
                    else
                    {
                        label2.Text = "Sarah";
                        label5.Text = "D";
                    }
                }
                else
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label3.Text = "Sarah";
                        label7.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label3.Text = "Sarah";
                        label7.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label3.Text = "Sarah";
                        label7.Text = "C";
                    }
                    else
                    {
                        label3.Text = "Sarah";
                        label7.Text = "D";
                    }
                }
            }
            else
            {
                if (label4.Text == "")
                {
                    label1.Text = "Sarah";
                    label4.Text = "-";
                }
                else if (label5.Text == "")
                {
                    label2.Text = "Sarah";
                    label5.Text = "-";
                }
                else
                {
                    label3.Text = "Sarah";
                    label7.Text = "-";
                }
            }

        }

        private void Osama()
        {
            if (GameMenu.question_type == "Mechanics" || GameMenu.question_type == "Physics")
            {
                if (label4.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label1.Text = "Osama";
                        label4.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label1.Text = "Osama";
                        label4.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label1.Text = "Osama";
                        label4.Text = "C";
                    }
                    else
                    {
                        label1.Text = "Osama";
                        label4.Text = "D";
                    }

                }
                else if (label5.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label2.Text = "Osama";
                        label5.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label2.Text = "Osama";
                        label5.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label2.Text = "Osama";
                        label5.Text = "C";
                    }
                    else
                    {
                        label2.Text = "Osama";
                        label5.Text = "D";
                    }
                }
                else
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label3.Text = "Osama";
                        label7.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label3.Text = "Osama";
                        label7.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label3.Text = "Osama";
                        label7.Text = "C";
                    }
                    else
                    {
                        label3.Text = "Osama";
                        label7.Text = "D";
                    }
                }
            }
            else
            {
                if (label4.Text == "")
                {
                    label1.Text = "Osama";
                    label4.Text = "-";
                }
                else if (label5.Text == "")
                {
                    label2.Text = "Osama";
                    label5.Text = "-";
                }
                else
                {
                    label3.Text = "Osama";
                    label7.Text = "-";
                }
            }

        }

        private void Omer()
        {
            if (GameMenu.question_type == "Mathematics" || GameMenu.question_type == "Physics")
            {
                if (label4.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label1.Text = "Omer";
                        label4.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label1.Text = "Omer";
                        label4.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label1.Text = "Omer";
                        label4.Text = "C";
                    }
                    else
                    {
                        label1.Text = "Omer";
                        label4.Text = "D";
                    }

                }
                else if (label5.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label2.Text = "Omer";
                        label5.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label2.Text = "Omer";
                        label5.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label2.Text = "Omer";
                        label5.Text = "C";
                    }
                    else
                    {
                        label2.Text = "Omer";
                        label5.Text = "D";
                    }
                }
                else
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label3.Text = "Omer";
                        label7.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label3.Text = "Omer";
                        label7.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label3.Text = "Omer";
                        label7.Text = "C";
                    }
                    else
                    {
                        label3.Text = "Omer";
                        label7.Text = "D";
                    }
                }
            }
            else
            {
                if (label4.Text == "")
                {
                    label1.Text = "Omer";
                    label4.Text = "-";
                }
                else if (label5.Text == "")
                {
                    label2.Text = "Omer";
                    label5.Text = "-";
                }
                else
                {
                    label3.Text = "Omer";
                    label7.Text = "-";
                }
            }

        }

        private void Zayd()
        {
            if (GameMenu.question_type == "Sports" || GameMenu.question_type == "Politics")
            {
                if (label4.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label1.Text = "Zayd";
                        label4.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label1.Text = "Zayd";
                        label4.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label1.Text = "Zayd";
                        label4.Text = "C";
                    }
                    else
                    {
                        label1.Text = "Zayd";
                        label4.Text = "D";
                    }

                }
                else if (label5.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label2.Text = "Zayd";
                        label5.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label2.Text = "Zayd";
                        label5.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label2.Text = "Zayd";
                        label5.Text = "C";
                    }
                    else
                    {
                        label2.Text = "Zayd";
                        label5.Text = "D";
                    }
                }
                else
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label3.Text = "Zayd";
                        label7.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label3.Text = "Zayd";
                        label7.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label3.Text = "Zayd";
                        label7.Text = "C";
                    }
                    else
                    {
                        label3.Text = "Zayd";
                        label7.Text = "D";
                    }
                }
            }
            else
            {
                if (label4.Text == "")
                {
                    label1.Text = "Zayd";
                    label4.Text = "-";
                }
                else if (label5.Text == "")
                {
                    label2.Text = "Zayd";
                    label5.Text = "-";
                }
                else
                {
                    label3.Text = "Zayd";
                    label7.Text = "-";
                }
            }

        }
        private void JCole()
        {
            if (GameMenu.question_type == "Sports" || GameMenu.question_type == "Politics" || GameMenu.question_type == "Movies")
            {
                if (label4.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label1.Text = "Jcole";
                        label4.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label1.Text = "Jcole";
                        label4.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label1.Text = "Jcole";
                        label4.Text = "C";
                    }
                    else
                    {
                        label1.Text = "Jcole";
                        label4.Text = "D";
                    }

                }
                else if (label5.Text == "")
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label2.Text = "Jcole";
                        label5.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label2.Text = "Jcole";
                        label5.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label2.Text = "Jcole";
                        label5.Text = "C";
                    }
                    else
                    {
                        label2.Text = "Jcole";
                        label5.Text = "D";
                    }
                }
                else
                {
                    if (GameMenu.correct_answer == 1)
                    {
                        label3.Text = "Jcole";
                        label7.Text = "A";
                    }
                    else if (GameMenu.correct_answer == 2)
                    {
                        label3.Text = "Jcole";
                        label7.Text = "B";
                    }
                    else if (GameMenu.correct_answer == 3)
                    {
                        label3.Text = "Jcole";
                        label7.Text = "C";
                    }
                    else
                    {
                        label3.Text = "Jcole";
                        label7.Text = "D";
                    }
                }
            }
            else
            {
                if (label4.Text == "")
                {
                    label1.Text = "Jcole";
                    label4.Text = "-";
                }
                else if (label5.Text == "")
                {
                    label2.Text = "Jcole";
                    label5.Text = "-";
                }
                else
                {
                    label3.Text = "Jcole";
                    label7.Text = "-";
                }
            }
        }
    }
}
