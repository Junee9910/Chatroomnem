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
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Welcome : Form
    {
        
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            lblWmsg.Text = "";

            //accessing form values
            string ipAddress = txtIPAddress.Text;
            string nickname = txtNickname.Text;

            if (nickname=="") {
                lblWmsg.Text = "Please fill all fields.";
            }else {
				
				if (nickname.Contains(":")){
                    lblWmsg.Text = "Your nickname cannot contain the character \':\' . ";
				}else if(nickname.Length > 45)
                {
					lblWmsg.Text = "Your nickname cannot exceed 45 characters . ";
                }else{
					
					//creating variable to hold server response
					string serverResponse="";

					try{
						//creating connection to the server
						Variables.tcpclnt = new TcpClient();
						Variables.tcpclnt.Connect("127.0.0.1", 8001);
						Variables.stm = Variables.tcpclnt.GetStream();

                        ASCIIEncoding asen = new ASCIIEncoding();
						//sending nickname to the server
						byte[] bNickname = asen.GetBytes(nickname);
						Variables.stm.Write(bNickname, 0, bNickname.Length);
						Variables.stm.Flush();

                        //nhận phản hồi của máy chủ
                        byte[] bNicknameResponse = new byte[1000];
						int k = Variables.stm.Read(bNicknameResponse, 0, 1000);

						for (int i = 0; i <= k; i++)
						{
							serverResponse = serverResponse + Convert.ToChar(bNicknameResponse[i]);
						}

						string[] tokens = serverResponse.Split(new char[] { '|' },2);

						//checking server response
						if (tokens[0].Equals("CLIENTS"))
						{
							
							Variables.nickName = nickname;
							Variables.puC = new PublicChat();
							Variables.puC.Show();
							
							this.Hide();
						
						}else {
						
							txtNickname.Text = "";
							lblWmsg.Text = tokens[1];
							Variables.tcpclnt.Close();
							Variables.stm.Dispose();
						}
						
					}catch (SocketException) {
                        lblWmsg.Text = "Cannot connect to the IP Address entered!";
                        txtIPAddress.Text = "";
                    }					
				}   

            }

        }
    }
}
