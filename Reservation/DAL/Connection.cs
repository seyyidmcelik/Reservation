using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.DAL
{
    public class Connection
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4TJ17LF\SQLEXPRESS;Initial Catalog=librarydb;Integrated Security=True;Pooling=False");
    }
}
