using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system
{
    public partial class frm_ListarVisitas : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";

        public frm_ListarVisitas()
        {
            InitializeComponent();
        }

        private void frm_ListarVisitas_Load(object sender, EventArgs e)
        {
            CarregarVisitas();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarVisitas();
        }

        private void CarregarVisitas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id_visita, nome, bi, data_nascimento, endereco, motivo, data_visita FROM visitas";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewVisitas.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar visitas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_ListarVisitas_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_presystemDataSet1.visitas' table. You can move, or remove it, as needed.
            this.visitasTableAdapter.Fill(this.db_presystemDataSet1.visitas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }
    }
}
