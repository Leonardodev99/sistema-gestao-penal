using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using system.Model; // Verifique se esse namespace está correto e não entra em conflito com 'System'

namespace system // Considere renomear este namespace para algo mais específico
{
    public partial class frm_cela : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";

        public frm_cela()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarTodosCampos())
            {
                return;
            }

            Cela cela = new Cela
            {
                Nome = textNome.Text,
                Capacidade = Convert.ToInt32(textCapacidade.Text)
            };

            if (CadastrarCela(cela))
            {
                MessageBox.Show("Cela cadastrada com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar cela.");
            }
        }

        private bool ValidarTodosCampos()
        {
            return ValidarCampoTexto(textNome, "Nome") &&
                   ValidarCampoNumerico(textCapacidade, "Capacidade");
        }

        private bool ValidarCampoTexto(TextBox textBox, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"O campo {nomeCampo} é obrigatório.");
                return false;
            }
            return true;
        }

        private bool ValidarCampoNumerico(TextBox textBox, string nomeCampo)
        {
            int numero;
            if (!int.TryParse(textBox.Text, out numero) || numero <= 0)
            {
                MessageBox.Show($"O campo {nomeCampo} deve ser um número positivo válido.");
                return false;
            }
            return true;
        }

        private bool CadastrarCela(Cela cela)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO celas (nome, capacidade) 
                                     VALUES (@Nome, @Capacidade)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", cela.Nome);
                        command.Parameters.AddWithValue("@Capacidade", cela.Capacidade);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cela: " + ex.Message);
                return false;
            }
        }

        private void LimparCampos()
        {
            // Limpar campos do formulário após o cadastro
            textNome.Text = "";
            textCapacidade.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }
    }
}


