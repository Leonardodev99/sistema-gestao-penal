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
    public partial class frm_visita_agenda : Form
    {
        private string conectionString = @"Data Source=PC\LEO;Initial Catalog=db_presystem;Integrated Security=True";
        public frm_visita_agenda()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
            Visitas visita = new Visitas
            {
                Nome = textNome.Text,
                BI = textBI.Text,
                DataNascimento = dateTimePickerDataNascimento.Value,
                Endereco = textEndereco.Text,
                Motivo = textMotivo.Text,
                DataVisita = dateTimePickerDataVisita.Value,

            };

            if (AgendarVisita(visita))
            {
                MessageBox.Show("Agendamento feito com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao agendar visita");
            }
        }

        private bool AgendarVisita(Visitas visita)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(conectionString))
                {
                    conection.Open();
                    string query = @"INSERT INTO visitas (nome, bi, data_nascimento, endereco, motivo, data_visita)
                                     VALUES (@Nome, @BI, @DataNascimento, @Endereco, @Motivo, @DataVisita)";
                    using (SqlCommand command = new SqlCommand(query, conection))
                    {
                        command.Parameters.AddWithValue("@Nome", visita.Nome);
                        command.Parameters.AddWithValue("@BI", visita.BI);
                        command.Parameters.AddWithValue("@DataNascimento", visita.DataNascimento);
                        command.Parameters.AddWithValue("@Endereco", visita.Endereco);
                        command.Parameters.AddWithValue("@Motivo", visita.Motivo);
                        command.Parameters.AddWithValue("@DataVisita", visita.DataVisita);

                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao agendar visita" + ex);
                return false;
            }

        }

        private void LimparCampo()
        {
            textNome.Text = "";
            textBI.Text = "";
            dateTimePickerDataNascimento.Value = DateTime.Now;
            textEndereco.Text = "";
            textMotivo.Text = "";
            dateTimePickerDataVisita.Value = DateTime.Now;

        }

    }
}
