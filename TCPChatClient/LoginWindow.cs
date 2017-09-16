using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;

namespace TCPChatClient
{

    //Форма входа в чат
    public partial class LoginWindow : Form
    {
        static string userName;
        private string host = "";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        static Thread receiveThread;
        static List<string> UsersOnline = new List<string>();
        public LoginWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory+@"\Settings.txt", Encoding.GetEncoding("windows-1251"));
            host = sr.ReadLine();
            sr.Close();  
    }

        private void ShowSettings_Click(object sender, EventArgs e)
        {
            Settings setForm = new Settings();
            setForm.Visible = true;
        }

        private void SignInBut_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length != 0) && (textBox2.Text.Length != 0))
            {
                userName = textBox1.Text;
                string pass = textBox2.Text;
                try
                {
                    client = new TcpClient();
                    client.Connect(host, port); //подключение клиента
                    stream = client.GetStream(); // получаем поток

                    CoreServer.Message tempMes = new CoreServer.Message("connection", userName, "", "", null);
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, tempMes);

                    tempMes = new CoreServer.Message("signIn", userName, pass, DateTime.Now.ToString(), null);
                    formatter.Serialize(stream, tempMes);
                    //Зпускаем новый поток для получения данных
                    receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                    receiveThread.Start(); 
                }
                catch (Exception ex)
                { 
                }
  
            }
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            RegisterWindow RegForm = new RegisterWindow(client, stream,host,port);
            RegForm.Visible = true;
        }


        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
            Environment.Exit(0);
        }

        public void ReceiveMessage()
        {
            bool flag = true;
            while (flag)
            {   try
                {
                    CoreServer.Message RecMes;

                        IFormatter formatter = new BinaryFormatter();
                        RecMes = (CoreServer.Message)formatter.Deserialize(stream);

                    if (RecMes.type == "signAnNo")
                    {
                        MessageBox.Show(RecMes.body);//вывод сообщения
                        flag = false;
                        
                    }
                    else if (RecMes.type == "signAnYes")
                    {
                        MessageBox.Show("Вы успешно авторизировались!");//вывод сообщения

                        this.Invoke(new Action(() =>
                        {
                            this.Visible = false;
                            MainWindow mainForm = new MainWindow(RecMes.UserName, client, stream, UsersOnline);
                            mainForm.Visible = true;
                        }));

                        flag = false;
                    }
                    else if (RecMes.type == "online")
                    { UsersOnline = RecMes.OnlineUser; }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Подключение прервано!");
                    Disconnect();
                    break;
                }
            }

        }

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();

        }


    }
}
