using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SimpleChatClient;
using SimpleChatFrameManager;
using System.Net;
using Client_chat.Dao;

namespace Client_chat
{
    public partial class Chat_Equipe : Form
    {
        ChatConnec chatConnec;
        DBConnection db;
        string moment, time, pseudo, message;
        public Chat_Equipe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            buttonSender.Enabled = false;
            labelConnect.Text = "Etat Chat : Déconnecté";
            labelConnect.ForeColor = Color.Red;
            label1.Text = ("Etat DB : Déconnecté");
            label1.ForeColor = Color.Red;
            chatConnec = new ChatConnec();


        }

        private void buttonSender_Click(object sender, EventArgs e)
        {
            chatConnec.Send(textBox1.Text);
            if (textBox1.Text == @"/users")
            {
                DataBase form2 = new DataBase();
                form2.Show();
            }
            textBox1.Text = string.Empty;
        }

        private void buttonDeco_Click(object sender, EventArgs e)
        {
            try
            {
                db.Connection.Close();
              //  Client.CloseConnection();
                
            }
            catch(Exception _e)
            {
                MessageBox.Show("Déconnexion impossible " + _e.Message);
            }
        }

        private void buttonConnec_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ip = textBoxIP.Text;                    //Connexion Chat
            Properties.Settings.Default.login = textBoxLogin.Text;
            Properties.Settings.Default.passwd = User.Password_Hash(textBoxPsswd.Text);
            Properties.Settings.Default.port = textBoxPort.Text;

            Properties.Settings.Default.UserID = textBoxUID.Text;               //Connexion DB
            Properties.Settings.Default.Psswd = textBoxPW.Text;
            Properties.Settings.Default.InitialCatalog = textBoxIC.Text;
            Properties.Settings.Default.DataSource = textBoxDS.Text;
            try
            {
                if (chatConnec.Connection())
                {
                    MessageBox.Show("Connecté au Chat");
                    timer1.Enabled = true;
                    buttonSender.Enabled = true;
                    labelConnect.Text = "Etat Chat : Connecté";
                    labelConnect.ForeColor = Color.Green;
                    textBox1.Enabled = true;
                    listBox1.Enabled = true;
                    richTextBox1.Enabled = true;
                    buttonDeco.Enabled = true;
                }
                else
                    MessageBox.Show("Connexion impossible");
            }
            catch (Exception _e)
            {
                MessageBox.Show("Connexion au Chat impossible" + _e.Message);
            }

            try
            {
                db = new DBConnection();
                    db.Connect();
                if (db.Connection.State == ConnectionState.Open)
                    MessageBox.Show("Connexion à la base de données réussie");
                else
                    MessageBox.Show("La connexion à la base de données a échoué");
                
                
      
            }
            catch (Exception _e)
            {
                MessageBox.Show("La connexion à la base de données a échoué !" + _e.Message);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Client.GetFrame(out byte[] messageRetour))
            {
                if (FrameManager.GetFrameType(messageRetour) == 10)
                {
                    chatConnec.GetMessage(messageRetour, out moment, out time, out pseudo, out message);
                    if (message != string.Empty)
                    {
                        richTextBox1.SelectionColor = Color.Black;
                        richTextBox1.AppendText("[" + moment + " " + time + "]" + " " + pseudo);
                        richTextBox1.AppendText(" : " + message);
                        richTextBox1.AppendText(Environment.NewLine);
                    }
                }
               else if (FrameManager.GetFrameType(messageRetour) == 3)
                {
                    listBox1.Items.Clear();
                    foreach (KeyValuePair<string, byte> items in chatConnec.GetUsers(messageRetour))
                    {
                        if (!listBox1.Items.Contains(items.Key))
                            listBox1.Items.Add(items.Key);
                    }

                }
            }
            ShowStateChat();
            ShowStateDB();

        }

        public void ShowStateChat()
        {
            if(Client.connectionState)
            {
                labelConnect.Text = "Etat Chat : Connecté";
                labelConnect.ForeColor = Color.Green;
            }
            else
            {
                labelConnect.Text = "Etat Chat : Déconnecté";
                labelConnect.ForeColor = Color.Red;
            }
        }
        public void ShowStateDB()
        {
            if (db.TestCon())
            {
                label1.Text = "Etat DB : Connecté";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Etat DB : Déconnecté";
                label1.ForeColor = Color.Red;
            }
        }

    }
}
