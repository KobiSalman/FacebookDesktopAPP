using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Mail;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookFeatures;

namespace FacebookFeatures
{
    public partial class SendingMail : Form
    {
        private AppConfigSingleton m_MyAppConfig = AppConfigSingleton.Instante;
        private User m_LoggedInUser;

        public SendingMail()
        {
            InitializeComponent();
            if (System.IO.File.Exists(StaticMethods.Database.SerializeFileName()))
            {
                m_MyAppConfig = (AppConfigSingleton)m_MyAppConfig.DeserialzeInstante();
                if (m_MyAppConfig.ItsLogIn)
                {
                    LoginResult result = FacebookService.Connect(m_MyAppConfig.AccessToken);
                    m_LoggedInUser = result.LoggedInUser;
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(m_MyAppConfig.ItsLogIn)
            {
                try
                {
                    MailMessage mail = new MailMessage(textBoxFrom.Text, textBoxTo.Text, "Your Facebook Friends List", AttachFriendsList());
                    SmtpClient client = new SmtpClient(textBoxSmtp.Text);
                    client.Port = 587;  //SSL Protocol
                    client.Credentials = new System.Net.NetworkCredential(textBoxUserName.Text, textBoxPassword.Text);
                    client.EnableSsl = true;
                    client.Send(mail);
                    MessageBox.Show("Mail sent.", "Success", MessageBoxButtons.OK);
                }
                catch(Exception)
                {
                    MessageBox.Show("Fields required");
                }
            }
            else
            {
                StaticMethods.MessageView.LoginFirst();
            }
        }

        public string AttachFriendsList()
        {
                foreach (User fbFriend in m_LoggedInUser.Friends)
                {
                    textBoxBody.AppendText(fbFriend.Name);
                    textBoxBody.AppendText(Environment.NewLine);
                }

                if (m_LoggedInUser.Friends.Count == 0)
                {
                    StaticMethods.MessageView.NoFrinds();
                }
            return textBoxBody.Text;
        }
    }
}
