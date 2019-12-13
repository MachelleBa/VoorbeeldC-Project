using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace Chapeau_Model
{
    public class OrderingModel
    {
        public class Order
        {
            public int orderID, tableID, employeeID;
            public double orderPrice;
            public bool orderPaidStatus;
            public DateTime orderTime;

            public Order()
            {

            }

            public Order(int orderID, int tableID, int employeeID, double orderPrice)
            {
                this.orderID = orderID;
                this.tableID = tableID;
                this.employeeID = employeeID;
                this.orderPrice = orderPrice;
            }

            public List<Item> OrderItems = new List<Item>();
        }

        public class Item
        {
            public int itemID;
            protected string name;
            public decimal itemPrice;
            public string comment;
            public int stock;
            public int quantity;
            protected MenuType menuType;
            protected SubMenuType subMenuType;

            public string Name
            {
                get { return name; }
                set
                {
                    name = value.Replace("_", " ");
                }
            }

            public MenuType MenuType
            {
                get { return menuType; }
                set
                {
                    menuType = value;
                }
            }

            public SubMenuType SubMenuType
            {
                get { return this.subMenuType; }
                set
                {
                    subMenuType = value;
                }
            }

            public Item()
            {
                comment = "";
            }
        }
    }


    //public class DataGridViewNumericUpDownCell : DataGridViewTextBoxCell
   // {
        //public DataGridViewNumericUpDownCell()
       // {

        //}
   // }
}

