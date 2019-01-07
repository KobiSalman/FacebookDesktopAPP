using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookFeatures;

namespace FacebookFeatures
{
    public partial class FormGajetOne : Form
    {
        private User m_LoggedInUser;
        private AppConfigSingleton m_MyAppConfig = AppConfigSingleton.Instante;
        private Post m_SelectedPost;

        public FormGajetOne()
        {
            InitializeComponent();
            this.Text = "Search posts by date";

            if (System.IO.File.Exists(StaticMethods.Database.SerializeFileName()))
            {
                m_MyAppConfig = (AppConfigSingleton)m_MyAppConfig.DeserialzeInstante();
                if (m_MyAppConfig.ItsLogIn)
                {
                    LoginResult result = FacebookService.Connect(m_MyAppConfig.AccessToken);
                    m_LoggedInUser = result.LoggedInUser;
                }
            }

            this.BackColor = Color.FromArgb(216, 223, 234);
            this.listBoxPosts.ScrollAlwaysVisible = true;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void FetchPosts_Click(object sender, EventArgs e)
        {
            displaySelectedPost();
        }

        private void displaySelectedPost()
        {
            listBoxPosts.Items.Clear();
            listBoxPostsTime.Items.Clear();
            if(m_MyAppConfig.ItsLogIn)
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (post.CreatedTime.Value >= startDateTimePicker.Value.Date && post.CreatedTime.Value <= endDateTimePicker.Value.Date && post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                        listBoxPostsTime.Items.Add(post.CreatedTime.Value);
                    }
                }
            }
            else
            {
                StaticMethods.MessageView.SelectedPost();
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            whenClickOnPost();
        }

        private void whenClickOnPost()
        {
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                string name = (string)listBoxPosts.SelectedItem;
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    if (name == post.Message)
                    {
                        if (post.PictureURL != null)
                        {
                            pictureBoxUrlLink.LoadAsync(post.PictureURL);
                            pictureBoxUrlLink.SizeMode = PictureBoxSizeMode.Zoom;
                            m_SelectedPost = post;
                            break;
                        }
                        else
                        {
                            pictureBoxUrlLink.Image = pictureBoxUrlLink.ErrorImage;
                        }
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            whenClickOnPicture();
        }

        private void whenClickOnPicture()
        {
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                System.Diagnostics.Process.Start(m_SelectedPost.Link);
            }
            else
            {
                StaticMethods.MessageView.ChosePost();
            }
        }
    }
}
