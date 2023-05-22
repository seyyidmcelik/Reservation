using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Reservation.PLL;
using System.Windows.Forms;
using Reservation.DAL;

namespace Reservation.BLL
{
    public class LoginBLL
    {
        public void LoginUser(TextBox _username, TextBox _password, Login form)
        {
            LoginDAL objdal = new LoginDAL();
            Connection conn = objdal.GetLoginConnection();

            string username, password;
            username = _username.Text;
            password = _password.Text;

            try
            {
                String query = "select * from Users where Username = '" + username + "' and Password = '" + password + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn.con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = _username.Text;
                    password = _password.Text;

                    Tables tables = new Tables(username);

                    form.Hide();
                    tables.ShowDialog();
                    form.Close();

                }
                else
                {
                    _username.Clear();
                    _password.Clear();
                    _username.Focus();
                    MessageBox.Show("Invalid Login Details", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.con.Close();
            }
        }
    }
}
