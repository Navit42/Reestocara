
namespace Reestocara
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "010233",
            "Camisa Polo gola alta",
            "Polo gola alta",
            "M",
            "25",
            "132,25",
            ""}, -1);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBalanco = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarItem = new System.Windows.Forms.Button();
            this.btnVenderItem = new System.Windows.Forms.Button();
            this.pnlExibicao = new System.Windows.Forms.Panel();
            this.listItensEmEstoque = new System.Windows.Forms.ListView();
            this.pnlMenu.SuspendLayout();
            this.pnlExibicao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenu.Controls.Add(this.btnBalanco);
            this.pnlMenu.Controls.Add(this.btnCadastrarCliente);
            this.pnlMenu.Controls.Add(this.btnCadastrarFuncionario);
            this.pnlMenu.Controls.Add(this.btnCadastrarItem);
            this.pnlMenu.Controls.Add(this.btnVenderItem);
            this.pnlMenu.Location = new System.Drawing.Point(1, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(211, 447);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnBalanco
            // 
            this.btnBalanco.Location = new System.Drawing.Point(0, 217);
            this.btnBalanco.Name = "btnBalanco";
            this.btnBalanco.Size = new System.Drawing.Size(208, 23);
            this.btnBalanco.TabIndex = 5;
            this.btnBalanco.Text = "Balanço";
            this.btnBalanco.UseVisualStyleBackColor = true;
            this.btnBalanco.Click += new System.EventHandler(this.BtnBalanco_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(0, 179);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(208, 23);
            this.btnCadastrarCliente.TabIndex = 4;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(0, 139);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(208, 23);
            this.btnCadastrarFuncionario.TabIndex = 3;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarItem
            // 
            this.btnCadastrarItem.Location = new System.Drawing.Point(0, 100);
            this.btnCadastrarItem.Name = "btnCadastrarItem";
            this.btnCadastrarItem.Size = new System.Drawing.Size(208, 23);
            this.btnCadastrarItem.TabIndex = 2;
            this.btnCadastrarItem.Text = "Cadastrar Item";
            this.btnCadastrarItem.UseVisualStyleBackColor = true;
            this.btnCadastrarItem.Click += new System.EventHandler(this.BtnCadastrarItem_Click);
            // 
            // btnVenderItem
            // 
            this.btnVenderItem.Location = new System.Drawing.Point(0, 59);
            this.btnVenderItem.Name = "btnVenderItem";
            this.btnVenderItem.Size = new System.Drawing.Size(211, 23);
            this.btnVenderItem.TabIndex = 1;
            this.btnVenderItem.Text = "Vender Item";
            this.btnVenderItem.UseVisualStyleBackColor = true;
            this.btnVenderItem.Click += new System.EventHandler(this.BtnVenderItem_Click);
            // 
            // pnlExibicao
            // 
            this.pnlExibicao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlExibicao.Controls.Add(this.listItensEmEstoque);
            this.pnlExibicao.Location = new System.Drawing.Point(218, 1);
            this.pnlExibicao.Name = "pnlExibicao";
            this.pnlExibicao.Size = new System.Drawing.Size(582, 447);
            this.pnlExibicao.TabIndex = 1;
            // 
            // listItensEmEstoque
            // 
            this.listItensEmEstoque.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listItensEmEstoque.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listItensEmEstoque.Location = new System.Drawing.Point(3, 0);
            this.listItensEmEstoque.Name = "listItensEmEstoque";
            this.listItensEmEstoque.Size = new System.Drawing.Size(576, 444);
            this.listItensEmEstoque.TabIndex = 0;
            this.listItensEmEstoque.UseCompatibleStateImageBehavior = false;
            this.listItensEmEstoque.View = System.Windows.Forms.View.Details;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlExibicao);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlExibicao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlExibicao;
        private System.Windows.Forms.Button btnBalanco;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnCadastrarItem;
        private System.Windows.Forms.Button btnVenderItem;
        private System.Windows.Forms.ListView listItensEmEstoque;
    }
}

