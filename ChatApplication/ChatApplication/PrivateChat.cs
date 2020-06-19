/*
 * Author Nadeem Fazloon : CB006456
 * 
 * 
 * 
 * 
 * */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class PrivateChat : Form
    {
        public string serverMsg = "";
        public string name;

        public PrivateChat()
        {
            InitializeComponent();
        }

        private void PrivateChat_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            rtbPrivateMsg.Select();
        }

        private void btnPrivateSend_Click(object sender, EventArgs e)
        {
            if (rtbPrivateMsg.Text.Length>145) {
                MessageBox.Show("You have exceeded the character limit","Alert");
            } else {
				rtbPrivateDisplay.SelectionAlignment = HorizontalAlignment.Right;
				rtbPrivateDisplay.AppendText(rtbPrivateMsg.Text+Environment.NewLine);
				rtbPrivateDisplay.ScrollToCaret();
				rtbPrivateDisplay.SelectionAlignment = HorizontalAlignment.Left;

				ASCIIEncoding asen = new ASCIIEncoding();
				byte[] bMsg = asen.GetBytes("PRIV|#"+name+"#"+rtbPrivateMsg.Text);

				Variables.stm.Write(bMsg, 0, bMsg.Length);
				Variables.stm.Flush();
				rtbPrivateMsg.Text = "";
				rtbPrivateMsg.Select();
			}
        }

        public void message()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(message));
            }
            else
            {
                if (serverMsg=="sent")
                {
                    rtbPrivateDisplay.SelectionAlignment = HorizontalAlignment.Right;
                    rtbPrivateDisplay.SelectionFont = new Font(rtbPrivateDisplay.Font, FontStyle.Italic);
                    rtbPrivateDisplay.AppendText(serverMsg + Environment.NewLine + Environment.NewLine);
					rtbPrivateDisplay.ScrollToCaret();
                    rtbPrivateDisplay.SelectionFont = new Font(rtbPrivateDisplay.Font, FontStyle.Regular);
                    rtbPrivateDisplay.SelectionAlignment = HorizontalAlignment.Left;

                }
                else
                {
                    int Nsize = name.Length;
                    if (serverMsg.Substring(Nsize + 1).Equals("_no longer connected.")){
                        rtbPrivateDisplay.SelectionAlignment = HorizontalAlignment.Center;
                        rtbPrivateDisplay.AppendText(name+" is no longer connected to the chat server! " + Environment.NewLine);
                        rtbPrivateDisplay.ScrollToCaret();
                        rtbPrivateDisplay.SelectionAlignment = HorizontalAlignment.Left;

                    }
                    else {
                        rtbPrivateDisplay.SelectionFont = new Font(rtbPrivateDisplay.Font, FontStyle.Bold);
                        rtbPrivateDisplay.AppendText(serverMsg.Substring(0, name.Length+1));
                        rtbPrivateDisplay.SelectionFont = new Font(rtbPrivateDisplay.Font, FontStyle.Regular);
                        rtbPrivateDisplay.AppendText(serverMsg.Substring(name.Length+1) + Environment.NewLine + Environment.NewLine);
                        rtbPrivateDisplay.ScrollToCaret();
                    }
                }

                serverMsg = "";
            }
        }
    }
}
