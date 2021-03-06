﻿using System;
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
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookFeatures;
using System.Threading;

namespace FacebookFeatures
{
    public partial class SendingStatus : Form
    {
        private AppConfigSingleton m_MyAppConfig = AppConfigSingleton.Instante;
        private User m_LoggedInUser;
        private string textbirtdayDefault = "המון מזל טוב שפע ברכות ואיחולים,";
        private string textUrlDefaultlink = "www.penelope.co.il/pict/gallery/pict_big/Products_1651_3764.jpg";
        private List<User> listfbFriend = new List<User>();


        public SendingStatus()
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

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            sendPost();
        }


        private void sendPost()
        {
            SerchFriend();
            if (listfbFriend.Count > 0)
            {
                new Thread(() =>
                    {
                        foreach (User friend in listfbFriend)
                        {
                            posted(friend);
                        }                        
                    }
                ).Start();
            }
        }

        private void posted(User friend)
        {
            try
            {
                new Thread(() =>
                {
                    Status postedStatus = m_LoggedInUser.PostStatus(textbirtdayDefault, i_PictureURL: textUrlDefaultlink, i_Link: m_LoggedInUser.Link, i_TaggedFriendIDs: friend.Id);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                ).Start();

            }
            catch (Exception)
            {
                StaticMethods.MessageView.LoginFirst();
            }
        }



        public void SerchFriend()
        {
            try
            {
                foreach (User fbFriend in m_LoggedInUser.Friends)
                {
                    DateTime BirthdayfbFriend = new DateTime();
                    DateTime.TryParse(fbFriend.Birthday, out BirthdayfbFriend);
                    if (BirthdayfbFriend == DateTime.Now.Date)
                    {
                        listfbFriend.Add(fbFriend);
                    }
                    listfbFriend.Add(fbFriend);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errow");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }









    }

}
