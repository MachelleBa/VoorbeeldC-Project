using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_DAL;
using Chapeau_Model;

namespace Chapeau_Logic
{
    public class LoginLogic
    {   
        public ChapeauModel.Employee LoginCheck(string username, string password)
        {
            ChapeauDAL dal = new ChapeauDAL();

            ChapeauModel.Employee employee = dal.LoginDAO(username, password);

            return employee;            
        }       
    }
}
