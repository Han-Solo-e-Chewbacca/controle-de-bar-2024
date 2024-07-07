using ControleDeBar.Dominio.Modulo_Produtos;

using ControleDeBar.Dominio.ModuloProdutos;
using ControleDeBar.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Infra.Orm.ModuloProduto
{
    public class RepositorioProdutoEmOrm : IRepositorioProduto
    {
        ControleDeBarDbContext dbContext;

        public RepositorioProdutoEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Produto Produto)
        {
            dbContext.Produtos.Add(Produto);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Produto produtoAtualizado)
        {
            Produto Produto = dbContext.Produtos.Find(id)!;

            if (Produto == null)
                return false;

            Produto.AtualizarRegistro(produtoAtualizado);

            dbContext.Produtos.Update(Produto);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Produto Produto = dbContext.Produtos.Find(id)!;

            if (Produto == null)
                return false;

            dbContext.Produtos.Remove(Produto);
            dbContext.SaveChanges();

            return true;
        }

        public Produto SelecionarPorId(int id)
        {
            return dbContext.Produtos.Find(id)!;
        }

        public List<Produto> SelecionarTodos()
        {
            return dbContext.Produtos.ToList();
        }
    }
}
