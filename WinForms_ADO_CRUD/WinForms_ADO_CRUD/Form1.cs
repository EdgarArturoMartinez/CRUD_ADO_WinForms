using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_ADO_CRUD;

namespace WinForms_ADO_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            PeopleDB objPeople = new PeopleDB();
            if (objPeople.GetConnection())
            {
                MessageBox.Show("Test Succesfully, App Connected to Database");
            }
            else
            {
                MessageBox.Show("Test Failed! App did not connect to Database");
            }
        }
    }
}
