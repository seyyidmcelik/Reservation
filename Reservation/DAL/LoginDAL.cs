using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Reservation.DAL
{
    public class LoginDAL
    {
        public Connection GetLoginConnection()
        {
            Connection conn = new Connection();

            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Close();
            }

            try
            {
                return conn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
