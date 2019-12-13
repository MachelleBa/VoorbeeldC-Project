using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_DAL;
using Chapeau_Model;


namespace Chapeau_Logic
{
    public class ChapeauLogic
    {


        public List<ChapeauModel.Order> showOrders()
        {
            ChapeauDAL DAL = new ChapeauDAL();
            List<ChapeauModel.Order> orderList = DAL.OrderDAO();
            return orderList;
        }

        public void FlipCompleteStatus(ChapeauModel.Order selectedOrder)
        {
            ChapeauDAL DAL = new ChapeauDAL();
            selectedOrder.completed = 1;
            DAL.UpdateOrderDAO(selectedOrder);
        }
    }
}
