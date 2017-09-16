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
namespace TCPChatClient
{
    public partial class Settings : Form
    {
        //Форма настроек для изменения ip адреса в файле.
        static string nameFile = Environment.CurrentDirectory + @"\Settings.txt";

        public Settings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if(!File.Exists(nameFile))
            File.Create(nameFile);
            
            StreamReader sr = new StreamReader(nameFile, Encoding.GetEncoding("windows-1251"));
            inputAddress.Text = sr.ReadLine();
            sr.Close();
        }

        private void CloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(nameFile, false, Encoding.GetEncoding("windows-1251"));

            if (inputAddress.Text.Trim().Length != 0)
            {
                sw.WriteLine(inputAddress.Text);
                sw.Close();
                this.Close();
            }
            else MessageBox.Show("Заполните поле с адресом сервера!");
        }
    }
}
