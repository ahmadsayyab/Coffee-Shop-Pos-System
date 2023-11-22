using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string name;
        int quantity;
        int price;
        int total;
        int grandTotal = 0;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (chkCoffee.Checked)
            {
                name = "Coffee";
                quantity = int.Parse(nudCoffee.Value.ToString());
                price = 300;
                total = price * quantity;


                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (chkTea.Checked)
            {
                name = "Tea";
                quantity = int.Parse(nudTea.Value.ToString());
                price = 100;
                total = price * quantity;

                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (chkGreenTea.Checked)
            {
                name = "Green Tea";
                quantity = int.Parse(nudGreenTea.Value.ToString());
                price = 60;
                total = price * quantity;

                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (chkColdDrink.Checked)
            {
                name = "Cold Drink";
                quantity = int.Parse(nudColdDrink.Value.ToString());
                price = 60;
                total = price * quantity;

                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (chkBiryani.Checked)
            {
                name = "Biryani";
                quantity = int.Parse(nudBiryani.Value.ToString());
                price = 300;
                total = price * quantity;

                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (chkFish.Checked)
            {
                name = "Fish";
                quantity = int.Parse(nudFish.Value.ToString());
                price = 800;
                total = price * quantity;

                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (chkBeef.Checked)
            {
                name = "Beef";
                quantity = int.Parse(nudBeef.Value.ToString());
                price = 3000;
                total = price * quantity;

                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (chkChicken.Checked)
            {
                name = "Chicken";
                quantity = int.Parse(nudChicken.Value.ToString());
                price = 1500;
                total = price * quantity;

                grandTotal += total;
                DataService.SaveOrder(name, quantity, price, total);
            }

            if (grandTotal > 0)
            {
                lblTotalBill.Text = grandTotal.ToString();
                lblTotalBill.Visible = true;
                dgvOrderData.DataSource = DataService.GetOrderData();
            }
            else
            {
                MessageBox.Show("There is either no selection made or a missing element in your current choice!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //dgvOrderData.DataSource = DataService.GetOrderData();
        }

        
    }
}
