﻿using System;
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
            frm_Detento_Cadastro frm = new frm_Detento_Cadastro();
            frm.Show();
            this.Close();
        }

        private void aGENDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           frm_visita_agenda frm = new frm_visita_agenda();
            frm.Show();
            this.Close();
        }

        private void rEGISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Atividades_laboral frm = new frm_Atividades_laboral();
            frm.Show();
            this.Close();
        }

        private void rEGISTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Atividade_desporto frm = new frm_Atividade_desporto();
            frm.Show();
            this.Close();
        }

        private void mATRICULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Atividade_curso frm = new frm_Atividade_curso();
            frm.Show();
            this.Close();
        }

        private void dETENTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Pena_registrar frm = new frm_Pena_registrar();
            frm.Show();
            this.Close();
        }

        private void oCORRÊNCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gERISTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cela_registro frm = new frm_cela_registro();
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
    }
}