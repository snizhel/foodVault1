using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer_DAL;

namespace BussinessLogicLayer_BLL
{
    public class FoodManagement
    {
        FoodDAO foodDAO = new FoodDAO();
        //admin
        public DataSet ViewFoods()
        {
            return foodDAO.getAllFood();
        }
        public DataSet searchByName(string name)
        {
            return foodDAO.searchByName(name);
        }


        public SqlDataReader getDatails(string id)
        {
            return foodDAO.findById(id);
        }


        public void closeConnection()
        {
            foodDAO.closeConnection();
        }


        //public int AddEmployee(Food emp)
        //{
        //    // check valid

        //    //call DAO
        //    return foodDAO.createFood(emp);

        //}
        //public int UpdateEmployee(Food emp)
        //{
        //    // check valid

        //    //call DAO
        //    return foodDAO.createFood(emp);

        //}
        public int RemoveEmployee(string id)
        {
            // check valid

            //call DAO
            return foodDAO.deleteFood(id);

        }
        
    }
}
