using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Reservation.DAL
{
    public class RegisterDAL
    {
        public Connection GetRegisterConnection()
        {
            Connection conn = new Connection();

            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
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
