using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
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
            Persons temp = new Persons();
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

            lblFeedback.Text = lblFeedback.Text = "User Information" + "\nFirst Name: " + txtfirstName.Text + "\nMiddle Name: " + txtmiddleName.Text + "\nLast Name: " + txtlastName.Text + "\nPrimary Address: " + txtstreet1.Text + "\nSecondary Address: " + txtstreet2.Text + "\nState: " + txtstate.Text + "\nCity: " + txtcity.Text + "\nEmail: " + txtemail.Text + "\nZip Code: " + txtzip.Text + "\nPhone Number: " + txtphone.Text;
        }
    }
}
