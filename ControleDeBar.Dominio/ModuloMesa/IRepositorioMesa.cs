using ControleDeBar.Dominio.ModuloGarcom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio.ModuloMesa
{
    public interface IRepositorioMesa
    {
        void Cadastrar(Mesa mesa);
        bool Editar(int id, Mesa mesa);
        bool Excluir(int id);
        Mesa SelecionarPorId(int id);
        List<Mesa> SelecionarTodos();
    }
}
