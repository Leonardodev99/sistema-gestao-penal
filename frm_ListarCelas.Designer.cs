namespace system
{
    partial class frm_ListarCelas
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
            this.dataGridViewCelas = new System.Windows.Forms.DataGridView();
            this.db_presystemDataSet4 = new system.db_presystemDataSet4();
            this.celasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celasTableAdapter = new system.db_presystemDataSet4TableAdapters.celasTableAdapter();
            this.idcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(65, 56);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewCelas
            // 
            this.dataGridViewCelas.AutoGenerateColumns = false;
            this.dataGridViewCelas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcelaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.capacidadeDataGridViewTextBoxColumn});
            this.dataGridViewCelas.DataSource = this.celasBindingSource;
            this.dataGridViewCelas.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewCelas.Name = "dataGridViewCelas";
            this.dataGridViewCelas.Size = new System.Drawing.Size(344, 150);
            this.dataGridViewCelas.TabIndex = 2;
            // 
            // db_presystemDataSet4
            // 
            this.db_presystemDataSet4.DataSetName = "db_presystemDataSet4";
            this.db_presystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celasBindingSource
            // 
            this.celasBindingSource.DataMember = "celas";
            this.celasBindingSource.DataSource = this.db_presystemDataSet4;
            // 
            // celasTableAdapter
            // 
            this.celasTableAdapter.ClearBeforeFill = true;
            // 
            // idcelaDataGridViewTextBoxColumn
            // 
            this.idcelaDataGridViewTextBoxColumn.DataPropertyName = "id_cela";
            this.idcelaDataGridViewTextBoxColumn.HeaderText = "Código da Cela";
            this.idcelaDataGridViewTextBoxColumn.Name = "idcelaDataGridViewTextBoxColumn";
            this.idcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // capacidadeDataGridViewTextBoxColumn
            // 
            this.capacidadeDataGridViewTextBoxColumn.DataPropertyName = "capacidade";
            this.capacidadeDataGridViewTextBoxColumn.HeaderText = "Capacidade";
            this.capacidadeDataGridViewTextBoxColumn.Name = "capacidadeDataGridViewTextBoxColumn";
            // 
            // frm_ListarCelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(373, 274);
            this.Controls.Add(this.dataGridViewCelas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAtualizar);
            this.MaximizeBox = false;
            this.Name = "frm_ListarCelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ListarCelas";
            this.Load += new System.EventHandler(this.frm_ListarCelas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_presystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewCelas;
        private db_presystemDataSet4 db_presystemDataSet4;
        private System.Windows.Forms.BindingSource celasBindingSource;
        private db_presystemDataSet4TableAdapters.celasTableAdapter celasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadeDataGridViewTextBoxColumn;
    }
}