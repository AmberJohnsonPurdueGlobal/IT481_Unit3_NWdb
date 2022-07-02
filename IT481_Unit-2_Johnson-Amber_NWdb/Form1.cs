using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;


namespace IT481_Unit_2_Johnson_Amber_NWdb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.northwindDataSet1.Customers);
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void checkingConnection_label_Click(object sender, EventArgs e, string customersDataTable)

        {

            try
            {
                this.customersTableAdapter1.FillBy(this.northwindDataSet1.Customers);
                SqlConnection connection = new SqlConnection();

                connection.ConnectionString = customersDataTable;
                connection.Open();

                checkingConnection_label.Text = "Connection Successful";

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex);
            }


        }

        private void viewDatabase_button_Click(object sender, EventArgs e, string customersDataTable)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = customersDataTable;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from Customers";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView.DataSource = dt;
            connection.Close();
        }

        private void updateDatabase_button_Click(object sender, EventArgs e, string customersDataTable)
        {
            this.customersTableAdapter1.FillBy(this.northwindDataSet1.Customers);

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = customersDataTable;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "insert into customers (ID, Company) values('" + id_textBox.Text + "','" + companyName_textBox.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Data Saved");
            connection.Close();


        }

        private void recordCount_button_Click(object sender, EventArgs e, string customersDataTable)
        {
            this.customersTableAdapter1.FillBy(this.northwindDataSet1.Customers);
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = customersDataTable;
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select count(*) from customers";

            int count = (int)command.ExecuteScalar();
            recordCount_button.Text = count.ToString();
        }

        
    }
}


