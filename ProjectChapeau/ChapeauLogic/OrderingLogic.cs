using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapeau_Model;
using Chapeau_DAL;

namespace Chapeau_Logic
{
    public class OrderingLogic
    {
        private static OrderingDAL DBConnection = new OrderingDAL();

        public static List<OrderingModel.Item> CallMenuListDB()
        {
            List<OrderingModel.Item> MenuItemsList;
            MenuItemsList = DBConnection.DB_getMenu();

            return MenuItemsList;
        }

        public static List<OrderingModel.Item> CallTableItemsDB(int tableId)
        {
            List<OrderingModel.Item> TableItemsList;
            TableItemsList = DBConnection.DB_getTableItems(tableId);

            return TableItemsList;
        }

        public static List<OrderingModel.Item> CallTableReceipt()
        {
            List<OrderingModel.Item> MenuItemsList;
            MenuItemsList = DBConnection.DB_getMenu();

            return MenuItemsList;
        }

        public static void ActionInsertOrdersDB(OrderingModel.Order NewOrder, int tableId, int employeeId)
        {
            DBConnection.DB_InsertOrder(NewOrder, tableId, employeeId);
        }
        public static void ActionDeleteOrdersDB(int tableId)
        {
            DBConnection.DB_DeleteOrder(tableId);
        }
       

        public static void RepairName(string objectName)
        {
            objectName = objectName.Replace("_", " ");
        }

        public static double ColumnMultiplier(double valueX, double valueY)
        {
            return valueX * valueY;
        }

        public static List<string> FillSubComboBox()
        {
            List<string> comboboxItems = new List<string>
                { "ALL TYPES","LUNCH MAIN","SPECIALS", "BITES","DINNER STARTERS","DINNER MAINS", "DESSERTS","SOFT DRINKS","HOT DRINKS", "BEERS","WINES"};
            return comboboxItems;
        }

        public static List<string> FillSubComboBox(MenuType type)
        {
            List<string> comboboxItems = new List<string>();
            if (type == MenuType.Lunch)
            {
                comboboxItems = new List<string>
                { "ALL(LUNCH)","LUNCH MAIN","SPECIALS", "BITES"};
                return comboboxItems;
            }
            else if (type == MenuType.Dinner)
            {
                comboboxItems = new List<string>
                { "ALL(DINNER)","DINNER STARTERS","DINNER MAINS", "DESSERTS"};
                return comboboxItems;
            }
            else if (type == MenuType.Drink)
            {
                comboboxItems = new List<string>
                { "ALL(DRINKS)","SOFT DRINKS","HOT DRINKS", "BEERS","WINES"};
                return comboboxItems;
            }

            return comboboxItems;         
        }

        public static int GetWaitingTime(int tableId)
        {
            DateTime dtToday = DateTime.Now;
            TimeSpan passedTime = dtToday.Subtract(DBConnection.DB_GetOrderTime(tableId));
            int minutes = (int)Math.Round(passedTime.TotalMinutes);
            return minutes;
        }

       public static bool GetOrderStatus(int OrderId)
        {
            return DBConnection.DB_GetOrderStatus(OrderId);

        }

        public static int GetOrderId(int tableId)
        {
            return DBConnection.DB_GetOrderId(tableId);

        }
    }
}

