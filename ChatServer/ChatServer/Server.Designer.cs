namespace ServerApplication
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.lvConnectedServerUsers = new System.Windows.Forms.ListView();
            this.rtbServerDisplay = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOnline = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvGroup = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvAll = new System.Windows.Forms.ListView();
            this.txbMessage = new System.Windows.Forms.RichTextBox();
            this.btnPublicSend = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabOnline.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvConnectedServerUsers
            // 
            this.lvConnectedServerUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvConnectedServerUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConnectedServerUsers.Location = new System.Drawing.Point(3, 3);
            this.lvConnectedServerUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lvConnectedServerUsers.Name = "lvConnectedServerUsers";
            this.lvConnectedServerUsers.Size = new System.Drawing.Size(125, 468);
            this.lvConnectedServerUsers.TabIndex = 1;
            this.lvConnectedServerUsers.UseCompatibleStateImageBehavior = false;
            this.lvConnectedServerUsers.View = System.Windows.Forms.View.List;
            // 
            // rtbServerDisplay
            // 
            this.rtbServerDisplay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbServerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbServerDisplay.Location = new System.Drawing.Point(22, 26);
            this.rtbServerDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.rtbServerDisplay.Name = "rtbServerDisplay";
            this.rtbServerDisplay.ReadOnly = true;
            this.rtbServerDisplay.Size = new System.Drawing.Size(568, 381);
            this.rtbServerDisplay.TabIndex = 3;
            this.rtbServerDisplay.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOnline);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(729, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(139, 500);
            this.tabControl1.TabIndex = 4;
            // 
            // tabOnline
            // 
            this.tabOnline.Controls.Add(this.lvConnectedServerUsers);
            this.tabOnline.Location = new System.Drawing.Point(4, 22);
            this.tabOnline.Name = "tabOnline";
            this.tabOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnline.Size = new System.Drawing.Size(131, 474);
            this.tabOnline.TabIndex = 0;
            this.tabOnline.Text = "Online";
            this.tabOnline.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(131, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhóm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvGroup
            // 
            this.lvGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGroup.Location = new System.Drawing.Point(3, 3);
            this.lvGroup.Name = "lvGroup";
            this.lvGroup.Size = new System.Drawing.Size(125, 468);
            this.lvGroup.TabIndex = 0;
            this.lvGroup.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvAll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(131, 474);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Tất cả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvAll
            // 
            this.lvAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAll.Location = new System.Drawing.Point(3, 3);
            this.lvAll.Name = "lvAll";
            this.lvAll.Size = new System.Drawing.Size(125, 468);
            this.lvAll.TabIndex = 0;
            this.lvAll.UseCompatibleStateImageBehavior = false;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(22, 468);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(433, 45);
            this.txbMessage.TabIndex = 5;
            this.txbMessage.Text = "";
            // 
            // btnPublicSend
            // 
            this.btnPublicSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPublicSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPublicSend.Location = new System.Drawing.Point(482, 468);
            this.btnPublicSend.Name = "btnPublicSend";
            this.btnPublicSend.Size = new System.Drawing.Size(108, 42);
            this.btnPublicSend.TabIndex = 6;
            this.btnPublicSend.Text = "Send";
            this.btnPublicSend.UseVisualStyleBackColor = false;
            this.btnPublicSend.Click += new System.EventHandler(this.btnPublicSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(869, 525);
            this.Controls.Add(this.btnPublicSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rtbServerDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOnline.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvConnectedServerUsers;
        private System.Windows.Forms.RichTextBox rtbServerDisplay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOnline;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvGroup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvAll;
        private System.Windows.Forms.RichTextBox txbMessage;
        private System.Windows.Forms.Button btnPublicSend;
    }
}

