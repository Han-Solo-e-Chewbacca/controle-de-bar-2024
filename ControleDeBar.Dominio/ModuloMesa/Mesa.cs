using GeradorDeTestes.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string Numero { get; set; }


        public Mesa(string numero)
        {
            Numero = numero;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Mesa novoMesa = (Mesa)novoRegistro;

            Numero = novoMesa.Numero;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Numero.Trim()))
                erros.Add("O Numero da mesa deve ser preenchido!");

            else if (Numero.Trim().Length < 3)
                erros.Add("O Numero da mesa deve conter ao menos 3 caracteres!");

            return erros;
        }

        public override string ToString()
        {
            return $"{Numero}";
        }

    }
}
