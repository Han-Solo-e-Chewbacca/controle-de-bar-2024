using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Infra.Orm.ModuloGarcom
{
    public class RepositorioGarcomEmOrm : IRepositorioGarcom
    {
        ControleDeBarDbContext dbContext;

        public RepositorioGarcomEmOrm(ControleDeBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Garcom Garcom)
        {
            dbContext.Garcons.Add(Garcom);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Garcom disciplinaAtualizada)
        {
            Garcom Garcom = dbContext.Garcons.Find(id)!;

            if (Garcom == null)
                return false;

            Garcom.AtualizarRegistro(disciplinaAtualizada);

            dbContext.Garcons.Update(Garcom);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Garcom Garcom = dbContext.Garcons.Find(id)!;

            if (Garcom == null)
                return false;

            dbContext.Garcons.Remove(Garcom);
            dbContext.SaveChanges();

            return true;
        }

        public Garcom SelecionarPorId(int id)
        {
            return dbContext.Garcons.Find(id)!;
        }

        public List<Garcom> SelecionarTodos()
        {
            return dbContext.Garcons.ToList();
        }
    }
}
