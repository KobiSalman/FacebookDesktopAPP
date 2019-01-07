namespace FacebookFeatures
{
    public partial class FormGajetTwo
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
            this.richTextBoxUserLikedPages = new System.Windows.Forms.RichTextBox();
            this.pictureLinkToSearchInGoogle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.linkLabelUserLikedPages = new System.Windows.Forms.LinkLabel();
            this.textBoxStringToSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchInLike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLinkToSearchInGoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxUserLikedPages
            // 
            this.richTextBoxUserLikedPages.Location = new System.Drawing.Point(12, 36);
            this.richTextBoxUserLikedPages.Name = "richTextBoxUserLikedPages";
            this.richTextBoxUserLikedPages.Size = new System.Drawing.Size(278, 271);
            this.richTextBoxUserLikedPages.TabIndex = 0;
            this.richTextBoxUserLikedPages.Text = string.Empty;
            // 
            // pictureLinkToSearchInGoogle
            // 
            this.pictureLinkToSearchInGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLinkToSearchInGoogle.Image = global::FacebookFeatures.Properties.Resources.Googlelogo;
            this.pictureLinkToSearchInGoogle.Location = new System.Drawing.Point(296, 36);
            this.pictureLinkToSearchInGoogle.Name = "pictureLinkToSearchInGoogle";
            this.pictureLinkToSearchInGoogle.Size = new System.Drawing.Size(121, 37);
            this.pictureLinkToSearchInGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLinkToSearchInGoogle.TabIndex = 3;
            this.pictureLinkToSearchInGoogle.TabStop = false;
            this.pictureLinkToSearchInGoogle.Click += new System.EventHandler(this.pictureSearchGoogle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacebookFeatures.Properties.Resources.Facebook;
            this.pictureBox1.Location = new System.Drawing.Point(531, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(296, 76);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(106, 26);
            this.labelSearch.TabIndex = 104;
            this.labelSearch.Text = "(Mark the words \r\n  you want to search)";
            // 
            // linkLabelUserLikedPages
            // 
            this.linkLabelUserLikedPages.AutoSize = true;
            this.linkLabelUserLikedPages.Location = new System.Drawing.Point(9, 7);
            this.linkLabelUserLikedPages.Name = "linkLabelUserLikedPages";
            this.linkLabelUserLikedPages.Size = new System.Drawing.Size(96, 13);
            this.linkLabelUserLikedPages.TabIndex = 105;
            this.linkLabelUserLikedPages.TabStop = true;
            this.linkLabelUserLikedPages.Text = "Show Liked Pages";
            this.linkLabelUserLikedPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUserLikedPages_Click);
            // 
            // textBoxStringToSearch
            // 
            this.textBoxStringToSearch.Location = new System.Drawing.Point(111, 7);
            this.textBoxStringToSearch.Name = "textBoxStringToSearch";
            this.textBoxStringToSearch.Size = new System.Drawing.Size(179, 20);
            this.textBoxStringToSearch.TabIndex = 106;
            // 
            // buttonSearchInLike
            // 
            this.buttonSearchInLike.Location = new System.Drawing.Point(296, 7);
            this.buttonSearchInLike.Name = "buttonSearchInLike";
            this.buttonSearchInLike.Size = new System.Drawing.Size(99, 23);
            this.buttonSearchInLike.TabIndex = 107;
            this.buttonSearchInLike.Text = "Search in likes";
            this.buttonSearchInLike.UseVisualStyleBackColor = true;
            this.buttonSearchInLike.Click += new System.EventHandler(this.buttonSearchInLike_Click);
            // 
            // FormGajetTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 315);
            this.Controls.Add(this.buttonSearchInLike);
            this.Controls.Add(this.textBoxStringToSearch);
            this.Controls.Add(this.linkLabelUserLikedPages);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.pictureLinkToSearchInGoogle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxUserLikedPages);
            this.Name = "FormGajetTwo";
            this.Text = "Search likes in google";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLinkToSearchInGoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxUserLikedPages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureLinkToSearchInGoogle;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.LinkLabel linkLabelUserLikedPages;
        private System.Windows.Forms.TextBox textBoxStringToSearch;
        private System.Windows.Forms.Button buttonSearchInLike;
    }
}