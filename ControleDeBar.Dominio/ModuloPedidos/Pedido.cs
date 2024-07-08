using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloProdutos;
using GeradorDeTestes.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleDeBar.Dominio.ModuloPedidos
{
    public class Pedido : EntidadeBase
    {
        public string Mesa { get; set; }
        public Garcom Garcom { get; set; }       
        public List<Produto> Produtos { get; set; }
        public decimal Total { get; set; }    
        public DateTime Data { get; set; }
        public string Situacao { get; set; }

        public Pedido(string mesa,Garcom garcom,List<Produto> produtos , decimal total, DateTime data,string situacao)
        {
            Mesa = mesa;
            Garcom = garcom;
            Produtos = produtos;
            Total = total;
            Data = data;
            Situacao = situacao;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pedido novoPedido = (Pedido)novoRegistro;

            Mesa = novoPedido.Mesa;
            Garcom = novoPedido.Garcom;
            Produtos = novoPedido.Produtos;
            Total = novoPedido.Total;
            Data = novoPedido.Data;
            Situacao = novoPedido.Situacao;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Mesa.Trim()))
                erros.Add("O nome da mesa deve ser preenchido!");

            else if (Mesa.Trim().Length < 3)
                erros.Add("O nome do garçom deve conter ao menos 3 caracteres!");

            if (string.IsNullOrEmpty(Garcom.Nome.Trim()))
                erros.Add("O nome do garcom deve ser preenchido!");
            if (Produtos.Count<=0)
                erros.Add("Os produtos devem ser preenchidos!");
            if (string.IsNullOrEmpty(Total.ToString().Trim()))
                erros.Add("O total deve ser preenchido!");
            return erros;
        }

        public override string ToString()
        {
            return $"{Mesa}";
        }

    }
}
