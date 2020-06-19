namespace ChatApplication
{
    partial class PublicChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicChat));
            this.rtbPublicDisplay = new System.Windows.Forms.RichTextBox();
            this.lvConnectedUsers = new System.Windows.Forms.ListView();
            this.rtbPublicMsg = new System.Windows.Forms.RichTextBox();
            this.btnPublicSend = new System.Windows.Forms.Button();
            this.lblPublicWelcome = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblUserOnline = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPublicDisplay
            // 
            this.rtbPublicDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbPublicDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPublicDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbPublicDisplay.Location = new System.Drawing.Point(23, 113);
            this.rtbPublicDisplay.Name = "rtbPublicDisplay";
            this.rtbPublicDisplay.ReadOnly = true;
            this.rtbPublicDisplay.Size = new System.Drawing.Size(617, 323);
            this.rtbPublicDisplay.TabIndex = 0;
            this.rtbPublicDisplay.Text = "";
            // 
            // lvConnectedUsers
            // 
            this.lvConnectedUsers.Font = new System.Drawing.Font("Georgia", 8.5F, System.Drawing.FontStyle.Bold);
            this.lvConnectedUsers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lvConnectedUsers.Location = new System.Drawing.Point(662, 136);
            this.lvConnectedUsers.Name = "lvConnectedUsers";
            this.lvConnectedUsers.Size = new System.Drawing.Size(238, 365);
            this.lvConnectedUsers.TabIndex = 1;
            this.lvConnectedUsers.UseCompatibleStateImageBehavior = false;
            this.lvConnectedUsers.View = System.Windows.Forms.View.List;
            this.lvConnectedUsers.DoubleClick += new System.EventHandler(this.lvConnectedUsers_DoubleClick);
            // 
            // rtbPublicMsg
            // 
            this.rtbPublicMsg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbPublicMsg.Location = new System.Drawing.Point(23, 459);
            this.rtbPublicMsg.Name = "rtbPublicMsg";
            this.rtbPublicMsg.Size = new System.Drawing.Size(502, 42);
            this.rtbPublicMsg.TabIndex = 2;
            this.rtbPublicMsg.Text = "";
            // 
            // btnPublicSend
            // 
            this.btnPublicSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPublicSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPublicSend.Location = new System.Drawing.Point(532, 459);
            this.btnPublicSend.Name = "btnPublicSend";
            this.btnPublicSend.Size = new System.Drawing.Size(108, 42);
            this.btnPublicSend.TabIndex = 3;
            this.btnPublicSend.Text = "Send";
            this.btnPublicSend.UseVisualStyleBackColor = false;
            this.btnPublicSend.Click += new System.EventHandler(this.btnPublicSend_Click);
            // 
            // lblPublicWelcome
            // 
            this.lblPublicWelcome.AutoSize = true;
            this.lblPublicWelcome.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPublicWelcome.Location = new System.Drawing.Point(88, 31);
            this.lblPublicWelcome.Name = "lblPublicWelcome";
            this.lblPublicWelcome.Size = new System.Drawing.Size(318, 24);
            this.lblPublicWelcome.TabIndex = 4;
            this.lblPublicWelcome.Text = "Public Chat Room";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisconnect.Location = new System.Drawing.Point(811, 25);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(88, 41);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblUserOnline
            // 
            this.lblUserOnline.AutoSize = true;
            this.lblUserOnline.Font = new System.Drawing.Font("Georgia", 10F);
            this.lblUserOnline.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUserOnline.Location = new System.Drawing.Point(662, 103);
            this.lblUserOnline.Name = "lblUserOnline";
            this.lblUserOnline.Size = new System.Drawing.Size(110, 20);
            this.lblUserOnline.TabIndex = 6;
            this.lblUserOnline.Text = "Online Users ";
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNickname.Location = new System.Drawing.Point(29, 83);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(30, 17);
            this.lblNickname.TabIndex = 7;
            this.lblNickname.Text = "Hi,";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(23, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(59, 54);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // PublicChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(919, 521);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.lblUserOnline);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblPublicWelcome);
            this.Controls.Add(this.btnPublicSend);
            this.Controls.Add(this.rtbPublicMsg);
            this.Controls.Add(this.lvConnectedUsers);
            this.Controls.Add(this.rtbPublicDisplay);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PublicChat";
            this.Text = "Public Chat Room";
            this.Load += new System.EventHandler(this.PublicChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPublicDisplay;
        private System.Windows.Forms.ListView lvConnectedUsers;
        private System.Windows.Forms.RichTextBox rtbPublicMsg;
        private System.Windows.Forms.Button btnPublicSend;
        private System.Windows.Forms.Label lblPublicWelcome;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblUserOnline;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}