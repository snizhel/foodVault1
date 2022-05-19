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


        public int updateUserRole(UserRole userRole)
        {
            //try
            //{
            //    //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

            //    string sql = " update Employee set Fname='" + userRole.FirstName +
            //                 "' , Address='" + userRole.Address + "',Bdate='" +
            //                 userRole.Dob.ToString("yyyy/MM/dd") +
            //                 "' where ssn='" + userRole.Ssn + "' ";

            //    string sql_1 = string.Format("update Employee " +
            //                                    "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
            //                                     " where ssn ='{3}'  ",
            //                                 userRole.FirstName, userRole.Address, userRole.Dob.ToString("yyyy/MM/dd"), userRole.Ssn);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
            return -1;
        }


        public int createUserRole(UserRole userRole)
        {
            //try
            //{
            //    string sql = string.Format("insert [EMPLOYEE] " +
            //        "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
            //                               userRole.FirstName, userRole.Ssn, userRole.Dob.ToString("yyyy/MM/dd"), userRole.Address);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
            return -1;
        }
    }


}
