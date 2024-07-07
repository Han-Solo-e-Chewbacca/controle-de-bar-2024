using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Infra.Orm.ModuloGarcom;
using ControleDeBar.ModuloGarcom;
using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.WinApp.Compartilhado;

namespace ControleDeBar
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; }

        ControladorBase controlador;

        IRepositorioGarcom repositorioGarcom;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;

            ControleDeBarDbContext dbContext = new ControleDeBarDbContext();

            repositorioGarcom = new RepositorioGarcomEmOrm(dbContext);

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
            controlador = new ControladorGarcom(repositorioGarcom);

            ConfigurarTelaPrincipal(controlador);
        }
    }



}

