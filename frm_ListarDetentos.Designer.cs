namespace system
{
    partial class frm_ListarDetentos
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
            this.db_presystemDataSet1 = new system.db_presystemDataSet();
            this.dataGridViewDetentos = new System.Windows.Forms.DataGridView();
            this.iddetentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacrimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorpolicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentencapenalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasentencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juizresponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasolturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_presystemDataSet3 = new system.db_presystemDataSet3();
            this.detentosTableAdapter = new system.db_presystemDataSet3TableAdapters.detentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(413, 59);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(965, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // db_presystemDataSet1
            // 
            this.db_presystemDataSet1.DataSetName = "db_presystemDataSet";
            this.db_presystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewDetentos
            // 
            this.dataGridViewDetentos.AutoGenerateColumns = false;
            this.dataGridViewDetentos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDetentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetentoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.biDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.crimeDataGridViewTextBoxColumn,
            this.datacrimeDataGridViewTextBoxColumn,
            this.setorpolicialDataGridViewTextBoxColumn,
            this.sentencapenalDataGridViewTextBoxColumn,
            this.datasentencaDataGridViewTextBoxColumn,
            this.juizresponsavelDataGridViewTextBoxColumn,
            this.datasolturaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.idcelaDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.celaDataGridViewTextBoxColumn});
            this.dataGridViewDetentos.DataSource = this.detentosBindingSource;
            this.dataGridViewDetentos.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewDetentos.Name = "dataGridViewDetentos";
            this.dataGridViewDetentos.Size = new System.Drawing.Size(1350, 150);
            this.dataGridViewDetentos.TabIndex = 2;
            // 
            // iddetentoDataGridViewTextBoxColumn
            // 
            this.iddetentoDataGridViewTextBoxColumn.DataPropertyName = "id_detento";
            this.iddetentoDataGridViewTextBoxColumn.HeaderText = "Numero de processo";
            this.iddetentoDataGridViewTextBoxColumn.Name = "iddetentoDataGridViewTextBoxColumn";
            this.iddetentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Gênero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // biDataGridViewTextBoxColumn
            // 
            this.biDataGridViewTextBoxColumn.DataPropertyName = "bi";
            this.biDataGridViewTextBoxColumn.HeaderText = "Bilhete de Identidade";
            this.biDataGridViewTextBoxColumn.Name = "biDataGridViewTextBoxColumn";
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Enderenço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // crimeDataGridViewTextBoxColumn
            // 
            this.crimeDataGridViewTextBoxColumn.DataPropertyName = "crime";
            this.crimeDataGridViewTextBoxColumn.HeaderText = "Crime";
            this.crimeDataGridViewTextBoxColumn.Name = "crimeDataGridViewTextBoxColumn";
            // 
            // datacrimeDataGridViewTextBoxColumn
            // 
            this.datacrimeDataGridViewTextBoxColumn.DataPropertyName = "data_crime";
            this.datacrimeDataGridViewTextBoxColumn.HeaderText = "Data do crime";
            this.datacrimeDataGridViewTextBoxColumn.Name = "datacrimeDataGridViewTextBoxColumn";
            // 
            // setorpolicialDataGridViewTextBoxColumn
            // 
            this.setorpolicialDataGridViewTextBoxColumn.DataPropertyName = "setor_policial";
            this.setorpolicialDataGridViewTextBoxColumn.HeaderText = "Setor policial";
            this.setorpolicialDataGridViewTextBoxColumn.Name = "setorpolicialDataGridViewTextBoxColumn";
            // 
            // sentencapenalDataGridViewTextBoxColumn
            // 
            this.sentencapenalDataGridViewTextBoxColumn.DataPropertyName = "sentenca_penal";
            this.sentencapenalDataGridViewTextBoxColumn.HeaderText = "Sentença penal";
            this.sentencapenalDataGridViewTextBoxColumn.Name = "sentencapenalDataGridViewTextBoxColumn";
            // 
            // datasentencaDataGridViewTextBoxColumn
            // 
            this.datasentencaDataGridViewTextBoxColumn.DataPropertyName = "data_sentenca";
            this.datasentencaDataGridViewTextBoxColumn.HeaderText = "Data sentença";
            this.datasentencaDataGridViewTextBoxColumn.Name = "datasentencaDataGridViewTextBoxColumn";
            // 
            // juizresponsavelDataGridViewTextBoxColumn
            // 
            this.juizresponsavelDataGridViewTextBoxColumn.DataPropertyName = "juiz_responsavel";
            this.juizresponsavelDataGridViewTextBoxColumn.HeaderText = "juíz responsável";
            this.juizresponsavelDataGridViewTextBoxColumn.Name = "juizresponsavelDataGridViewTextBoxColumn";
            // 
            // datasolturaDataGridViewTextBoxColumn
            // 
            this.datasolturaDataGridViewTextBoxColumn.DataPropertyName = "data_soltura";
            this.datasolturaDataGridViewTextBoxColumn.HeaderText = "Data de soltura";
            this.datasolturaDataGridViewTextBoxColumn.Name = "datasolturaDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // idcelaDataGridViewTextBoxColumn
            // 
            this.idcelaDataGridViewTextBoxColumn.DataPropertyName = "id_cela";
            this.idcelaDataGridViewTextBoxColumn.HeaderText = "Número da cela";
            this.idcelaDataGridViewTextBoxColumn.Name = "idcelaDataGridViewTextBoxColumn";
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "Códico do curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            // 
            // celaDataGridViewTextBoxColumn
            // 
            this.celaDataGridViewTextBoxColumn.DataPropertyName = "cela";
            this.celaDataGridViewTextBoxColumn.HeaderText = "Nome da cela";
            this.celaDataGridViewTextBoxColumn.Name = "celaDataGridViewTextBoxColumn";
            // 
            // detentosBindingSource
            // 
            this.detentosBindingSource.DataMember = "detentos";
            this.detentosBindingSource.DataSource = this.db_presystemDataSet3;
            // 
            // db_presystemDataSet3
            // 
            this.db_presystemDataSet3.DataSetName = "db_presystemDataSet3";
            this.db_presystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detentosTableAdapter
            // 
            this.detentosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ListarDetentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1364, 286);
            this.Controls.Add(this.dataGridViewDetentos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "frm_ListarDetentos";
            this.Text = "Consulta de Detentos";
            this.Load += new System.EventHandler(this.frm_ListarDetentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button2;
        private db_presystemDataSet db_presystemDataSet1;
        private System.Windows.Forms.DataGridView dataGridViewDetentos;
        private db_presystemDataSet3 db_presystemDataSet3;
        private System.Windows.Forms.BindingSource detentosBindingSource;
        private db_presystemDataSet3TableAdapters.detentosTableAdapter detentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacrimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorpolicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentencapenalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasentencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juizresponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasolturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celaDataGridViewTextBoxColumn;
    }
}