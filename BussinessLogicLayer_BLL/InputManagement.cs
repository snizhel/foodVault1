using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer_BLL
{
    public class InputManagement
    {
        InputDAO inputDao = new InputDAO();

        public DataSet ViewInputs()
        {
            return inputDao.getAllInput();
        }

        public int AddInput(Input input)
        {
            return inputDao.createInput(input);
        }
    }
}
