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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginBLL loginBLL = new LoginBLL();
            loginBLL.LoginUser(usernameTextBox,passwordTextBox,this);
        }
    }
}
