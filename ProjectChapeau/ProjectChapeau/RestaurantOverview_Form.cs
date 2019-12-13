using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau_Logic;
using Chapeau_Model;


namespace ProjectChapeau
{
    public partial class RestaurantOverview_Form : Form //Machelle
    {

        public RestaurantOverview_Form(ChapeauModel.Employee employee)
        {
            InitializeComponent();

            //the timer (made by Machelle)
            Timer timer = new Timer();
            timer.Interval = (15 * 1000); // 15 secs
            timer.Enabled = true;
            timer.Tick += new EventHandler((s, ev) => timer_Tick(s, ev, this, employee)); ;
            timer.Start();

            //the standard controls that will not be reloaded each time and therefore are created here
            lbl_loggedinEmployee.ForeColor = Color.Black;
            lbl_loggedinEmployee.Text = employee.Firstname + " " + employee.Lastname;
            lbl_loggedinEmployee.Font = new Font(lbl_loggedinEmployee.Font, FontStyle.Bold);
            pnl_topbar.Controls.Add(lbl_loggedinEmployee);

            //everything that will be reloaded using the timer every 15 seconds, though also needs to be loaded once when the form is created
            Load_RestaurantOverview(this, employee);

        }

        //clear flow panels method + reload trigger
        protected void timer_Tick(object sender, EventArgs e, RestaurantOverview_Form form, ChapeauModel.Employee employee)
        {
            //simply clearing the even flow panels since these panels won't be re-added
            form.flowlaypnl_statusEven.Controls.Clear();
            form.flowlaypnl_table_overview_even.Controls.Clear();

            //simply clearing the uneven flow panels since these panels won't be re-added
            form.flowlaypnl_statusUneven.Controls.Clear();
            form.flowlaypnl_table_overview_uneven.Controls.Clear();

            Load_RestaurantOverview(form, employee);

        }

        //reload method
        public void Load_RestaurantOverview(RestaurantOverview_Form form, ChapeauModel.Employee employee)
        {
            TableTopLogic tablelogic = new TableTopLogic();
            List<TableTop> AllTables = tablelogic.tableTopListLogic();

            foreach (TableTop table in AllTables)
            {
                TableButton tablebutton = new TableButton(table, this, employee);
                StatusButton statusButton = new StatusButton(table, 1);
                StatusButton satTimeButton = new StatusButton(table, 2);

                if (table.GetTableId() % 2 == 0)
                {
                    form.flowlaypnl_table_overview_even.Controls.Add(tablebutton); //adds the even buttons here (2,4,6,8,10)
                    form.flowlaypnl_statusEven.Controls.Add(statusButton);
                    form.flowlaypnl_statusEven.Controls.Add(satTimeButton);
                }
                else
                {
                    form.flowlaypnl_table_overview_uneven.Controls.Add(tablebutton); //adds the uneven buttons here (1,3,5,7,9)
                    form.flowlaypnl_statusUneven.Controls.Add(statusButton);
                    form.flowlaypnl_statusUneven.Controls.Add(satTimeButton);
                }
            }
        }

        //square table button
        public class TableButton : Button //Machelle
        {

            public TableButton(TableTop table, RestaurantOverview_Form form, ChapeauModel.Employee employee)
            {
                this.Size = new Size(70, 70);
                this.Font = new Font("Arial", 12, FontStyle.Bold);
                this.Text = table.GetTableId().ToString();
                this.Click += new EventHandler((s, ev) => TableButton_Click(s, ev, table, form, employee));
                this.Margin = new Padding(0, 25, 0, 0);

                if (table.GetTableStatus() == TableStatus.Available)
                {
                    this.BackColor = Color.Green;
                }
                else if (table.GetTableStatus() == TableStatus.Occupied)
                {
                    this.BackColor = Color.Red;
                }
                else if (table.GetTableStatus() == TableStatus.Reserved)
                {
                    this.BackColor = Color.LightYellow;
                }


            }

            public void TableButton_Click(object sender, EventArgs e, TableTop table, RestaurantOverview_Form form, ChapeauModel.Employee employee)
            {


                if (table.GetTableStatus() == TableStatus.Available)
                {
                    OrderingForm ordering = new OrderingForm(table, employee);
                    ordering.Show();
                    form.Close();
                }
                else
                {
                    OccupiedTableForm occupied = new OccupiedTableForm(table, employee);
                    occupied.Show();
                    form.Close();

                }

            }
        }

        public class StatusButton : Button
        {
            public StatusButton(TableTop table, int position)
            {
                this.Size = new Size(70, 35);
                this.Font = new Font("Arial", 7);
                this.Text = table.GetTableStatus().ToString();

                bool orderCompleted = OrderingLogic.GetOrderStatus(table.GetTableId());


                if (position % 2 != 0)// status information (top)
                {
                    this.Margin = new Padding(0, 25, 0, 0);

                    if (table.GetTableStatus() == TableStatus.Available)
                    {
                        this.Text = "Table Available";
                    }
                    else if (table.GetTableStatus() == TableStatus.Occupied)
                    {

                        if (!orderCompleted)
                        {
                            this.Text = "Waiting for order";
                        }
                        else
                        {
                            this.Text = "No pending orders";
                        }
                    }
                }

                else //set time information (bottom)
                {
                    this.Margin = new Padding(0, 0, 0, 0);

                    if (!orderCompleted && table.GetTableStatus() == TableStatus.Occupied)
                    {
                        this.Text = "Wait time : " + (OrderingLogic.GetWaitingTime(table.GetTableId())).ToString() + " min";
                    }
                    else
                    {
                        this.Text = " - ";
                    }
                }


            }
        }



        private void btn_logoff_Click(object sender, EventArgs e)
        {

            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        public void NotifyWaiter(ChapeauModel.Order notify)
        {
            DialogResult dialog = (MessageBox.Show("Kitchen needs you!", "For table " + notify.tableId, MessageBoxButtons.OK));
        }

        private void flowlaypnl_table_overview_even_Paint(object sender, PaintEventArgs e)
        {

        }
    }



}
