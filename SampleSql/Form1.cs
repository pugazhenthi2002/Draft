using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;
using MySql.Data.MySqlClient;

namespace SampleSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string connectionstring = "server=localhost;port=3306;uid=root;" + "database=practice";
            manager = new MySqlHandler("localhost", "root", "Lucid123", "ProjectManagement");
            var x = manager.Connect().Result;
            var z = manager.ShowTables("expense").Value;
            var y = manager.CheckConnection().ToString();
        }
        DatabaseManager manager;
    }
}
