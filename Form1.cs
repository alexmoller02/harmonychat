using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ChatV2
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        

        public Form1()
        {
            InitializeComponent();
            var chatPath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/public.chat");
            var displayChat = File.ReadAllText(chatPath);
            txt_publicChat.Text = displayChat;

        }
        
        private void btn_create_Click(object sender, EventArgs e)
        {
            var usrpath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/users/{txt_username.Text}.user");
            var chatpath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/{txt_username.Text}.pchat");
            var usrLogs = ($"C:/Users/{Environment.UserName}/AppData/Roaming/usrLogs/{txt_username.Text}.log");

            if (!File.Exists(usrpath))
            {
                File.Create(chatpath).Close();
                File.Create(usrLogs).Close();
                File.WriteAllText(usrpath, txt_pass.Text);
                lbl_exists.Text = "User succesfully created!";
                txt_username.Text = "";
                txt_pass.Text = "";
            }
            else if (File.Exists(usrpath))
            {
                lbl_exists.Text = "Sorry an user with that name already exists!";
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var usrpath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/users/{txt_username.Text}.user");
            var Validate = File.ReadAllText(usrpath);
            var privatePath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/{txt_username.Text}.pchat");
            var displayPrivate = File.ReadAllText(privatePath);
            var usrLogs = ($"C:/Users/{Environment.UserName}/AppData/Roaming/usrLogs/{txt_username.Text}.log");

            var chatPath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/public.chat");
            var displayChat = File.ReadAllText(chatPath);
            

           // var timeStamp = File.WriteAllText(usrLogs, DateTime);

            if (txt_pass.Text == Validate)
            {
                lbl_exists.Text = "Succes";
                if (index < listPanel.Count - 1)
                {
                    listPanel[++index].BringToFront();
                    txt_privateChat.Text = displayPrivate;
                    File.AppendAllText(usrLogs,$"{txt_username.Text} Logged in: "+ DateTime.Now.ToString(": dd : HH:{Environment.UserName}:ss Year: yyyy tt")+ Environment.NewLine);
                    File.ReadAllText(chatPath);
                    txt_publicChat.Text = displayChat;
                }

                
            }
            else if (txt_pass.Text != Validate)
            {
                lbl_exists.Text = "Wrong credentials!";
                txt_pass.Text = "";
                txt_username.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();

            var chatPath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/public.chat");
            
            var displayChat = File.ReadAllText(chatPath);
            
           
            txt_publicChat.Text = displayChat;
            
        }

        private void txt_publicChat_TextChanged(object sender, EventArgs e)
        {
           /* var chatPath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/public.chat");
            var displayChat = File.ReadAllText(chatPath);
            File.ReadAllText(chatPath);
            txt_publicChat.Text = displayChat;*/
        }

        private void btn_sendMsg_Click(object sender, EventArgs e)
        {
            //Variables
            var chatPath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/public.chat");
            var displayChat = File.ReadAllText(chatPath);
            var privatePath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/{txt_username.Text}.pchat");
            var displayPrivate = File.ReadAllText(privatePath);
            var pos = txt_usrMsg.Text.IndexOf("@");
            //var directMsg = txt_usrMsg.Text.Substring(1, pos);
            //   var privateChatValidate = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/{directMsg}.pchat");
            



            File.ReadAllText(chatPath);
            txt_publicChat.Text = displayChat;
            if (txt_usrMsg.TextLength > 0)
            {
                if (!txt_usrMsg.Text.StartsWith("@"))
                {
                    txt_publicChat.Text = displayChat;
                    File.AppendAllText(chatPath, txt_username.Text + ": " + txt_usrMsg.Text + ": " + DateTime.Now.ToString("h:MM:ss tt") + Environment.NewLine);
                    File.ReadAllText(chatPath);
                    txt_publicChat.Text = displayChat;
                    txt_usrMsg.Text = "";

                }
            }
           // if (txt_usrMsg.Text.StartsWith("@"))
          //  {
          //      if (File.Exists(privateChatValidate))
          //      {
           //         File.AppendAllText(privateChatValidate, txt_username.Text+ ": "+ txt_usrMsg.Text + " " + DateTime.Now.ToString("h:{Environment.UserName}:ss tt"));
          //          File.ReadAllText(privateChatValidate);
           //         txt_privateChat.Text = displayPrivate;
            //    }
                
          //  }
        }

        private void txt_usrMsg_TextChanged(object sender, EventArgs e)
        {

        }


        private void txt_usrMsg_Enter(object sender, EventArgs e)

        {

            if (txt_usrMsg.Text.Trim() != "" || txt_usrMsg.Text != null)

            {

                txt_usrMsg.Text = "";

            }

        }

        private void ck_privateMessage_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_sendPrivate_Click(object sender, EventArgs e)
        {
            var privatePath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/{txt_username.Text}.pchat");
            var displayPrivate = File.ReadAllText(privatePath);
            var Ppath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/{txt_pName.Text}.pchat");

            File.AppendAllText(Ppath, txt_username.Text + ": " + txt_usrMsg.Text + " " + DateTime.Now.ToString(" dd : HH:MM: Year: yy tt") + Environment.NewLine);
            File.AppendAllText(privatePath, "to: "+txt_pName.Text + ": " + txt_usrMsg.Text + " " + DateTime.Now.ToString(" dd : HH:MM: Year: yy tt") + Environment.NewLine);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            var chatPath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/public.chat");
            var displayChat = File.ReadAllText(chatPath);
            var privatePath = ($"C:/Users/{Environment.UserName}/AppData/Roaming/Chats/{txt_username.Text}.pchat");
            var displayPrivate = File.ReadAllText(privatePath);

            txt_publicChat.Text = displayChat;
            txt_privateChat.Text = displayPrivate;


        }
    }
}
