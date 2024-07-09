using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
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

namespace ControleDeBar.ModuloMesa
{
    public partial class TabelaMesaControl : UserControl
    {
        public TabelaMesaControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns[0].Width = 20;
        }

        public void AtualizarRegistros(List<Mesa> mesas)
        {
            grid.Rows.Clear();

            foreach (Mesa g in mesas)
                grid.Rows.Add(g.Id, g.Numero);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Número" }
            };
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
