using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace system
{
    public partial class frm_login : Form
    {
        // Referência da conexão
        SqlConnection connection = new SqlConnection(@"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True");

        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!ValidarTodosCampos())
            {
                return;
            }

            try
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM usuarios WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = textUsername.Text.Trim();
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = textPassword.Text.Trim();

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        frm_main frm = new frm_main();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nome do usuário ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro de SQL: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private bool ValidarTodosCampos()
        {
            return ValidarCampoTexto(textUsername, "Nome do Usuário") &&
                   ValidarCampoTexto(textPassword, "Senha");
        }

        private bool ValidarCampoTexto(TextBox textBox, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"O campo {nomeCampo} é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
