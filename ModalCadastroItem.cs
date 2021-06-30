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

            pnlContent.Top = (Constants.alturaMaxima/2 -172);
            pnlContent.Left = (Constants.larguraMaxima/2 -343);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
