namespace FacebookFeatures
{
    public partial class FormGajetOne
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Massege = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.listBoxPostsTime = new System.Windows.Forms.ListBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.FetchPosts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaveFriendsListToFile = new System.Windows.Forms.Label();
            this.pictureBoxUrlLink = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrlLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "End date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "Start date";
            // 
            // Massege
            // 
            this.Massege.AutoSize = true;
            this.Massege.Location = new System.Drawing.Point(-1, 154);
            this.Massege.Name = "Massege";
            this.Massege.Size = new System.Drawing.Size(50, 13);
            this.Massege.TabIndex = 109;
            this.Massege.Text = "Massege";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(369, 154);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 108;
            this.Time.Text = "Time";
            // 
            // listBoxPostsTime
            // 
            this.listBoxPostsTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPostsTime.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxPostsTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPostsTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostsTime.FormattingEnabled = true;
            this.listBoxPostsTime.ItemHeight = 19;
            this.listBoxPostsTime.Location = new System.Drawing.Point(369, 170);
            this.listBoxPostsTime.Name = "listBoxPostsTime";
            this.listBoxPostsTime.Size = new System.Drawing.Size(163, 251);
            this.listBoxPostsTime.TabIndex = 107;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDateTimePicker.Location = new System.Drawing.Point(15, 100);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 106;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDateTimePicker.Location = new System.Drawing.Point(15, 50);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 105;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 19;
            this.listBoxPosts.Location = new System.Drawing.Point(2, 170);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(362, 251);
            this.listBoxPosts.TabIndex = 104;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // FetchPosts
            // 
            this.FetchPosts.AutoSize = true;
            this.FetchPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FetchPosts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FetchPosts.Location = new System.Drawing.Point(12, 10);
            this.FetchPosts.Name = "FetchPosts";
            this.FetchPosts.Size = new System.Drawing.Size(111, 13);
            this.FetchPosts.TabIndex = 103;
            this.FetchPosts.Text = "Press To Fetch Posts:";
            this.FetchPosts.Click += new System.EventHandler(this.FetchPosts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "picture:";
            // 
            // labelSaveFriendsListToFile
            // 
            this.labelSaveFriendsListToFile.AutoSize = true;
            this.labelSaveFriendsListToFile.Location = new System.Drawing.Point(583, 154);
            this.labelSaveFriendsListToFile.Name = "labelSaveFriendsListToFile";
            this.labelSaveFriendsListToFile.Size = new System.Drawing.Size(146, 13);
            this.labelSaveFriendsListToFile.TabIndex = 117;
            this.labelSaveFriendsListToFile.Text = "(Click to open Picture Url link)";
            // 
            // pictureBoxUrlLink
            // 
            this.pictureBoxUrlLink.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBoxUrlLink.Location = new System.Drawing.Point(538, 170);
            this.pictureBoxUrlLink.Name = "pictureBoxUrlLink";
            this.pictureBoxUrlLink.Size = new System.Drawing.Size(228, 251);
            this.pictureBoxUrlLink.TabIndex = 115;
            this.pictureBoxUrlLink.TabStop = false;
            this.pictureBoxUrlLink.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacebookFeatures.Properties.Resources.Facebook;
            this.pictureBox1.Location = new System.Drawing.Point(618, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // FormGajetOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 424);
            this.Controls.Add(this.labelSaveFriendsListToFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxUrlLink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Massege);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.listBoxPostsTime);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.FetchPosts);
            this.Name = "FormGajetOne";
            this.Text = "Search posts by date";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUrlLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Massege;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ListBox listBoxPostsTime;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label FetchPosts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxUrlLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSaveFriendsListToFile;
    }
}