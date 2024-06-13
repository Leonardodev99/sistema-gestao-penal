using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
{
    public partial class frm_process : Form
    {
        public frm_process()
        {
            InitializeComponent();
        }

        private async void frm_process_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000);
            frm_login frm = new frm_login();

            frm.StartPosition = FormStartPosition.CenterParent;
            
            frm.Show();


            this.Hide();
            

        }
        private void CentralizarImagem()
        {
            // Carregar a imagem
            Image imagem = Image.FromFile("C:\\Users\\DELL\\Downloads.jpg");

            // Calcular as coordenadas para centralizar a imagem
            int x = (pictureBox1.Width - imagem.Width) / 2;
            int y = (pictureBox1.Height - imagem.Height) / 2;

            // Definir a posição da imagem dentro do PictureBox
            pictureBox1.Location = new Point(x, y);

            // Definir a imagem no PictureBox
            pictureBox1.Image = imagem;
        }
    }
}
