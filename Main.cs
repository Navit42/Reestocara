using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reestocara
{
    public partial class Main : Form
    {  
        public Main()
        {
            InitializeComponent();
            PositioningComponents();
          

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

        private void btnVenderItem_Click(object sender, EventArgs e)
        {
            ModalVenderItem modal = new ModalVenderItem();
            modal.Show();
            
        
        }

        private  void btnCadastrarItem_Click(object sender, EventArgs e)
        {
            ModalCadastroItem modal = new ModalCadastroItem();
            modal.Show();

        }
    }
}
