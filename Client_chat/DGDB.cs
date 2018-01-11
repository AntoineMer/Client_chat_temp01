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
            UserManager userManager = new UserManager();

            dataGridDB.ColumnCount = 2;
            for (int i = 0; i < userManager.FetchAll<users>().Count; i++)
            {
                dataGridDB.Columns[0].HeaderText = "Login";
                dataGridDB.Columns[1].HeaderText = "Group_Id";
                dataGridDB.Rows.Add(userManager.FetchAll<users>()[i].Login);
                dataGridDB.Rows.Add(userManager.FetchAll<users>()[i].Group_id);
            }
        }

        private void dataGridDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
