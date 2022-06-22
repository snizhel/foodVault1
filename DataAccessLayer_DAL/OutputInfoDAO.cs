using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class OutputInfoDAO : GeneralDAO
    {
        public DataSet getAllOutputInfo()
        {
            return getAll("OutputInfo");
        }


        public DataSet searchByName(string name)
        {
            return search("OutputInfo", "OutputPrice like '%" + name + "%' or " +
                                      "OutputPrice like '%" + name + "%' ");
        }
        public DataSet searchByCustomerId(int id)
        {
            return search("OutputInfo", "IdCustomer like '%" + id + "%' or " +
                                      "IdCustomer like '%" + id + "%' ");
        }

        public SqlDataReader findById(int id)
        {
            getConnection();
            SqlDataReader dr = findById("OutputInfo", " Id= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteOutputInfo(int id)
        {
            try
            {
                string sql = "delete [OutputInfo] where Id ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return 1;
            }
        }


        public int updateOutputInfo(OutputInfo outputInfo)
        {
            try
            {
                string sql = "update [OutputInfo] set IdFood = '" + outputInfo.IdFood + "', " +
                                                 "IdOutput = '" + outputInfo.IdOutput + "', " +
                                                 "IdInputInfo = '" + outputInfo.IdInputInfo + "', " +
                                                 "IdCustomer = '" + outputInfo.IdCustomer + "', " +
                                                 "CountOutput = '" + outputInfo.CountOutput + "', " +
                                                 "OutputPrice = '" + outputInfo.OutputPrice + "', " +
                                                 "StatusOutput = '" + outputInfo.StatusOutput + "' " +
                                                 "where Id = '" + outputInfo.Id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int createOutputInfo(OutputInfo outputInfo)
        {
            try
            {
                string sql = "insert into [OutputInfo] (IdFood, IdOutput, IdInputInfo, IdCustomer, CountOutput, OutputPrice, StatusOutput) " +
                             "values ('" + outputInfo.IdFood + "', '" + outputInfo.IdOutput + "', '" + outputInfo.IdInputInfo + "', '" + outputInfo.IdCustomer + "', '" + outputInfo.CountOutput + "', '" + outputInfo.OutputPrice + "', '" + outputInfo.StatusOutput + "')";
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
