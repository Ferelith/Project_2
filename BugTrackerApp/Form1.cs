using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BugTrackerApp
{
    public partial class Form1 : Form
    {
        public static string databaseCon = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\c3469557\\Documents\\TrackerDB.mdf;Integrated Security = True; Connect Timeout = 30";
        Connection conn = new Connection(databaseCon);
        public Form1()
        {
            InitializeComponent();
            // Passing a connection string to class Connection.
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
    public class Connection
    {
        
        SqlConnection mySqlConnection = new SqlConnection();
        SqlCommand mySqlCommand = new SqlCommand();
        public Connection(string data)
        {
            // Initializing the connection.
            SqlConnection mySqlConnection = new SqlConnection(data);
            // Opening the connection using mySqlConnection and passed string.
            mySqlConnection.Open();
            /*
            // Checking connection state.
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connected");
            } else
            {
                MessageBox.Show("Not connected");
            }
            */
        }
        public void sendQuery()
        {

        }

        public void closeConn(string data)
        {
            // Closing connection with the database.
           
        }
    }
   
}
