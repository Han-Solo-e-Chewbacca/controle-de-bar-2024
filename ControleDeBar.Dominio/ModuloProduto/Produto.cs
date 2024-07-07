using GeradorDeTestes.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio.ModuloProdutos
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto novoProduto = (Produto)novoRegistro;

            Nome = novoProduto.Nome;
            Preco = novoProduto.Preco;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (Preco <= 0)
                erros.Add("O preço deve ser preenchido corretamente!");

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
