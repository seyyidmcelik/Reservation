using Reservation.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation.BLL
{
    public class RegisterBLL
    {
        public void RegisterUser(TextBox _username, TextBox _password)
        {
            RegisterDAL objdal = new RegisterDAL();
            Connection conn = objdal.GetRegisterConnection();

            string username, password;

            username = _username.Text;
            password = _password.Text;
            try
            {
                if (_username.Text.Length >= 1 && _password.Text.Length >= 1)
                {
                    SqlCommand cmd = new SqlCommand("insert into Users(Username,Password) values(@username,@password)", conn.con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    _username.Clear();
                    _password.Clear();
                    MessageBox.Show("Register Successfully. Go to Login Page", "Register Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _username.Clear();
                    _password.Clear();
                    _username.Focus();
                    MessageBox.Show("Register is failed", "Register Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Register Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.con.Close();
            }
        }
    }
}
