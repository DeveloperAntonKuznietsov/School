using SchuleApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                    SerialNuber="00",
                    LastName="Default",
                    FirstName="Default",
                    Address="Default",
                    Phone="Default",
                    Order="Default"
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
       public Client client=new Client();
        private void BtnNew_Click(object sender, EventArgs e)
        {
            FormAddNew();
        }

        private void FormAddNew()
        {
            NewClient newClient = new NewClient();
            if (newClient.ShowDialog() == DialogResult.OK)
            {
                client = newClient.newClient;
                _clients.Add(client);
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            MethodNext();
        }
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodNext();
        }

        private void MethodNext()
        {
            _index++;
            if (_index >= _clients.Count) _index = 0;
            DataBinding(_index);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNew();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            MethodPrevious();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodPrevious();
        }
        private void MethodPrevious()
        {
            _index--;
            if (_index < 0) _index = _clients.Count - 1;
            DataBinding(_index);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            _index = 0;
            DataBinding(_index);
        }

        private void firstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _index = 0;
            DataBinding(_index);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            _index = _clients.Count - 1;
            DataBinding(_index);
        }

        private void lastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _index = _clients.Count - 1;
            DataBinding(_index);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var number = txtBoxSearch.Text;
            var counter=0;
            if(number!=null && !number.Equals("")) 
            { 
                foreach(Client client in _clients)
                {
                     if (client.SerialNuber.Equals(number))
                      {
                        counter++;
                        txtNumberClient.Text = client.SerialNuber;
                        txtFirstnameClient.Text = client.FirstName;
                        txtLastnameClient.Text = client.LastName;
                        txtPhoneClient.Text = client.Phone;
                        txtAddressClient.Text = client.Address;
                        txtOrderClient.Text = client.Order;
                     }

                }
                if (counter == 0)
                {
                    MessageBox.Show("Nothing found", "No match", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Fields cannot be empty!", "Error",  MessageBoxButtons.OK);
            }
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            _clients.RemoveAt(_index);
            MethodNext();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _clients.RemoveAt(_index);
            MethodNext();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            MethodSaveData();
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodSaveData();
        }

        private void MethodSaveData()
        {
            StreamWriter str = new StreamWriter("clients.txt");
            for (int i = 0; i < _clients.Count; i++)
            {
                str.WriteLine(_clients[i].SerialNuber);
                str.WriteLine(_clients[i].FirstName);
                str.WriteLine(_clients[i].LastName);
                str.WriteLine(_clients[i].Phone);
                str.WriteLine(_clients[i].Address);
                str.WriteLine(_clients[i].Order);
            }
            str.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            _clients = _clients = new List<Client>();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //string data = File.ReadAllText(openFile.FileName);
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    
                    while (!sr.EndOfStream)
                    {
                       
                            Client client = new Client
                            {
                                SerialNuber = sr.ReadLine(),
                                LastName = sr.ReadLine(),
                                FirstName = sr.ReadLine(),
                                Address = sr.ReadLine(),
                                Phone = sr.ReadLine(),
                                Order = sr.ReadLine()
                            };
                        _clients.Add(client);
                    }
                }
                MethodNext();
            }
        }
    }
}
