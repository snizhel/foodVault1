using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class UserRoleDAO : GeneralDAO
    {
        public DataSet getAllUserRole()
        {
            return getAll("UserRole");
        }


        public DataSet searchByName(string name)
        {
            return search("UserRole", "DisplayNameRole like '%" + name + "%' or " +
                                      "DisplayNameRole like '%" + name + "%' ");
        }


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("UserRole", " RoleId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteUserRole(string id)
        {
            try
            {
                string sql = "delete [UserRole] where RoleId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


       
    }


}
