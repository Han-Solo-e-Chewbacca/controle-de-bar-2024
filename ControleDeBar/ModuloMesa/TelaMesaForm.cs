using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
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
    public partial class TelaMesaForm : Form
    {
        public TelaMesaForm(List<Mesa> mesasCadastradas)
        {
            InitializeComponent();
            this.mesasCadastradas = mesasCadastradas;
        }
        public Mesa Mesa
        {
            get => mesa;
            set
            {
                txtId.Text = value.Id.ToString();
                txtMesa.Text = value.Numero;
            }
        }
        private Mesa mesa;


        private List<Mesa> mesasCadastradas;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            mesa = new Mesa(txtMesa.Text+" "+numericUpDown1.Value);

            List<string> erros = mesa.Validar();

            if (GarcomTemNomeDuplicado())
                erros.Add("Já existe uma mesa com este nome cadastrado, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private bool GarcomTemNomeDuplicado()
        {
            return mesasCadastradas.Any(d => d.Numero == mesa.Numero);
        }

    }
}
