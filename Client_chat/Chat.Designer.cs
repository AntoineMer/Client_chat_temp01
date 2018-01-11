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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(154, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 122);
            this.textBox1.TabIndex = 0;
            // 
            // buttonSender
            // 
            this.buttonSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSender.Location = new System.Drawing.Point(507, 351);
            this.buttonSender.Name = "buttonSender";
            this.buttonSender.Size = new System.Drawing.Size(75, 23);
            this.buttonSender.TabIndex = 2;
            this.buttonSender.Text = "Envoyer";
            this.buttonSender.UseVisualStyleBackColor = true;
            this.buttonSender.Click += new System.EventHandler(this.buttonSender_Click);
            // 
            // buttonConnec
            // 
            this.buttonConnec.Location = new System.Drawing.Point(27, 335);
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
            this.richTextBox1.Location = new System.Drawing.Point(332, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 312);
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
            this.labelConnect.Click += new System.EventHandler(this.labelConnect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(154, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelMess
            // 
            this.labelMess.AutoSize = true;
            this.labelMess.Location = new System.Drawing.Point(84, 226);
            this.labelMess.Name = "labelMess";
            this.labelMess.Size = new System.Drawing.Size(56, 13);
            this.labelMess.TabIndex = 7;
            this.labelMess.Text = "Message :";
            // 
            // labelUtili
            // 
            this.labelUtili.AutoSize = true;
            this.labelUtili.Location = new System.Drawing.Point(84, 38);
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
            this.buttonDeco.Location = new System.Drawing.Point(27, 364);
            this.buttonDeco.Name = "buttonDeco";
            this.buttonDeco.Size = new System.Drawing.Size(81, 23);
            this.buttonDeco.TabIndex = 10;
            this.buttonDeco.Text = "Déconnexion";
            this.buttonDeco.UseVisualStyleBackColor = true;
            this.buttonDeco.Click += new System.EventHandler(this.buttonDeco_Click);
            // 
            // Chat_Equipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 399);
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
    }
}

