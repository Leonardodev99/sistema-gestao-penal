using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system
{
    public partial class frm_ListarDetentos : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";
        public frm_ListarDetentos()
        {
            InitializeComponent();
        }

        private void frm_ListarCursos_Load(object sender, EventArgs e)
        {
            CarregarDetentos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDetentos();
        }

        private void CarregarDetentos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id_detento, nome, genero, bi, data_nascimento, endereco, crime, data_crime, setor_policial, sentenca_penal, data_sentenca, juiz_responsavel, data_soltura, descricao, id_cela, id_curso, cela FROM detentos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewDetentos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cursos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }

        private void frm_ListarDetentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_presystemDataSet3.detentos' table. You can move, or remove it, as needed.
            this.detentosTableAdapter.Fill(this.db_presystemDataSet3.detentos);

        }
    }
}
