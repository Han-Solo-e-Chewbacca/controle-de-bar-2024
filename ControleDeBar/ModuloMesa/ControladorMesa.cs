using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.ModuloGarcom;
using GeradorDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ModuloMesa
{
    public class ControladorMesa : ControladorBase
    {
        public override string TipoCadastro => "Mesa";

        public override string ToolTipAdicionar => "Cadastrar uma nova Mesa";

        public override string ToolTipEditar => "Editar uma Mesa existente";

        public override string ToolTipExcluir => "Excluir uma Mesa existente";

        TabelaMesaControl tabelaMesa;

        IRepositorioMesa repositorioMesa;

        public ControladorMesa(IRepositorioMesa repositorioMesa)
        {
            this.repositorioMesa = repositorioMesa;
        }

        public override void Adicionar()
        {
            List<Mesa> mesas = repositorioMesa.SelecionarTodos();

            TelaMesaForm telaMesa = new TelaMesaForm(mesas);

            DialogResult resultado = telaMesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Mesa novoRegistro = telaMesa.Mesa;

            repositorioMesa.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Numero}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaMesa.ObterRegistroSelecionado();

            Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(idSelecionado);

            if (mesaSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Mesa> mesasCadastradas = repositorioMesa.SelecionarTodos();

            TelaMesaForm telaMesa = new TelaMesaForm(mesasCadastradas);

            telaMesa.Mesa = mesaSelecionada;

            DialogResult resultado = telaMesa.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Mesa registroEditado = telaMesa.Mesa;

            repositorioMesa.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Numero}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMesa.ObterRegistroSelecionado();

            Mesa mesaSelecionada = repositorioMesa.SelecionarPorId(idSelecionado);

            if (mesaSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{mesaSelecionada.Numero}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioMesa.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{mesaSelecionada.Numero}\" foi exluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMesa == null)
                tabelaMesa = new TabelaMesaControl();

            CarregarRegistros();

            return tabelaMesa;
        }

        public override void CarregarRegistros()
        {
            List<Mesa> mesas = repositorioMesa.SelecionarTodos();

            tabelaMesa.AtualizarRegistros(mesas);
        }
    }
}
