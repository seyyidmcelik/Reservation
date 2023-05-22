using Reservation.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation.PLL
{
    public partial class Tables : Form
    {
        private ArrayList activeUserList = new ArrayList();

        public Tables()
        {
            InitializeComponent();
            GetTableDatas();
        }

        public Tables(string _activeUser)
        {
            activeUserList.Add(_activeUser);
            InitializeComponent();
            GetTableDatas();
            activeUser.Text = "Welcome " + activeUserList[0];
        }

        private void GetTableDatas()
        {
            TableBLL tableBLL = new TableBLL();
            dataGridView1.DataSource = tableBLL.GetTables();
        }

        private void emptyTablesBtn_Click(object sender, EventArgs e)
        {
            getEmptyTables();
        }

        private void allTablesBtn_Click(object sender, EventArgs e)
        {
            GetTableDatas();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            getEmptyTables();
            Book book = new Book((string)activeUserList[0]);
            book.ShowDialog();
        }

        private void getEmptyTables()
        {
            BookBLL bookBLL = new BookBLL();
            dataGridView1.DataSource = bookBLL.GetNotNullTables();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete((string)activeUserList[0]);
            delete.ShowDialog();
        }
    }
}
