using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using FontAwesome.Sharp;

namespace server
{
    public partial class displayscreen : Form
    {

        // ********************DESIGN PART **********************************
        //Color of Left Panel
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Color BackgroundButton = Color.FromArgb(37, 36, 81);

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 188, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = BackgroundButton;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();


            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public TcpClient client;
        public TcpListener server;
        public Thread listening;
        public Thread getImage;
        public Thread sendData;
        public Thread receiveMessage;
        public NetworkStream nSteam;
        public int port;
        public displayscreen(TcpClient obj1,TcpListener obj2,int port)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.client=obj1 as TcpClient;
            this.server = obj2 as TcpListener;
            this.port = port;
            //client = new TcpClient();
            //tạo luồng để lắng nghe kết nối từ client
            listening = new Thread(startListening);
            //tạo luồng nhận dữ liệu màn hình 
            getImage = new Thread(receiveImage);
            //tạo luồng nhận dữ liệu tin nhắn từ client
           
            //this.port = port;
            //server = new TcpListener(IPAddress.Any, port);
            listening.Start();
        }  
        //hàm lắng nghe kết nối
        private void startListening()
        { 
            //while (!client.Connected)
            //{
            //    server.Start();
            //    client = server.AcceptTcpClient();
            //}
            getImage.Start();//bắt đầu nhận dữ liệu hình ảnh
            getImage.Join();
        }
        //hàm nhận dữ liệu hình ảnh
        private void receiveImage()
        {
            BinaryFormatter bin = new BinaryFormatter(); 
                while (client.Connected)
                {
                    nSteam = client.GetStream();
                while(true)
                {
                    try { pictureBox1.Image = (Image)bin.Deserialize(nSteam); }

                    catch
                    {
                        break;
                    }
                }
                }                                           
        }
        //khi form displayscreen đóng thì gọi hàm stopListening để đóng kết nối socket
        private void Displayscreen_closing(object sender, FormClosingEventArgs e)
        {
            stopListening();
        }
        //Hàm đóng kết nối socket
        private void stopListening()
        {
            server.Stop();
            client = null;
            if (listening.IsAlive)
            {
                listening.Abort();
            }
            if (getImage.IsAlive)
            {
                getImage.Abort();
            }
            
        }
        

        //hàm gửi lệnh tắt máy
        void sendshutdown()
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("!@#$%^&*()");
            nSteam.Write(data, 0, data.Length);
        }
        //hàm gửi lệnh restart
        void sendrestart()
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("+_)(*&^%$#@!");
            nSteam.Write(data, 0, data.Length);
        }
        

        //hàm gửi lệnh sleep cho client
        void sendsleep()
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("<>?:{}|");
            nSteam.Write(data, 0, data.Length);
        }   

        
        void sendChat()
        {
            Byte[] data = System.Text.Encoding.UTF8.GetBytes("__________");
            nSteam.Write(data, 0, data.Length);
        }    

        //button tạo thread để gửi thông báo cho client tắt máy
        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("client is shutdowning.");
            sendData = new Thread(sendshutdown);
            sendData.Start();
            ActivateButton(sender, RGBColors.color1);
        }
        //button gửi lệnh restart cho client
        private void iconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("client is restarting.");
            sendData = new Thread(sendrestart);
            sendData.Start();
            ActivateButton(sender, RGBColors.color2);
        }
        //button gửi lệnh sleep cho client
        private void iconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("client is sleeping.");
            sendData = new Thread(sendsleep);
            sendData.Start();
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            sendChat();
            khungchat_server f = new khungchat_server(port);
            f.Show();
            ActivateButton(sender, RGBColors.color4);
        }

        private void displayscreen_Load(object sender, EventArgs e)
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panel1.Controls.Add(leftBorderBtn);
        }
    }
}
