using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using system.Model;

namespace system
{
    public partial class frm_Atividades : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";

        public frm_Atividades()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_main fr = new frm_main();
            fr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarTodosCampos())
            {
                return;
            }

            Atividades atividade = new Atividades
            {
                NomeAgente = textNomeAgente.Text,
                NipAgente = textNipAgente.Text,
                DataHoraRegistro = DateTime.Now, // Registro automático no momento do cadastro
                DataAtividade = dateTimePickerDataAtividade.Value,
                HoraInicio = TimeSpan.Parse(textHoraInicio.Text),
                HoraTermino = TimeSpan.Parse(textHoraTermino.Text),
                TipoAtividade = textTipoAtividade.Text,
                Descricao = textDescricao.Text
            };

            if (CadastrarAtividade(atividade))
            {
                MessageBox.Show("Atividade cadastrada com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar atividade.");
            }
        }

        private bool ValidarTodosCampos()
        {
            return ValidarCampoTexto(textNomeAgente, "Nome do Agente") &&
                   ValidarCampoTexto(textNipAgente, "NIP do Agente") &&
                   ValidarHora(textHoraInicio, "Hora de Início") &&
                   ValidarHora(textHoraTermino, "Hora de Término") &&
                   ValidarHorario(textHoraInicio, textHoraTermino) &&
                   ValidarCampoTexto(textTipoAtividade, "Tipo de Atividade") &&
                   ValidarCampoTexto(textDescricao, "Descrição");
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

        private bool ValidarHora(TextBox textBox, string nomeCampo)
        {
            TimeSpan hora;
            if (!TimeSpan.TryParse(textBox.Text, out hora))
            {
                MessageBox.Show($"O campo {nomeCampo} deve ser um horário válido (HH:MM).");
                return false;
            }
            return true;
        }

        private bool ValidarHorario(TextBox textHoraInicio, TextBox textHoraTermino)
        {
            TimeSpan horaInicio, horaTermino;
            if (TimeSpan.TryParse(textHoraInicio.Text, out horaInicio) &&
                TimeSpan.TryParse(textHoraTermino.Text, out horaTermino))
            {
                if (horaInicio >= horaTermino)
                {
                    MessageBox.Show("A Hora de Término deve ser maior que a Hora de Início.");
                    return false;
                }
            }
            return true;
        }

        private bool CadastrarAtividade(Atividades atividade)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO atividades (nome_agente, nip_agente, data_hora_registro, data_atividade, hora_inicio, hora_termino, tipo_atividade, descricao) 
                                     VALUES (@NomeAgente, @NipAgente, @DataHoraRegistro, @DataAtividade, @HoraInicio, @HoraTermino, @TipoAtividade, @Descricao)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NomeAgente", atividade.NomeAgente);
                        command.Parameters.AddWithValue("@NipAgente", atividade.NipAgente);
                        command.Parameters.AddWithValue("@DataHoraRegistro", atividade.DataHoraRegistro);
                        command.Parameters.AddWithValue("@DataAtividade", atividade.DataAtividade);
                        command.Parameters.AddWithValue("@HoraInicio", atividade.HoraInicio);
                        command.Parameters.AddWithValue("@HoraTermino", atividade.HoraTermino);
                        command.Parameters.AddWithValue("@TipoAtividade", atividade.TipoAtividade);
                        command.Parameters.AddWithValue("@Descricao", atividade.Descricao);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar atividade: " + ex.Message);
                return false;
            }
        }

        private void LimparCampos()
        {
            // Limpar campos do formulário após o cadastro
            textNomeAgente.Text = "";
            textNipAgente.Text = "";
            dateTimePickerDataAtividade.Value = DateTime.Now;
            textHoraInicio.Text = "";
            textHoraTermino.Text = "";
            textTipoAtividade.Text = "";
            textDescricao.Text = "";
        }
    }
}
