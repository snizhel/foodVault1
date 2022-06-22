using DataAccessLayer_DAL;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogicLayer_BLL
{
    public class OutputInfoManagement
    {
        OutputInfoDAO outputInfoDAO = new OutputInfoDAO();
        public DataSet listOutputInfoById(int id)
        {
            return outputInfoDAO.searchByCustomerId(id);
        }
        public DataSet searchByName(string name)
        {
            return outputInfoDAO.searchByName(name);
        }
        public DataSet ViewOutputInfo()
        {
            return outputInfoDAO.getAllOutputInfo();
        }
        public SqlDataReader getDatails(int id)
        {
            return outputInfoDAO.findById(id);
        }


        public void closeConnection()
        {
            outputInfoDAO.closeConnection();
        }


        public int AddOutputInfo(OutputInfo outputInfo)
        {
            // check valid

            //call DAO
            return outputInfoDAO.createOutputInfo(outputInfo);

        }
        public int UpdateOutputInfo(OutputInfo outputInfo)
        {
            // check valid

            //call DAO
            return outputInfoDAO.updateOutputInfo(outputInfo);

        }
        public int RemoveOutputInfo(int id)
        {
            // check valid

            //call DAO
            return outputInfoDAO.deleteOutputInfo(id);

        }
    }
}
