using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using system.Model;

namespace system
{
    public partial class frm_Detentos : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";

        public frm_Detentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarTodosCampos())
            {
                return;
            }

            Detentos detento = new Detentos
            {
                Nome = textNome.Text,
                Genero = cmbGenero.SelectedItem.ToString(),
                BI = textBI.Text,
                DataNascimento = dtpDataNascimento.Value,
                Endereco = textEndereco.Text,
                Crime = textCrime.Text,
                DataCrime = dtpDataCrime.Value,
                SetorPolicial = textSetorPolicial.Text,
                SentencaPenal = textSentencaPenal.Text,
                DataSentenca = dtpDataSentenca.Value,
                JuizResponsavel = textJuizResponsavel.Text,
                DataSoltura = dtpDataSoltura.Value,
                Descricao = textDescricao.Text,
                IdCela = Convert.ToInt32(textIdCela.Text),
                IdCurso = Convert.ToInt32(textIdCurso.Text),
                Cela = textCela.Text
            };

            if (CadastrarDetento(detento))
            {
                MessageBox.Show("Detento cadastrado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar detento.");
            }
        }

        private bool ValidarTodosCampos()
        {
            return ValidarCampoTexto(textNome, "Nome") &&
                  // ValidarComboBox(cmbGenero, "Gênero") &&
                   ValidarCampoTexto(textBI, "BI") &&
                   ValidarCampoNumerico(textIdCela, "ID Cela") &&
                   ValidarCampoNumerico(textIdCurso, "ID Curso") &&
                   ValidarIdade(dtpDataNascimento) &&
                   ValidarCampoTexto(textEndereco, "Endereço") &&
                   ValidarCampoTexto(textCrime, "Crime") &&
                   ValidarCampoTexto(textSetorPolicial, "Setor Policial") &&
                   ValidarCampoTexto(textSentencaPenal, "Sentença Penal") &&
                   ValidarCampoTexto(textJuizResponsavel, "Juiz Responsável") &&
                   ValidarCampoTexto(textDescricao, "Descrição") &&
                   ValidarCampoTexto(textCela, "Cela") &&
                   ValidarDataSoltura(dtpDataSentenca, dtpDataSoltura);
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

        private bool ValidarComboBox(ComboBox comboBox, string nomeCampo)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"O campo {nomeCampo} é obrigatório.");
                return false;
            }
            return true;
        }

        private bool ValidarCampoNumerico(TextBox textBox, string nomeCampo)
        {
            int numero;
            if (!int.TryParse(textBox.Text, out numero))
            {
                MessageBox.Show($"O campo {nomeCampo} deve ser um número válido.");
                return false;
            }
            return true;
        }

        private bool ValidarIdade(DateTimePicker datePicker)
        {
            int idade = DateTime.Today.Year - datePicker.Value.Year;
            if (datePicker.Value.Date > DateTime.Today.AddYears(-idade)) idade--;
            if (idade < 18)
            {
                MessageBox.Show("O detento deve ser maior de idade (18+ anos).");
                return false;
            }
            return true;
        }

        private bool ValidarDataSoltura(DateTimePicker dataSentenca, DateTimePicker dataSoltura)
        {
            if (dataSoltura.Value <= dataSentenca.Value)
            {
                MessageBox.Show("A data de soltura deve ser maior que a data da sentença.");
                return false;
            }
            return true;
        }

        private bool CadastrarDetento(Detentos detento)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO detentos (nome, genero, bi, data_nascimento, endereco, crime, data_crime, 
                                setor_policial, sentenca_penal, data_sentenca, juiz_responsavel, data_soltura, descricao, 
                                id_cela, id_curso, cela) 
                                VALUES (@Nome, @Genero, @BI, @DataNascimento, @Endereco, @Crime, @DataCrime, 
                                        @SetorPolicial, @SentencaPenal, @DataSentenca, @JuizResponsavel, @DataSoltura, @Descricao, 
                                        @IdCela, @IdCurso, @Cela)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", detento.Nome);
                        command.Parameters.AddWithValue("@Genero", detento.Genero);
                        command.Parameters.AddWithValue("@BI", detento.BI);
                        command.Parameters.AddWithValue("@DataNascimento", detento.DataNascimento);
                        command.Parameters.AddWithValue("@Endereco", detento.Endereco);
                        command.Parameters.AddWithValue("@Crime", detento.Crime);
                        command.Parameters.AddWithValue("@DataCrime", detento.DataCrime);
                        command.Parameters.AddWithValue("@SetorPolicial", detento.SetorPolicial);
                        command.Parameters.AddWithValue("@SentencaPenal", detento.SentencaPenal);
                        command.Parameters.AddWithValue("@DataSentenca", detento.DataSentenca);
                        command.Parameters.AddWithValue("@JuizResponsavel", detento.JuizResponsavel);
                        command.Parameters.AddWithValue("@DataSoltura", detento.DataSoltura);
                        command.Parameters.AddWithValue("@Descricao", detento.Descricao);
                        command.Parameters.AddWithValue("@IdCela", detento.IdCela);
                        command.Parameters.AddWithValue("@IdCurso", detento.IdCurso);
                        command.Parameters.AddWithValue("@Cela", detento.Cela);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar detento: " + ex.Message);
                return false;
            }
        }

        private void LimparCampos()
        {
            // Limpar campos do formulário após o cadastro
            textNome.Text = "";
            cmbGenero.SelectedIndex = -1;
            textBI.Text = "";
            dtpDataNascimento.Value = DateTime.Today;
            textEndereco.Text = "";
            textCrime.Text = "";
            dtpDataCrime.Value = DateTime.Today;
            textSetorPolicial.Text = "";
            textSentencaPenal.Text = "";
            dtpDataSentenca.Value = DateTime.Today;
            textJuizResponsavel.Text = "";
            dtpDataSoltura.Value = DateTime.Today;
            textDescricao.Text = "";
            textIdCela.Text = "";
            textIdCurso.Text = "";
            textCela.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }
    }
}


