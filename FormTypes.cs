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

namespace Shop
{
    public partial class FormTypes : Form
    {
        DataSet data;
        SqlDataAdapter adap;
        SqlCommandBuilder command;
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=Shop; Integrated Security=True";
        string sql = "SELECT * FROM Types_";
        public FormTypes()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adap = new SqlDataAdapter(sql, connection);

                data = new DataSet();
                adap.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            DataRow row = data.Tables[0].NewRow();
            data.Tables[0].Rows.Add(row);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adap = new SqlDataAdapter(sql, connection);
                command = new SqlCommandBuilder(adap);
                adap.InsertCommand = new SqlCommand("ADD_Types_", connection);
                adap.InsertCommand.CommandType = CommandType.StoredProcedure;
                adap.InsertCommand.Parameters.Add(new SqlParameter("@Name_type", SqlDbType.VarChar, 20, "Name_type"));

                adap.Update(data);
            }
        }
    }
}
