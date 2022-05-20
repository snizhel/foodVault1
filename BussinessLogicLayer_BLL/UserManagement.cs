using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer_BLL
{
    public class UserManagement
    {
        UserDAO userDao = new UserDAO();
        public bool loginUser(User user)
        {
            return userDao.checkLogin(user.UserName,user.PassWord);
        }
        public bool registerUser(User user)
        {
            return userDao.register(user);
        }

        public bool isExistUserName(string userName)
        {
            List<User> lst = userDao.getAllUsers();
            foreach (User user in lst)
            {
                string userName_indb = user.UserName;
                if (userName_indb == userName)
                {
                    return true; // tk da ton tai
                }

            }
            return false; // tk chua ton tai
        }
        public bool isExistdisplayUserName(string displayUserName)
        {
            List<User> lst = userDao.getAllUsers();
            foreach (User user in lst)
            {
                string displayUserName_indb = user.DisplayNameUser;
                if (displayUserName_indb == displayUserName)
                {
                    return true; // tk da ton tai
                }

            }
            return false; // tk chua ton tai
        }
    }
}
