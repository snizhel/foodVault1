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
            //try
            //{
            //    //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

            //    string sql = " update Employee set Fname='" + inputInfo.FirstName +
            //                 "' , Address='" + inputInfo.Address + "',Bdate='" +
            //                 inputInfo.Dob.ToString("yyyy/MM/dd") +
            //                 "' where ssn='" + inputInfo.Ssn + "' ";

            //    string sql_1 = string.Format("update Employee " +
            //                                    "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
            //                                     " where ssn ='{3}'  ",
            //                                 inputInfo.FirstName, inputInfo.Address, inputInfo.Dob.ToString("yyyy/MM/dd"), inputInfo.Ssn);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}

            return -1;
        }


        public int createInputInfo(InputInfo inputInfo)
        {
            //try
            //{
            //    string sql = string.Format("insert [EMPLOYEE] " +
            //        "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
            //                               inputInfo.FirstName, inputInfo.Ssn, inputInfo.Dob.ToString("yyyy/MM/dd"), inputInfo.Address);

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
