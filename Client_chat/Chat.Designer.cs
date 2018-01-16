namespace Client_chat
{
    partial class Chat_Equipe
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat_Equipe));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSender = new System.Windows.Forms.Button();
            this.buttonConnec = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelConnect = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelMess = new System.Windows.Forms.Label();
            this.labelUtili = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeco = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPsswd = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelpsswd = new System.Windows.Forms.Label();
            this.labelConnectChat = new System.Windows.Forms.Label();
            this.textBoxIC = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.textBoxDS = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.labelIC = new System.Windows.Forms.Label();
            this.labelDS = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(468, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 112);
            this.textBox1.TabIndex = 0;
            // 
            // buttonSender
            // 
            this.buttonSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSender.Location = new System.Drawing.Point(513, 343);
            this.buttonSender.Name = "buttonSender";
            this.buttonSender.Size = new System.Drawing.Size(75, 23);
            this.buttonSender.TabIndex = 2;
            this.buttonSender.Text = "Envoyer";
            this.buttonSender.UseVisualStyleBackColor = true;
            this.buttonSender.Click += new System.EventHandler(this.buttonSender_Click);
            // 
            // buttonConnec
            // 
            this.buttonConnec.Location = new System.Drawing.Point(309, 343);
            this.buttonConnec.Name = "buttonConnec";
            this.buttonConnec.Size = new System.Drawing.Size(81, 23);
            this.buttonConnec.TabIndex = 3;
            this.buttonConnec.Text = "Connexion";
            this.buttonConnec.UseVisualStyleBackColor = true;
            this.buttonConnec.Click += new System.EventHandler(this.buttonConnec_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(606, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(169, 304);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Location = new System.Drawing.Point(2, 61);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(72, 13);
            this.labelConnect.TabIndex = 5;
            this.labelConnect.Text = "Etat du Chat :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(468, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 6;
            // 
            // labelMess
            // 
            this.labelMess.AutoSize = true;
            this.labelMess.Location = new System.Drawing.Point(398, 225);
            this.labelMess.Name = "labelMess";
            this.labelMess.Size = new System.Drawing.Size(56, 13);
            this.labelMess.TabIndex = 7;
            this.labelMess.Text = "Message :";
            // 
            // labelUtili
            // 
            this.labelUtili.AutoSize = true;
            this.labelUtili.Location = new System.Drawing.Point(398, 33);
            this.labelUtili.Name = "labelUtili";
            this.labelUtili.Size = new System.Drawing.Size(64, 13);
            this.labelUtili.TabIndex = 8;
            this.labelUtili.Tag = "";
            this.labelUtili.Text = "Utilisateurs :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Etat DB : ";
            // 
            // buttonDeco
            // 
            this.buttonDeco.Location = new System.Drawing.Point(209, 343);
            this.buttonDeco.Name = "buttonDeco";
            this.buttonDeco.Size = new System.Drawing.Size(81, 23);
            this.buttonDeco.TabIndex = 10;
            this.buttonDeco.Text = "Déconnexion";
            this.buttonDeco.UseVisualStyleBackColor = true;
            this.buttonDeco.Click += new System.EventHandler(this.buttonDeco_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(5, 231);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 11;
            this.textBoxIP.Text = "192.168.221.171";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(5, 257);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 12;
            this.textBoxPort.Text = "9009";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(5, 283);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 13;
            this.textBoxLogin.Text = "Antoine";
            // 
            // textBoxPsswd
            // 
            this.textBoxPsswd.Location = new System.Drawing.Point(5, 309);
            this.textBoxPsswd.Name = "textBoxPsswd";
            this.textBoxPsswd.PasswordChar = '*';
            this.textBoxPsswd.Size = new System.Drawing.Size(100, 20);
            this.textBoxPsswd.TabIndex = 14;
            this.textBoxPsswd.Text = "vamvam";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(111, 234);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 15;
            this.labelIP.Text = "IP";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(111, 260);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 16;
            this.labelPort.Text = "Port";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(111, 290);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 17;
            this.labelLogin.Text = "Login";
            // 
            // labelpsswd
            // 
            this.labelpsswd.AutoSize = true;
            this.labelpsswd.Location = new System.Drawing.Point(111, 312);
            this.labelpsswd.Name = "labelpsswd";
            this.labelpsswd.Size = new System.Drawing.Size(41, 13);
            this.labelpsswd.TabIndex = 18;
            this.labelpsswd.Text = "Psswrd";
            // 
            // labelConnectChat
            // 
            this.labelConnectChat.AutoSize = true;
            this.labelConnectChat.Location = new System.Drawing.Point(2, 206);
            this.labelConnectChat.Name = "labelConnectChat";
            this.labelConnectChat.Size = new System.Drawing.Size(29, 13);
            this.labelConnectChat.TabIndex = 19;
            this.labelConnectChat.Text = "Chat";
            // 
            // textBoxIC
            // 
            this.textBoxIC.Location = new System.Drawing.Point(190, 231);
            this.textBoxIC.Name = "textBoxIC";
            this.textBoxIC.Size = new System.Drawing.Size(100, 20);
            this.textBoxIC.TabIndex = 20;
            this.textBoxIC.Text = "dlcdi_chat";
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(190, 257);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUID.TabIndex = 21;
            this.textBoxUID.Text = "chatServer";
            // 
            // textBoxDS
            // 
            this.textBoxDS.Location = new System.Drawing.Point(190, 283);
            this.textBoxDS.Name = "textBoxDS";
            this.textBoxDS.Size = new System.Drawing.Size(100, 20);
            this.textBoxDS.TabIndex = 22;
            this.textBoxDS.Text = "CRM-UC-3628\\SQLEXPRESS";
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(190, 309);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(100, 20);
            this.textBoxPW.TabIndex = 23;
            this.textBoxPW.Text = "Cdi1234";
            // 
            // labelIC
            // 
            this.labelIC.AutoSize = true;
            this.labelIC.Location = new System.Drawing.Point(306, 231);
            this.labelIC.Name = "labelIC";
            this.labelIC.Size = new System.Drawing.Size(70, 13);
            this.labelIC.TabIndex = 24;
            this.labelIC.Text = "Initial Catalog";
            // 
            // labelDS
            // 
            this.labelDS.AutoSize = true;
            this.labelDS.Location = new System.Drawing.Point(306, 283);
            this.labelDS.Name = "labelDS";
            this.labelDS.Size = new System.Drawing.Size(67, 13);
            this.labelDS.TabIndex = 25;
            this.labelDS.Text = "Data Source";
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(306, 309);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(41, 13);
            this.labelPW.TabIndex = 26;
            this.labelPW.Text = "Psswrd";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(306, 257);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(43, 13);
            this.labelUID.TabIndex = 27;
            this.labelUID.Text = "User ID";
            // 
            // Chat_Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(787, 389);
            this.Controls.Add(this.labelUID);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelDS);
            this.Controls.Add(this.labelIC);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxDS);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.textBoxIC);
            this.Controls.Add(this.labelConnectChat);
            this.Controls.Add(this.labelpsswd);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxPsswd);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.buttonDeco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUtili);
            this.Controls.Add(this.labelMess);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonConnec);
            this.Controls.Add(this.buttonSender);
            this.Controls.Add(this.textBox1);
            this.Name = "Chat_Equipe";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSender;
        private System.Windows.Forms.Button buttonConnec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelMess;
        private System.Windows.Forms.Label labelUtili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeco;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPsswd;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelpsswd;
        private System.Windows.Forms.Label labelConnectChat;
        private System.Windows.Forms.TextBox textBoxIC;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.TextBox textBoxDS;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label labelIC;
        private System.Windows.Forms.Label labelDS;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelUID;
    }
}

