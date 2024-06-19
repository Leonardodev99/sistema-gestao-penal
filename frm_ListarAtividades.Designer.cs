namespace system
{
    partial class frm_ListarAtividades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewAtividades = new System.Windows.Forms.DataGridView();
            this.idatividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeagenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nipagenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datahoraregistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataatividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaterminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoatividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_presystemDataSet2 = new system.db_presystemDataSet2();
            this.atividadesTableAdapter = new system.db_presystemDataSet2TableAdapters.atividadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(213, 47);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewAtividades
            // 
            this.dataGridViewAtividades.AutoGenerateColumns = false;
            this.dataGridViewAtividades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idatividadeDataGridViewTextBoxColumn,
            this.nomeagenteDataGridViewTextBoxColumn,
            this.nipagenteDataGridViewTextBoxColumn,
            this.datahoraregistroDataGridViewTextBoxColumn,
            this.dataatividadeDataGridViewTextBoxColumn,
            this.horainicioDataGridViewTextBoxColumn,
            this.horaterminoDataGridViewTextBoxColumn,
            this.tipoatividadeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridViewAtividades.DataSource = this.atividadesBindingSource;
            this.dataGridViewAtividades.Location = new System.Drawing.Point(12, 88);
            this.dataGridViewAtividades.Name = "dataGridViewAtividades";
            this.dataGridViewAtividades.Size = new System.Drawing.Size(944, 150);
            this.dataGridViewAtividades.TabIndex = 2;
            // 
            // idatividadeDataGridViewTextBoxColumn
            // 
            this.idatividadeDataGridViewTextBoxColumn.DataPropertyName = "id_atividade";
            this.idatividadeDataGridViewTextBoxColumn.HeaderText = "ID da Atividade";
            this.idatividadeDataGridViewTextBoxColumn.Name = "idatividadeDataGridViewTextBoxColumn";
            this.idatividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeagenteDataGridViewTextBoxColumn
            // 
            this.nomeagenteDataGridViewTextBoxColumn.DataPropertyName = "nome_agente";
            this.nomeagenteDataGridViewTextBoxColumn.HeaderText = "Nome do agente";
            this.nomeagenteDataGridViewTextBoxColumn.Name = "nomeagenteDataGridViewTextBoxColumn";
            // 
            // nipagenteDataGridViewTextBoxColumn
            // 
            this.nipagenteDataGridViewTextBoxColumn.DataPropertyName = "nip_agente";
            this.nipagenteDataGridViewTextBoxColumn.HeaderText = "NIP do Agente";
            this.nipagenteDataGridViewTextBoxColumn.Name = "nipagenteDataGridViewTextBoxColumn";
            // 
            // datahoraregistroDataGridViewTextBoxColumn
            // 
            this.datahoraregistroDataGridViewTextBoxColumn.DataPropertyName = "data_hora_registro";
            this.datahoraregistroDataGridViewTextBoxColumn.HeaderText = "Data e Hora do registro";
            this.datahoraregistroDataGridViewTextBoxColumn.Name = "datahoraregistroDataGridViewTextBoxColumn";
            // 
            // dataatividadeDataGridViewTextBoxColumn
            // 
            this.dataatividadeDataGridViewTextBoxColumn.DataPropertyName = "data_atividade";
            this.dataatividadeDataGridViewTextBoxColumn.HeaderText = "Data da atividade";
            this.dataatividadeDataGridViewTextBoxColumn.Name = "dataatividadeDataGridViewTextBoxColumn";
            // 
            // horainicioDataGridViewTextBoxColumn
            // 
            this.horainicioDataGridViewTextBoxColumn.DataPropertyName = "hora_inicio";
            this.horainicioDataGridViewTextBoxColumn.HeaderText = "Hora de inicio";
            this.horainicioDataGridViewTextBoxColumn.Name = "horainicioDataGridViewTextBoxColumn";
            // 
            // horaterminoDataGridViewTextBoxColumn
            // 
            this.horaterminoDataGridViewTextBoxColumn.DataPropertyName = "hora_termino";
            this.horaterminoDataGridViewTextBoxColumn.HeaderText = "Hora de término";
            this.horaterminoDataGridViewTextBoxColumn.Name = "horaterminoDataGridViewTextBoxColumn";
            // 
            // tipoatividadeDataGridViewTextBoxColumn
            // 
            this.tipoatividadeDataGridViewTextBoxColumn.DataPropertyName = "tipo_atividade";
            this.tipoatividadeDataGridViewTextBoxColumn.HeaderText = "Tipo da atividade";
            this.tipoatividadeDataGridViewTextBoxColumn.Name = "tipoatividadeDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // atividadesBindingSource
            // 
            this.atividadesBindingSource.DataMember = "atividades";
            this.atividadesBindingSource.DataSource = this.db_presystemDataSet2;
            // 
            // db_presystemDataSet2
            // 
            this.db_presystemDataSet2.DataSetName = "db_presystemDataSet2";
            this.db_presystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atividadesTableAdapter
            // 
            this.atividadesTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ListarAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(963, 261);
            this.Controls.Add(this.dataGridViewAtividades);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAtualizar);
            this.MaximizeBox = false;
            this.Name = "frm_ListarAtividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conulta de Atividades";
            this.Load += new System.EventHandler(this.frm_ListarAtividades_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewAtividades;
        private db_presystemDataSet2 db_presystemDataSet2;
        private System.Windows.Forms.BindingSource atividadesBindingSource;
        private db_presystemDataSet2TableAdapters.atividadesTableAdapter atividadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idatividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeagenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nipagenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datahoraregistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataatividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaterminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoatividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}