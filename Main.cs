using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Reestocara
{
    public partial class Main : Form
    {

        Sql sql = new Sql();
        public string connString;


        public Main()
        {
            connString = sql.CreateConnString("reestocara", "localhost", "root", "toor");
            InitializeComponent();
            PositioningComponents();
            ListViewHandler();
            AtualizaLista();

        }

        private void PositioningComponents()
        {
            //Variaveis de posicionamento 
            int alturaMaximaBtn = Constants.alturaMaxima / 15;
            //Posicionamento Da Tela Principal
            this.Top = 0;
            this.Left = 0;
            this.Height = Constants.alturaMaxima;
            this.Width = Constants.larguraMaxima;
            //Posicionamento Paineis
            pnlMenu.Height =  Constants.alturaMaxima;
            pnlMenu.Top = 0;
            pnlMenu.Left = 0;
            pnlMenu.Width = Constants.larguraMaxima / 5;
            pnlExibicao.Height = Constants.alturaMaxima;
            pnlExibicao.Width = (Constants.larguraMaxima / 5) * 4;
            pnlExibicao.Top = 0;
            pnlExibicao.Left = (Constants.larguraMaxima / 5) + 2;
            //Posicionamento Botões
            //btnVenderItem
            btnVenderItem.Height = alturaMaximaBtn;
            btnVenderItem.Width = pnlMenu.Width;
            btnVenderItem.Left = 0;
            btnVenderItem.Top = Constants.alturaMaxima / 10;
            //btnCadastrarItem
            btnCadastrarItem.Height = alturaMaximaBtn;
            btnCadastrarItem.Width = pnlMenu.Width;
            btnCadastrarItem.Left = 0;
            btnCadastrarItem.Top = Constants.alturaMaxima/10*2;
            //btnCadastrarFuncionario
            btnCadastrarFuncionario.Height = alturaMaximaBtn;
            btnCadastrarFuncionario.Width = pnlMenu.Width;
            btnCadastrarFuncionario.Left = 0;
            btnCadastrarFuncionario.Top = Constants.alturaMaxima/10*3;
            //btnCadastrarClente
            btnCadastrarCliente.Height = alturaMaximaBtn;
            btnCadastrarCliente.Width = pnlMenu.Width;
            btnCadastrarCliente.Left = 0;
            btnCadastrarCliente.Top = Constants.alturaMaxima / 10 * 4;
            //btnBalanco
            btnBalanco.Height = alturaMaximaBtn;
            btnBalanco.Width = pnlMenu.Width;
            btnBalanco.Left = 0;
            btnBalanco.Top = Constants.alturaMaxima / 10 * 5;
            //listItensEmEstoque
            listItensEmEstoque.Width = pnlExibicao.Width;
            listItensEmEstoque.Height = pnlExibicao.Height;
            listItensEmEstoque.Top = 0;
            listItensEmEstoque.Left = 0;
        }

        private void ListViewHandler()
        {
            listItensEmEstoque.GridLines = true;
            listItensEmEstoque.FullRowSelect = true;
            listItensEmEstoque.Columns.Add("Código de Barras", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Nome do Item", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Marca", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Preço de compra", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Preço de venda", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Quantia em estoque", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Categoria", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Quem cadastrou", -2, HorizontalAlignment.Left);
            listItensEmEstoque.Columns.Add("Quem vendeu", -2, HorizontalAlignment.Left);

        }

        public void AtualizaLista()
        {

            listItensEmEstoque.Items.Clear();
            MySqlDataReader result;
            result = sql.ReadableConnect(connString, "Select * From item");
            List<ListViewItem> itens = new List<ListViewItem>();
            int count = 0;

                while (result.Read())
                {
                    itens.Add(new ListViewItem(result.GetValue(1).ToString()));
                    for (int i = 2; i < 11; i++)
                    {
                        itens[count].SubItems.Add(result.GetValue(i).ToString());
                    }
                    listItensEmEstoque.Items.Add(itens[count]);
                    count++;
                }
            sql.Close();
        }
        private void BtnVenderItem_Click(object sender, EventArgs e)
        {
            ModalVenderItem VendaItem = new ModalVenderItem();
            VendaItem.Show();
        }

        private void BtnCadastrarItem_Click(object sender, EventArgs e)
        {
            ModalCadastroItem CadItem = new ModalCadastroItem();
            CadItem.Show();
        }

        private void BtnBalanco_Click(object sender, EventArgs e)
        {
            ModalBalanco Balanco = new ModalBalanco();
            Balanco.Show();
        }
    }
    
}
