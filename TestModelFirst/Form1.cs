using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestModelFirst
{
    public partial class Form1 : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public delegate void ContextCallback(IQueryable<Customers> CustomerList);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchases NewPurchase = new Purchases();
            NewPurchase.Amount = new Decimal(5.99);
            NewPurchase.PurchaseDate = DateTime.Now;

            Customers NewCustomer = new Customers();
            NewCustomer.CustomerName = "Customer Name";

            Rewards2ModelContainer context = new Rewards2ModelContainer();

            context.Customers.Add(NewCustomer);
            context.Purchases.Add(NewPurchase);
            context.SaveChanges();

            MessageBox.Show("Record Added");
        }

        private void btnConcurrency_Click(object sender, EventArgs e)
        {
            UpdateRecord User1 = new UpdateRecord();
            User1.Text = "User 1 Update";
            User1.Show(this);

            UpdateRecord User2 = new UpdateRecord();
            User2.Text = "User 2 Update";
            User2.Show(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Rewards2ModelContainer context = new Rewards2ModelContainer();

            IQueryable<Customers> customersData = context.Customers.AsQueryable();

            var customerDataList = customersData.Select(cd => cd);
        }

        private void btnThreaded_Click(object sender, EventArgs e)
        {
            MultiThreadedQuery MTQ = new MultiThreadedQuery(new ContextCallback(ResultsCallback));

            Thread MyThread = new Thread(MTQ.GetCustomers);
            MyThread.Start();
        }


        public static void ResultsCallback(IQueryable<Customers> CustomerList)
        {
            StringBuilder Output = new StringBuilder("Customer List:");

            foreach (var customer in CustomerList)
            {
                Output.Append("\r\n" + customer.CustomerName + "has made pruchases on:");

                foreach (var purchase in customer.Purchases)
                {
                    Output.Append("\r\n" + purchase.PurchaseDate);
                }
            }

            MessageBox.Show(Output.ToString());
        }

        /// <summary>
        /// Delte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_2(object sender, EventArgs e)
        {
            Rewards2ModelContainer context = new Rewards2ModelContainer();

            int deletedItemId = (int)cbCustomerID.SelectedValue; 
            var delCustomerList = context.Customers.FirstOrDefault(c => c.Id == deletedItemId);
            var delPurchaseList = context.Purchases.Where(p => p.CustomersId == deletedItemId);

            if (delPurchaseList != null)
            {
                context.Purchases.RemoveRange(delPurchaseList);            
            }

            context.Customers.Remove(delCustomerList);
            context.SaveChanges();

            this.purchasesTableAdapter.Fill(this.rewards2DataSet.Purchases);
            this.customersTableAdapter.Fill(this.rewards2DataSet.Customers);       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rewards2DataSet.Purchases' table. You can move, or remove it, as needed.
            this.purchasesTableAdapter.Fill(this.rewards2DataSet.Purchases);
            // TODO: This line of code loads data into the 'rewards2DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.rewards2DataSet.Customers);
        }
    }

    public class MultiThreadedQuery
    {
        private Rewards2ModelContainer context;

        private IQueryable<Customers> CustomerList;

        private readonly Form1.ContextCallback _Callback;

        public MultiThreadedQuery(Form1.ContextCallback CallbackDelegate)
        {
            _Callback = CallbackDelegate;          
        }

        public void GetCustomers()
        {
            if (context == null)
            {
                context = new Rewards2ModelContainer();
            }

            lock (context)
            {
                CustomerList = from cust in context.Customers
                               select cust;

                if (_Callback != null)
                {
                    _Callback(CustomerList);                              
                }
            }


        }
    
    }
}
