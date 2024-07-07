using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloProdutos;
using GeradorDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloProduto
{
    public class ControladorProduto : ControladorBase
    {
        public override string TipoCadastro => "Garçom";

        public override string ToolTipAdicionar => "Cadastrar um novo Garçom";

        public override string ToolTipEditar => "Editar um Garçom existente";

        public override string ToolTipExcluir => "Excluir um Garçom existente";

        TabelaProdutoControl tabelaProduto;

        IRepositorioProduto repositorioProduto;

        public ControladorProduto(IRepositorioProduto repositorioProduto)
        {
            this.repositorioProduto = repositorioProduto;
        }

        public override void Adicionar()
        {
            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            TelaProdutoForm telaProduto = new TelaProdutoForm(produtos);

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Produto novoRegistro = telaProduto.Produto;

            repositorioProduto.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto ProdutoSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (ProdutoSelecionado == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();

            TelaProdutoForm telaProduto = new TelaProdutoForm(produtosCadastrados);

            telaProduto.Produto = ProdutoSelecionado;

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Produto registroEditado = telaProduto.Produto;

            repositorioProduto.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto ProdutoSelecionada = repositorioProduto.SelecionarPorId(idSelecionado);

            if (ProdutoSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{ProdutoSelecionada.Nome}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioProduto.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{ProdutoSelecionada.Nome}\" foi exluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaProduto == null)
                tabelaProduto = new TabelaProdutoControl();

            CarregarRegistros();

            return tabelaProduto;
        }

        public override void CarregarRegistros()
        {
            List<Produto> disciplinas = repositorioProduto.SelecionarTodos();

            tabelaProduto.AtualizarRegistros(disciplinas);
        }
    }
}
