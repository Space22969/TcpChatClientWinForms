using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPChatClient
{
    public partial class MainWindow : Form
    {
        static string yourName;//Имя пользователя
        static TcpClient client;
        static NetworkStream stream;
        static List<string> UsersOnline = new List<string>();//Онлайн пользователи

        public MainWindow(string personName, TcpClient iNclient,NetworkStream iNstream, List<string> inUsersOnline)
        {
            InitializeComponent();
            yourName = personName;
            client = iNclient;
            stream = iNstream;
            this.StartPosition = FormStartPosition.CenterScreen;
            UsersOnline = inUsersOnline;   
            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start(); 
            ChatBody.AppendText(DateTime.Now.ToShortTimeString() + ": Добро пожаловать в чат!" + Environment.NewLine);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (SendBody.Text.Length != 0)
            {
                //Отправка сообщения
                string date = DateTime.Now.ToString();
                SendMessage(SendBody.Text, date);
                SendToBody(date, "ВЫ", SendBody.Text, 0);
                SendBody.Clear();
            }
            else MessageBox.Show("Введите сообщение!");
        }

        static void SendMessage(string message, string DateTime)//Метод отправки сообщения серверу
        {
            CoreServer.Message tempMes = new CoreServer.Message("mess", yourName, message, DateTime, null);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, tempMes);
        }

         public void ReceiveMessage()//Получение сообщений и их обработка
        {
            CoreServer.Message RecMes;
            IFormatter ReqOn = new BinaryFormatter();
            while (true)
            {
                try
                {
                    do
                    { 
                        RecMes = (CoreServer.Message)ReqOn.Deserialize(stream);
                    }
                    while (stream.DataAvailable);
                    
                    string userName = RecMes.UserName;

                    if (RecMes.type == "mess")//Сообщение "Сообщение"
                    {
                        UsersOnline = RecMes.OnlineUser;
                        SendToBody(RecMes.DateTime, userName, RecMes.body, 1);
                        OnlineUsersShow();
                    }

                    else if (RecMes.type == "signIn")//Сообщение "Вход в чат"
                    {
                        UsersOnline = RecMes.OnlineUser;
                        SendToBody(RecMes.DateTime, userName, "вошёл в чат!", 2);
                        OnlineUsersShow();
                    }
                    else if (RecMes.type == "exit")//Сообщение "Выход"
                    {
                        UsersOnline = RecMes.OnlineUser;
                        SendToBody(RecMes.DateTime, userName, "покинул чат!", 2);
                        OnlineUsersShow();
                    }

                    else if (RecMes.type == "online")//Сообщение "Онлайн"
                    { 
                            if (RecMes.OnlineUser != null)
                            {
                                  UsersOnline = RecMes.OnlineUser;
                            }

                        OnlineUsersShow();
                    }

                }
               catch (Exception ex)
                {
                    MessageBox.Show("Подключение прервано!"); //соединение было прервано
                    Disconnect();
                    break;
                }
            }
        }

        public void OnlineUsersShow()//Вывод списка онлайн пользователей
        {
            if (UsersOnline != null)

                Online.Invoke(new Action(() =>
                {
                    for (int i = 0; i < Online.Items.Count; i++)
                    {
                        if (!UsersOnline.Contains(Online.Items[i]))
                            Online.Items.Remove(Online.Items[i]);
                    }

                    for (int i = 0; i < UsersOnline.Count; i++)
                    {
                        if (!Online.Items.Contains(UsersOnline[i]))
                            Online.Items.Add(UsersOnline[i]);
                    }

                }));
        }
        public void SendToBody(string date, string name, string body, int type)//Вывод сообщений в главное окно чата
        {
            ChatBody.Invoke(new Action(() =>
            {
                ChatBody.SelectionFont = new Font(ChatBody.Font.FontFamily, this.Font.Size, FontStyle.Bold);
                ChatBody.AppendText(date.Remove(0,11).Remove(5)); ChatBody.AppendText(": ");
                if (type == 1)
                {

                    ChatBody.SelectionColor = Color.Red;
                }
                ChatBody.AppendText(name);
                ChatBody.SelectionColor = Color.Black;
                if (type == 1)
                {
                    ChatBody.AppendText(": ");
                    ChatBody.SelectionFont = new Font(ChatBody.Font.FontFamily, this.Font.Size, FontStyle.Regular);
                }
                           else ChatBody.AppendText(" ");
                ChatBody.AppendText(body + Environment.NewLine);
                ChatBody.ScrollToCaret();
            }));
        }


        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//Отключение потока
            if (client != null)
                client.Close();//Отключение клиента
            Environment.Exit(0);//Завершение процесса
        }


        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
            Environment.Exit(0);
        }

        private void SendBody_KeyDown(object sender, KeyEventArgs e)//Отправка сообщений по нажатию кнопки.
        {
            
            if (e.KeyCode == Keys.Return )
            {
                if (SendBody.Text.Length != 0)
                {
                    string date = DateTime.Now.ToString();
                    SendMessage(SendBody.Text, date);
                    SendToBody(date, "ВЫ", SendBody.Text, 0);
                    SendBody.Clear();
                }
                else MessageBox.Show("Введите сообщение!");
            }
        }

        private void MainWindow_Shown(object sender, EventArgs e)//Отображение онлайн пользователей при отображении формы
        {
            OnlineUsersShow();
        }
    }
}
