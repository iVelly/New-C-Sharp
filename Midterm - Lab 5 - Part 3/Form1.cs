using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer temp = new Customer();
            temp.FirstName = txtfirstName.Text;
            temp.MiddleName = txtmiddleName.Text;
            temp.LastName = txtlastName.Text;
            temp.Street1 = txtstreet1.Text;
            temp.Street2 = txtstreet2.Text;
            temp.City = txtcity.Text;
            temp.State = txtstate.Text;
            temp.Zip = txtzip.Text;
            temp.Phone = txtphone.Text;
            temp.Email = txtemail.Text;
            temp.CellPhone = txtCell.Text;
            temp.TotalPurchase = double.Parse(txtPurchases.Text);
            temp.DiscountMember = bool.Parse(txtDiscountMember.Text);
            temp.Rewards = int.Parse(txtRewardsEarned.Text);
            temp.CustomerSince = DateTime.Parse(txtCustomerSince.Text);

        lblFeedback.Text = "User Information" + "\nFirst Name: " + txtfirstName.Text + "\nMiddle Name: " + txtmiddleName.Text + "\nLast Name: " + txtlastName.Text + "\nPrimary Address: " + txtstreet1.Text + "\nSecondary Address: " + txtstreet2.Text + "\nState: " + txtstate.Text + "\nCity: " + txtcity.Text + "\nEmail: " + txtemail.Text + "\nZip Code: " + txtzip.Text + "\nPhone Number: " + txtphone.Text + "\nInstagram URL: " + txtInsta.Text + "\nCell Phone: " + txtCell.Text + "\nTotal of Purchase: " + double.Parse(txtPurchases.Text) + "\nDiscount Member: " + bool.Parse(txtDiscountMember.Text) + "\nRewards Earned: " + int.Parse(txtRewardsEarned.Text) + "\nCustomer Since: " + DateTime.Parse(txtCustomerSince.Text) + temp.Feedback; ;
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
