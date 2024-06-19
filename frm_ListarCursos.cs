using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system
{
    public partial class frm_ListarCursos : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";

        public frm_ListarCursos()
        {
            InitializeComponent();
        }

        private void frm_ListarCursos_Load(object sender, EventArgs e)
        {
            CarregarCursos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarCursos();
        }

        private void CarregarCursos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id_curso, nome, instituicao_responsavel, local, duracao, data_inicio, data_termino, horario, descricacao FROM cursos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewCursos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cursos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }
    }
}
