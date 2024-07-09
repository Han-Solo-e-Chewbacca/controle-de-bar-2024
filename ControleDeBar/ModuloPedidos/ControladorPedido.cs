using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Dominio.ModuloProdutos;
using GeradorDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloPedidos
{
    public class ControladorPedido : ControladorBase
    {
        public override string TipoCadastro => "Pedido";

        public override string ToolTipAdicionar => "Cadastrar um novo Pedido";

        public override string ToolTipEditar => "Editar um Pedido existente";

        public override string ToolTipExcluir => "Excluir um Pedido existente";

        TabelaPedidoControl tabelaPedido;

        IRepositorioPedido repositorioPedido;
        IRepositorioGarcom repositorioGarcom;
        IRepositorioProduto repositorioProduto;
        IRepositorioMesa repositorioMesa;

        public ControladorPedido(IRepositorioPedido repositorioPedido,IRepositorioGarcom repositorioGarcom,IRepositorioProduto repositorioProduto,IRepositorioMesa repositorioMesa)
        {
            this.repositorioPedido = repositorioPedido;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioProduto = repositorioProduto;
            this.repositorioMesa = repositorioMesa;
        }

        public override void Adicionar()
        {       
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();

            TelaPedidoForm telaPedido = new TelaPedidoForm(pedidos);

            List<Garcom> garconsCadastrados = repositorioGarcom.SelecionarTodos();

            telaPedido.CarregarGarcons(garconsCadastrados);

            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();

            telaPedido.CarregarProdutos(produtosCadastrados);

            List<Mesa> mesasCadastradas = repositorioMesa.SelecionarTodos();
            telaPedido.CarregarMesas(mesasCadastradas);

            DialogResult resultado = telaPedido.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Pedido novoRegistro = telaPedido.Pedido;

            repositorioPedido.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Mesa}\" foi criado com sucesso!");
        }

        public override void Editar()
        {

            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();

            TelaPedidoForm telaPedido = new TelaPedidoForm(pedidos);

            List<Garcom> garconsCadastrados = repositorioGarcom.SelecionarTodos();

            telaPedido.CarregarGarcons(garconsCadastrados);

            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();

            telaPedido.CarregarProdutos(produtosCadastrados);

            List<Mesa> mesasCadastradas = repositorioMesa.SelecionarTodos();
            telaPedido.CarregarMesas(mesasCadastradas);

            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Pedido PedidoSelecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if (PedidoSelecionado == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Pedido> pedidosCadastrados = repositorioPedido.SelecionarTodos();


            telaPedido.Pedido = PedidoSelecionado;

            DialogResult resultado = telaPedido.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Pedido registroEditado = telaPedido.Pedido;

            repositorioPedido.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Mesa}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Pedido PedidoSelecionada = repositorioPedido.SelecionarPorId(idSelecionado);

            if (PedidoSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{PedidoSelecionada.Mesa}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioPedido.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{PedidoSelecionada.Mesa}\" foi exluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPedido == null)
                tabelaPedido = new TabelaPedidoControl();

            CarregarRegistros();

            return tabelaPedido;
        }

        public override void CarregarRegistros()
        {
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();

            tabelaPedido.AtualizarRegistros(pedidos);
        }
    }
}
