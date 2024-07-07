using ControleDeBar.Dominio.ModuloGarcom;
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
    public partial class TelaGarcomForm : Form
    {
        public TelaGarcomForm(List<Garcom> garconsCadastrados)
        {
            InitializeComponent();

            this.garconsCadastrados = garconsCadastrados;
        }
        public Garcom Garcom
        {
            get => garcom;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
        }
        private Garcom garcom;


        private List<Garcom> garconsCadastrados;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            garcom = new Garcom(txtNome.Text);

            List<string> erros = garcom.Validar();

            if (GarcomTemNomeDuplicado())
                erros.Add("Já existe um garçom com este nome cadastrada, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private bool GarcomTemNomeDuplicado()
        {
            return garconsCadastrados.Any(d => d.Nome == garcom.Nome);
        }
    }
}


