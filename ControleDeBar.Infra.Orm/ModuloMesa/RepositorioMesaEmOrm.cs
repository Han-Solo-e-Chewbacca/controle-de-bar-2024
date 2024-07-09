using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Infra.Orm.ModuloMesa
{
    public class RepositorioMesaEmOrm : IRepositorioMesa
    {
        ControleDeBarDbContext dbContext;

        public RepositorioMesaEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Mesa Mesa)
        {
            dbContext.Mesas.Add(Mesa);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Mesa disciplinaAtualizada)
        {
            Mesa Mesa = dbContext.Mesas.Find(id)!;

            if (Mesa == null)
                return false;

            Mesa.AtualizarRegistro(disciplinaAtualizada);

            dbContext.Mesas.Update(Mesa);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Mesa Mesa = dbContext.Mesas.Find(id)!;

            if (Mesa == null)
                return false;

            dbContext.Mesas.Remove(Mesa);
            dbContext.SaveChanges();

            return true;
        }

        public Mesa SelecionarPorId(int id)
        {
            return dbContext.Mesas.Find(id)!;
        }

        public List<Mesa> SelecionarTodos()
        {
            return dbContext.Mesas.ToList();
        }
    }
}
