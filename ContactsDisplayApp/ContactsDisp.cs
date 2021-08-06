using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsLib.Data;

namespace ContactsDisplayApp
{
    public partial class ContactsDisp : Form
    {
        SqlDBAccess sqlDB;
        DataSet ds;

        public ContactsDisp()
        {
            ds = new DataSet();
            sqlDB = new SqlDBAccess("connection_string");
            ds = sqlDB.FillData();
            InitializeComponent();
        }

        private void displayContactsBtn_Click(object sender, EventArgs e)
        {
            dispContacts.DataSource = ds.Tables[0];
            dispContacts.Update();
        }

        private void displayAddressBtn_Click(object sender, EventArgs e)
        {
            dispAddress.DataSource = ds.Tables[1];
            dispAddress.Update();
        }

        private void addUserContacts_Click(object sender, EventArgs e)
        {
            string name = getName.Text;
            string addr = getAddr.Text;
            string no = getNo.Text;

            getName.Text = "";
            getAddr.Text = "";
            getNo.Text = "";

            sqlDB.AddContacts(name, no, addr);
        }

        private void displayUserAddrBtn_Click(object sender, EventArgs e)
        {
            string contactAddressName = getNameAddr.Text;
            ds = sqlDB.FetchAdresses(contactAddressName, ds);
            showUserAddr.DataSource = ds.Tables[2];
        }
    }
}