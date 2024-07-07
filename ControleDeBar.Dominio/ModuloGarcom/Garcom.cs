
using GeradorDeTestes.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio.ModuloGarcom
{
    
     public class Garcom : EntidadeBase
    {
        public string Nome { get; set; }
      

        public Garcom(string nome) 
        {
            Nome = nome;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Garcom novoGarcom = (Garcom)novoRegistro;

            Nome = novoGarcom.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O nome do garçom deve ser preenchido!");

            else if (Nome.Trim().Length < 3)
                erros.Add("O nome do garçom deve conter ao menos 3 caracteres!");

            return erros;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

    }
}
