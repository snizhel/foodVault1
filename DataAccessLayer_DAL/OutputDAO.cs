using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class OutputDAO : GeneralDAO
    {
        public DataSet getAllOutput()
        {
            return getAll("Output");
        }


        public DataSet searchByName(string name)
        {
            return search("Output", "TotalPrice like '%" + name + "%' or " +
                                      "TotalPrice like '%" + name + "%' ");
        }


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Output", " OutputId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteOutput(int id)
        {
            try
            {
                string sql = "delete [Output] where OutputId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateOutput(Output output)
        {
            try
            {
                string sql = "update [Output] set DateOutput = '" + output.DateOutput.ToString("MM/dd/yyyy") + "', " +
                                                 "TotalPrice = '" + output.TotalPrice + "', " +
                                                 "where OutputId = '" + output.OutputId + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int createOutput(Output output)
        {
            try
            {
                string sql = "insert into [Output] (DateOutput, TotalPrice) " +
                             "values ('" + output.DateOutput.ToString("MM/dd/yyyy") + "', '" + output.TotalPrice + "')";
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
