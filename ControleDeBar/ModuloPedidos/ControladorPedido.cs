using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Dominio.ModuloProdutos;
using ControleDeBar.ModuloProduto;
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

            if (PedidoSelecionado == null ||PedidoSelecionado.Situacao=="Fechado")
            {
                MessageBox.Show(
                    "Você precisa selecionar um valido registro para executar esta ação!",
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

            Pedido PedidoSelecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if (PedidoSelecionado == null || PedidoSelecionado.Situacao == "Fechado")
            {
                MessageBox.Show(
                    "Você precisa selecionar um valido registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{PedidoSelecionado.Mesa}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioPedido.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{PedidoSelecionado.Mesa}\" foi exluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaPedido == null)
                tabelaPedido = new TabelaPedidoControl();

            CarregarRegistros();

            return tabelaPedido;
        }
        public override UserControl ObterListagemAberta()
        {
            if (tabelaPedido == null)
                tabelaPedido = new TabelaPedidoControl();

            CarregarRegistrosAbertos();

            return tabelaPedido;
        }
        public override void CarregarRegistrosAbertos()
        {
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();
            List<Pedido> pedidosAbertos = new List<Pedido>();
            
            foreach(Pedido pe in pedidos)
            {
                if (pe.Situacao=="Aberto") {
                    pedidosAbertos.Add(pe);
                }
            }


            tabelaPedido.AtualizarRegistros(pedidosAbertos);
        }
        public override void CarregarRegistros()
        {
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();

            tabelaPedido.AtualizarRegistros(pedidos);
        }

        public override void ConfirmarPedido()
        {
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();

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

            PedidoSelecionado.Situacao = "Fechado";
            repositorioPedido.Editar(idSelecionado, PedidoSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{PedidoSelecionado.Mesa}\" foi confirmado com sucesso!");
        }

        public override void VisualizarFaturamento()
        {
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();
            TelaFaturamentoForm telaFaturamento = new TelaFaturamentoForm(pedidos);
            DialogResult resultado = telaFaturamento.ShowDialog();
        }

        public override void AdicionarProdutos()
        {
            List<Pedido> pedidos = repositorioPedido.SelecionarTodos();

            

            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();
            TelaAdicionarProdutosForm telaPedido = new TelaAdicionarProdutosForm(produtosCadastrados);

            telaPedido.CarregarProdutos(produtosCadastrados);

            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Pedido PedidoSelecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if (PedidoSelecionado == null || PedidoSelecionado.Situacao == "Fechado")
            {
                MessageBox.Show(
                    "Você precisa selecionar um valido registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Pedido> pedidosCadastrados = repositorioPedido.SelecionarTodos();


            DialogResult resultado = telaPedido.ShowDialog();

            List<Produto> produtosTela = telaPedido.CarregarNovosPedidos();
            if (resultado != DialogResult.OK)
                return;

            foreach (Produto p in produtosTela) {
                PedidoSelecionado.Produtos.Add(p);
                            }
            decimal vtNovo = 0;
            foreach (Produto p in PedidoSelecionado.Produtos)
            {
                vtNovo += p.Preco;            
            }
            PedidoSelecionado.Total =vtNovo;

            Pedido registroEditado = PedidoSelecionado;
            
            repositorioPedido.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Mesa}\" foi adicionado com sucesso!");
        }
    }
}
