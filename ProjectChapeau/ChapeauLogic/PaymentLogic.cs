using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Model;
using Chapeau_DAL;

namespace Chapeau_Logic
{
    public class PaymentLogic
    {
        public void InsertPayment(int employeeId, int orderId, double tip, PaymentMethod paymentMethod, string comments)
        {
            Payment payment = GetTotalPayments(orderId);
            payment.EmployeeId = employeeId;
            payment.OrderId = orderId; //elizabeth's part?
            payment.Tip = tip;
            payment.PaymentMethod = paymentMethod;
            payment.Comments = comments;
            payment.TimePayed = DateTime.Now;

            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> orderItems = GetOrderItems(payment.OrderId);

            dal.PaymentDAO(payment);
        }

        public Payment GetTotalPayments(int orderId)
        {
            Payment payment = new Payment();
            List<OrderItems> orderItems = GetOrderItems(orderId);

            foreach (OrderItems item in orderItems)
            {                
                payment.Vat += item.Vat * item.ItemPrice;
                payment.InitialPrice += item.ItemPrice;
            }

            payment.TotalPrice = payment.Vat + payment.InitialPrice;

            return payment;
        }

        public List<OrderItems> GetOrderItems(int orderId)
        {
            ChapeauDAL dal = new ChapeauDAL();
            List<OrderItems> itemsDAL = dal.OrderItemsDAO(orderId);
            List<OrderItems> orderItems = itemsDAL.GroupBy(p => p.ItemName).Select(s => s.FirstOrDefault()).Distinct().ToList();

            for (int i = 0; i < orderItems.Count; i++)
            {
                for (int j = 0; j < itemsDAL.Count; j++)
                {
                    if (orderItems[i].ItemName != itemsDAL[j].ItemName)
                        continue;

                    else
                    {                        
                        orderItems[i].Quantity++;                        
                    }
                }

                orderItems[i].ItemPrice *= orderItems[i].Quantity;
            }
                                    
            return orderItems;
        }
    }
}
