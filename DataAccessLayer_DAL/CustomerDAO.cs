using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class CustomerDAO : GeneralDAO
    {
        public DataSet getAllCustomer()
        {
            return getAll("Customer");
        }
        public DataSet searchByName(string name)
        {
            return search("Customer", "DisplayNameCustomer like '%" + name + "%' or " +
                                      "DisplayNameCustomer like '%" + name + "%' ");
        }
        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Customer", " CustomerId= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteCustomer(string id)
        {
            try
            {
                string sql = "delete [Customer] where CustomerId ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateCustomer(Customer customer)
        {
            return -1;
            //try
            //{
            //    //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

            //    string sql = " update Employee set Fname='" + customer.FirstName +
            //                 "' , Address='" + customer.Address + "',Bdate='" +
            //                 customer.Dob.ToString("yyyy/MM/dd") +
            //                 "' where ssn='" + customer.Ssn + "' ";

            //    string sql_1 = string.Format("update Employee " +
            //                                    "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
            //                                     " where ssn ='{3}'  ",
            //                                 customer.FirstName, customer.Address, customer.Dob.ToString("yyyy/MM/dd"), customer.Ssn);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
        }


        public int createCustomer(Customer customer)
        {
            return -1;
            //try
            //{
            //    string sql = string.Format("insert [EMPLOYEE] " +
            //        "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
            //                               customer.FirstName, customer.Ssn, customer.Dob.ToString("yyyy/MM/dd"), customer.Address);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
        }
    }
}
