using DataAccessLayer_DAL;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogicLayer_BLL
{
    public class OutputManagement
    {
        OutputDAO outputDAO = new OutputDAO();
        //admin
        public DataSet ViewOutput()
        {
            return outputDAO.getAllOutput();
        }

        public DataSet searchByName(string name)
        {
            return outputDAO.searchByName(name);
        }


        public SqlDataReader getDatails(string id)
        {
            return outputDAO.findById(id);
        }


        public void closeConnection()
        {
            outputDAO.closeConnection();
        }


        public int AddOutput(Output output)
        {
            // check valid

            //call DAO
            return outputDAO.createOutput(output);

        }
        public int UpdateOutput(Output output)
        {
            // check valid

            //call DAO
            return outputDAO.updateOutput(output);

        }
        public int RemoveOutput(int id)
        {
            // check valid

            //call DAO
            return outputDAO.deleteOutput(id);

        }
    }
}
