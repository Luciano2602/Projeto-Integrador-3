using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class ChamarTela
    {

        //chamando as telas Cliente
        public static void ClienteAletarCadastrar()
        {
            Console.WriteLine("Consegui usar o git");

            FrmClienteAletarCadastrar frmClienteAletarCadastrar = new FrmClienteAletarCadastrar();
            frmClienteAletarCadastrar.Show();
            Console.WriteLine("Fazendo Teste no gitHub Mas");
        }

        public static void ClienteConsultarExcluir()
        {
            FrmClienteConsultarExcluir frmClienteConsultarExcluir = new FrmClienteConsultarExcluir();
            frmClienteConsultarExcluir.Show();
        }
        // fim das telas Cliente



        // chmando a tela Categoria
        public static void CategoriaCrud()
        {
            FrmCategoriaCrud frmCategoriaCrud = new FrmCategoriaCrud();
            frmCategoriaCrud.Show();
        }
        // fim da tela Categoria



        // chamando a tela iniciar
        public static void Inicial()
        {
            FrmInicial frmInicial = new FrmInicial();
            frmInicial.Show();
        }
        //fim da iniciar


        // chamando a tela Login
        public static void Login()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            
        }
        //fim da Login


        // chamando as telas Pedido
        public static void PedidoAlterarCadastrar()
        {
            
            FrmPedidoAlterarCadastrar frmPedidoAlterarCadastrar = new FrmPedidoAlterarCadastrar();
            frmPedidoAlterarCadastrar.Show();
            
        }

        public static void PedidoConsultarExcluir()
        {
            FrmPedidoConsultarExcluir frmPedidoConsultarExcluir = new FrmPedidoConsultarExcluir();
            frmPedidoConsultarExcluir.Show();
        }
        //fim das telas pedidos


        // chamando as telas Produtos
        public static void ProdutoAlterarCadastrar()
        {
            FrmProdutoAlterarCadastrar frmProdutoAlterarCadastrar = new FrmProdutoAlterarCadastrar();
            frmProdutoAlterarCadastrar.Show();
        }

        public static void ProdutoConsultarExcluir()
        {
            FrmProdutoConsultarExcluir frmProdutoConsultarExcluir = new FrmProdutoConsultarExcluir();
            frmProdutoConsultarExcluir.Show();
        }
        // fim das telas Produtos

        // chamando as telas Usuario
        public static void UsuarioAlterarCadastrar()
        {
            FrmUsuarioAlterarCadastrar frmUsuarioAlterarCadastrar = new FrmUsuarioAlterarCadastrar();
            frmUsuarioAlterarCadastrar.Show();
        }

        public static void UsuarioConsultarExcluir()
        {
            FrmUsuarioConsultarExcluir frmUsuarioConsultarExcluir = new FrmUsuarioConsultarExcluir();
            frmUsuarioConsultarExcluir.Show();
        }
        // fim das telas Usuario
    }
}
