using ControleDeBar.Dominio.ModuloGarcom;
using GeradorDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloGarcom
{
    public class ControladorGarcom : ControladorBase
    {
        public override string TipoCadastro => "Garçom";

        public override string ToolTipAdicionar => "Cadastrar um novo Garçom";

        public override string ToolTipEditar => "Editar um Garçom existente";

        public override string ToolTipExcluir => "Excluir um Garçom existente";

        TabelaGarcomControl tabelaGarcom;

        IRepositorioGarcom repositorioGarcom;

        public ControladorGarcom(IRepositorioGarcom repositorioGarcom)
        {
            this.repositorioGarcom = repositorioGarcom;
        }

        public override void Adicionar()
        {
            List<Garcom> garcons = repositorioGarcom.SelecionarTodos();

            TelaGarcomForm telaGarcom = new TelaGarcomForm(garcons);

            DialogResult resultado = telaGarcom.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Garcom novoRegistro = telaGarcom.Garcom;

            repositorioGarcom.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomSelecionado = repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomSelecionado == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Garcom> garconsCadastrados = repositorioGarcom.SelecionarTodos();

            TelaGarcomForm telaGarcom = new TelaGarcomForm(garconsCadastrados);

            telaGarcom.Garcom = garcomSelecionado;

            DialogResult resultado = telaGarcom.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Garcom registroEditado = telaGarcom.Garcom;

            repositorioGarcom.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomSelecionada = repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{garcomSelecionada.Nome}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioGarcom.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{garcomSelecionada.Nome}\" foi exluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaGarcom == null)
                tabelaGarcom = new TabelaGarcomControl();

            CarregarRegistros();

            return tabelaGarcom;
        }

        public override void CarregarRegistros()
        {
            List<Garcom> disciplinas = repositorioGarcom.SelecionarTodos();

            tabelaGarcom.AtualizarRegistros(disciplinas);
        }
    }
}
