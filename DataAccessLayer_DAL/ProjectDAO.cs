using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class ProjectDAO : GeneralDAO
    {
        public DataSet getAllProjects()
        {
            return getAll("Project");
        }
    }
}
