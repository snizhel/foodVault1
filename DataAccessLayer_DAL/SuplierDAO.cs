using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class SuplierDAO : GeneralDAO
    {
        public DataSet getAllSuplier()
        {
            return getAll("Suplier");
        }


        public DataSet searchByName(string name)
        {
            return search("Suplier", "DisplayName like '%" + name + "%' or " +
                                      "DisplayName like '%" + name + "%' ");
        }


        public SqlDataReader findById(string id)
        {
            getConnection();
            SqlDataReader dr = findById("Suplier", " Id= '" + id + "' ");
            //closeConnection();
            return dr;
        }

        public int deleteSuplier(string id)
        {
            try
            {
                string sql = "delete [Suplier] where Id ='" + id + "' ";
                return insert_update_delete(sql);// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }


        public int updateSuplier(Suplier suplier)
        {
            //try
            //{
            //    //[Fname], [Minit], [Lname], [Ssn], [Bdate], [Address], [Sex], [Salary], [Super_ssn], [Dno]

            //    string sql = " update Employee set Fname='" + suplier.FirstName +
            //                 "' , Address='" + suplier.Address + "',Bdate='" +
            //                 suplier.Dob.ToString("yyyy/MM/dd") +
            //                 "' where ssn='" + suplier.Ssn + "' ";

            //    string sql_1 = string.Format("update Employee " +
            //                                    "set Fname='{0}',Address='{1}'," + " Bdate='{2}'" +
            //                                     " where ssn ='{3}'  ",
            //                                 suplier.FirstName, suplier.Address, suplier.Dob.ToString("yyyy/MM/dd"), suplier.Ssn);

            //    return insert_update_delete(sql); // -1 if error

            //}
            //catch (Exception ex)
            //{
            //    // log
            //    return -1;
            //}
            return -1;
        }


        public int createSuplier(Suplier suplier)
        {
            //try
            //{
            //    string sql = string.Format("insert [EMPLOYEE] " +
            //        "                      values('{0}', 'M', 'LN', '{1}', '{2}', '{3}', 'F', 10000, '333445555', '1')",
            //                               suplier.FirstName, suplier.Ssn, suplier.Dob.ToString("yyyy/MM/dd"), suplier.Address);

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
