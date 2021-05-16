using System;
using System.Windows.Forms;
using CadastroForms.Classes;

namespace CadastroForms
{
    public partial class TelaCadastro : Form
    {

        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Anuncio anuncio = new Anuncio();

            //Nome do anuncio
            if (txtBoxNomeAnuncio.Text != string.Empty)
            {
                anuncio.nomeAnuncio = txtBoxNomeAnuncio.Text;
            }
            else
            {
                MessageBox.Show("Informe o nome do anúncio");
                return;
            }

            //Nome do cliente
            if (txtBoxNomeCliente.Text != string.Empty)
            {
                anuncio.nomeCliente = txtBoxNomeCliente.Text;
            }
            else
            {
                MessageBox.Show("Informe o nome do cliente");
                return;
            }

            //Data de inicio do anúncio
            if (txtBoxDataInicio.Text != string.Empty)
            {
                anuncio.dataInicio = (txtBoxDataInicio.Text);
            }
            else
            {
                MessageBox.Show("Informe a data de inicio do anúncio");
                return;
            }

            //Data do termino do anúncio
            if (txtBoxDataTermino.Text != string.Empty)
            {
                anuncio.dataTermino = (txtBoxDataTermino.Text);
            }
            else
            {
                MessageBox.Show("Informe a data do fim do anúncio");
                return;
            }


            //Valor investido por dia
            if (txtBoxInvestimentoDia.Text != string.Empty)
            {
                anuncio.investimentoDiario = Convert.ToString(txtBoxInvestimentoDia);
            }
            else
            {
                MessageBox.Show("Informe o valor investido por dia");
                return;
            }

            MessageBox.Show("Cadastro efetuado com sucesso.");
            return;

            //Inserindo no banco de dados
            inserirAnuncioNoBancoDeDados(anuncio);
            this.Close();

        }

     /*  private void calculadora()
        {
            int visualizacoes, compartilhamentos, cliques = 0;

            visualizacoes = Convert.ToDecimal(investimentoDiario());


            visualizacoes = Convert.ToInt32(valorInvestido * 30);
            cliques = visualizacoes / 8;
            compartilhamentos = (cliques / 7) + 1;

        }
     */
        //seria a conexão com o banco de dados
        private void inserirAnuncioNoBancoDeDados(Anuncio anuncio)
        {
            /*
            string stringConection = @"Data Source=(localdb)\== Não Consegui.
            SqlConnection conexao = new SqlConnection(stringConection);
            SqlCommand comando = new SqlCommand
            {
                CommandText = "INSERT INTO Anuncio(NOMEANUNCIO,NOMECLIENTE,DATAINICIO,DATAFIM,VALORINVESTIDODIA) VALUES (@NOMEANUNCIO,@NOMECLIENTE,@DATAINICIO,@DATAFIM,@VALORINVESTIDODIA)",
                CommandType = CommandType.Text,
                Connection = conexao
            };

            comando.Parameters.Add(new SqlParameter("@NOMEANUNCIO", anuncio.nomeAnuncio));
            comando.Parameters.Add(new SqlParameter("@NOMECLIENTE", anuncio.nomeCliente));
            comando.Parameters.Add(new SqlParameter("@DATAINICIO", anuncio.dataInicio));
            comando.Parameters.Add(new SqlParameter("@DATAFIM", anuncio.dataTermino));
            comando.Parameters.Add(new SqlParameter("@VALORINVESTIDODIA", anuncio.investimentoDiario));


            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }*/

        }

        //Limpar digitos na tela de cadastro
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNomeAnuncio.Clear();
            txtBoxNomeCliente.Clear();
            txtBoxDataInicio.Clear();
            txtBoxDataTermino.Clear();
            txtBoxInvestimentoDia.Clear();

        }

        //sair do programa
        private void btnSairCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
