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
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookFeatures;
using System.Threading;

namespace FacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.BackColor = Color.FromArgb(216, 223, 234);
            this.menuStrip1.BackColor = Color.FromArgb(59, 89, 152);
        }

        private AppConfigSingleton m_MyAppConfig = AppConfigSingleton.Instante;
        private User m_LoggedInUser; 
        private LoginResult m_Result;
        private Form FactoryForm;
        private SendingMessages sendingMessage = new SendingMessages();
        private int Countertime = 0;

        protected override void OnClosed(EventArgs e)
        {
            serialize();
            base.OnClosed(e);
        }

        protected override void OnShown(EventArgs e)
        {
            if (System.IO.File.Exists(StaticMethods.Database.SerializeFileName()))      
            {
                m_MyAppConfig = (AppConfigSingleton)deserialze();
                if (m_MyAppConfig.CheckBoxChecked)
                {
                    new Thread(() =>
                      {
                          m_Result = FacebookService.Connect(m_MyAppConfig.AccessToken);
                          m_LoggedInUser = m_Result.LoggedInUser;

                          this.checkBoxRemamberMe.Invoke((MethodInvoker)delegate()
                          {
                              this.checkBoxRemamberMe.Checked = true;
                          });
                          m_MyAppConfig.ItsLogIn = true;
                          new Thread(fetchUserInfo).Start();
                         if (Thread.CurrentThread.IsAlive)
                         {
                             Thread.Sleep(2000);
                             new Thread(()=>{ StaticMethods.MessageView.AutomaticallyLogin(m_LoggedInUser); }).Start(); 
                         }
                      }).Start();
                }
                else
                {
                    this.checkBoxRemamberMe.Checked = m_MyAppConfig.CheckBoxChecked;
                    m_MyAppConfig.ItsLogIn = false;
                }
            }

            this.ToolStripMenuItemGadjet.DropDownItemClicked += new ToolStripItemClickedEventHandler(this.ToolStripItemClickedEventHandler_click);
            base.OnShown(e);
        }

        private void loginAndInit()
        {
            if (m_MyAppConfig.ItsLogIn)
            {
                StaticMethods.MessageView.AutomaticallyLogin(m_LoggedInUser);
            }
            else
            {
                 m_Result = FacebookService.Login("161323547554494", "user_about_me", "user_friends", "publish_actions", "user_tagged_places", "rsvp_event", "user_work_history", "read_custom_friendlists", "user_status", "user_actions.news", "manage_pages", "publish_pages", "user_events", "user_posts", "user_photos", "user_status", "user_videos", "user_birthday", "user_website", "user_work_history", "read_insights", "read_audience_network_insights", "email", "read_page_mailboxes", "user_relationships", "read_insights", "user_likes", "user_location", "manage_pages", "publish_pages", "publish_actions", "ads_read", "ads_management");
     
                if (!string.IsNullOrEmpty(m_Result.AccessToken))
                {
                    m_LoggedInUser = m_Result.LoggedInUser;
                    m_MyAppConfig.ItsLogIn = true;

                    new Thread(fetchUserInfo).Start();
                }
                else
                {
                    MessageBox.Show(m_Result.ErrorMessage);
                }
            }
        }

        private void exitFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Action call = new Action(userLogOut);
                FacebookService.Logout(call);
                StaticMethods.MessageView.LogoutSuccessfully();
            }
            catch (Exception)
            {
                MessageBox.Show("Logout Fail");
            }
        }

        public void userLogOut()
        {
            userSmallPictureBox.Visible = false;
            BornOn.Text = string.Empty;
            InRelationshipWith.Text = string.Empty;
            Gender.Text = " ";
            labelUserName.Text = string.Empty;
            labelUserLastName.Text = string.Empty;
            labelWelcome.Text = string.Empty;
            m_MyAppConfig.ItsLogIn = false;
            this.checkBoxRemamberMe.Checked = false;
        }

        private void fetchUserInfo()
        {
            this.userSmallPictureBox.Invoke((MethodInvoker)delegate()
             {
                 userSmallPictureBox.Visible = true;
                 userSmallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
                 BornOn.Text = m_LoggedInUser.Birthday;
                 InRelationshipWith.Text = Convert.ToString(m_LoggedInUser.RelationshipStatus.Value);
                 Gender.Text = Convert.ToString(m_LoggedInUser.Gender);
                 //if (m_LoggedInUser.Posts.Count > 0)
                 //{
                 //    textBoxWriteNewPost.Text = m_LoggedInUser.Posts[0].Message;
                 //}
             } );

            this.labelUserLastName.Invoke((MethodInvoker)delegate()
            {
                labelUserName.Text = m_LoggedInUser.FirstName;
                labelUserLastName.Text = m_LoggedInUser.LastName;
                labelWelcome.Text = "Welcome !";
            });
        }

        private void loginToFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void ToolStripItemClickedEventHandler_click(object sender, EventArgs e)
        {
            serialize();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void MenuItemClicked(string i_FormName)
        {
            FactoryForm = CreateFormFactory.Create(i_FormName);
            FactoryForm.ShowDialog();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            serialize();
            sendingMessage.SendStatusMessage();
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            serialize();
            sendingMessage.SendEmailMessage();
        }

        private void StartGadgetOneMenuItem_Click(object sender, EventArgs e)                   /// Factory Method design ///
        {
           MenuItemClicked(sender.ToString());
        }

        private void StartGadgetTwoMenuItem_Click(object sender, EventArgs e)                  /// Factory Method design ///
        {
            MenuItemClicked(sender.ToString());
        }

        private void startGadjetThreeMenuItem_Click(object sender, EventArgs e)              /// Factory Method design ///
        {
            MenuItemClicked(sender.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxRemamberMe.Checked && m_MyAppConfig.ItsLogIn == false)
            {
                StaticMethods.MessageView.RemamberMe();
            }

            this.checkBoxRemamberMe.Checked = this.checkBoxRemamberMe.Checked;
        }

        private void serialize()
        {
            try
            {
                if (m_MyAppConfig.ItsLogIn)
                {
                    m_MyAppConfig.AccessToken = m_Result.AccessToken;
                    m_MyAppConfig.CheckBoxChecked = this.checkBoxRemamberMe.Checked;
                    XmlSerializer serializer = new XmlSerializer(typeof(AppConfigSingleton));
                    using (StreamWriter streamWriter = System.IO.File.CreateText(StaticMethods.Database.SerializeFileName()))
                    {
                        serializer.Serialize(streamWriter, m_MyAppConfig);
                    }
                }
                else
                {
                    m_MyAppConfig.CheckBoxChecked = this.checkBoxRemamberMe.Checked;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Errow!");
            }
        }

        private object deserialze()
        {
            object data;
            XmlSerializer serializer = new XmlSerializer(typeof(AppConfigSingleton));
            try
            {
                using (TextReader reader = new StreamReader(StaticMethods.Database.SerializeFileName()))
                {
                    var ReaderData = serializer.Deserialize(reader);
                    data = ReaderData as AppConfigSingleton;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return data;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Countertime > 7)
            {
                timer1.Stop();
            }

            pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
            Countertime++;
        }
    }
}
