
using ControleDeBar.Dominio.ModuloGarcom;
using GeradorDeTestes.WinApp.Compartilhado.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloProdutos;

namespace ControleDeBar.ModuloProduto
{
    public partial class TabelaProdutoControl : UserControl
    {
        public TabelaProdutoControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns[0].Width = 30;
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            grid.Rows.Clear();

            foreach (Produto g in produtos)
                grid.Rows.Add(g.Id, g.Nome, g.Preco);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço" }
            };
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
