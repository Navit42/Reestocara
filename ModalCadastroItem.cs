using System;
using System.Windows.Forms;

namespace Reestocara
{
    public partial class ModalCadastroItem : Form
    {
        public ModalCadastroItem()
        {
            InitializeComponent();
        }

        private void ModalCadastroItem_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Height = Constants.alturaMaxima;
            Width = Constants.larguraMaxima;

            pnlContent.Top = (Constants.alturaMaxima / 2 - 218);
            pnlContent.Left = (Constants.larguraMaxima / 2 - 338);


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            sql.connect();
            MessageBox.Show("Deu bom");
            Close();
        }

       
    }
}