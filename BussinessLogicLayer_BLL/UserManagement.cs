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


    }
}
