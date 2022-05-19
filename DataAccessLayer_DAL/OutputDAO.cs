using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class OutputDAO : GeneralDAO
    {
        public DataSet getAllOutput()
        {
            return getAll("Output");
        }


        //public DataSet searchByName(string name)
        //{
        //    return search("Input", "DisplayNameCustomer like '%" + name + "%' or " +
        //                              "DisplayNameCustomer like '%" + name + "%' ");
        //}


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Output", " OutputId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteOutput(string id)
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
            //try
            //{
            //    //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

            //    string sql = " update Employee set Fname='" + output.FirstName +
            //                 "' , Address='" + output.Address + "',Bdate='" +
            //                 output.Dob.ToString("yyyy/MM/dd") +
            //                 "' where ssn='" + output.Ssn + "' ";

            //    string sql_1 = string.Format("update Employee " +
            //                                    "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
            //                                     " where ssn ='{3}'  ",
            //                                 output.FirstName, output.Address, output.Dob.ToString("yyyy/MM/dd"), output.Ssn);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}

            return -1;
        }


        public int createOutput(Output output)
        {
            //try
            //{
            //    string sql = string.Format("insert [EMPLOYEE] " +
            //        "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
            //                               output.FirstName, output.Ssn, output.Dob.ToString("yyyy/MM/dd"), output.Address);

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
