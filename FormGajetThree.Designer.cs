namespace FacebookFeatures
{
    public partial class FormGajetThree
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
            this.buttonSaveUserFriendsListToFile = new System.Windows.Forms.Button();
            this.pictureBoxShowUserFriends = new System.Windows.Forms.PictureBox();
            this.linkLabelShowUserFriendsList = new System.Windows.Forms.LinkLabel();
            this.labelFrindsList = new System.Windows.Forms.Label();
            this.listBoxUserFriendsList = new System.Windows.Forms.ListBox();
            this.pictureBoxAppLog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowUserFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppLog)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveUserFriendsListToFile
            // 
            this.buttonSaveUserFriendsListToFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveUserFriendsListToFile.Location = new System.Drawing.Point(161, 53);
            this.buttonSaveUserFriendsListToFile.Name = "buttonSaveUserFriendsListToFile";
            this.buttonSaveUserFriendsListToFile.Size = new System.Drawing.Size(142, 23);
            this.buttonSaveUserFriendsListToFile.TabIndex = 71;
            this.buttonSaveUserFriendsListToFile.Text = "Save Frinds List";
            this.buttonSaveUserFriendsListToFile.UseVisualStyleBackColor = true;
            this.buttonSaveUserFriendsListToFile.Click += new System.EventHandler(this.buttonSaveUserFriendsListToFile_Click);
            // 
            // pictureBoxShowUserFriends
            // 
            this.pictureBoxShowUserFriends.Location = new System.Drawing.Point(161, 82);
            this.pictureBoxShowUserFriends.Name = "pictureBoxShowUserFriends";
            this.pictureBoxShowUserFriends.Size = new System.Drawing.Size(142, 118);
            this.pictureBoxShowUserFriends.TabIndex = 70;
            this.pictureBoxShowUserFriends.TabStop = false;
            // 
            // linkLabelShowUserFriendsList
            // 
            this.linkLabelShowUserFriendsList.AutoSize = true;
            this.linkLabelShowUserFriendsList.Location = new System.Drawing.Point(12, 9);
            this.linkLabelShowUserFriendsList.Name = "linkLabelShowUserFriendsList";
            this.linkLabelShowUserFriendsList.Size = new System.Drawing.Size(90, 13);
            this.linkLabelShowUserFriendsList.TabIndex = 67;
            this.linkLabelShowUserFriendsList.TabStop = true;
            this.linkLabelShowUserFriendsList.Text = "Show Friends List";
            this.linkLabelShowUserFriendsList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowUserFriendsList_LinkClicked);
            // 
            // labelFrindsList
            // 
            this.labelFrindsList.AutoSize = true;
            this.labelFrindsList.Location = new System.Drawing.Point(12, 28);
            this.labelFrindsList.Name = "labelFrindsList";
            this.labelFrindsList.Size = new System.Drawing.Size(158, 13);
            this.labelFrindsList.TabIndex = 68;
            this.labelFrindsList.Text = "(Click here to see your frinds list)";
            // 
            // listBoxUserFriendsList
            // 
            this.listBoxUserFriendsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxUserFriendsList.FormattingEnabled = true;
            this.listBoxUserFriendsList.Location = new System.Drawing.Point(12, 53);
            this.listBoxUserFriendsList.Name = "listBoxUserFriendsList";
            this.listBoxUserFriendsList.Size = new System.Drawing.Size(143, 147);
            this.listBoxUserFriendsList.TabIndex = 69;
            this.listBoxUserFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxUserFriendsList_SelectedIndexChanged_1);
            // 
            // pictureBoxAppLog
            // 
            this.pictureBoxAppLog.Image = global::FacebookFeatures.Properties.Resources.Facebook;
            this.pictureBoxAppLog.Location = new System.Drawing.Point(400, 9);
            this.pictureBoxAppLog.Name = "pictureBoxAppLog";
            this.pictureBoxAppLog.Size = new System.Drawing.Size(148, 118);
            this.pictureBoxAppLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAppLog.TabIndex = 115;
            this.pictureBoxAppLog.TabStop = false;
            // 
            // FormGajetThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 216);
            this.Controls.Add(this.pictureBoxAppLog);
            this.Controls.Add(this.buttonSaveUserFriendsListToFile);
            this.Controls.Add(this.pictureBoxShowUserFriends);
            this.Controls.Add(this.linkLabelShowUserFriendsList);
            this.Controls.Add(this.labelFrindsList);
            this.Controls.Add(this.listBoxUserFriendsList);
            this.Name = "FormGajetThree";
            this.Text = "Save friends list";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowUserFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAppLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveUserFriendsListToFile;
        private System.Windows.Forms.PictureBox pictureBoxShowUserFriends;
        private System.Windows.Forms.LinkLabel linkLabelShowUserFriendsList;
        private System.Windows.Forms.Label labelFrindsList;
        private System.Windows.Forms.ListBox listBoxUserFriendsList;
        private System.Windows.Forms.PictureBox pictureBoxAppLog;
    }
}