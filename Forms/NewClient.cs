using SchuleApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchuleApp1
{
    public partial class NewClient : Form
    {
        public string SrialNumber
        {
            get => txtNumberClient.Text;
            set => txtNumberClient.Text = value;
        }
        public string Firstname
        {
            get => txtFirstnameClient.Text;
            set => txtFirstnameClient.Text = value;
        }
        public string Lastname
        {
            get => txtLastnameClient.Text;
            set => txtLastnameClient.Text = value;
        }
        public string Address
        {
            get => txtAddressClient.Text;
            set => txtAddressClient.Text = value;
        }
        public string Phone
        {
            get => txtPhoneClient.Text;
            set => txtPhoneClient.Text = value;
        }
        public string Order
        {
            get => txtOrderClient.Text;
            set => txtOrderClient.Text = value;
        }

        public NewClient()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtNumberClient.Text == "")
            {
                MessageBox.Show(this, "Fields cannot be empty!",
                                   "Error", MessageBoxButtons.OK);
            }
        }
    }
}
