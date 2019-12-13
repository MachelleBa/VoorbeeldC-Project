using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Chapeau_Logic;
using Chapeau_Model;

namespace ProjectChapeau
{
    public partial class Payment_Form : Form
    {
        private int orderId;
        private ChapeauModel.Employee employee;

        public Payment_Form(ChapeauModel.Employee employee, int tableId)
        {
            InitializeComponent();
            this.employee = employee;
            orderId = OrderingLogic.GetOrderId(tableId);
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            payCashbttn.Appearance = Appearance.Button; //Payment Method Buttons
            payCashbttn.BackgroundImageLayout = ImageLayout.Stretch;
            payDebitbttn.Appearance = Appearance.Button;
            payDebitbttn.BackgroundImageLayout = ImageLayout.Stretch;
            payCreditbttn.Appearance = Appearance.Button;
            payCreditbttn.BackgroundImageLayout = ImageLayout.Stretch;

            TipInputnum.Value = 0; //NumericUpDown -> TipInput
            TipInputnum.Minimum = 0;
            TipInputnum.DecimalPlaces = 2;

            orderItemsPaymentlv.View = View.Details;  //Items that have been ordered
            orderItemsPaymentlv.Columns.Add("Menu Items", 175, HorizontalAlignment.Left);
            orderItemsPaymentlv.Columns.Add("Quantity", 70, HorizontalAlignment.Left);
            orderItemsPaymentlv.Columns.Add("Price", 65, HorizontalAlignment.Left);

            orderDetailsPaymentlv.View = View.Details; //Final Payment Values
            orderDetailsPaymentlv.Columns.Add("Vat", 310/3, HorizontalAlignment.Center);
            orderDetailsPaymentlv.Columns.Add("Vat-Free Price", 310/3, HorizontalAlignment.Center);
            orderDetailsPaymentlv.Columns.Add("Final Price", 310/3, HorizontalAlignment.Center);

            PaymentLogic pl = new PaymentLogic();
            List<OrderItems> orderItems = pl.GetOrderItems(orderId);
            Payment finalValues = pl.GetTotalPayments(orderId);
            
            try
            {
                if (orderItems.Count == 0)
                {
                    throw new Exception("Either nothing has been ordered yet, or your order hasn't been completed!");
                }

                for (int i = 0; i < orderItems.Count; i++)
                {
                    orderItemsPaymentlv.Items.Add(orderItems[i].ItemName);
                    orderItemsPaymentlv.Items[i].SubItems.Add(orderItems[i].Quantity.ToString());
                    orderItemsPaymentlv.Items[i].SubItems.Add(orderItems[i].ItemPrice.ToString("0.00"));

                    if (i < 1)
                    {
                        orderDetailsPaymentlv.Items.Add(finalValues.Vat.ToString("0.00"));
                        orderDetailsPaymentlv.Items[i].SubItems.Add(finalValues.InitialPrice.ToString("0.00"));
                        orderDetailsPaymentlv.Items[i].SubItems.Add(finalValues.TotalPrice.ToString("0.00"));
                    }                    
                }
            }            

            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Payment View Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation //For triangle Warning 
                );

                Close();
            }
        }        

        private void FinishedPaymentBttn_Click(object sender, EventArgs e)
        {
            PaymentMethod paymentMethod = PaymentMethod.Cash;
            double tip = double.Parse(TipInputnum.Value.ToString()); //user input
            
            if (payCreditbttn.Checked)
            {
                paymentMethod = PaymentMethod.Credit;
            }

            else if (payDebitbttn.Checked)
            {
                paymentMethod = PaymentMethod.Debit;
            }            

            PaymentLogic pl = new PaymentLogic();            

            DialogResult confirmPayment = MessageBox.Show("Are you sure you wish to pay for this order?", "Confirm Payment", MessageBoxButtons.YesNo);
            if (confirmPayment == DialogResult.Yes)
            {
                pl.InsertPayment(employee.EmployeeId, orderId, tip, paymentMethod, CommentsTxt.Text);

                DialogResult finalisePayment = MessageBox.Show(
                                               "You have succesfully paid for your order!",
                                               "Payment Complete",
                                               MessageBoxButtons.OK
                                               );

                if (finalisePayment == DialogResult.OK)
                {
                    Close();
                }
            }                                 
        }

        private void CancelPaymentbttn_Click(object sender, EventArgs e)
        {
            //RestaurantOverview_Form restaurantOverview = new RestaurantOverview_Form(employee);
            Close();
            //restaurantOverview.Show();
        }        
    }
}
