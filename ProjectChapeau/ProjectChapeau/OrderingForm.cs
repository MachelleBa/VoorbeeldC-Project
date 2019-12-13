using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau_Model;
using Chapeau_Logic;

namespace ProjectChapeau
{
    public partial class OrderingForm : Form
    {
        private TableTop table;
        private ChapeauModel.Employee employee;
        
        public OrderingForm(TableTop table, ChapeauModel.Employee employee)
        {
            InitializeComponent();
            this.table = table;
            this.employee = employee;
            FillMenuList();

            if(table.GetTableStatus() == TableStatus.Occupied)
            {
                FillCartPrevItems();
                AddOrderButton.Text = "Edit Order";
            }
            //labelDisplayTableID.Text = "Table " + table.GetTableId();
            MenuTypeComboBox.SelectedIndex = 0;
            subMenuTypeComboBox.SelectedIndex = 0;

            MenuTypeComboBox.SelectedIndexChanged += (s, e) => MenuTypeComboBox_SelectedIndexChanged(s, e);
            MenuListView.SelectedIndexChanged += (s, e) => MenuListView_SelectedIndexChanged(s, e);
            MenuListView.DoubleClick += (s, e) => MenuListView_DoubleClick(s, e);
            OrdersCart.RowTemplate.Height = 40;
            OrdersCart.CellContentClick += (s, e) => OrderCartButtons_Click(s, e);
            OrdersCart.CellPainting += (s, e) => OrderCartButtonGraphics_CellPainting(s, e);
            OrdersCart.AllowUserToAddRows = false;
            OrdersCart.RowsAdded += (s, e) => OrdersCart_RowsAdded(s, e);
            OrdersCart.RowsRemoved += (s, e) => OrdersCart_RowsRemoved(s, e);
            OrdersCart.CellValueChanged += (s, e) => OrdersCart_CellStyleContentChanged(s, e);
            PriceOverviewListView.ColumnWidthChanging += (s, e) => PriceOverviewListView_ColumnWidthChanged(s, e);
            CommentButtonColumn.FlatStyle = FlatStyle.System;
            DeleteButtonColumn.FlatStyle = FlatStyle.System;
            


        }

            private void FillMenuList()
        {
            MenuListView.HideSelection = false;
            MenuListView.Items.Clear();
            List<OrderingModel.Item> MenuItemsList = new List<OrderingModel.Item>();
            MenuItemsList = OrderingLogic.CallMenuListDB();

            foreach (OrderingModel.Item MenuItem in MenuItemsList)
            {

                    ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.Name);
                    ListViewMenuItem.ImageIndex = (MenuItem.itemID - 1);
                    ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());
                    

                    if (MenuItem.stock < 1)
                    {
                        ListViewMenuItem.ForeColor = Color.Gray;
                        ListViewMenuItem.ImageIndex = 48;
                    }

