using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservation.DAL;

namespace Reservation.BLL
{
    public class TableBLL
    {
        public DataTable GetTables()
        {
            try
            {
                TableDAL objdal = new TableDAL();
                return objdal.ReadTable();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

