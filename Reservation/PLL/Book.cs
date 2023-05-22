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
    public partial class Book : Form
    {
        string user;
        public Book()
        {
            InitializeComponent();
        }

        public Book(string _active)
        {
            InitializeComponent();
            user = _active;
            active.Text = "Welcome " + _active;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookBLL bookBLL = new BookBLL();
            bookBLL.BookTable(tableNoBook.Text,user);
        }
    }
}
