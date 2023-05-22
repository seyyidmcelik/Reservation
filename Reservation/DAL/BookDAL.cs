using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL
{
    public class BookDAL
    {
        DataTable dt = new DataTable();

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

        public DataTable ReadNotNullTable()
        {
            Connection conn = GetConnection();

            SqlCommand cmd = new SqlCommand("select TableNo,TableSize,Owner, Hour from Tables where Owner is null", conn.con);

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
    }
}
