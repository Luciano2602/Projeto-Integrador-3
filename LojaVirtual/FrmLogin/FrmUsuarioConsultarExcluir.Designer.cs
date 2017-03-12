namespace FrmLogin
{
    partial class FrmUsuarioConsultarExcluir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidoAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedidoExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutoAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutoExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarioAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarioCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarioConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarioExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTelaInicial = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Image = global::FrmLogin.Properties.Resources.Fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(676, 39);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 95);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::FrmLogin.Properties.Resources.Excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(516, 39);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 95);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::FrmLogin.Properties.Resources.Alterar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(361, 39);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 95);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::FrmLogin.Properties.Resources.Consultar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.Location = new System.Drawing.Point(209, 39);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 95);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::FrmLogin.Properties.Resources.Adicionar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(53, 39);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 95);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::FrmLogin.Properties.Resources.Pesquisar;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(696, 160);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 29);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(134, 169);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(531, 20);
            this.txtPesquisar.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 219);
            this.dataGridView1.TabIndex = 24;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuPedido,
            this.menuProduto,
            this.menuUsuario,
            this.menuTelaInicial});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(862, 24);
            this.menu.TabIndex = 25;
            this.menu.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClienteAlterar,
            this.menuClienteCadastrar,
            this.menuClienteConsultar,
            this.menuClienteExcluir});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(56, 20);
            this.menuCliente.Text = "Cliente";
            // 
            // menuClienteAlterar
            // 
            this.menuClienteAlterar.Name = "menuClienteAlterar";
            this.menuClienteAlterar.Size = new System.Drawing.Size(152, 22);
            this.menuClienteAlterar.Text = "Alterar";
            this.menuClienteAlterar.Click += new System.EventHandler(this.menuClienteAlterar_Click);
            // 
            // menuClienteCadastrar
            // 
            this.menuClienteCadastrar.Name = "menuClienteCadastrar";
            this.menuClienteCadastrar.Size = new System.Drawing.Size(152, 22);
            this.menuClienteCadastrar.Text = "Cadastrar";
            this.menuClienteCadastrar.Click += new System.EventHandler(this.menuClienteCadastrar_Click);
            // 
            // menuClienteConsultar
            // 
            this.menuClienteConsultar.Name = "menuClienteConsultar";
            this.menuClienteConsultar.Size = new System.Drawing.Size(152, 22);
            this.menuClienteConsultar.Text = "Consultar";
            this.menuClienteConsultar.Click += new System.EventHandler(this.menuClienteConsultar_Click);
            // 
            // menuClienteExcluir
            // 
            this.menuClienteExcluir.Name = "menuClienteExcluir";
            this.menuClienteExcluir.Size = new System.Drawing.Size(152, 22);
            this.menuClienteExcluir.Text = "Excluir";
            this.menuClienteExcluir.Click += new System.EventHandler(this.menuClienteExcluir_Click);
            // 
            // menuPedido
            // 
            this.menuPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPedidoAlterar,
            this.menuPedidoCadastrar,
            this.menuPedidoConsultar,
            this.menuPedidoExcluir});
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.Size = new System.Drawing.Size(56, 20);
            this.menuPedido.Text = "Pedido";
            // 
            // menuPedidoAlterar
            // 
            this.menuPedidoAlterar.Name = "menuPedidoAlterar";
            this.menuPedidoAlterar.Size = new System.Drawing.Size(152, 22);
            this.menuPedidoAlterar.Text = "Alterar";
            this.menuPedidoAlterar.Click += new System.EventHandler(this.menuPedidoAlterar_Click);
            // 
            // menuPedidoCadastrar
            // 
            this.menuPedidoCadastrar.Name = "menuPedidoCadastrar";
            this.menuPedidoCadastrar.Size = new System.Drawing.Size(152, 22);
            this.menuPedidoCadastrar.Text = "Cadastrar";
            this.menuPedidoCadastrar.Click += new System.EventHandler(this.menuPedidoCadastrar_Click);
            // 
            // menuPedidoConsultar
            // 
            this.menuPedidoConsultar.Name = "menuPedidoConsultar";
            this.menuPedidoConsultar.Size = new System.Drawing.Size(152, 22);
            this.menuPedidoConsultar.Text = "Consultar";
            this.menuPedidoConsultar.Click += new System.EventHandler(this.menuPedidoConsultar_Click);
            // 
            // menuPedidoExcluir
            // 
            this.menuPedidoExcluir.Name = "menuPedidoExcluir";
            this.menuPedidoExcluir.Size = new System.Drawing.Size(152, 22);
            this.menuPedidoExcluir.Text = "Excluir";
            this.menuPedidoExcluir.Click += new System.EventHandler(this.menuPedidoExcluir_Click);
            // 
            // menuProduto
            // 
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProdutoAlterar,
            this.menuProdutoCadastrar,
            this.menuProdutoConsultar,
            this.menuProdutoExcluir});
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(62, 20);
            this.menuProduto.Text = "Produto";
            // 
            // menuProdutoAlterar
            // 
            this.menuProdutoAlterar.Name = "menuProdutoAlterar";
            this.menuProdutoAlterar.Size = new System.Drawing.Size(152, 22);
            this.menuProdutoAlterar.Text = "Alterar";
            this.menuProdutoAlterar.Click += new System.EventHandler(this.menuProdutoAlterar_Click);
            // 
            // menuProdutoCadastrar
            // 
            this.menuProdutoCadastrar.Name = "menuProdutoCadastrar";
            this.menuProdutoCadastrar.Size = new System.Drawing.Size(152, 22);
            this.menuProdutoCadastrar.Text = "Cadastrar";
            this.menuProdutoCadastrar.Click += new System.EventHandler(this.menuProdutoCadastrar_Click);
            // 
            // menuProdutoConsultar
            // 
            this.menuProdutoConsultar.Name = "menuProdutoConsultar";
            this.menuProdutoConsultar.Size = new System.Drawing.Size(152, 22);
            this.menuProdutoConsultar.Text = "Consultar";
            this.menuProdutoConsultar.Click += new System.EventHandler(this.menuProdutoConsultar_Click);
            // 
            // menuProdutoExcluir
            // 
            this.menuProdutoExcluir.Name = "menuProdutoExcluir";
            this.menuProdutoExcluir.Size = new System.Drawing.Size(152, 22);
            this.menuProdutoExcluir.Text = "Excluir";
            this.menuProdutoExcluir.Click += new System.EventHandler(this.menuProdutoExcluir_Click);
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarioAlterar,
            this.menuUsuarioCadastrar,
            this.menuUsuarioConsultar,
            this.menuUsuarioExcluir});
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(59, 20);
            this.menuUsuario.Text = "Usuário";
            // 
            // menuUsuarioAlterar
            // 
            this.menuUsuarioAlterar.Name = "menuUsuarioAlterar";
            this.menuUsuarioAlterar.Size = new System.Drawing.Size(152, 22);
            this.menuUsuarioAlterar.Text = "Alterar";
            this.menuUsuarioAlterar.Click += new System.EventHandler(this.menuUsuarioAlterar_Click);
            // 
            // menuUsuarioCadastrar
            // 
            this.menuUsuarioCadastrar.Name = "menuUsuarioCadastrar";
            this.menuUsuarioCadastrar.Size = new System.Drawing.Size(152, 22);
            this.menuUsuarioCadastrar.Text = "Cadastrar";
            this.menuUsuarioCadastrar.Click += new System.EventHandler(this.menuUsuarioCadastrar_Click);
            // 
            // menuUsuarioConsultar
            // 
            this.menuUsuarioConsultar.Name = "menuUsuarioConsultar";
            this.menuUsuarioConsultar.Size = new System.Drawing.Size(152, 22);
            this.menuUsuarioConsultar.Text = "Consultar";
            this.menuUsuarioConsultar.Click += new System.EventHandler(this.menuUsuarioConsultar_Click);
            // 
            // menuUsuarioExcluir
            // 
            this.menuUsuarioExcluir.Name = "menuUsuarioExcluir";
            this.menuUsuarioExcluir.Size = new System.Drawing.Size(152, 22);
            this.menuUsuarioExcluir.Text = "Excluir";
            this.menuUsuarioExcluir.Click += new System.EventHandler(this.menuUsuarioExcluir_Click);
            // 
            // menuTelaInicial
            // 
            this.menuTelaInicial.Name = "menuTelaInicial";
            this.menuTelaInicial.Size = new System.Drawing.Size(74, 20);
            this.menuTelaInicial.Text = "Tela inicial";
            this.menuTelaInicial.Click += new System.EventHandler(this.menuTelaInicial_Click);
            // 
            // FrmUsuarioConsultarExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 455);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmUsuarioConsultarExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarioAlterarExcluir";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuClienteAlterar;
        private System.Windows.Forms.ToolStripMenuItem menuClienteCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuClienteConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuClienteExcluir;
        private System.Windows.Forms.ToolStripMenuItem menuPedido;
        private System.Windows.Forms.ToolStripMenuItem menuPedidoAlterar;
        private System.Windows.Forms.ToolStripMenuItem menuPedidoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuPedidoConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuPedidoExcluir;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem menuProdutoAlterar;
        private System.Windows.Forms.ToolStripMenuItem menuProdutoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuProdutoConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuProdutoExcluir;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarioAlterar;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarioCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarioConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarioExcluir;
        private System.Windows.Forms.ToolStripMenuItem menuTelaInicial;
    }
}