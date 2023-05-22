using Reservation.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Reservation.BLL
{
    public class BookBLL
    {
        BookDAL ojbdal = new BookDAL();
        public DataTable GetNotNullTables() 
        {
			try
			{
				return ojbdal.ReadNotNullTable();
			}
			catch (Exception)
			{
				throw;
			}
        }

		public void BookTable(string tableNo, string activeUser)
		{
			Connection conn = ojbdal.GetConnection();
			string _tableNo = tableNo;
			string _activeUser = activeUser;
			try
			{
				if (tableNo.Length > 0)
				{
                    SqlCommand cmd = new SqlCommand("update Tables set Owner = @_activeUser where TableNo = @TableNo", conn.con);
                    cmd.Parameters.AddWithValue("@TableNo", _tableNo);
                    cmd.Parameters.AddWithValue("@_activeUser", _activeUser);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Successfully.", "Booking Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
			}
			catch (Exception)
			{
				throw;
			}
		}
    }
}
