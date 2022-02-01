using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AE.Net.Mail;
using System.Net;
using System.Net.Mail;

namespace MillionaireGame
{
    public partial class MessageFriend : Form
    {
        static ImapClient IC;
        private int duration = 60;
        public MessageFriend()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            bunifuTileButton1.BackgroundImage = Properties.Resources.imageedit_5_7119960663;
            bunifuTileButton1.Enabled = false;
            GetAnswer();

        }

        private void GetAnswer()
        {
            IC = new ImapClient("imap.gmail.com", "hamzamunir2001@gmail.com", "kzvletxemanoqyuw", AuthMethods.Login, 993, true);
            IC.SelectMailbox("INBOX");
            var x = IC.GetMessageCount() - 3;
            var Email = IC.GetMessage(x);
            string checkSubject = Email.Subject.ToString().Trim();
            string originalSubject = "Re: WWTBM";
            if (checkSubject == originalSubject)
            {
                label1.Visible = true;
                label2.Text = Email.Body.ToString().Substring(0, 1);
            }
            else
            {
                bunifuTileButton1.BackgroundImage = Properties.Resources.general;
                bunifuTileButton1.Enabled = true;
            }

        }

        private void MessageFriend_Load(object sender, EventArgs e)
        {

        }
    }
}
