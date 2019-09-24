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
    public partial class AddNew : Form
    {
        private string _serialNumber;
        public string SrialNumber
        {
            get =>_serialNumber;
            set => _serialNumber = value;
        }
        public string _firstname;
        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }
        private string _lastname;
        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }
        private string _address;
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        private string _phone;
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        private string _order;
        public string Order
        {
            get => _order;
            set => _order = value;
        }
        public  Client newClient=new Client();
     
        public AddNew()
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




            newClient.SerialNuber = txtNumberClient.Text;
            newClient.FirstName = txtFirstnameClient.Text;
            newClient.LastName = txtLastnameClient.Text;
            newClient.Address = txtAddressClient.Text;
            newClient.Phone = txtPhoneClient.Text;
            newClient.Order = txtOrderClient.Text;


            MessageBox.Show(this, "Added successfully!",
                                    "Like a house on fire!", MessageBoxButtons.OK);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
