namespace FacebookFeatures
{
    partial class SendingMail
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
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxSmtp = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelSub = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(31, 51);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(73, 48);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(224, 20);
            this.textBoxFrom.TabIndex = 1;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(31, 15);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 13);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "To:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(31, 77);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(68, 13);
            this.labelSubject.TabIndex = 3;
            this.labelSubject.Text = "Smtp Server:";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(73, 12);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(224, 20);
            this.textBoxTo.TabIndex = 5;
            // 
            // textBoxSmtp
            // 
            this.textBoxSmtp.Location = new System.Drawing.Point(105, 74);
            this.textBoxSmtp.Name = "textBoxSmtp";
            this.textBoxSmtp.Size = new System.Drawing.Size(192, 20);
            this.textBoxSmtp.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxSmtp, "Ex: smtp.live.com");
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(105, 216);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(192, 35);
            this.textBoxBody.TabIndex = 7;
            this.textBoxBody.Visible = false;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(105, 154);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(38, 103);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(63, 13);
            this.labelUserName.TabIndex = 9;
            this.labelUserName.Text = "User Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(105, 100);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(192, 20);
            this.textBoxUserName.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBoxUserName, "Your E-mail username");
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(38, 129);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(105, 126);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(192, 20);
            this.textBoxPassword.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxPassword, "Your E-mail password");
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(105, 190);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(192, 20);
            this.textBoxSub.TabIndex = 14;
            this.textBoxSub.Visible = false;
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(34, 193);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(46, 13);
            this.labelSub.TabIndex = 13;
            this.labelSub.Text = "Subject:";
            this.labelSub.Visible = false;
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(34, 223);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(34, 13);
            this.labelBody.TabIndex = 4;
            this.labelBody.Text = "Body:";
            this.labelBody.Visible = false;
            // 
            // SendingMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 189);
            this.Controls.Add(this.textBoxSub);
            this.Controls.Add(this.labelSub);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSmtp);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.labelFrom);
            this.Name = "SendingMail";
            this.Text = "Sending Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxSmtp;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.Label labelBody;
    }
}