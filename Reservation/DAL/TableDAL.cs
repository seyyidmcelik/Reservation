using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Reservation.DAL
{
    public class TableDAL
    {
        DataTable dt = new DataTable();

        public DataTable ReadTable()
        {
            Connection conn = new Connection();

            if(ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }

            SqlCommand cmd = new SqlCommand("select TableNo,TableSize,Owner, Hour from Tables", conn.con);

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
