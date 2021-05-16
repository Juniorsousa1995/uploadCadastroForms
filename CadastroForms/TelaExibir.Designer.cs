
namespace CadastroForms
{
    partial class TelaExibir
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVoltarExibir = new System.Windows.Forms.Button();
            this.nomeAnuncio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(215, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anúncios cadastrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeAnuncio,
            this.dataGridViewTextBoxColumn1,
            this.nomeCliente,
            this.dataInicio,
            this.dataTermino});
            this.dataGridView1.Location = new System.Drawing.Point(34, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(583, 124);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnVoltarExibir
            // 
            this.btnVoltarExibir.Location = new System.Drawing.Point(215, 301);
            this.btnVoltarExibir.Name = "btnVoltarExibir";
            this.btnVoltarExibir.Size = new System.Drawing.Size(188, 52);
            this.btnVoltarExibir.TabIndex = 2;
            this.btnVoltarExibir.Text = "Voltar";
            this.btnVoltarExibir.UseVisualStyleBackColor = true;
            this.btnVoltarExibir.Click += new System.EventHandler(this.btnVoltarExibir_Click);
            // 
            // nomeAnuncio
            // 
            this.nomeAnuncio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nomeAnuncio.HeaderText = "Nome Anúncio";
            this.nomeAnuncio.Name = "nomeAnuncio";
            this.nomeAnuncio.Width = 113;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Valor total investido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Visualizações Máximas";
            this.nomeCliente.Name = "nomeCliente";
            // 
            // dataInicio
            // 
            this.dataInicio.HeaderText = "Cliques Máximos";
            this.dataInicio.Name = "dataInicio";
            // 
            // dataTermino
            // 
            this.dataTermino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataTermino.HeaderText = "Compartilhamentos Maximos";
            this.dataTermino.Name = "dataTermino";
            // 
            // TelaExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 461);
            this.Controls.Add(this.btnVoltarExibir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "TelaExibir";
            this.Text = "TelaExibir";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVoltarExibir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAnuncio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTermino;
    }
}