using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer_BLL
{
    public class InputInfoManagement
    {
        InputInfoDAO inputInfoDao = new InputInfoDAO();

        public DataSet ViewInputs()
        {
            return inputInfoDao.getAllInputInfo();
        }

        public int AddInputInfo(InputInfo inputInfo)
        {
            return inputInfoDao.createInputInfo(inputInfo);
        }

        public DataSet listInfoByInputId(int id)
        {
            return inputInfoDao.searchByInputId(id);
        }

        public SqlDataReader getDatails(string id)
        {
            return inputInfoDao.findById(id);
        }

        public void closeConnection()
        {
            inputInfoDao.closeConnection();
        }

        public int UpdateInputInfo(InputInfo inputInfo)
        {
            return inputInfoDao.updateInputInfo(inputInfo);
        }

    }
}
