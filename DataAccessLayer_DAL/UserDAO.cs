using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class UserDAO : GeneralDAO
    {
        public DataSet getAllUser()
        {
            return getAll("User");
        }


        public DataSet searchByName(string name)
        {
            return search("User", "DisplayNameUser like '%" + name + "%' or " +
                                      "DisplayNameUser like '%" + name + "%' ");
        }


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("User", " Id= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteUser(string id)
        {
            try
            {
                string sql = "delete [User] where Id ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateUser(User user)
        {
            try
            {
                string sql = "update [Users] set DisplayNameUser = '" + user.DisplayNameUser + "', " +
                                                 "PasswordUser = '" + user.PassWord + "', " +
                                                 "RoleUser = '" + user.IdRole + "' " +
                             "where Id = '" + user.Id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }

        public bool register(User user)
        {
            try
            {
                string sql = "insert into [Users] (DisplayNameUser,UserName, PassWord, IdRole) " +
                             "values ('" + user.DisplayNameUser + "','"+user.UserName+"' ,'" + user.PassWord + "', '" + 2 + "') ";
                return insert_update_delete(sql) > 0;// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return false;
            }
        }

        public bool checkLogin(string username, string password)
        {
            getConnection();
            SqlDataReader dr = findById("Users", "UserName='" + username + "' and PassWord='" + password + "'");
            if (dr.Read())
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                return false;
            }
        }


    }


}
