using System;
using System.Windows.Forms;

namespace CadastroForms
{
    public partial class TelaExibir : Form
    {
        public TelaExibir()
        {
            InitializeComponent();

            /*string stringConection = @"Data Source=(localdb)\== Não Consegui.
              SqlConnection conexao = new SqlConnection(stringConection);
              SqlCommand comando = new SqlCommand();
              SqlDataReader sqlDataReader
              comando.CommandText = "SELECT * FROM ANUNCIO;
              comando.CommandType = CommandType.Text;
              comando.Connection = conexao;




              conexao.Open();
              sqlDataReader = comando.ExecuteReader();
              if (sqlDataReader.HasRows)
              {
                  while (sqlDataReader.Read())
                  {
                      txtBoxNomeAnuncio.Text = sqlDataReader["NOMEANUNCIO"].ToString();
                      txtBoxNomeCliente.Text = sqlDataReader["NOMECLIENTE"].ToString();
                      txtBoxDataInicio.Text = sqlDataReader["DATAINICIO"].ToString();
                      txtBoxDataTermino.Text = sqlDataReader["DATAFIM"].ToString();
                      txtBoxInvestimentoDia.Text = sqlDataReader["VALORINVESTIDODIA"].ToString();
                  }
              }
              conexao.Close(); */
        }

        private void btnVoltarExibir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
