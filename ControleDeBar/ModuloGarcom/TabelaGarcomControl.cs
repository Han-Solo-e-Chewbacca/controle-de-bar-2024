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

namespace ControleDeBar.ModuloGarcom
{
    public partial class TabelaGarcomControl : UserControl
    {
        public TabelaGarcomControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(ObterColunas());
           
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns[0].Width = 20;
        }

        public void AtualizarRegistros(List<Garcom> garcons)
        {
            grid.Rows.Clear();

            foreach (Garcom g in garcons)
                grid.Rows.Add(g.Id, g.Nome);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
            };
        }
    }
}
