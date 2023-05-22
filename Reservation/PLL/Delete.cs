using Reservation.BLL;
using System;
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
    public partial class Delete : Form
    {
        string user;
        public Delete()
        {
            InitializeComponent();
            GetTableDatas();
        }

        public Delete(string activeUser)
        {
            InitializeComponent();
            user = activeUser;
            active.Text = "Welcome " + activeUser;
            GetTableDatas();
        }

        public void GetTableDatas()
        {
            DeleteBLL deleteBLL = new DeleteBLL();
            dataGridView1.DataSource = deleteBLL.GetTables(user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteBLL deleteBLL = new DeleteBLL();
            deleteBLL.DeleteTable(textBox1.Text);
        }
    }
}
