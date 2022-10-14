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
    public partial class FormClothing : Form
    {
        DataSet data;
        SqlDataAdapter adap;
        SqlCommandBuilder command;
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=Shop; Integrated Security=True";
        string sql = "SELECT * FROM Clothing";


        public FormClothing()
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
                adap.InsertCommand = new SqlCommand("ADD_Clothing", connection);
                adap.InsertCommand.CommandType = CommandType.StoredProcedure;
                adap.InsertCommand.Parameters.Add(new SqlParameter("@Name_clothing", SqlDbType.NVarChar, 50, "Name_clothing"));
                adap.InsertCommand.Parameters.Add(new SqlParameter("@id_type", SqlDbType.Int, 0, "id_type"));
                adap.InsertCommand.Parameters.Add(new SqlParameter("@id_sex", SqlDbType.Int, 0, "id_sex"));
                adap.InsertCommand.Parameters.Add(new SqlParameter("@id_season", SqlDbType.Int, 0, "id_season"));
                adap.InsertCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Money, 0, "Price"));

                adap.Update(data);
            }
        }
    }  
}
