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
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApplication
{
    public partial class Server : Form
    {

        ServerHandling serverH;
        public string msg = "";

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {

            serverH = new ServerHandling();
            serverH.startServer();

            Thread t = new Thread(serverH.listen);
            t.Start();
            ChatEntities db = new ChatEntities();
            var user = db.Accounts.ToList();
            foreach (var u in user )
            {
                lvAll.Items.Add(u.Name);
            }
        }

        public void appendDisplay() {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(appendDisplay));
            }
            else
            {
                rtbServerDisplay.AppendText(msg + Environment.NewLine);
				rtbServerDisplay.ScrollToCaret();
                msg = "";
            }
        }

        public void addClient(string clientChange) {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(()=>addClient(clientChange)));
            }
            else
            {
                lvConnectedServerUsers.Items.Add(clientChange);
            }
        }

        public void removeClient(string clientChange) {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(()=>removeClient(clientChange)));
            }
            else
            {
                foreach (ListViewItem it in lvConnectedServerUsers.Items) {
                    if (it.Text.Equals(clientChange)) {
                        lvConnectedServerUsers.Items.Remove(it);
                        break;
                    }
                }

            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPublicSend_Click(object sender, EventArgs e)
        {
            ServerHandling.broadcast("server",txbMessage.Text, "msg");


        }
    }

    public class ServerHandling {

        public static Hashtable clientsList = new Hashtable();//danh sách sk


        TcpListener myListener;
        ASCIIEncoding asen = new ASCIIEncoding();
        Server server = (Server)Application.OpenForms["Server"];
		
		private static readonly object locker = new object();

        public void startServer() {

            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            myListener = new TcpListener(ipAd, 8001);
            myListener.Start();

            server.msg = ">> Server Started";
            server.appendDisplay();
        }


        public void listen() {

            int numberOfClients = 0;
            Socket s;

            while (true)
            {

                s = myListener.AcceptSocket();

                if (numberOfClients >= 30) {

                    s.Send(asen.GetBytes("ERROR|Chat Room Full, Try Again Later!"));
					s.Close();

                } else {

                    string nicknameRef = checkNickname(s);

                    if(nicknameRef.Equals("true"))
                    {
                        s.Send(asen.GetBytes("ERROR|Nickname is already in use!"));
                        s.Close();
                    }else{
						s.Send(asen.GetBytes("CLIENTS|"));

						clientsList.Add(nicknameRef, s);
						numberOfClients = clientsList.Count;

						ClientHandling client = new ClientHandling();
						client.start(nicknameRef, s);

						broadcast(nicknameRef, "", "join");

						server.msg = "Client No: " + numberOfClients + " " + nicknameRef + " - connected to the server ";
						server.appendDisplay();
						server.addClient(nicknameRef);
					}

                }          

            }

            s.Close();
            myListener.Stop();

        }

        public string checkNickname(Socket s)
        {

            //receive nickname from client
            string clientNickname;
            byte[] bClientNickname = new byte[100];
            int k = s.Receive(bClientNickname);
            clientNickname = Encoding.UTF8.GetString(bClientNickname, 0, k);

            //check if nickname is already in use
            if (clientsList.ContainsKey(clientNickname))
            {
                return "true";
            }
            else
            {
                return clientNickname;
            }

        }

        public string getClients()
        {
            string clients = "";
            foreach (DictionaryEntry Item in clientsList) {
				clients = clients + "," + (string)Item.Key;
            }
            return clients;
        }

        public static void broadcast(string clientName, string msg, string flag)
        {

			lock (locker) {

                ASCIIEncoding asenb = new ASCIIEncoding();

				foreach (DictionaryEntry Item in clientsList)
				{
					Socket cs = (Socket)Item.Value;
					if (flag == "msg")
					{
						cs.Send(asenb.GetBytes("PUBLIC|"+clientName + ": " + msg));          
					}
					else if (flag == "join")
					{
						if (!clientName.Equals((string)Item.Key)) {
							cs.Send(asenb.GetBytes("JOIN|" + clientName + ": - joined the chat room"));
						}
					}
					else
					{
						cs.Send(asenb.GetBytes("LEFT|" + clientName + ": - left the chat room"));  
					}

				}
			}

        }

        public void privateMsg(string sender, string receiver, string msg, Socket cs) {

            ASCIIEncoding asenb = new ASCIIEncoding();
            
            if (clientsList.ContainsKey(receiver))
            {
                Socket cr = (Socket)clientsList[receiver];
                cs.Send(asenb.GetBytes("PRIV|" + receiver + ":" + "sent"));
                cr.Send(asenb.GetBytes("PRIV|"+sender + ": " + msg));

                server.msg = ">> Private Message from Client: " + sender + " to " + receiver + " - " + msg;
                server.appendDisplay();
            }
            else
            {
                cs.Send(asenb.GetBytes("PRIV|" + receiver + ":_no longer connected."));
                server.msg = ">> Private Message from Client: "+sender+" to Dissconnected Client "+receiver+" - "+msg+" - FAIL";
                server.appendDisplay();
            }

        }

    }

    public class ClientHandling {

        public string nickname;
        Socket s;
        Thread thread;
        Server server = (Server)Application.OpenForms["Server"];

        public void start(string nickname, Socket s) {
            this.nickname = nickname;
            this.s = s;
            thread = new Thread(chat);
            thread.Start();
        }

        public void chat() {
            ServerHandling sh = new ServerHandling();
            ASCIIEncoding asen = new ASCIIEncoding();

            string clients = sh.getClients();
            s.Send(asen.GetBytes(clients));

            int msgCount = 1;

            byte[] bmsg = new byte[1000];
            int k = s.Receive(bmsg);
            string msg = Encoding.UTF8.GetString(bmsg, 0, k);
            string[] token = msg.Split(new char[] { '|' }, 2);


            while (token[0] != "DIS")
            {

                //check if it is a private msg, if so only to one client else broadcast. for now onlt broad cast

                if (token[0].Equals("PRIV"))
                {
                    int i = 1;
                    string receiver = "";

                    while (token[1][i] != '#')
                    {
                        receiver = receiver + token[1][i];
                        i++;
                    }

                    string newMsg = token[1].Substring(i + 1);

                    sh.privateMsg(nickname, receiver, newMsg, s);

                }
                else
                {
                    ServerHandling.broadcast(nickname, token[1], "msg");
                    server.msg = ">> Messages " + msgCount + " from " + nickname + " - " + token[1];
                    server.appendDisplay();
                    msgCount += 1;
                }

                k = s.Receive(bmsg);
                msg = Encoding.UTF8.GetString(bmsg, 0, k);
                token = msg.Split(new char[] { '|' }, 2);

            }

            ServerHandling.broadcast(nickname, msg, "left");

            server.msg = ">> Client:" + nickname + " - disconnected from the server";
            server.appendDisplay();
            server.removeClient(nickname);

            ServerHandling.clientsList.Remove(nickname);
            s.Close();
            thread.Join();
        }
    }
}
