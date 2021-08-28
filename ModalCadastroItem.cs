using System;
using System.Collections.Generic;
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
            string[] columns = new string[8];
            string[] values = new string[8];
            string sqlString, connString;
            //usar o '.' para floats pois a ',' da erro;
            //usar a lista de itens para fazer a verificação de valores um a um e encontrar erros;
            //informações permitidas:preco de compra: float; categoria do item: uma palavra apenas; todo o resto textos. lembrar tambem de verificar o tamanho dos valores.
            //para o preco de compra verificar se esta usando '.' ou ',' e fazer a substituição se necessário;
            columns[0] = "codigoDeBarras";
            columns[1] = "titulo";
            columns[2] = "marca";
            columns[3] = "precoCompra";
            columns[4] = "estoque";
            columns[5] = "descricao";
            columns[6] = "categoria";
            columns[7] = "funcionarioCadastrou";

            values[0] = txtBoxCodBarras.Text;
            values[1] = txtBoxNomeItem.Text;
            values[2] = txtBoxMarcaItem.Text;
            values[3] = txtBoxPrecoDeCompra.Text;
            values[4] = txtBoxQuantiaComprada.Text;
            values[5] = txtBoxDescricao.Text;
            values[6] = txtBoxCategoriaItem.Text;
            values[7] = txtBoxCodigoFunc.Text;
            int count=0;
            foreach(string valor in values)
            {
                values[count]=values[count].Trim();
                if (values[count] == "") 
                {
                    MessageBox.Show($"Verifique a Caixa de numero {count+1}. Ela parece estar vazia.");
                    return;  
                }
                count++;

            }

            sqlString = sql.CreateCommandString("insert into", "item",columns,values);
            connString = sql.CreateConnString("reestocara", "localhost", "root", "toor");
            sql.Connect(connString, sqlString);
            
            Main main = Application.OpenForms["Main"] as Main;
            main.AtualizaLista();

            Close();
        }

       
    }
}