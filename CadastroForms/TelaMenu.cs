using System;
using System.Windows.Forms;


namespace CadastroForms
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        //Abre a tela de cadastramento.
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.ShowDialog();
        }

        //Fecha o programa
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Chama a tela que exibe os anúncios.
        private void btnExibir_Click(object sender, EventArgs e)
        {
            TelaExibir exibir = new TelaExibir();
            exibir.ShowDialog();
        }
    }
}
