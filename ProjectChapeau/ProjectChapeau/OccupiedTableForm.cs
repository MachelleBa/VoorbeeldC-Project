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
    public partial class OccupiedTableForm : Form
    {
        private TableTop table;
        private ChapeauModel.Employee employee;

        public OccupiedTableForm(TableTop table, ChapeauModel.Employee employee)
        {
            this.employee = employee;

            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Enabled = true;
            timer.Tick += new EventHandler((s, e) => timer_Tick(s, e)); ;
            timer.Start();

            InitializeComponent();
            //labelDisplayTableID.Text = "Table " + table.GetTableId();
            this.table = table;
            this.employee = employee;
            ordertimeLabel.Text = ("Waiting time since order was placed: " + OrderingLogic.GetWaitingTime(table.GetTableId()) + " minutes");
            if (OrderingLogic.GetOrderStatus(OrderingLogic.GetOrderId(table.GetTableId())) == true)
            {
                statusDisplayLabel.Text = "Served";
            }
            else
            {
                statusDisplayLabel.Text = "Waiting Order";
            }
            FillTableList();


        }

        protected void timer_Tick(object sender, EventArgs e)
        {
            ordertimeLabel.Text = ("Waiting time since order was placed: " + OrderingLogic.GetWaitingTime(table.GetTableId()) + " minutes");
            if (OrderingLogic.GetOrderStatus(OrderingLogic.GetOrderId(table.GetTableId())) == true)
            {
                statusDisplayLabel.Text = "Served";
            }
            else
            {
                statusDisplayLabel.Text = "Waiting Order";
            }
        }


        private void FillTableList()
        {
            tableReceiptListView.HideSelection = false;
            tableReceiptListView.Items.Clear();
            List<OrderingModel.Item> TableItemsList = new List<OrderingModel.Item>();
            TableItemsList = OrderingLogic.CallTableItemsDB(this.table.GetTableId());
            decimal price = 0;

            foreach (OrderingModel.Item TableItem in TableItemsList)
            {

                ListViewItem LvTableItem = new ListViewItem(TableItem.Name);
                LvTableItem.SubItems.Add("...................");
                LvTableItem.SubItems.Add(TableItem.itemPrice.ToString());
                tableReceiptListView.Items.Add(LvTableItem);
                price = TableItem.itemPrice + price;
            }

            ListViewItem LvPriceItem = new ListViewItem("Total Price");
            LvPriceItem.SubItems.Add("...................");
            LvPriceItem.SubItems.Add(price.ToString());
            tableReceiptListView.Items.Add(LvPriceItem);

        }

        private void tableReceiptListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void startPaymentButton_Click(object sender, EventArgs e)
        {
            Payment_Form payment = new Payment_Form(employee, table.GetTableId());
            payment.Show();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            OrderingForm ordering = new OrderingForm(table, employee);
            this.Close();
            ordering.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            RestaurantOverview_Form form = new RestaurantOverview_Form(employee);
            form.Show();
            this.Close();
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult ContinueDialog = MessageBox.Show("Are you sure you want to cancel this order?", "Chapeau says", MessageBoxButtons.YesNo);
            if (ContinueDialog == DialogResult.Yes)
            {
                OrderingLogic.ActionDeleteOrdersDB(table.GetTableId());

                RestaurantOverview_Form form = new RestaurantOverview_Form(employee);
                form.Show();
                this.Close();
            }

        }

        private void OccupiedTableForm_Load(object sender, EventArgs e)
        {
            //the timer (made by Machelle)


        }
    }
}
