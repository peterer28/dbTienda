using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;

namespace prBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ventana_login = new login();
            ventana_login.Show();

            var ventana_gerencia = new Gerencia();
            ventana_gerencia.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=COCO;Initial Catalog=dbTienda;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            try
            {
                conn.Open();
                MessageBox.Show("USTED SE HA CONECTADO");
            }
            catch (Exception err)
            {
                MessageBox.Show(":v");
            }

            if (conn.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("insertarCredenciales", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", "juanito");
                cmd.Parameters.AddWithValue("@pass", "1234");

                DataSet ds = new DataSet("tabla");
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd2 = new SqlCommand("sp_ver_credenciales", conn);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@usr", "juanito");
                da.SelectCommand = cmd2;
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Usuario creado");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}