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
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Client_chat
{
    public partial class DataBase : Form
    {
        DBConnection dBConnection;
        SqlCommand command;
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
        }

        private void dataGridDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            DateTime date = Convert.ToDateTime(dateTimePicker1.Value);
            if (userManager.AddUser(textBoxLog.Text, date, textBoxPass.Text, textBoxMail.Text))
            {
                MessageBox.Show("Ajout réussi !");
            }
            else
                MessageBox.Show("La tentative d'ajout n'a pas pu aboutir !");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //command = new SqlCommand();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //DataSet dataSet = new DataSet();
            //sqlDataAdapter.Fill(dataSet);
            //dataGridDB.Rows.Add(dataReader);
        }
    }
}
