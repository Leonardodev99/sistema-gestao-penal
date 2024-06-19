using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system
{
    public partial class frm_ListarAtividades : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";
        public frm_ListarAtividades()
        {
            InitializeComponent();
        }

        private void frm_ListarAtividades_Load(object sender, EventArgs e)
        {
            CarregarAtividades();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarAtividades();
        }

        private void CarregarAtividades()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id_atividade, nome_agente, nip_agente, data_hora_registro, data_atividade, hora_inicio, hora_termino, tipo_atividade, descricao FROM atividades";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewAtividades.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar atividades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }

        private void frm_ListarAtividades_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_presystemDataSet2.atividades' table. You can move, or remove it, as needed.
            this.atividadesTableAdapter.Fill(this.db_presystemDataSet2.atividades);

        }
    }
}
