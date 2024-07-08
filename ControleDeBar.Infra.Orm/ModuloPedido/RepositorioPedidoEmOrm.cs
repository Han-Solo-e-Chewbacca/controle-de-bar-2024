using ControleDeBar.Dominio.ModuloPedidos;
using ControleDeBar.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Infra.Orm.ModuloPedido
{
    public class RepositorioPedidoEmOrm : IRepositorioPedido
    {
        ControleDeBarDbContext dbContext;

        public RepositorioPedidoEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Pedido Pedido)
        {
            dbContext.Pedidos.Add(Pedido);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Pedido produtoAtualizado)
        {
            Pedido Pedido = dbContext.Pedidos.Find(id)!;

            if (Pedido == null)
                return false;

            Pedido.AtualizarRegistro(produtoAtualizado);

            dbContext.Pedidos.Update(Pedido);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Pedido Pedido = dbContext.Pedidos.Find(id)!;

            if (Pedido == null)
                return false;

            dbContext.Pedidos.Remove(Pedido);
            dbContext.SaveChanges();

            return true;
        }

        public Pedido SelecionarPorId(int id)
        {
            return dbContext.Pedidos.Find(id)!;
        }

        public List<Pedido> SelecionarTodos()
        {
            return dbContext.Pedidos.Include(x => x.Garcom)
                .Include(x => x.Produtos)
                .ToList(); 
        }
    }
}
