using Microsoft.VisualBasic.Devices;
using ReaLTaiizor.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//服务端的几个按钮功能还没做
//messagebox是错误的，跨了线程了，应该用Invoke回到UI线程处理状态，还没改


//测试

namespace http_client
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Socket SocketClient;//声明一个Socket对象
        bool isConnected = false; // 连接状态标志
        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_connect_Click(object sender, EventArgs e)
        {
            //创建一个Socket对象，参数分别为：地址族、套接字类型、协议类型
            //使用IPv4地址格式，通过TCP协议进行可靠的、面向连接的网络数据流通信
            SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建一个Socket对象

            // 第一步：从界面控件获取字符串数据
            string ipStr = tb_ServerIP.Text.Trim();      // 获取IP地址字符串
            string portStr = tb_ServerPort.Text.Trim();  // 获取端口号字符串

            // 第二步：进行类型转换
            IPAddress ipAddress = null;
            int port = 0;
            if (ipStr != "" && portStr != "")
            {
                ipAddress = IPAddress.Parse(ipStr); // 将字符串解析为IPAddress对象
                port = int.Parse(portStr); // 将字符串解析为整数
            }
            else { MessageBox.Show("请输入服务端IP和端口"); }

            // 第三步：使用转换后的对象创建IPEndPoint实例
            IPEndPoint ip_port = new IPEndPoint(ipAddress, port);

            // 第四步：尝试连接服务端
            try
            {
                SocketClient.Connect(ip_port); // 连接到服务端
                //改变状态栏的文本与颜色，表示成功
                tslb_connect.Text = "成功连接至服务端！";
                tslb_connect.BackColor = Color.Green;
                toolStripStatusLabel1.BackColor = Color.Green;
                isConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tslb_connect.Text = "连接失败！";
                tslb_connect.BackColor = Color.Red;
                toolStripStatusLabel1.BackColor = Color.Red;
            }

            if (isConnected)
            {
                Task.Run(new Action(() =>
                {
                    // 监听接收服务器发送的数据
                    ReceiveServer();
                }));

            }

        }

        /// <summary>
        /// 循环监听服务器发送的消息
        /// </summary>
        public void ReceiveServer()
        {
            //循环监听服务器发送的消息
            while (true)
            {
                //1.创建一个缓冲区来存储接收到的数据
                byte[] buffer = new byte[1024];
                //2.数据长度
                int length = -1;

                try
                {
                    length = SocketClient.Receive(buffer);
                }
                catch (Exception ex)
                {
                    //通过 Invoke 回到 UI 线程处理状态
                    Invoke(new Action(() =>
                    {
                        tslb_connect.Text = "连接异常断开";
                        tslb_connect.BackColor = Color.Red;
                    }));
                    break; // 跳出死循环，结束该后台线程
                }

                if (length > 0)
                {
                    string data = Encoding.UTF8.GetString(buffer);


                    Invoke(new Action(() =>
                    {
                        rtb_Receive.AppendText(data + Environment.NewLine);

                    }));

                }


            }

        }

        /// <summary>
        /// 发送ASCII数据到服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sendascii_Click(object sender, EventArgs e)
        {
            //Socket 传输数据时，只认识二进制流，也就是 byte[]（字节流）
            //因此，在发送数据之前，需要将字符串转换为 byte[] 类型的数据
            byte[] data = Encoding.ASCII.GetBytes(tb_SendToServer.Text.Trim()); // 将输入的字符串转换为ASCII编码的字节数组

            //?.防止 SocketClient 对象为 null 时引发 NullReferenceException 异常，如果 SocketClient 不为 null，则调用 Send 方法发送数据
            SocketClient?.Send(data);
        }

        /// <summary>
        /// 发送UTF8数据到服务端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sendutf8_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(tb_SendToServer.Text.Trim());
            SocketClient?.Send(data);
        }

        /// <summary>
        /// 断开服务器连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            SocketClient?.Close();//?.防止 SocketClient 对象为 null 时引发 NullReferenceException 异常，如果 SocketClient 不为 null，则调用 Close 方法关闭连接
            tslb_connect.Text = "未连接";
            tslb_connect.BackColor = Color.Yellow;


        }



        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////


        //服务端
        Socket SocketServer;//声明一个Socket对象
        //保存当前在线的客户端列表（字典）
        public Dictionary<string,Socket>CurrentClientsList = new Dictionary<string,Socket>();
       
        
        
        /// <summary>
        /// 开启服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartServer_Click(object sender, EventArgs e)
        {
            //创建一个Socket对象
            SocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string ipStr = tb_ClientIP.Text.Trim();      // 获取IP地址字符串
            string portStr = tb_ClientPort.Text.Trim();  // 获取端口号字符串
            IPAddress ipAddress = null;
            int port = 0;
            if (ipStr != "" && portStr != "")
            {
                ipAddress = IPAddress.Parse(ipStr); // 将字符串解析为IPAddress对象
                port = int.Parse(portStr); // 将字符串解析为整数
            }
            else { MessageBox.Show("请输入服务端IP和端口"); }


          
            IPEndPoint ip_port = new IPEndPoint(ipAddress,port);

            try
            {
                SocketServer.Bind(ip_port);
                toolStripStatusLabel3.Text = "服务已启动！";
                toolStripStatusLabel3.BackColor = Color.Green;
            }
            catch
            {
                
            
            }

            //可以连接十个设备
            SocketServer.Listen(10);

            Task.Run(new Action(() =>
            {

                ListenClient();
            }));


        }


        public void ListenClient()
        {
            while (true)
            {
                //等待客户端连接，并返回一个新的 Socket 对象，用于与该客户端进行通信
                Socket socketClient = SocketServer.Accept();
                //获取客户端的信息
                string client = socketClient.RemoteEndPoint.ToString();

                //保存到字典(成对的进行数据保存)
                CurrentClientsList.Add(client, socketClient);

                UpdateClientListBox(client, 1); //更新客户端列表框，参数1表示添加
                Task.Run(new Action(() => {

                   ReceiveClient(socketClient);

                }));

            }



        }

        /// <summary>
        /// 更新客户端在线列表
        /// </summary>
        /// <param name="client"></param>
        /// <param name="add_or_delete"></param>
        public void UpdateClientListBox(string client,int add_or_delete)
        {
            if (add_or_delete ==1)
            {
                Invoke(new Action(() =>
                {
                    listBox1.Items.Add(client);
                }));
            }
            else
            {
                foreach (var item in listBox1.Items)
                { 
                    if(item == client)
                    {listBox1.Items.Remove(item); }
                    break;
                }
            }

        }

        /// <summary>
        /// 循环监听客户端发送的消息，并且显示在服务端的接收框中
        /// </summary>
        public void ReceiveClient(Socket Client)
        {
            while (true)
            {
                
                byte[] buffer = new byte[1024];

                int length = -1;

                try
                {
                    length = Client.Receive(buffer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    ////通过 Invoke 回到 UI 线程处理状态
                    //Invoke(new Action(() =>
                    //{
                    //    toolStripStatusLabel3.Text = "连接异常断开";
                    //    toolStripStatusLabel3.BackColor = Color.Red;
                    //}));
                    //break; // 跳出死循环，结束该后台线程
                }



                if (length > 0)
                {
                    string data = Encoding.UTF8.GetString(buffer);


                    Invoke(new Action(() =>
                    {
                        rtb_Receive_Server.AppendText(data + Environment.NewLine);

                    }));

                }




            }


        }




    }
}