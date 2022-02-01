using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillionaireGame
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel4 , new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel1, new object[] { true });

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            QuestionData myForm = new QuestionData();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(myForm);
            myForm.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            PlayerData myForm = new PlayerData();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(myForm);
            myForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
