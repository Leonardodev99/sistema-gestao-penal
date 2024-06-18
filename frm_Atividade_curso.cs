using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system.Model;
using System.Data.SqlClient;

namespace system
{
    public partial class frm_Atividade_curso : Form
    {
        private string connectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";
        public frm_Atividade_curso()
        {
            InitializeComponent();
        }

        private void frm_Atividade_curso_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_main frm = new frm_main();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos
            {
                Nome = textNome.Text,
                InstituicaoResponsavel = textInstituicaoResponsavel.Text,
                Local = textLocal.Text,
                Duracao = textDuracao.Text,
                DataInicio = dateTimePickerDataInicio.Value,
                DataTermino = dateTimePickerDataTermino.Value,
                Horario = textHorario.Text,
                Descricacao = textDescricacao.Text
            };

            if (CadastrarCurso(curso))
            {
                MessageBox.Show("Curso cadastrado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar curso.");
            }
            //MessageBox.Show("Cadastro feito com sucesso");
        }
        private bool CadastrarCurso(Cursos curso)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO cursos (nome, instituicao_responsavel, local, duracao, data_inicio, data_termino, horario, descricacao) 
                                     VALUES (@Nome, @InstituicaoResponsavel, @Local, @Duracao, @DataInicio, @DataTermino, @Horario, @Descricacao)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", curso.Nome);
                        command.Parameters.AddWithValue("@InstituicaoResponsavel", curso.InstituicaoResponsavel);
                        command.Parameters.AddWithValue("@Local", curso.Local);
                        command.Parameters.AddWithValue("@Duracao", curso.Duracao);
                        command.Parameters.AddWithValue("@DataInicio", curso.DataInicio);
                        command.Parameters.AddWithValue("@DataTermino", curso.DataTermino);
                        command.Parameters.AddWithValue("@Horario", curso.Horario);
                        command.Parameters.AddWithValue("@Descricacao", curso.Descricacao);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar curso: " + ex.Message);
                return false;
            }
        }

        private void LimparCampos()
        {
            // Limpar campos do formulário após o cadastro
            textNome.Text = "";
            textInstituicaoResponsavel.Text = "";
            textLocal.Text = "";
            textDuracao.Text = "";
            dateTimePickerDataInicio.Value = DateTime.Now;
            dateTimePickerDataTermino.Value = DateTime.Now;
            textHorario.Text = "";
            textDescricacao.Text = "";
        }
    }
}
