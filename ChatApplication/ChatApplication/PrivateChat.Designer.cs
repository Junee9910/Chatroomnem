namespace ChatApplication
{
    partial class PrivateChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateChat));
            this.rtbPrivateDisplay = new System.Windows.Forms.RichTextBox();
            this.rtbPrivateMsg = new System.Windows.Forms.RichTextBox();
            this.btnPrivateSend = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPrivateDisplay
            // 
            this.rtbPrivateDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbPrivateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPrivateDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbPrivateDisplay.Location = new System.Drawing.Point(29, 74);
            this.rtbPrivateDisplay.Name = "rtbPrivateDisplay";
            this.rtbPrivateDisplay.ReadOnly = true;
            this.rtbPrivateDisplay.Size = new System.Drawing.Size(569, 327);
            this.rtbPrivateDisplay.TabIndex = 0;
            this.rtbPrivateDisplay.Text = "";
            // 
            // rtbPrivateMsg
            // 
            this.rtbPrivateMsg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbPrivateMsg.Location = new System.Drawing.Point(29, 432);
            this.rtbPrivateMsg.Name = "rtbPrivateMsg";
            this.rtbPrivateMsg.Size = new System.Drawing.Size(437, 38);
            this.rtbPrivateMsg.TabIndex = 1;
            this.rtbPrivateMsg.Text = "";
            // 
            // btnPrivateSend
            // 
            this.btnPrivateSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrivateSend.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrivateSend.Location = new System.Drawing.Point(493, 432);
            this.btnPrivateSend.Name = "btnPrivateSend";
            this.btnPrivateSend.Size = new System.Drawing.Size(79, 38);
            this.btnPrivateSend.TabIndex = 2;
            this.btnPrivateSend.Text = "Send";
            this.btnPrivateSend.UseVisualStyleBackColor = false;
            this.btnPrivateSend.Click += new System.EventHandler(this.btnPrivateSend_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(97, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 24);
            this.lblName.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(29, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(45, 42);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // PrivateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 490);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPrivateSend);
            this.Controls.Add(this.rtbPrivateMsg);
            this.Controls.Add(this.rtbPrivateDisplay);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrivateChat";
            this.Text = "Private Chat ";
            this.Load += new System.EventHandler(this.PrivateChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbPrivateMsg;
        private System.Windows.Forms.Button btnPrivateSend;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox rtbPrivateDisplay;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}