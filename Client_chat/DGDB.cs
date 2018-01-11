using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_chat.Dao;

namespace Client_chat
{
    public partial class DataBase : Form
    {
        DBConnection dBConnection;
        public DataBase()
        {
            InitializeComponent();
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            //UserManager userManager = new UserManager();

            //dataGridDB.ColumnCount = 2;
            //dataGridDB.Columns[0].HeaderText = "Login";
            //dataGridDB.Columns[1].HeaderText = "Email";
            //for (int i = 0; i < userManager.FetchAll<User>().Count; i++)
            //{
            //    dataGridDB.Rows.Add(userManager.Data[i].Login);
            //    dataGridDB.Rows.Add(userManager.Data[i].Email);
            //}
            timer1.Enabled = true;
        }

        private void dataGridDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            if (newUser.IsValide())
            {
                newUser.Login = textBoxLog.Text;
                newUser.Passwd = textBoxPass.Text;
                newUser.Email = textBoxMail.Text;
                newUser.Birthday = Convert.ToDateTime(dateTimePicker1.Value);
                UserManager userManager = new UserManager();
                userManager.Data.Add(newUser);
            }
            else
                MessageBox.Show("Erreur de saisie");
            
        }

    }
}
