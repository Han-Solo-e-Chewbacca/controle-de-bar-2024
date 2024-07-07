using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio.ModuloGarcom
{
    public interface IRepositorioGarcom
    {
        void Cadastrar(Garcom disciplina);
        bool Editar(int id, Garcom disciplina);
        bool Excluir(int id);
        Garcom SelecionarPorId(int id);
        List<Garcom> SelecionarTodos();
    }
}
