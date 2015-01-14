using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestModelFirst
{
    public partial class UpdateRecord : Form
    {
        string OldName = "";
        DateTime OldPurchaseDate = new DateTime();
        Decimal OldAmount = new Decimal();

        public UpdateRecord()
        {
            InitializeComponent();
        }

        private void UpdateRecord_Load(object sender, EventArgs e)
        {
            Rewards2ModelContainer context = new Rewards2ModelContainer();


            var PurchaseData = from pd in context.Purchases
                               select pd;

            txtCustomerName.Text = PurchaseData.First().Customers.CustomerName;
            txtPurchaseDate.Text = PurchaseData.First().PurchaseDate.ToShortDateString();
            txtAmount.Text = PurchaseData.First().Amount.ToString();

            OldName = PurchaseData.First().Customers.CustomerName;
            OldPurchaseDate = PurchaseData.First().PurchaseDate;
            OldAmount = PurchaseData.First().Amount;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayData()
        {
            Rewards2ModelContainer context = new Rewards2ModelContainer();

            var PurchaseData = from pd in context.Purchases
                               select pd;

            OldName = PurchaseData.First().Customers.CustomerName;
            OldPurchaseDate = PurchaseData.First().PurchaseDate;
            OldAmount = PurchaseData.First().Amount;

            StringBuilder Output = new StringBuilder();
            Output.Append(PurchaseData.First().Customers.CustomerName +
                "\r\n" + PurchaseData.First().PurchaseDate +
                "\r\n" + PurchaseData.First().Amount);
            MessageBox.Show(Output.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rewards2ModelContainer context = new Rewards2ModelContainer();

            if (OldName != txtCustomerName.Text)
                context.Purchases.First().Customers.CustomerName = txtCustomerName.Text;

            if (OldPurchaseDate != Convert.ToDateTime(txtPurchaseDate.Text))
                context.Purchases.First().PurchaseDate = Convert.ToDateTime(txtPurchaseDate.Text);

            if (OldAmount.ToString() != txtAmount.Text)
                context.Purchases.First().Amount = Convert.ToDecimal(txtAmount.Text);

            context.SaveChanges();

            DisplayData();
        }
    }
}
