﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class FoodDAO : GeneralDAO
    {
        public DataSet getAllFood()
        {
            return getAll("Food");
        }
        public DataSet searchByName(string name)
        {
            return search("Food", "DisplayName like '%" + name + "%' or " +
                                      "DisplayName like '%" + name + "%' ");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Food", " FoodId= '"+id+"' ");
            //closeConnection();
            return dr;
        }

        public int deleteFood(string id)
        {
            try
            {
                string sql = "delete [Food] where FoodId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
        public int updateFood(Food food)
        {
            try
            {
                string sql = "update [Food] set DisplayNameFood = '" + food.Name + "', " +
                                                 "Price = '" + food.Price + "', " +
                                                 "Status = '" + food.Status + "', " +
                                                 "Image = '" + food.Image + "' " +
                                                 "where FoodId = '" + food.ID + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
        //public int createFood(Food food)
        //{
            
        //}
    }
}