using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace prBD
{
    public partial class Gerencia : Form
    {
        private DataTable dataTable;
        private SqlConnection connection;
        private DataTable puestoDataTable;
        private DataTable nivelDataTable;
        public Gerencia()
        {
            InitializeComponent();

            comboBox1.DisplayMember = "nombrePuesto";
            comboBox1.ValueMember = "idPuesto";
        }

        private void refresh_gridview()
        {
            dataTable = new DataTable();

            // Retrieve data from the database and fill the DataTable
            string connectionString = "Data Source=COCO;Initial Catalog=dbTienda;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False";
            string query = "SELECT * FROM vwEmpleadoDetails";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            // Set the DataTable as the data source for your DataGridView or any other control
            dataGridView1.DataSource = dataTable;
        }

        private void refresh_gridview2()
        {
            dataTable = new DataTable();

            // Retrieve data from the database and fill the DataTable
            string connectionString = "Data Source=COCO;Initial Catalog=dbTienda;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False";
            string query = "SELECT * FROM vwPuestos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            // Set the DataTable as the data source for your DataGridView or any other control
            dataGridView2.DataSource = dataTable;
        }

        private void refresh_combobox()
        {
            string connectionString = "Data Source=COCO;Initial Catalog=dbTienda;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Retrieve data from the tbPuesto table
                String query = "SELECT idPuesto, nombrePuesto FROM tbPuesto";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                puestoDataTable = new DataTable();

                // Fill the DataTable with the data from the table
                adapter.Fill(puestoDataTable);
            }

            // Set the DataSource of the ComboBox to the DataTable
            comboBox1.DataSource = puestoDataTable;
        }

        private void refresh_combobox2()
        {
            string connectionString = "Data Source=COCO;Initial Catalog=dbTienda;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Retrieve data from the tbNiveles table
                String query = "SELECT idNiveles, nombreNivel FROM tbNiveles";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                nivelDataTable = new DataTable();

                // Fill the DataTable with the data from the table
                adapter.Fill(nivelDataTable);
            }

            // Set the DataSource of the ComboBox to the DataTable
            comboBox2.DataSource = nivelDataTable;
            comboBox2.DisplayMember = "nombreNivel";
            comboBox2.ValueMember = "idNiveles";
        }
        private void Gerencia_Load(object sender, EventArgs e)
        {
            refresh_gridview();
            refresh_gridview2();
            refresh_combobox();
            refresh_combobox2();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrarUsuario_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=COCO;Initial Catalog=dbTienda;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("dbTienda.dbo.registerEmployee", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the parameters
                    command.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    command.Parameters.AddWithValue("@idID", txt_id.Text);
                    command.Parameters.AddWithValue("@idPuesto", (int)comboBox1.SelectedValue);
                    command.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                    command.Parameters.AddWithValue("@pass", txt_password.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Employee registered successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            refresh_gridview();
        }

        private void btn_registrarPuesto_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=COCO;Initial Catalog=dbTienda;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("dbTienda.dbo.insertarPuesto", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the parameters
                    command.Parameters.AddWithValue("@nombrePuesto", txt_nPuesto.Text);
                    command.Parameters.AddWithValue("@nivel", (int)comboBox2.SelectedValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Puesto registered successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            refresh_gridview2();
        }
    }
}
