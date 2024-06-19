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

namespace system
{
    public partial class frm_ListarCelas : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";
        public frm_ListarCelas()
        {
            InitializeComponent();
        }

        private void frm_ListarCelas_Load(object sender, EventArgs e)
        {
            CarregarCelas();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarCelas();
        }

        private void CarregarCelas()
        {
            try {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM celas";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewCelas.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar celas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_ListarCelas_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_presystemDataSet4.celas' table. You can move, or remove it, as needed.
            this.celasTableAdapter.Fill(this.db_presystemDataSet4.celas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }
    }
}
