using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL
{
    public class DeleteDAL
    {
        DataTable dt = new DataTable();

        public DataTable ReadTable(string activeUser)
        {
            Connection conn = new Connection();

            if (ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }

            SqlCommand cmd = new SqlCommand("select TableNo,TableSize,Owner, Hour from Tables where Owner = '" + activeUser + "'", conn.con);

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Connection GetConnection()
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
