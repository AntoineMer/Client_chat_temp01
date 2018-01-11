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
        string pseudo, message, moment, time;
        string a;
        Dao.DBConnection db;
        bool verif;
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
        }

        private void buttonSender_Click(object sender, EventArgs e)
        {
            byte[] frame2 = FrameManager.WrapFrame110(textBox1.Text);
            Client.SendFrame(frame2);
            if (textBox1.Text == @"/users")
            {
                DataBase form2 = new DataBase();
                form2.Show();
            }
            textBox1.Text = string.Empty;
        }

        private void labelConnect_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonDeco_Click(object sender, EventArgs e)
        {
            if (
                (db.TestCon())
                //&& (Client.connectionState)
                )
            {
                db.Close();
                // Client.CloseConnection();


            }
        }

        private void buttonConnec_Click(object sender, EventArgs e)
        {
            try
            {
                verif = Client.SendFrame(Dao.ChatConnec.Connection());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (verif)
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
            {
                MessageBox.Show("Connexion au Chat impossible");
                labelConnect.Text = "Etat Chat : Déconnecté";
                labelConnect.ForeColor = Color.Red;
            }
            try
            {
                db = new Dao.DBConnection("dlcdi_chat", "chatServer", @"CRM-UC-3628\SQLEXPRESS", "Cdi1234");
                db.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            Dictionary<string, byte> _users = new Dictionary<string, byte>();
            byte[] frame = Dao.ChatConnec.GetFrame();
            if (frame != null)
            {
                if (FrameManager.GetFrameType(frame) == 10)
                {
                    FrameManager.UnwrapFrame10(frame, out moment, out time, out pseudo, out message);
                    a = "[" + moment + " " + time + "]" + " " + pseudo;
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.AppendText(a);
                    richTextBox1.AppendText(" : " + message);
                    richTextBox1.AppendText(Environment.NewLine);
                }
                else if (FrameManager.GetFrameType(frame) == 3)
                {
                    FrameManager.UnwrapFrame3(frame, out _users);
                    listBox1.Items.Clear();
                    foreach (KeyValuePair<string, byte> items in _users)
                    {
                        if (!listBox1.Items.Contains(items.Key))
                            listBox1.Items.Add(items.Key);
                    }
                }
            }
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
            if (Client.connectionState)
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


    }
}
