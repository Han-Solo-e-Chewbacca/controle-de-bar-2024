using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Dominio.ModuloProdutos;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleDeBar.ModuloPedidos
{
    public partial class TabelaPedidoControl : UserControl
    {
        public TabelaPedidoControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns[0].Width = 20;
        }

        public void AtualizarRegistros(List<Pedido> pedidos)
        {
            grid.Rows.Clear();

            foreach (Pedido g in pedidos)
                grid.Rows.Add(g.Id, g.Mesa, g.Garcom.Nome, g.Produtos.Count, g.Total, g.Data, g.Situacao);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Mesa", HeaderText = "Mesa" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Garcom", HeaderText = "Garçom" },
                new DataGridViewTextBoxColumn { DataPropertyName = "QTDProdutos", HeaderText = "QTD.Produtos" },
                new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Situacao", HeaderText = "Situação" }
            };
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
