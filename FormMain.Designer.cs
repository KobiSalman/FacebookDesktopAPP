namespace FacebookFeatures
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSetNewPostOnFacebook = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.groupBoxMessagesCenter = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonBornOn = new System.Windows.Forms.Button();
            this.checkBoxRemamberMe = new System.Windows.Forms.CheckBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.InRelationshipWith = new System.Windows.Forms.TextBox();
            this.labelUserLastName = new System.Windows.Forms.Label();
            this.BornOn = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonGender = new System.Windows.Forms.Button();
            this.userSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonRelationshipStatus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemLogInAndOut = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGadjet = new System.Windows.Forms.ToolStripMenuItem();
            this.StartGadgetOneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartGadgetTwoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGadjetThreeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMessagesCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSmallPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetNewPostOnFacebook
            // 
            this.buttonSetNewPostOnFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetNewPostOnFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetNewPostOnFacebook.Location = new System.Drawing.Point(110, 22);
            this.buttonSetNewPostOnFacebook.Name = "buttonSetNewPostOnFacebook";
            this.buttonSetNewPostOnFacebook.Size = new System.Drawing.Size(148, 23);
            this.buttonSetNewPostOnFacebook.TabIndex = 49;
            this.buttonSetNewPostOnFacebook.Text = "Status birthday ";
            this.buttonSetNewPostOnFacebook.UseVisualStyleBackColor = true;
            this.buttonSetNewPostOnFacebook.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // groupBoxMessagesCenter
            // 
            this.groupBoxMessagesCenter.Controls.Add(this.pictureBox3);
            this.groupBoxMessagesCenter.Controls.Add(this.buttonEmail);
            this.groupBoxMessagesCenter.Controls.Add(this.buttonSetNewPostOnFacebook);
            this.groupBoxMessagesCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxMessagesCenter.Location = new System.Drawing.Point(288, 106);
            this.groupBoxMessagesCenter.Name = "groupBoxMessagesCenter";
            this.groupBoxMessagesCenter.Size = new System.Drawing.Size(278, 103);
            this.groupBoxMessagesCenter.TabIndex = 66;
            this.groupBoxMessagesCenter.TabStop = false;
            this.groupBoxMessagesCenter.Text = "Messages Center";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FacebookFeatures.Properties.Resources.icon_email;
            this.pictureBox3.Location = new System.Drawing.Point(0, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // buttonEmail
            // 
            this.buttonEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmail.Location = new System.Drawing.Point(110, 51);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(148, 23);
            this.buttonEmail.TabIndex = 50;
            this.buttonEmail.Text = "E-mail my friends list";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.groupBoxMessagesCenter);
            this.groupBoxLogin.Controls.Add(this.buttonBornOn);
            this.groupBoxLogin.Controls.Add(this.checkBoxRemamberMe);
            this.groupBoxLogin.Controls.Add(this.Gender);
            this.groupBoxLogin.Controls.Add(this.labelWelcome);
            this.groupBoxLogin.Controls.Add(this.InRelationshipWith);
            this.groupBoxLogin.Controls.Add(this.labelUserLastName);
            this.groupBoxLogin.Controls.Add(this.BornOn);
            this.groupBoxLogin.Controls.Add(this.labelUserName);
            this.groupBoxLogin.Controls.Add(this.buttonGender);
            this.groupBoxLogin.Controls.Add(this.userSmallPictureBox);
            this.groupBoxLogin.Controls.Add(this.buttonRelationshipStatus);
            this.groupBoxLogin.Location = new System.Drawing.Point(189, 31);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(566, 189);
            this.groupBoxLogin.TabIndex = 69;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // buttonBornOn
            // 
            this.buttonBornOn.Location = new System.Drawing.Point(288, 19);
            this.buttonBornOn.Name = "buttonBornOn";
            this.buttonBornOn.Size = new System.Drawing.Size(119, 23);
            this.buttonBornOn.TabIndex = 95;
            this.buttonBornOn.Text = "Born on:";
            this.buttonBornOn.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemamberMe
            // 
            this.checkBoxRemamberMe.AutoSize = true;
            this.checkBoxRemamberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRemamberMe.Location = new System.Drawing.Point(9, 19);
            this.checkBoxRemamberMe.Name = "checkBoxRemamberMe";
            this.checkBoxRemamberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRemamberMe.TabIndex = 47;
            this.checkBoxRemamberMe.Text = "Remamber Me";
            this.checkBoxRemamberMe.UseVisualStyleBackColor = true;
            this.checkBoxRemamberMe.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(413, 80);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(133, 20);
            this.Gender.TabIndex = 100;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(5, 63);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 19);
            this.labelWelcome.TabIndex = 46;
            // 
            // InRelationshipWith
            // 
            this.InRelationshipWith.Location = new System.Drawing.Point(413, 48);
            this.InRelationshipWith.Name = "InRelationshipWith";
            this.InRelationshipWith.Size = new System.Drawing.Size(133, 20);
            this.InRelationshipWith.TabIndex = 99;
            // 
            // labelUserLastName
            // 
            this.labelUserLastName.AutoSize = true;
            this.labelUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserLastName.Location = new System.Drawing.Point(6, 137);
            this.labelUserLastName.Name = "labelUserLastName";
            this.labelUserLastName.Size = new System.Drawing.Size(0, 20);
            this.labelUserLastName.TabIndex = 45;
            // 
            // BornOn
            // 
            this.BornOn.Location = new System.Drawing.Point(413, 22);
            this.BornOn.Name = "BornOn";
            this.BornOn.Size = new System.Drawing.Size(133, 20);
            this.BornOn.TabIndex = 98;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(6, 100);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 20);
            this.labelUserName.TabIndex = 44;
            // 
            // buttonGender
            // 
            this.buttonGender.Location = new System.Drawing.Point(288, 77);
            this.buttonGender.Name = "buttonGender";
            this.buttonGender.Size = new System.Drawing.Size(119, 23);
            this.buttonGender.TabIndex = 97;
            this.buttonGender.Text = "Gender:";
            this.buttonGender.UseVisualStyleBackColor = true;
            // 
            // userSmallPictureBox
            // 
            this.userSmallPictureBox.Location = new System.Drawing.Point(113, 10);
            this.userSmallPictureBox.Name = "userSmallPictureBox";
            this.userSmallPictureBox.Size = new System.Drawing.Size(169, 181);
            this.userSmallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userSmallPictureBox.TabIndex = 42;
            this.userSmallPictureBox.TabStop = false;
            // 
            // buttonRelationshipStatus
            // 
            this.buttonRelationshipStatus.Location = new System.Drawing.Point(288, 48);
            this.buttonRelationshipStatus.Name = "buttonRelationshipStatus";
            this.buttonRelationshipStatus.Size = new System.Drawing.Size(119, 23);
            this.buttonRelationshipStatus.TabIndex = 96;
            this.buttonRelationshipStatus.Text = "relationship status:";
            this.buttonRelationshipStatus.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLogInAndOut,
            this.ToolStripMenuItemGadjet});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 26);
            this.menuStrip1.TabIndex = 101;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemLogInAndOut
            // 
            this.MenuItemLogInAndOut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToFacebookToolStripMenuItem,
            this.exitFacebookToolStripMenuItem});
            this.MenuItemLogInAndOut.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemLogInAndOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuItemLogInAndOut.ImageTransparentColor = System.Drawing.SystemColors.InfoText;
            this.MenuItemLogInAndOut.Name = "MenuItemLogInAndOut";
            this.MenuItemLogInAndOut.Size = new System.Drawing.Size(60, 22);
            this.MenuItemLogInAndOut.Text = "Login";
            // 
            // loginToFacebookToolStripMenuItem
            // 
            this.loginToFacebookToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToFacebookToolStripMenuItem.Name = "loginToFacebookToolStripMenuItem";
            this.loginToFacebookToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loginToFacebookToolStripMenuItem.Text = "Login Facebook";
            this.loginToFacebookToolStripMenuItem.Click += new System.EventHandler(this.loginToFacebookToolStripMenuItem_Click);
            // 
            // exitFacebookToolStripMenuItem
            // 
            this.exitFacebookToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFacebookToolStripMenuItem.Name = "exitFacebookToolStripMenuItem";
            this.exitFacebookToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitFacebookToolStripMenuItem.Text = "Exit Facebook";
            this.exitFacebookToolStripMenuItem.Click += new System.EventHandler(this.exitFacebookToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemGadjet
            // 
            this.ToolStripMenuItemGadjet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartGadgetOneMenuItem,
            this.StartGadgetTwoMenuItem,
            this.startGadjetThreeMenuItem});
            this.ToolStripMenuItemGadjet.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemGadjet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemGadjet.Name = "ToolStripMenuItemGadjet";
            this.ToolStripMenuItemGadjet.Size = new System.Drawing.Size(80, 22);
            this.ToolStripMenuItemGadjet.Text = "Gadgets";
            // 
            // StartGadgetOneMenuItem
            // 
            this.StartGadgetOneMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGadgetOneMenuItem.Image = global::FacebookFeatures.Properties.Resources.facebook_like_thumb;
            this.StartGadgetOneMenuItem.Name = "StartGadgetOneMenuItem";
            this.StartGadgetOneMenuItem.Size = new System.Drawing.Size(218, 22);
            this.StartGadgetOneMenuItem.Text = "Search posts by date";
            this.StartGadgetOneMenuItem.Click += new System.EventHandler(this.StartGadgetOneMenuItem_Click);
            // 
            // StartGadgetTwoMenuItem
            // 
            this.StartGadgetTwoMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGadgetTwoMenuItem.Image = global::FacebookFeatures.Properties.Resources.facebook_like_thumb;
            this.StartGadgetTwoMenuItem.Name = "StartGadgetTwoMenuItem";
            this.StartGadgetTwoMenuItem.Size = new System.Drawing.Size(218, 22);
            this.StartGadgetTwoMenuItem.Text = "Search likes in google";
            this.StartGadgetTwoMenuItem.Click += new System.EventHandler(this.StartGadgetTwoMenuItem_Click);
            // 
            // startGadjetThreeMenuItem
            // 
            this.startGadjetThreeMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGadjetThreeMenuItem.Image = global::FacebookFeatures.Properties.Resources.facebook_like_thumb;
            this.startGadjetThreeMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.startGadjetThreeMenuItem.Name = "startGadjetThreeMenuItem";
            this.startGadjetThreeMenuItem.Size = new System.Drawing.Size(218, 22);
            this.startGadjetThreeMenuItem.Text = "Save friends list";
            this.startGadjetThreeMenuItem.Click += new System.EventHandler(this.startGadjetThreeMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FacebookFeatures.Properties.Resources.Facebook;
            this.pictureBox2.Location = new System.Drawing.Point(5, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 102;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacebookFeatures.Properties.Resources.welcome;
            this.pictureBox1.Location = new System.Drawing.Point(5, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 227);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxLogin);
            this.Name = "FormMain";
            this.Text = "Tal & Kobi Facebook App";
            this.groupBoxMessagesCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSmallPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userSmallPictureBox;
        private System.Windows.Forms.Button buttonSetNewPostOnFacebook;
        private System.Windows.Forms.GroupBox groupBoxMessagesCenter;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelUserLastName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox InRelationshipWith;
        private System.Windows.Forms.TextBox BornOn;
        private System.Windows.Forms.Button buttonGender;
        private System.Windows.Forms.Button buttonRelationshipStatus;
        private System.Windows.Forms.Button buttonBornOn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogInAndOut;
        private System.Windows.Forms.ToolStripMenuItem loginToFacebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFacebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGadjet;
        private System.Windows.Forms.ToolStripMenuItem StartGadgetOneMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartGadgetTwoMenuItem;
        private System.Windows.Forms.CheckBox checkBoxRemamberMe;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripMenuItem startGadjetThreeMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}