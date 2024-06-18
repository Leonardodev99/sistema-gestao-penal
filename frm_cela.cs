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

