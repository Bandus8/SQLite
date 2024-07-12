using Kribo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Class;

namespace WindowsFormsApp2.Forms
{
    public partial class ContactList : Form
    {
        public ContactList()
        {
            InitializeComponent();
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            dBHelper db = new dBHelper(dBFunctions.ConnectionStringSQLite);
            db.Load("SELECT*FROM Contact");
            DataTable dataTabel = db.DataSet.Tables[0];
            dataGridView1.DataSource = dataTabel;
        }
    }
}
