namespace FrmLogin
{
    partial class FrmInicial
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
            this.components = new System.ComponentModel.Container();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Image = global::FrmLogin.Properties.Resources.Pedido1;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedido.Location = new System.Drawing.Point(425, 54);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(155, 148);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Image = global::FrmLogin.Properties.Resources.Produto;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduto.Location = new System.Drawing.Point(250, 221);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(155, 148);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrmLogin.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 315);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = global::FrmLogin.Properties.Resources.Usuario;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(425, 221);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(155, 148);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::FrmLogin.Properties.Resources.Cliente;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(250, 54);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(155, 148);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.menu.Size = new System.Drawing.Size(659, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
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
            this.menuClienteAlterar.Size = new System.Drawing.Size(125, 22);
            this.menuClienteAlterar.Text = "Alterar";
            this.menuClienteAlterar.Click += new System.EventHandler(this.menuClienteAlterar_Click);
            // 
            // menuClienteCadastrar
            // 
            this.menuClienteCadastrar.Name = "menuClienteCadastrar";
            this.menuClienteCadastrar.Size = new System.Drawing.Size(125, 22);
            this.menuClienteCadastrar.Text = "Cadastrar";
            this.menuClienteCadastrar.Click += new System.EventHandler(this.menuClienteCadastrar_Click);
            // 
            // menuClienteConsultar
            // 
            this.menuClienteConsultar.Name = "menuClienteConsultar";
            this.menuClienteConsultar.Size = new System.Drawing.Size(125, 22);
            this.menuClienteConsultar.Text = "Consultar";
            this.menuClienteConsultar.Click += new System.EventHandler(this.menuClienteConsultar_Click);
            // 
            // menuClienteExcluir
            // 
            this.menuClienteExcluir.Name = "menuClienteExcluir";
            this.menuClienteExcluir.Size = new System.Drawing.Size(125, 22);
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
            this.menuPedidoAlterar.Size = new System.Drawing.Size(125, 22);
            this.menuPedidoAlterar.Text = "Alterar";
            this.menuPedidoAlterar.Click += new System.EventHandler(this.menuPedidoAlterar_Click);
            // 
            // menuPedidoCadastrar
            // 
            this.menuPedidoCadastrar.Name = "menuPedidoCadastrar";
            this.menuPedidoCadastrar.Size = new System.Drawing.Size(125, 22);
            this.menuPedidoCadastrar.Text = "Cadastrar";
            this.menuPedidoCadastrar.Click += new System.EventHandler(this.menuPedidoCadastrar_Click);
            // 
            // menuPedidoConsultar
            // 
            this.menuPedidoConsultar.Name = "menuPedidoConsultar";
            this.menuPedidoConsultar.Size = new System.Drawing.Size(125, 22);
            this.menuPedidoConsultar.Text = "Consultar";
            this.menuPedidoConsultar.Click += new System.EventHandler(this.menuPedidoConsultar_Click);
            // 
            // menuPedidoExcluir
            // 
            this.menuPedidoExcluir.Name = "menuPedidoExcluir";
            this.menuPedidoExcluir.Size = new System.Drawing.Size(125, 22);
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
            this.menuProdutoAlterar.Size = new System.Drawing.Size(125, 22);
            this.menuProdutoAlterar.Text = "Alterar";
            this.menuProdutoAlterar.Click += new System.EventHandler(this.menuProdutoAlterar_Click);
            // 
            // menuProdutoCadastrar
            // 
            this.menuProdutoCadastrar.Name = "menuProdutoCadastrar";
            this.menuProdutoCadastrar.Size = new System.Drawing.Size(125, 22);
            this.menuProdutoCadastrar.Text = "Cadastrar";
            this.menuProdutoCadastrar.Click += new System.EventHandler(this.menuProdutoCadastrar_Click);
            // 
            // menuProdutoConsultar
            // 
            this.menuProdutoConsultar.Name = "menuProdutoConsultar";
            this.menuProdutoConsultar.Size = new System.Drawing.Size(125, 22);
            this.menuProdutoConsultar.Text = "Consultar";
            this.menuProdutoConsultar.Click += new System.EventHandler(this.menuProdutoConsultar_Click);
            // 
            // menuProdutoExcluir
            // 
            this.menuProdutoExcluir.Name = "menuProdutoExcluir";
            this.menuProdutoExcluir.Size = new System.Drawing.Size(125, 22);
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
            this.menuUsuarioAlterar.Size = new System.Drawing.Size(125, 22);
            this.menuUsuarioAlterar.Text = "Alterar";
            this.menuUsuarioAlterar.Click += new System.EventHandler(this.menuUsuarioAlterar_Click);
            // 
            // menuUsuarioCadastrar
            // 
            this.menuUsuarioCadastrar.Name = "menuUsuarioCadastrar";
            this.menuUsuarioCadastrar.Size = new System.Drawing.Size(125, 22);
            this.menuUsuarioCadastrar.Text = "Cadastrar";
            this.menuUsuarioCadastrar.Click += new System.EventHandler(this.menuUsuarioCadastrar_Click);
            // 
            // menuUsuarioConsultar
            // 
            this.menuUsuarioConsultar.Name = "menuUsuarioConsultar";
            this.menuUsuarioConsultar.Size = new System.Drawing.Size(125, 22);
            this.menuUsuarioConsultar.Text = "Consultar";
            this.menuUsuarioConsultar.Click += new System.EventHandler(this.menuUsuarioConsultar_Click);
            // 
            // menuUsuarioExcluir
            // 
            this.menuUsuarioExcluir.Name = "menuUsuarioExcluir";
            this.menuUsuarioExcluir.Size = new System.Drawing.Size(125, 22);
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
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 451);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicial";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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