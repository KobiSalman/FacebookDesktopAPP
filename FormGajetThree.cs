using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookFeatures;

namespace FacebookFeatures
{
    public partial class FormGajetThree : Form
    {
        private User m_LoggedInUser;
        private User m_SelectedFriend;
        private AppConfigSingleton m_MyAppConfig = AppConfigSingleton.Instante; 

        public FormGajetThree()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(216, 223, 234);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

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

        private void linkLabelShowUserFriendsList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchShowUserFriendsList();
        }

        private void fetchShowUserFriendsList()
        {
            try
            {
                foreach (User fbFriend in m_LoggedInUser.Friends)
                {
                    listBoxUserFriendsList.Items.Add(fbFriend);
                }

                if (m_LoggedInUser.Friends.Count == 0)
                {
                    StaticMethods.MessageView.NoFrinds();
                }
            }
            catch (Exception)
            {
                StaticMethods.MessageView.LoginFirst();
            }
        }

        private void listBoxUserFriendsList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            whenClickOnFriend();
        }

        private void whenClickOnFriend()
        {
            if (listBoxUserFriendsList.SelectedItems.Count == 1)
            {
                m_SelectedFriend = listBoxUserFriendsList.SelectedItem as User;
                if (m_SelectedFriend.PictureNormalURL != null)
                {
                    pictureBoxShowUserFriends.LoadAsync(m_SelectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxShowUserFriends.Image = pictureBoxShowUserFriends.ErrorImage;
                }
            }
        }

        private void buttonSaveUserFriendsListToFile_Click(object sender, EventArgs e)
        {
            if (listBoxUserFriendsList.Items.Count > 0)
            {
                using (TextWriter text = new StreamWriter(StaticMethods.Database.FriendsListFileName()))
                {
                    foreach (User friend in listBoxUserFriendsList.Items)
                    {
                        text.WriteLine(friend.Name);
                    }
                }

                Process.Start(StaticMethods.Database.FriendsListFileName());
            }
        }
    }
}
