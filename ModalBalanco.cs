using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reestocara
{
    public partial class ModalBalanco : Form
    {
        Sql sql = new Sql();
        public ModalBalanco()
        {
            InitializeComponent();
        }

        private void AtualizaBalanco()
        {
            //Esta função irá atualizar o balanço por dia, mes e ano;
            Main main = Application.OpenForms["Main"] as Main;
            MySqlDataReader resultado = sql.ReadableConnect(main.connString, "Select * FROM item WHERE precoVenda > 0");

        }

        private void pnlSair_Paint(object sender, PaintEventArgs e)
        {
            Close();
        }
    }
}