using Reservation.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation.BLL
{
    public class DeleteBLL
    {
        public DataTable GetTables(string activeUser)
        {
            try
            {
                DeleteDAL objdal = new DeleteDAL();
                return objdal.ReadTable(activeUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteTable(string tableNo)
        {
            DeleteDAL deleteDAL = new DeleteDAL();
            Connection conn = deleteDAL.GetConnection();
            string _tableNo = tableNo;
            try
            {
                if (tableNo.Length > 0)
                {
                    SqlCommand cmd = new SqlCommand("update Tables set Owner = null where TableNo = @TableNo", conn.con);
                    cmd.Parameters.AddWithValue("@TableNo", _tableNo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleting Successfully.", "Deleting Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
