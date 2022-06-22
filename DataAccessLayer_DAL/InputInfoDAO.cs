using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class InputInfoDAO : GeneralDAO
    {
        public DataSet getAllInputInfo()
        {
            return getAll("InputInfo");
        }


        //public DataSet searchByName(string name)
        //{
        //    return search("Input", "DisplayNameCustomer like '%" + name + "%' or " +
        //                              "DisplayNameCustomer like '%" + name + "%' ");
        //}

        public DataSet searchByInputId(int id)
        {
            return search("InputInfo", "IdInput like '%" + id + "%' or " +
                                      "IdInput like '%" + id + "%' ");
        }


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("InputInfo", " Id= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteInputInfo(string id)
        {
            try
            {
                string sql = "delete [InputInfo] where Id ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateInputInfo(InputInfo inputInfo)
        {
            try
            {
                string sql = "update [InputInfo] set StatusInput = '" + inputInfo.StatusInput + "' " +
                                                 "where Id = '" + inputInfo.Id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int createInputInfo(InputInfo inputInfo)
        {
            try
            {
                string sql = "insert into [InputInfo] (IdFood, IdInput, CountInput, InputPrice, StatusInput) " +
                                                 "values ('" + inputInfo.IdFood + "', '" + inputInfo.IdInput + "', '" + inputInfo.CountInput + "', '" + inputInfo.InputPrice + "', '" + inputInfo.StatusInput + "')";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }

            return -1;
        }
    }




}
