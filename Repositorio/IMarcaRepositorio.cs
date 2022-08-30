using contrleCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contrleCarro.Repositorio
{
    public interface IMarcaRepositorio
    {
        List<MarcaModel> BuscarTodos();

        MarcaModel ListaPorId(int id);

        MarcaModel Adicionar(MarcaModel contato);
    }
}
