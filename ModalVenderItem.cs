using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Reestocara
{
    public partial class ModalVenderItem : Form
    {
        public ModalVenderItem()
        {
            InitializeComponent();
        }

        private void ModalVenderItem_Load(object sender, EventArgs e)
        {
            PositioningComponents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void PositioningComponents()
        {
            pnlContent.Top = (Constants.alturaMaxima / 2 - 172);
            pnlContent.Left = (Constants.larguraMaxima / 2 - 343);
            List<TextBox> txtBoxPosit = new List<TextBox>();
            txtBoxPosit.Add(txtBoxNomeItem);
            txtBoxPosit.Add(txtBoxPrecoCompra);
            txtBoxPosit.Add(txtBoxPrecoVenda);
            txtBoxPosit.Add(txtBoxDesconto);
            txtBoxPosit.Add(txtBoxCpf);
            int count = 0;
            foreach (TextBox caixa in txtBoxPosit)
            {
                count++;
                caixa.Top = pnlContent.Height / 6 * count;
            }
            Top = 0;
            Left = 0;
            Height = Constants.alturaMaxima;
            Width = Constants.larguraMaxima;
        }
    }
}