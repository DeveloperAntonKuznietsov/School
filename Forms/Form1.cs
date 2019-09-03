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
    public partial class Form1 : Form
    {
        List<Client> _clients;
        private int _index;
        public Form1()
        {
            InitializeComponent();

            _clients = new List<Client>
            {
                new Client
                {
                    SerialNuber="123",
                    LastName="popov",
                    FirstName="alex",
                    Address="sss",
                    Phone="222",
                    Order="sasw"

                }
            };
            _index = 0;
            DataBinding(_index);
        }
        private void DataBinding(int index)
        {
            txtNumberClient.Text = _clients[index].SerialNuber;
            txtFirstnameClient.Text = _clients[index].FirstName;
            txtLastnameClient.Text = _clients[index].LastName;
            txtPhoneClient.Text = _clients[index].Phone;
            txtAddressClient.Text = _clients[index].Address;
            txtOrderClient.Text = _clients[index].Order;
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
            Client client = new Client
            {
                SerialNuber = newClient.SrialNumber,
                FirstName=newClient.Firstname,
                LastName=newClient.Lastname,
                Address=newClient.Address,
                Phone=newClient.Phone,
                Order=newClient.Order
            };
            _clients.Add(client);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _index++;
            if (_index >= _clients.Count) _index = 0;
            DataBinding(_index);
        }
    }
}
