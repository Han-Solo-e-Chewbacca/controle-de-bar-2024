using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Infra.Orm.ModuloGarcom;
using ControleDeBar.Infra.Orm.ModuloMesa;
using ControleDeBar.Infra.Orm.ModuloPedido;
using ControleDeBar.Infra.Orm.ModuloProduto;
using ControleDeBar.ModuloGarcom;
using ControleDeBar.ModuloMesa;
using ControleDeBar.ModuloPedidos;
using ControleDeBar.ModuloProduto;
using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.WinApp.Compartilhado;

namespace ControleDeBar
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; }

        ControladorBase controlador;

        IRepositorioGarcom repositorioGarcom;
        IRepositorioProduto repositorioProduto;
        IRepositorioPedido repositorioPedido;
        IRepositorioMesa repositorioMesa;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;

            ControleDeBarDbContext dbContext = new ControleDeBarDbContext();

            repositorioGarcom = new RepositorioGarcomEmOrm(dbContext);
            repositorioProduto = new RepositorioProdutoEmOrm(dbContext);
            repositorioPedido = new RepositorioPedidoEmOrm(dbContext);
            repositorioMesa = new RepositorioMesaEmOrm(dbContext);

        }




        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;
            btnVisualizarFaturamento.Enabled = controladorSelecionado is ControladorPedido;
            btnConfirmar.Enabled = controladorSelecionado is ControladorPedido;
            btnAdicionarProdutos.Enabled = controladorSelecionado is ControladorPedido;
            btnFiltroAbertas.Enabled = controladorSelecionado is ControladorPedido;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void garçomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorGarcom(repositorioGarcom,repositorioPedido);

            ConfigurarTelaPrincipal(controlador);
        }

        private void produtos_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProduto(repositorioProduto,repositorioPedido);

            ConfigurarTelaPrincipal(controlador);
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorPedido(repositorioPedido, repositorioGarcom, repositorioProduto, repositorioMesa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMesa(repositorioMesa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            controlador.ConfirmarPedido();
        }

        private void btnVisualizarFaturamento_Click(object sender, EventArgs e)
        {
            controlador.VisualizarFaturamento();
        }

        private void btnAdicionarProdutos_Click(object sender, EventArgs e)
        {
            controlador.AdicionarProdutos();
        }

        private void btnFiltroAbertas_Click(object sender, EventArgs e)
        {
            UserControl listagemContato = controlador.ObterListagemAberta();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);

        }
    }



}

