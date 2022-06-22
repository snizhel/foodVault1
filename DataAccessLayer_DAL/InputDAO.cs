using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class InputDAO : GeneralDAO
    {
        public DataSet getAllInput()
        {
            return getAll("Input");
        }


        //public DataSet searchByName(string name)
        //{
        //    return search("Input", "DisplayNameCustomer like '%" + name + "%' or " +
        //                              "DisplayNameCustomer like '%" + name + "%' ");
        //}


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Input", " InputId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteInput(string id)
        {
            try
            {
                string sql = "delete [Input] where InputId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateInput(Input input)
        {
           try
            {
                string sql = "update [Input] set InputId = '" + input.InputId + "', " +
                                                 "DateInput = '" + input.DateInput + "', " +
                                                 "TotalPrice = '" + input.TotalPrice + "', " +
                                                 "IdSuplier = '" + input.IdSuplier + "', " +
                                                 "where InputId = '" + input.InputId + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int createInput(Input input)
        {
            try
            {
                string sql = "insert into [Input] (DateInput, TotalPrice, IdSuplier) " +
                                                 "values ('" + input.DateInput.ToString("MM/dd/yyyy") + "', '" + input.TotalPrice + "', '" + input.IdSuplier + "')";
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
