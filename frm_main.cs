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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Detentos frm = new frm_Detentos();
            frm.Show();
            this.Close();
        }

        private void aGENDARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm_Visitas fr = new frm_Visitas();
            fr.Show();
            this.Close();
        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Atividades frm = new frm_Atividades();
            frm.Show();
            this.Close();
        }

        private void rEGISTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*frm_Atividade_desporto frm = new frm_Atividade_desporto();
            frm.Show();
            this.Close();*/
        }

        private void mATRICULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Atividade_curso frm = new frm_Atividade_curso();
            frm.Show();
            this.Close();
        }

        private void dETENTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*frm_Pena_registrar frm = new frm_Pena_registrar();
            frm.Show();
            this.Close();*/
        }

        private void oCORRÊNCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gERISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cela frm = new frm_cela();
            frm.Show();
            this.Close();
        }

        private void aTIVIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tRABALHOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gESTÃODEPENASToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                
        }

        private void vISITASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTRARToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void bLOQUIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login frm = new frm_login();
            frm.Show();
            this.Close();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cONSULTARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ListarCursos fr = new frm_ListarCursos();
            fr.Show();
            this.Close();
        }

        private void rEAGENDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ListarVisitas fr = new frm_ListarVisitas();
            fr.Show();
            this.Close();
        }

        private void cONSULTARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_ListarAtividades fr = new frm_ListarAtividades();
            fr.Show();
            this.Close();
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ListarDetentos fr = new frm_ListarDetentos();
            fr.Show();
            this.Close();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ListarCelas fr = new frm_ListarCelas();
            fr.Show();
            this.Close();
        }
    }
}
