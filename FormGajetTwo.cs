using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookFeatures
{
    public partial class FormGajetTwo : Form
    {
        private User m_LoggedInUser;
        private AppConfigSingleton m_MyAppConfig = AppConfigSingleton.Instante; 

        public FormGajetTwo()
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

        private void linkLabelUserLikedPages_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchShowUserLikedPages();
        }

        private void fetchShowUserLikedPages()
        {
            if (m_MyAppConfig.ItsLogIn)
            {
                try
                {
                    foreach (Page fbLikedPage in m_LoggedInUser.LikedPages)
                    {
                        richTextBoxUserLikedPages.AppendText(fbLikedPage.Name);
                        richTextBoxUserLikedPages.AppendText(Environment.NewLine);
                    }

                    if (m_LoggedInUser.LikedPages.Count == 0)
                    {
                        StaticMethods.MessageView.NoLiked();
                    }
                }
                catch (Exception)
                {
                    StaticMethods.MessageView.NoLiked();
                }
            }
            else
            {
                StaticMethods.MessageView.SelectedPost();
            }
        }

        private void pictureSearchGoogle_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBoxUserLikedPages.SelectedText != string.Empty)
                {
                    Process.Start("https://google.com/search?q=" + richTextBoxUserLikedPages.SelectedText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchInLike_Click(object sender, EventArgs e)
        {
            int index = 0;
            string stringInText = richTextBoxUserLikedPages.Text;
            richTextBoxUserLikedPages.Text = string.Empty;
            richTextBoxUserLikedPages.Text = stringInText;

            while (index < richTextBoxUserLikedPages.Text.LastIndexOf(textBoxStringToSearch.Text))
            {
                richTextBoxUserLikedPages.Find(textBoxStringToSearch.Text, index, richTextBoxUserLikedPages.TextLength, RichTextBoxFinds.None);
                richTextBoxUserLikedPages.SelectionBackColor = Color.Yellow;
                index = richTextBoxUserLikedPages.Text.IndexOf(textBoxStringToSearch.Text, index) + 1;
            }
        }
    }
}
