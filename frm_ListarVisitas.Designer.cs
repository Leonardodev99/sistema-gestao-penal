namespace system
{
    partial class frm_ListarVisitas
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
            this.dataGridViewVisitas = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.db_presystemDataSet = new system.db_presystemDataSet();
            this.dbpresystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_presystemDataSet1 = new system.db_presystemDataSet1();
            this.visitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitasTableAdapter = new system.db_presystemDataSet1TableAdapters.visitasTableAdapter();
            this.idvisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpresystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVisitas
            // 
            this.dataGridViewVisitas.AutoGenerateColumns = false;
            this.dataGridViewVisitas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvisitaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.biDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.motivoDataGridViewTextBoxColumn,
            this.datavisitaDataGridViewTextBoxColumn});
            this.dataGridViewVisitas.DataSource = this.visitasBindingSource;
            this.dataGridViewVisitas.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewVisitas.Name = "dataGridViewVisitas";
            this.dataGridViewVisitas.Size = new System.Drawing.Size(743, 220);
            this.dataGridViewVisitas.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(231, 31);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // db_presystemDataSet
            // 
            this.db_presystemDataSet.DataSetName = "db_presystemDataSet";
            this.db_presystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbpresystemDataSetBindingSource
            // 
            this.dbpresystemDataSetBindingSource.DataSource = this.db_presystemDataSet;
            this.dbpresystemDataSetBindingSource.Position = 0;
            // 
            // db_presystemDataSet1
            // 
            this.db_presystemDataSet1.DataSetName = "db_presystemDataSet1";
            this.db_presystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitasBindingSource
            // 
            this.visitasBindingSource.DataMember = "visitas";
            this.visitasBindingSource.DataSource = this.db_presystemDataSet1;
            // 
            // visitasTableAdapter
            // 
            this.visitasTableAdapter.ClearBeforeFill = true;
            // 
            // idvisitaDataGridViewTextBoxColumn
            // 
            this.idvisitaDataGridViewTextBoxColumn.DataPropertyName = "id_visita";
            this.idvisitaDataGridViewTextBoxColumn.HeaderText = "ID da Visita";
            this.idvisitaDataGridViewTextBoxColumn.Name = "idvisitaDataGridViewTextBoxColumn";
            this.idvisitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // biDataGridViewTextBoxColumn
            // 
            this.biDataGridViewTextBoxColumn.DataPropertyName = "bi";
            this.biDataGridViewTextBoxColumn.HeaderText = "Bilhente de Identidade";
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
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // motivoDataGridViewTextBoxColumn
            // 
            this.motivoDataGridViewTextBoxColumn.DataPropertyName = "motivo";
            this.motivoDataGridViewTextBoxColumn.HeaderText = "Motivo";
            this.motivoDataGridViewTextBoxColumn.Name = "motivoDataGridViewTextBoxColumn";
            // 
            // datavisitaDataGridViewTextBoxColumn
            // 
            this.datavisitaDataGridViewTextBoxColumn.DataPropertyName = "data_visita";
            this.datavisitaDataGridViewTextBoxColumn.HeaderText = "Data da Visita";
            this.datavisitaDataGridViewTextBoxColumn.Name = "datavisitaDataGridViewTextBoxColumn";
            // 
            // frm_ListarVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(757, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridViewVisitas);
            this.MaximizeBox = false;
            this.Name = "frm_ListarVisitas";
            this.Text = "Consultar Visitas";
            this.Load += new System.EventHandler(this.frm_ListarVisitas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpresystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVisitas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button2;
        private db_presystemDataSet db_presystemDataSet;
        private System.Windows.Forms.BindingSource dbpresystemDataSetBindingSource;
        private db_presystemDataSet1 db_presystemDataSet1;
        private System.Windows.Forms.BindingSource visitasBindingSource;
        private db_presystemDataSet1TableAdapters.visitasTableAdapter visitasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavisitaDataGridViewTextBoxColumn;
    }
}