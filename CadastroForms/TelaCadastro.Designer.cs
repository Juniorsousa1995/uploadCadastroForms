
namespace CadastroForms
{
    partial class TelaCadastro
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
            this.txtBoxNomeAnuncio = new System.Windows.Forms.TextBox();
            this.txtBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.txtBoxDataInicio = new System.Windows.Forms.TextBox();
            this.txtBoxDataTermino = new System.Windows.Forms.TextBox();
            this.txtBoxInvestimentoDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSairCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNomeAnuncio
            // 
            this.txtBoxNomeAnuncio.Location = new System.Drawing.Point(351, 53);
            this.txtBoxNomeAnuncio.Name = "txtBoxNomeAnuncio";
            this.txtBoxNomeAnuncio.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNomeAnuncio.TabIndex = 0;
            // 
            // txtBoxNomeCliente
            // 
            this.txtBoxNomeCliente.Location = new System.Drawing.Point(351, 118);
            this.txtBoxNomeCliente.Name = "txtBoxNomeCliente";
            this.txtBoxNomeCliente.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNomeCliente.TabIndex = 1;
            // 
            // txtBoxDataInicio
            // 
            this.txtBoxDataInicio.Location = new System.Drawing.Point(351, 175);
            this.txtBoxDataInicio.Name = "txtBoxDataInicio";
            this.txtBoxDataInicio.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDataInicio.TabIndex = 2;
            // 
            // txtBoxDataTermino
            // 
            this.txtBoxDataTermino.Location = new System.Drawing.Point(351, 231);
            this.txtBoxDataTermino.Name = "txtBoxDataTermino";
            this.txtBoxDataTermino.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDataTermino.TabIndex = 3;
            // 
            // txtBoxInvestimentoDia
            // 
            this.txtBoxInvestimentoDia.Location = new System.Drawing.Point(351, 288);
            this.txtBoxInvestimentoDia.Name = "txtBoxInvestimentoDia";
            this.txtBoxInvestimentoDia.Size = new System.Drawing.Size(100, 23);
            this.txtBoxInvestimentoDia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do anúncio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de término";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Investimento por dia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(260, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastro de anúncio";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(330, 343);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 36);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(155, 343);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 36);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSairCadastro
            // 
            this.btnSairCadastro.Location = new System.Drawing.Point(500, 343);
            this.btnSairCadastro.Name = "btnSairCadastro";
            this.btnSairCadastro.Size = new System.Drawing.Size(147, 36);
            this.btnSairCadastro.TabIndex = 13;
            this.btnSairCadastro.Text = "Sair";
            this.btnSairCadastro.UseVisualStyleBackColor = true;
            this.btnSairCadastro.Click += new System.EventHandler(this.btnSairCadastro_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 419);
            this.Controls.Add(this.btnSairCadastro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxInvestimentoDia);
            this.Controls.Add(this.txtBoxDataTermino);
            this.Controls.Add(this.txtBoxDataInicio);
            this.Controls.Add(this.txtBoxNomeCliente);
            this.Controls.Add(this.txtBoxNomeAnuncio);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNomeAnuncio;
        private System.Windows.Forms.TextBox txtBoxNomeCliente;
        private System.Windows.Forms.TextBox txtBoxDataInicio;
        private System.Windows.Forms.TextBox txtBoxDataTermino;
        private System.Windows.Forms.TextBox txtBoxInvestimentoDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSairCadastro;
    }
}