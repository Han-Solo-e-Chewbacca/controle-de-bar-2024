using ControleDeBar.Dominio.ModuloPedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeBar.ModuloProduto
{
    public partial class TelaFaturamentoForm : Form
    {
        public TelaFaturamentoForm(List<Pedido> pedidos)
        {
            InitializeComponent();

            foreach (Pedido p in pedidos)
            {
                if(p.Data.Day == DateTime.Now.Day)
                {
                    txtDia.Text = Convert.ToString(Convert.ToDecimal(txtDia.Text)+p.Total);
                }
                if (p.Data.Month == DateTime.Now.Month)
                {
                    txtMes.Text = Convert.ToString(Convert.ToDecimal(txtMes.Text) + p.Total);
                }
                if (p.Data > DateTime.Now.AddDays(-7))
                {
                    txtSemana.Text = Convert.ToString(Convert.ToDecimal(txtSemana.Text) + p.Total);
                }
                
            }
          






        }
    }
}
