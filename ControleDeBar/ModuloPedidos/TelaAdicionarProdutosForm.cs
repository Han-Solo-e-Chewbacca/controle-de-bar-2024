using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Dominio.ModuloProdutos;
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
    public partial class TelaAdicionarProdutosForm : Form
    {
        public TelaAdicionarProdutosForm(List<Produto> produtos)
        {
            InitializeComponent();
        }

        public List<Produto> CarregarNovosPedidos()
        {
            List<Produto> NovosPedidos = new List<Produto>();
            foreach (Produto item in listProdutos.CheckedItems)
            {
                NovosPedidos.Add(item);
            }
                       
            return NovosPedidos;
        }
        public void CarregarProdutos(List<Produto> produtos)
        {
            listProdutos.Items.Clear();
            foreach (Produto c in produtos)
                listProdutos.Items.Add(c);

        }
        private void listProdutos_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            txtVT.Text = "0";
            foreach (Produto c in listProdutos.CheckedItems)
                txtVT.Text = Convert.ToString(c.Preco + Convert.ToDecimal(txtVT.Text));
        }

    }
}
