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
using System.Net;
using System.Net.Mail;


namespace MillionaireGame
{

    public partial class GameMenu : Form
    {

        int stage = 0;
        int x = 0;
        int y = 0;
        private int duration = 60;
        private int duration2 = 60;
        public static string question_type = "";
        public static int correct_answer = 0;
        List<int> QuestionAsked = new List<int>();
        int NoofRows = 0;
        int number = 0;

        public GameMenu()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel19, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel22, new object[] { true });
            panel19.Enabled = false;

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            bunifuImageButton6.Image = Properties.Resources.bh;
            bunifuImageButton6.Enabled = false;
            if(y == 1)
            {
                bunifuTileButton2.Enabled = false;
                bunifuTileButton4.Enabled = false;
            }
            else if (y == 2)
            {
                bunifuTileButton3.Enabled = false;
                bunifuTileButton4.Enabled = false;
            }
            else if (y == 3)
            {
                bunifuTileButton2.Enabled = false;
                bunifuTileButton4.Enabled = false;
            }
            else
            {
                bunifuTileButton2.Enabled = false;
                bunifuTileButton1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitText()
        {
            WrongAnswerMessage myForm = new WrongAnswerMessage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel21.Controls.Clear();
            panel21.Controls.Add(myForm);
            myForm.Show();
        }

        private void CorrectText()
        {
            CorrectAnswerMessage myForm = new CorrectAnswerMessage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel21.Controls.Clear();
            panel21.Controls.Add(myForm);
            myForm.Show();
        }

        private void GameOverText() {
            GameEndMessage myForm = new GameEndMessage();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel21.Controls.Clear();
            panel21.Controls.Add(myForm);
            myForm.Show();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                bunifuTileButton2.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton3.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton4.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                x = 0;
            }
            bunifuTileButton1.BackgroundImage = Properties.Resources.prize;
            x = 1;

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                bunifuTileButton2.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton3.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton1.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                x = 0;
            }
            bunifuTileButton4.BackgroundImage = Properties.Resources.prize;
            x = 4;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                bunifuTileButton1.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton3.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton4.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                x = 0;
            }
            bunifuTileButton2.BackgroundImage = Properties.Resources.prize;
            x = 2;
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            if (x != 0)
            {
                bunifuTileButton2.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton1.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                bunifuTileButton4.BackgroundImage = Properties.Resources.button__1__removebg_preview;
                x = 0;
            }
            bunifuTileButton3.BackgroundImage = Properties.Resources.prize;
            x = 3;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            panel21.Controls.Clear();
            panel21.Visible = true;
            panel22.Hide();
            bunifuTileButton1.Enabled = false;
            bunifuTileButton2.Enabled = false;
            bunifuTileButton3.Enabled = false;
            bunifuTileButton4.Enabled = false;
            panel1.Enabled = false;

            if (x == y)
            {
                stageMasker();
                checker();
                bunifuImageButton1.Enabled = false;
                bunifuTileButton5.Enabled = true;
                bunifuTileButton5.Visible = true;
                bunifuTileButton6.Enabled = true;
                bunifuTileButton6.Visible = true;

                if (stage == 15) 
                {
                    GameOverText();
                    bunifuTileButton6.Enabled = true;
                    bunifuTileButton6.Visible = true;
                    bunifuTileButton5.Visible = false;
                }
                else 
                {
                    CorrectText();
                }
                
            }
            else
            {
                
                stageWrongMasker();
                checker();
                if (x == 1)
                {
                    bunifuTileButton1.BackgroundImage = Properties.Resources.imageedit_3_7461563440;

                }
                else if (x == 2)
                {
                    bunifuTileButton2.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
                }
                else if (x == 3)
                {
                    bunifuTileButton3.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
                }
                else
                {
                    bunifuTileButton4.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
                }
                bunifuTileButton6.Enabled = true;
                bunifuTileButton6.Visible = true;
                ExitText();
            }
        }

        private void checker()
        {
            if (y == 1)
            {
                bunifuTileButton1.BackgroundImage = Properties.Resources.correct__1_;
            }
            else if (y == 2)
            {
                bunifuTileButton2.BackgroundImage = Properties.Resources.correct__1_;
            }
            else if (y == 3)
            {
                bunifuTileButton3.BackgroundImage = Properties.Resources.correct__1_;
            }
            else
            {
                bunifuTileButton4.BackgroundImage = Properties.Resources.correct__1_;
            }
        }

        private void stageIncrementer()
        {
            if (stage == 0)
            {
                panel17.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 1)
            {
                panel16.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 2)
            {
                panel2.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 3)
            {
                panel3.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 4)
            {
                panel5.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 5)
            {
                panel6.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 6)
            {
                panel7.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 7)
            {
                panel8.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 8)
            {
                panel9.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 9)
            {
                panel10.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 10)
            {
                panel11.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 11)
            {
                panel12.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 12)
            {
                panel13.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 13)
            {
                panel14.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 14)
            {
                panel15.BackgroundImage = Properties.Resources.prize;
            }
            else if (stage == 15)
            {
                panel15.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
        }

        private void stageMasker()
        {

            if(stage == 1)
            {
                panel17.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 2)
            {
                panel16.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 3)
            {
                panel2.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 4)
            {
                panel3.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 5)
            {
                panel5.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 6)
            {
                panel6.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 7)
            {
                panel7.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 8)
            {
                panel8.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 9)
            {
                panel9.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 10)
            {
                panel10.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 11)
            {
                panel11.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 12)
            {
                panel12.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 13)
            {
                panel13.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 14)
            {
                panel14.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
            else if (stage == 15)
            {
                panel15.BackgroundImage = Properties.Resources.checkpoint__1_;
            }
        }


        private void stageWrongMasker()
        {

            if (stage == 1)
            {
                panel17.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 2)
            {
                panel16.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 3)
            {
                panel2.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 4)
            {
                panel3.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 5)
            {
                panel5.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 6)
            {
                panel6.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 7)
            {
                panel7.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 8)
            {
                panel8.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 9)
            {
                panel9.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 10)
            {
                panel10.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 11)
            {
                panel11.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 12)
            {
                panel12.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 13)
            {
                panel13.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 14)
            {
                panel14.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
            else if (stage == 15)
            {
                panel15.BackgroundImage = Properties.Resources.imageedit_3_7461563440;
            }
        }

        private void countDown_timer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;

            timer1.Start();
        }

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                timer1.Stop();
                panel21.Controls.Clear();
                panel22.Hide();
                bunifuTileButton1.Enabled = false;
                bunifuTileButton2.Enabled = false;
                bunifuTileButton3.Enabled = false;
                bunifuTileButton4.Enabled = false;
                panel1.Enabled = false;
                bunifuTileButton6.Enabled = true;
                bunifuTileButton6.Visible = true;
                ExitText();
            }
            else if (duration > 0)
            {
                duration--;
                timeLabel.Text = duration.ToString();
            }
        }

        private void pause()
        {
            timer1.Stop();
        }

        private void unpause()
        {
            timer1.Start();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {

            try 
            {
                pause();

                string inputMail = MainMenu.friend_email;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("hamzamunir2001@gmail.com");
                    mail.To.Add(inputMail);
                    mail.Subject = "WWTBM";
                    mail.Body = "<h1>Question</h1><br>" + QuestionLabel.Text + "<br> OptionA: " + bunifuTileButton1.LabelText + "<br> OptionB: " + bunifuTileButton2.LabelText + "<br> OptionC: " + bunifuTileButton3.LabelText + "<br> OptionD: " + bunifuTileButton4.LabelText + "<br>Type Option Alphabet as a reply. ";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("hamzamunir2001@gmail.com", "kzvletxemanoqyuw");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                MessageFriend myForm = new MessageFriend();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panel21.Controls.Clear();
                panel21.Controls.Add(myForm);
                myForm.Show();

                panel22.Visible = true;
                lifelinecountDown_timer();

                bunifuImageButton8.Image = Properties.Resources.image__1__removebg_preview;
                bunifuImageButton8.Enabled = false;
            } 
            catch 
            {
                MessageBox.Show("Unable to access mail.");
                unpause();
            }
 
            
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lifelinecountDown_timer()
        {
            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(lifelinecount_down);
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void lifelinecount_down(object sender, EventArgs e)
        {

            if (duration2 == 0)
            {
                timer2.Stop();
                panel22.Controls.Clear();
                panel22.Visible = false;
                panel21.Controls.Clear();
                unpause();
            }
            else if (duration2 > 0)
            {
                duration2--;
                label16.Text = duration2.ToString();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Audience myForm = new Audience();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel21.Controls.Clear();
            panel21.Controls.Add(myForm);
            myForm.Show();

            bunifuImageButton7.Image = Properties.Resources.audienceDisabled;
            bunifuImageButton7.Enabled = false;
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            stageIncrementer();
            if(stage == 0)
            {

                bunifuTileButton7.Enabled = false;
                bunifuTileButton7.Visible = false;
                stage += 1;
                LoadQuestion("one");
            }
            else if(stage <= 5 && stage > 0)
            {
                stage += 1;
                LoadQuestion("one");
            }
            else if(stage > 5 && stage <= 10)
            {
                stage += 1;
                LoadQuestion("two");
            }
            else
            {
                stage += 1;
                LoadQuestion("three");
            }
        }

        private void LoadQuestion(string levelno)
        {
            bunifuTileButton5.Enabled = false;
            bunifuTileButton5.Visible = false;
            bunifuTileButton6.Enabled = false;
            bunifuTileButton6.Visible = false;

            bunifuImageButton1.Enabled = true;
            bunifuTileButton2.Enabled = true;
            bunifuTileButton1.Enabled = true;
            bunifuTileButton4.Enabled = true;
            bunifuTileButton3.Enabled = true;
            panel1.Enabled = true;
            panel19.Enabled = true;

            y = 0;
            duration = 60;
            question_type = "";
            correct_answer = 0;

            bunifuTileButton1.BackgroundImage = Properties.Resources.button__1__removebg_preview;
            bunifuTileButton2.BackgroundImage = Properties.Resources.button__1__removebg_preview;
            bunifuTileButton3.BackgroundImage = Properties.Resources.button__1__removebg_preview;
            bunifuTileButton4.BackgroundImage = Properties.Resources.button__1__removebg_preview;


            QuestionCheck(levelno);

            QuestionAsked.Add(number);
            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";

            // now Extracting that question
            OracleConnection conn1 = new OracleConnection(oradb);
            conn1.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            cmd1.CommandText = "select * from level_" + levelno + " where question_id = '" + number + "'";
            OracleDataReader reader1 = cmd1.ExecuteReader();
            reader1.Read();
            QuestionLabel.Text = reader1.GetString(0);
            bunifuTileButton1.LabelText = reader1.GetString(1);
            bunifuTileButton2.LabelText = reader1.GetString(2);
            bunifuTileButton3.LabelText = reader1.GetString(3);
            bunifuTileButton4.LabelText = reader1.GetString(4);
            y = reader1.GetInt32(5);
            correct_answer = reader1.GetInt32(5);
            question_type = reader1.GetString(6);

            countDown_timer();
 
        }

        public void QuestionCheck(string levelno)
        {

            // Getting count to get random questions.
            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*) from level_" + levelno;
            OracleDataReader reader = cmd.ExecuteReader();
            reader.Read();
            NoofRows = reader.GetInt32(0);
            cmd.Dispose();
            conn.Close();

            // Now choosing random number
            Random rand = new Random();
            int check = rand.Next(1, NoofRows);

            if (QuestionAsked.Contains(check))
            {
                QuestionCheck(levelno);
            }
            else 
            {
                number = check;
            }
        }
        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            panel21.Controls.Clear();
            stageIncrementer();
            if (stage == 0)
            {
                bunifuTileButton7.Enabled = false;
                bunifuTileButton7.Visible = false;
                stage += 1;
                LoadQuestion("one");
            }
            else if (stage <= 5 && stage > 0)
            {
                stage += 1;
                LoadQuestion("one");
            }
            else if (stage > 5 && stage <= 10)
            {
                stage += 1;
                LoadQuestion("two");
            }
            else
            {
                stage += 1;
                LoadQuestion("three");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {


        }

        private void panel21_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

            QuestionLabel.MaximumSize = new Size(800, 0);
            QuestionLabel.AutoSize = true;
        }

        private void bunifuTileButton6_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to exit succesfully!");
                }
            }
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

    