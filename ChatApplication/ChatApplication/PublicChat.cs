/*
 * Author Nadeem Fazloon : CB006456
 * 
 * 
 * 
 * 
 * */



using System;
using System.Collections;
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
    public partial class PublicChat : Form
    {
        string serverMsg = "";
        bool flag = false;
        string token = "";
        
        Thread thread;
        public ArrayList clients = new ArrayList();
		
		private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public PublicChat()
        {
            InitializeComponent();
        }

        private void PublicChat_Load(object sender, EventArgs e)
        {
            rtbPublicMsg.Select();
            lblNickname.Text = lblNickname.Text+ Variables.nickName+" ";

            thread = new Thread(getMsg);
            thread.Start();
            
        }

        private void getMsg() {

            byte[] bClients = new byte[1380];
            int c = Variables.stm.Read(bClients,0,1380);

            string clientL = "";
            for (int i = 1; i < c; i++)
                clientL = clientL + Convert.ToChar(bClients[i]);

            string[] clientTokens = clientL.Split(new char[] {','});
            for (int i=0;i<clientTokens.Length;i++) {
                
				clients.Add(clientTokens[i]);
				if (!clientTokens[i].Equals(Variables.nickName))
				{
					addClient(clientTokens[i]);
				}
            
            }
			
			token = "JOIN";
            serverMsg = Variables.nickName+", Welcome to the chat room!";
            message(Variables.nickName.Length);

            while (true) {

                byte[] bServerMsg = new byte[200];
                int k = Variables.stm.Read(bServerMsg, 0, 200);

                string chat = "";
                for (int i = 0; i < k; i++)
                    chat = chat + Convert.ToChar(bServerMsg[i]);

                string[] tokens = chat.Split(new char[] { '|' },2);
                token = tokens[0];

                if (tokens[0].Equals("PRIV")) {
                    privateMsg(tokens[1]);

                }else{

                    serverMsg = tokens[1];
					string cName = getClientName(tokens[1]);

                    int nameSize = Variables.nickName.Length;
                    if (cName.Equals(Variables.nickName))
                    {
                        flag = true;
                        serverMsg = serverMsg.Substring(nameSize + 2);
                    }
                    
                    message(cName.Length);
					
                    if (tokens[0].Equals("JOIN")) {

                        if (!cName.Equals(Variables.nickName)) {

                            //add nickname to online client list
                            addClient(cName);
                            clients.Add(cName);

                        }
                        
                    }

                    if (tokens[0].Equals("LEFT"))
                    {
                        //remove nickname from online client list
                        removeClient(cName);
                        clients.Remove(cName);
                    }


                }
                
            }
        }

        private void privateMsg(string message) {

            string privateFriend = getClientName(message);

            int privateFriendSize = privateFriend.Length;

            //if private chat open send message to that chat form
            bool isPCOpen = false;
            foreach (PrivateChat pc in Application.OpenForms.OfType<PrivateChat>()){

                if (pc.name == privateFriend){

                    if (message.Substring(privateFriendSize + 1).Equals("sent")){
                        pc.serverMsg = "sent";
                    }else{
                        pc.serverMsg = message;
                    }

                    pc.message();
                    isPCOpen = true;
                    break;
                }
            }

            //if private chat not open, create one and send message to that chat form
            if (isPCOpen == false){
                createPrivateChat(privateFriend,message,privateFriendSize);
                isPCOpen = true;
            }

        }
		
		public string getClientName(string message) {

            string cName = "";
            //get client nickname
            char[] msg = message.ToCharArray();
            int n = 0;
            while (msg[n] != ':')
            {
                cName = cName + msg[n];
                n++;
            }
            return cName;
        }


        private void message(int cSize) {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(()=>message(cSize)));
            }
            else {
                if (flag)
                {
                    rtbPublicDisplay.SelectionAlignment = HorizontalAlignment.Right;
                    rtbPublicDisplay.AppendText(serverMsg + Environment.NewLine);
					rtbPublicDisplay.ScrollToCaret();
                    rtbPublicDisplay.SelectionAlignment = HorizontalAlignment.Left;
                    flag = false;
                }
                else {
                    if (token.Equals("JOIN")|| token.Equals("LEFT")) {
                        rtbPublicDisplay.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    rtbPublicDisplay.SelectionFont = new Font(rtbPublicDisplay.Font, FontStyle.Bold);
                    rtbPublicDisplay.AppendText(serverMsg.Substring(0, cSize+1));
                    rtbPublicDisplay.SelectionFont = new Font(rtbPublicDisplay.Font, FontStyle.Regular);
                    rtbPublicDisplay.AppendText(serverMsg.Substring(cSize+1) + Environment.NewLine + Environment.NewLine);
					rtbPublicDisplay.ScrollToCaret();
                    rtbPublicDisplay.SelectionAlignment = HorizontalAlignment.Left;
                }
                
                serverMsg = "";
            }
        }

        private void addClient(string client)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(()=>addClient(client)));
            }
            else
            {
                lvConnectedUsers.Items.Add(client);
            }
        }

        private void removeClient(string client) {
            if (this.InvokeRequired)
            {
                
                this.Invoke(new MethodInvoker(()=>removeClient(client)));
            }
            else
            {
           
                foreach (ListViewItem it in lvConnectedUsers.Items){
                    if (it.Text.Equals(client))
                    {
                        lvConnectedUsers.Items.Remove(it);
                        break;
                    }

                }
                  
            }
        }
		
		private void createPrivateChat(string privateFriend, string message, int privateFriendSize) {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => createPrivateChat(privateFriend,message, privateFriendSize)));
            }
            else
            {
                PrivateChat pc = new PrivateChat();
                pc.name = privateFriend;
                pc.Show();
                if (message.Substring(privateFriendSize + 1).Equals("sent"))
                {
                    pc.serverMsg = "sent";
                }
                else
                {
                    pc.serverMsg = message;
                }
                pc.message();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes("DIS|exit");
            Variables.stm.Write(ba, 0, ba.Length);
            Variables.stm.Flush();

            thread.Abort();
            Variables.tcpclnt.Close();
			Variables.stm.Dispose();

            Welcome welcome = (Welcome)Application.OpenForms["Welcome"];
            welcome.Show();
            
            foreach (PrivateChat pc in Application.OpenForms.OfType<PrivateChat>().ToList()) {
                pc.Close();
            }
            this.Close();
            
        }

        private void btnPublicSend_Click(object sender, EventArgs e)
        {
			if (rtbPublicMsg.Text.Length>145) {
                MessageBox.Show("You have exceeded the character limit", "Alert");
            } else {
                ASCIIEncoding asen = new ASCIIEncoding();
				byte[] bMsg = asen.GetBytes("PUBLIC|"+rtbPublicMsg.Text);

				Variables.stm.Write(bMsg, 0, bMsg.Length);
				Variables.stm.Flush();
				rtbPublicMsg.Text = "";
				rtbPublicMsg.Select();
			}
        }

        private void lvConnectedUsers_DoubleClick(object sender, EventArgs e)
        {
            bool check = true;
            foreach (PrivateChat pch in Application.OpenForms.OfType<PrivateChat>().ToList()) {
                if (pch.name.Equals(lvConnectedUsers.SelectedItems[0].Text)) {
                    pch.WindowState = FormWindowState.Minimized;
                    pch.Show();
                    pch.WindowState = FormWindowState.Normal;
                    check = false;
                    break;
                }
            }

            if (check) {
                PrivateChat pc = new PrivateChat();
                pc.name = Convert.ToString(lvConnectedUsers.SelectedItems[0].Text);
                pc.Show();
            }
            
        }
    }
}
