using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio.Modulo_Produtos
{
    public interface IRepositorioProduto
    {
        void Cadastrar(Produto produto);
        bool Editar(int id, Produto produto);
        bool Excluir(int id);
        Produto SelecionarPorId(int id);
        List<Produto> SelecionarTodos();
    }
}
