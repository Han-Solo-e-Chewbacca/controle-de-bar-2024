using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Dominio.ModuloProdutos;

namespace ControleDeBar.ModuloPedidos
{
    public partial class TelaPedidoForm : Form
    {
        public TelaPedidoForm(List<Pedido> pedidosCadastrados)
        {
            InitializeComponent();
            this.pedidosCadastrados = pedidosCadastrados;
        }
        public Pedido Pedido
        {
            get => pedido;
            set
            {
                txtId.Text = value.Id.ToString();
                cbMesa.Text = value.Mesa;
                cbGarcom.SelectedItem = value.Garcom;
            }
            //pedido = new Pedido(cbMesa.Text, (Garcom) cbGarcom.SelectedItem, listaProdutos, VTotal, DateTime.Now,true);
        }
        private Pedido pedido;


        private List<Pedido> pedidosCadastrados;

        //private bool PedidoTemIdDuplicado()
        //{
        //    return pedidosCadastrados.Any(d => d.Id == pedido.Id);
        //}


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void CarregarGarcons(List<Garcom> garcons)
        {
            cbGarcom.Items.Clear();

            foreach (Garcom c in garcons)
                cbGarcom.Items.Add(c);
        }
        public void CarregarProdutos(List<Produto> produtos)
        {
            listProdutos.Items.Clear();
            foreach (Produto c in produtos)
                listProdutos.Items.Add(c);

        }

        public void CarregarMesas(List<Mesa> mesas)
        {
            cbMesa.Items.Clear();

            foreach (Mesa c in mesas)
                cbMesa.Items.Add(c.Numero);
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            List<Produto> listaProdutos = new List<Produto>();
            decimal VTotal = 0;
            foreach (Produto c in listProdutos.CheckedItems)
                listaProdutos.Add(c);

            foreach (Produto c in listaProdutos)
                VTotal += c.Preco;

            pedido = new Pedido(cbMesa.Text, (Garcom)cbGarcom.SelectedItem, listaProdutos, VTotal, DateTime.Now, "Aberto");

            List<string> erros = pedido.Validar();

            //if (PedidoTemIdDuplicado())
            //    erros.Add("Já existe um pedido com este Id cadastrado, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVT.Text = "0";
            foreach (Produto c in listProdutos.CheckedItems)
                txtVT.Text = Convert.ToString(c.Preco + Convert.ToDecimal(txtVT.Text));
        }

        private void txtVT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
