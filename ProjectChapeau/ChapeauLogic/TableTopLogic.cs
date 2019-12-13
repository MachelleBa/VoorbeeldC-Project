using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_DAL;
using Chapeau_Model;

namespace Chapeau_Logic
{
    public class TableTopLogic
    {

        public List<TableTop> tableTopListLogic()
        {
            ChapeauDAL dal = new ChapeauDAL();

            List<TableTop> tableList = dal.TableTopDAO();

            return tableList;
        }

    }
}
