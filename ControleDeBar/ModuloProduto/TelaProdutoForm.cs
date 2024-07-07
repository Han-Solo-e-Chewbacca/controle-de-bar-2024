using ControleDeBar.Dominio.Modulo_Produtos;
using ControleDeBar.Dominio.ModuloGarcom;
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
    public partial class TelaProdutoForm : Form
    {
        public TelaProdutoForm(List<Produto> produtosCadastrados )
        {
            InitializeComponent();
            this.produtosCadastrados = produtosCadastrados;
        }
        public Produto Produto
        {
            get => produto;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtPreco.Value = value.Preco;
            }
        }
        private Produto produto;


        private List<Produto> produtosCadastrados;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            produto = new Produto(txtNome.Text,txtPreco.Value);

            List<string> erros = produto.Validar();

            if (ProdutoTemNomeDuplicado())
                erros.Add("Já existe um garçom com este nome cadastrada, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private bool ProdutoTemNomeDuplicado()
        {
            return produtosCadastrados.Any(d => d.Nome == produto.Nome);
        }
    }
}