                    MenuListView.Items.Add(ListViewMenuItem);
            }

        }

        private void FillMenuList(MenuType Option)
        {
            MenuListView.HideSelection = false;
            MenuListView.Items.Clear();
            List<OrderingModel.Item> MenuItemsList = new List<OrderingModel.Item>();
            MenuItemsList = OrderingLogic.CallMenuListDB();

            foreach (OrderingModel.Item MenuItem in MenuItemsList)
            {
                if (MenuItem.MenuType == Option)
                {
                    ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.Name);
                    ListViewMenuItem.ImageIndex = (MenuItem.itemID - 1);
                    ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());

                    if (MenuItem.stock < 1)
                    {
                        ListViewMenuItem.ForeColor = Color.Gray;
                        ListViewMenuItem.ImageIndex = 48;
                    }

                    MenuListView.Items.Add(ListViewMenuItem);
                }
                
            }

        }

        private void FillMenuList(SubMenuType Option)
        {
            MenuListView.HideSelection = false;
            MenuListView.Items.Clear();
            List<OrderingModel.Item> MenuItemsList = new List<OrderingModel.Item>();
            MenuItemsList = OrderingLogic.CallMenuListDB();

            foreach (OrderingModel.Item MenuItem in MenuItemsList)
            {
                if (MenuItem.SubMenuType == Option)
                {
                    ListViewItem ListViewMenuItem = new ListViewItem(MenuItem.Name);
                    ListViewMenuItem.ImageIndex = (MenuItem.itemID - 1);
                    ListViewMenuItem.SubItems.Add(MenuItem.itemID.ToString());

                    if (MenuItem.stock < 1)
                    {
                        ListViewMenuItem.ForeColor = Color.Gray;
                        ListViewMenuItem.ImageIndex = 48;
                    }

                    MenuListView.Items.Add(ListViewMenuItem);
                }

            }

        }

        private void FillCartPrevItems()
        {
            List<OrderingModel.Item> TableList = OrderingLogic.CallTableItemsDB(table.GetTableId());

            int storedItem = 50;
            int storedIndex = 50;

            for(int i=0; i < TableList.Count; i++)
            {
                TableList[i].quantity = 1;

                if (TableList[i].itemID != storedItem)
                {
                    OrdersCart.Rows.Add("", TableList[i].Name, "", TableList[i].quantity++, TableList[i].itemID, TableList[i].itemPrice);
                    storedItem = TableList[i].itemID;
                    storedIndex = i;
                }
                else
                {
                    OrdersCart.Rows[storedIndex].Cells["QuantityColumn"].Value = TableList[storedIndex].quantity++;

                }
            }           
        }

        private void AddCartItems(int MenuItemID)
        {
            List<OrderingModel.Item> MenuList = OrderingLogic.CallMenuListDB();

            foreach (OrderingModel.Item item in MenuList)
            {

                if (item.itemID == MenuItemID)
                {
                    if ((CheckItemPresent(MenuItemID)))
                    {
                        int QuantityValue = int.Parse(OrdersCart.Rows[SearchCorrectRow(MenuItemID)].Cells["QuantityColumn"].Value.ToString());
                        OrdersCart.Rows[SearchCorrectRow(MenuItemID)].Cells["QuantityColumn"].Value = QuantityValue + 1;
                        break;
                    }
                    else
                    {
                        NumericUpDown cellNumeric = new NumericUpDown();
                        OrdersCart.Rows.Add("", item.Name, "", 1, item.itemID, item.itemPrice);
                        break;
                    }

                }

            }
        }

        private int SearchCorrectRow(int MenuItemID)
        {
            foreach (DataGridViewRow CartRow in OrdersCart.Rows)
            {
                if (CartRow.Cells["ItemID"].Value.Equals(MenuItemID))
                {
                    return CartRow.Index;
                }

            }

            return 0;
        }

        private bool CheckItemPresent(int MenuItemID)
        {
            foreach (DataGridViewRow CartRow in OrdersCart.Rows)
            {
                if (CartRow.Cells[4].Value.Equals(MenuItemID) && CartRow.Cells[4].Value != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowCommentForm()
        {
            Form CommentsForm = new Form();

            TextBox CommentsTextBox = new TextBox();
            CommentsTextBox.Location = new System.Drawing.Point(40, 40);
            CommentsTextBox.Width = 200;
            CommentsTextBox.Height = 160;
            CommentsTextBox.Multiline = true;
            if (OrdersCart.CurrentRow.Cells["CommentHidden"].Value != null)
            {
                if (string.IsNullOrWhiteSpace(OrdersCart.CurrentRow.Cells["CommentHidden"].Value.ToString()))
                {
                    CommentsTextBox.Text = "";
                }
                else
                {
                    CommentsTextBox.Text = OrdersCart.CurrentRow.Cells["CommentHidden"].Value.ToString();
                }
            }

            CommentsForm.Controls.Add(CommentsTextBox);

            Button AddCommentsButton = new Button();
            AddCommentsButton.Text = "Add comments to the Item";
            AddCommentsButton.Location = new Point(60, 210);
            AddCommentsButton.Width = 160;
            AddCommentsButton.Height = 30;
            CommentsForm.Controls.Add(AddCommentsButton);

            AddCommentsButton.Click += (s, e) => {
                OrdersCart.CurrentRow.Cells["CommentHidden"].Value = CommentsTextBox.Text.ToString();
                CommentsForm.Close();

            };

            CommentsForm.ShowDialog();
        }

        private void DeleteRow()
        {
            OrdersCart.Rows.Remove(OrdersCart.CurrentRow);
        }

        private OrderingModel.Order SettingOrderFromCart()
        {
            OrderingModel.Order NewOrder = new OrderingModel.Order();

            foreach (DataGridViewRow row in OrdersCart.Rows)
            {
                for(int i=0; i < int.Parse(row.Cells["QuantityColumn"].Value.ToString()); i++)
                {
                    OrderingModel.Item OrderItem = new OrderingModel.Item();
                    OrderItem.itemID = int.Parse(row.Cells["ItemID"].Value.ToString());

                    if (row.Cells["CommentHidden"].Value != null)
                    {
                        OrderItem.comment = row.Cells["CommentHidden"].Value.ToString();
                    }

                    OrderItem.quantity = int.Parse(row.Cells["QuantityColumn"].Value.ToString());

                    NewOrder.OrderItems.Add(OrderItem);
                }
             
            }

            return NewOrder;
        }

        private void PriceOverviewUpdating()
        {
            PriceOverviewListView.Items.Clear();

            foreach (DataGridViewRow row in OrdersCart.Rows)
            {
                ListViewItem PriceRow = new ListViewItem(row.Cells["ItemNameColumn"].Value.ToString());
                PriceRow.SubItems.Add("....................");
                double truePrice = OrderingLogic.ColumnMultiplier(double.Parse(row.Cells["PriceColumn"].Value.ToString()), double.Parse(row.Cells["QuantityColumn"].Value.ToString()));
                PriceRow.SubItems.Add(truePrice.ToString("0.0000"));
                PriceRow.SubItems.Add(row.Cells["QuantityColumn"].Value.ToString());

                PriceOverviewListView.Items.Add(PriceRow);
            }
        }

        private void MenuTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MenuTypeComboBox.SelectedIndex)
            {
                case 0:
                    FillMenuList();
                    subMenuTypeComboBox.DataSource = OrderingLogic.FillSubComboBox();
                    break;
                case 1:
                    FillMenuList(MenuType.Lunch);
                    subMenuTypeComboBox.DataSource = OrderingLogic.FillSubComboBox(MenuType.Lunch);
                    break;
                case 2:
                    FillMenuList(MenuType.Dinner);
                    subMenuTypeComboBox.DataSource = OrderingLogic.FillSubComboBox(MenuType.Dinner);
                    break;
                case 3:
                    FillMenuList(MenuType.Drink);
                    subMenuTypeComboBox.DataSource = OrderingLogic.FillSubComboBox(MenuType.Drink);
                    break;
            }
        }

        private void subMenuTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (subMenuTypeComboBox.SelectedItem.ToString().Trim())
            {
                case "ALL TYPES":
                    FillMenuList();
                    break;
                case "ALL(LUNCH)":
                    FillMenuList(MenuType.Lunch);
                    break;
                case "ALL(DINNER)":
                    FillMenuList(MenuType.Dinner);
                    break;
                case "ALL(DRINKS)":
                    FillMenuList(MenuType.Drink);
                    break;
                case "LUNCH MAIN":
                    FillMenuList(SubMenuType.LunchMain);
                    break;
                case "SPECIALS":
                    FillMenuList(SubMenuType.Specials);
                    break;
                case "BITES":
                    FillMenuList(SubMenuType.Bites);
                    break;
                case "DINNER STARTERS":
                    FillMenuList(SubMenuType.Starters);
                    break;
                case "DINNER MAINS":
                    FillMenuList(SubMenuType.Mains);
                    break;
                case "DESSERTS":
                    FillMenuList(SubMenuType.Desserts);
                    break;
                case "SOFT DRINKS":
                    FillMenuList(SubMenuType.SoftDrinks);
                    break;
                case "HOT DRINKS":
                    FillMenuList(SubMenuType.HotDrinks);
                    break;
                case "BEERS":
                    FillMenuList(SubMenuType.Beers);
                    break;
                case "WINES":
                    FillMenuList(SubMenuType.Wines);
                    break;
            }
        }

        private void MenuListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (MenuListView.SelectedItems.Count > 0)
                AddToCartButton.Enabled = true;           
            else
                AddToCartButton.Enabled = false;
        }

        private void MenuListView_DoubleClick(object sender, EventArgs e)

        {
            if (MenuListView.SelectedItems.Count == 1)
            {
                int MenuItemID = int.Parse(MenuListView.SelectedItems[0].SubItems[1].Text);
                AddCartItems(MenuItemID);
            }

        }

        private void OrdersCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            PriceOverviewUpdating();
        }

        private void OrdersCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            PriceOverviewUpdating();           
        }
        private void OrdersCart_CellStyleContentChanged(object sender, DataGridViewCellEventArgs e)
        {
            PriceOverviewUpdating();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(MenuListView.SelectedItems[0].SubItems[1].Text);
            AddCartItems(MenuItemID);
        }

        private void OrderCartButtons_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == OrdersCart.Columns["CommentButtonColumn"].Index)
            {
                ShowCommentForm();
                
            }
            else if(e.ColumnIndex == OrdersCart.Columns["DeleteButtonColumn"].Index)
            {
                DeleteRow();
            }
        }

        private void OrderCartButtonGraphics_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
               
                using (var imageSource = new Bitmap(Properties.Resources.comment_icon))
                {
                    e.PaintContent(e.CellBounds);
                    e.Graphics.DrawImage(imageSource, e.CellBounds.Left + 10, e.CellBounds.Top + 5, 30, 30);
                }
                e.Handled = true;

            }

            if (e.ColumnIndex == 2)
            {

                using (var imageSource = new Bitmap(Properties.Resources.delete_icon))
                {
                    e.PaintContent(e.CellBounds);
                    e.Graphics.DrawImage(imageSource, e.CellBounds.Left + 9, e.CellBounds.Top + 10, 20, 20);
                   
                }
                e.Handled = true;
            }

            
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (OrdersCart.Rows.Count == 0)
            {
                MessageBox.Show("Orders cart is empty", "Chapeau says");
            }
            else
            {
                DialogResult ContinueDialog = MessageBox.Show("Are you sure you want to place this order?", "Chapeau says", MessageBoxButtons.YesNo);
                if (ContinueDialog == DialogResult.Yes)
                {
                    OrderingLogic.ActionInsertOrdersDB(SettingOrderFromCart(), this.table.GetTableId(), this.employee.GetEmployeeId());
                    this.Close();
                    OccupiedTableForm occupied = new OccupiedTableForm(table, employee);
                    occupied.ShowDialog();
                }
            }

        }

        private void PriceOverviewListView_ColumnWidthChanged(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = PriceOverviewListView.Columns[e.ColumnIndex].Width;
        }

        private void OrderingSystemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            RestaurantOverview_Form form = new RestaurantOverview_Form(employee);
            form.Show();
            this.Close();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            OrdersCart.Rows.Clear();
            OrdersCart.Refresh();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
