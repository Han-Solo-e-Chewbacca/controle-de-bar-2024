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
        public TelaAdicionarProdutosForm(List<Produto> produtos,Pedido pedidoSelecionado)
        {
            InitializeComponent();
        foreach (Produto produto in pedidoSelecionado.Produtos)
            {
            listProdutos.Items.Add(produto);
            }
        }

        public List<Produto> CarregarNovosPedidos()
        {
            List<Produto> NovosPedidos = new List<Produto>();
            foreach (Produto item in listProdutos.Items)
            {
                NovosPedidos.Add(item);
            }

            return NovosPedidos;
        }
        public void CarregarProdutos(List<Produto> produtos)
        {
            cbProdutos.Items.Clear();
            foreach (Produto c in produtos)
                cbProdutos.Items.Add(c);

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(numQTD.Value); i++)
            {
                listProdutos.Items.Add(cbProdutos.SelectedItem);
            }
            cbProdutos.SelectedItem = null;
            txtVT.Text = "0";
            foreach (Produto c in listProdutos.Items)
                txtVT.Text = Convert.ToString(c.Preco + Convert.ToDecimal(txtVT.Text));
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Remove(listProdutos.SelectedItem);

            txtVT.Text = "0";
            foreach (Produto c in listProdutos.Items)
                txtVT.Text = Convert.ToString(c.Preco + Convert.ToDecimal(txtVT.Text));
        }
    }
}
