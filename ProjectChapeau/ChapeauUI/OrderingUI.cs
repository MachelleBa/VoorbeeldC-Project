using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau_Model;

namespace ChapeauUI
{
    public class OrderingUI
    {
        public static void FillMenuList(ListView MenuListView, ComboBox MenuTypeComboBox)
        {
            /*MenuListView.HideSelection = false;







            OrderingDAL MenuDB = new OrderingDAL();
            List<OrderingModel.Item> MenuItemsList = new List<OrderingModel.Item>();
            MenuItemsList = MenuDB.DB_getMenu();

            switch (MenuTypeComboBox.SelectedIndex)
            {
                case 0:
                    
                        foreach (OrderingModel.Item MenuItem in MenuItemsList)
                        {
                            ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.name);
                            ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());
                            MenuListView.Items.Add(ListViewMenuItem);
                        }
                    break;
                case 1:

                    foreach (OrderingModel.Item MenuItem in MenuItemsList)
                    {
                        if(MenuItem.MenuType == "Lunch")
                        {
                            ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.name);
                            ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());
                            MenuListView.Items.Add(ListViewMenuItem);
                        }
                      
                    }
                    break;
                case 2:

                    foreach (OrderingModel.Item MenuItem in MenuItemsList)
                    {
                        if (MenuItem.MenuType == "Dinner")
                        {
                            ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.name);
                            ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());
                            MenuListView.Items.Add(ListViewMenuItem);
                        }

                    }
                    break;
                case 3:

                    foreach (OrderingModel.Item MenuItem in MenuItemsList)
                    {
                        if (MenuItem.MenuType == "Drink")
                        {
                            ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.name);
                            ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());
                            MenuListView.Items.Add(ListViewMenuItem);
                        }

                    }
                    break;
            }*/


        }

        public static void AddCartItems(int MenuItemID, DataGridView OrderCart)
        {
            /*OrderingDAL MenuDB = new OrderingDAL();
            List<OrderingModel.Item> MenuList = MenuDB.DB_getMenu();

            foreach (OrderingModel.Item item in MenuList)
            {
                
                if(item.itemID == MenuItemID)
                {
                    if ((CheckItemPresent(OrderCart, MenuItemID)))
                    {
                        int QuantityValue = int.Parse(OrderCart.Rows[SearchCorrectRow(OrderCart, MenuItemID)].Cells["QuantityColumn"].Value.ToString());
                        OrderCart.Rows[SearchCorrectRow(OrderCart, MenuItemID)].Cells["QuantityColumn"].Value = QuantityValue + 1;
                        break;
                    }
                    else
                    {
                        OrderCart.Rows.Add("Comment", item.name, "X", 1, item.itemID, item.item_price);
                        break;
                    }

                }     

            }*/
        }

        public static int SearchCorrectRow(DataGridView OrderCart, int MenuItemID)
        {
            foreach(DataGridViewRow CartRow in OrderCart.Rows)
            {
                if (CartRow.Cells["ItemID"].Value.Equals(MenuItemID))
                {
                    return CartRow.Index;
                }

            }

            return 0;
        }

        public static bool CheckItemPresent(DataGridView OrderCart, int MenuItemID)
        {
            foreach (DataGridViewRow CartRow in OrderCart.Rows)
            {
                    if (CartRow.Cells[4].Value.Equals(MenuItemID) && CartRow.Cells[4].Value != null)
                    {
                        return true;
                    }             
            }
            return false;
        }

        public static void ShowCommentForm(DataGridView OrderCart)
        {
                Form CommentsForm = new Form();

                TextBox CommentsTextBox = new TextBox();
                CommentsTextBox.Location = new System.Drawing.Point(40, 40);
                CommentsTextBox.Width = 200;
                CommentsTextBox.Height = 160;
                CommentsTextBox.Multiline = true;
                if(OrderCart.CurrentRow.Cells["CommentHidden"].Value != null)
                {
                    if (string.IsNullOrWhiteSpace(OrderCart.CurrentRow.Cells["CommentHidden"].Value.ToString()))
                    {
                        CommentsTextBox.Text = "";
                    }
                    else
                    {
                        CommentsTextBox.Text = OrderCart.CurrentRow.Cells["CommentHidden"].Value.ToString();
                    }
                }
               
                CommentsForm.Controls.Add(CommentsTextBox);

                Button AddCommentsButton = new Button();
                AddCommentsButton.Text = "Add comments to the Item";
                AddCommentsButton.Location = new System.Drawing.Point(60, 210);
                AddCommentsButton.Width = 160;
                AddCommentsButton.Height = 30;
                CommentsForm.Controls.Add(AddCommentsButton);

                AddCommentsButton.Click += (s, e) => {
                    OrderCart.CurrentRow.Cells["CommentHidden"].Value = CommentsTextBox.Text.ToString();
                    CommentsForm.Close();

                };

                CommentsForm.ShowDialog();
        }

        public static void DeleteRow(DataGridView OrderCart)
        {
            OrderCart.Rows.Remove(OrderCart.CurrentRow);
        }

        public static List<OrderingModel.Item> SettingOrderFromCart(DataGridView OrdersCart)
        {
            List<OrderingModel.Item> OrderItemsList = new List<OrderingModel.Item>();

            foreach (DataGridViewRow row in OrdersCart.Rows)
            {
                OrderingModel.Item OrderItem = new OrderingModel.Item();
                OrderItem.itemID = int.Parse(row.Cells["ItemID"].Value.ToString());
                OrderItem.comment = row.Cells["CommentHidden"].Value.ToString();
                OrderItem.quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString());

                OrderItemsList.Add(OrderItem);
            }

            return OrderItemsList;
        }

        public static void PriceOverviewUpdating(ListView PriceOverviewListView, DataGridView OrdersCart)
        {
            PriceOverviewListView.Items.Clear();

            foreach (DataGridViewRow row in OrdersCart.Rows)
            {
                ListViewItem PriceRow = new ListViewItem(row.Cells["ItemNameColumn"].Value.ToString());
                PriceRow.SubItems.Add("....................");
                PriceRow.SubItems.Add(row.Cells["PriceColumn"].Value.ToString());

                PriceOverviewListView.Items.Add(PriceRow);
            }
        }

      
        
    }
}
