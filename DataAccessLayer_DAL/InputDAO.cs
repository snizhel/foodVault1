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
            //try
            //{
            //    //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

            //    string sql = " update Employee set Fname='" + input.FirstName +
            //                 "' , Address='" + input.Address + "',Bdate='" +
            //                 input.Dob.ToString("yyyy/MM/dd") +
            //                 "' where ssn='" + input.Ssn + "' ";

            //    string sql_1 = string.Format("update Employee " +
            //                                    "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
            //                                     " where ssn ='{3}'  ",
            //                                 input.FirstName, input.Address, input.Dob.ToString("yyyy/MM/dd"), input.Ssn);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
            return -1;
        }


        public int createInput(Input input)
        {
            //try
            //{
            //    string sql = string.Format("insert [EMPLOYEE] " +
            //        "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
            //                               input.FirstName, input.Ssn, input.Dob.ToString("yyyy/MM/dd"), input.Address);

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
