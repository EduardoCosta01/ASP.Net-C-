using contrleCarro.Data;
using contrleCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contrleCarro.Repositorio
{
    public class MarcaRepositorio : IMarcaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public MarcaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<MarcaModel> BuscarTodos()
        {
            return _bancoContext.MarcaModel.ToList();
        }

        public MarcaModel Adicionar(MarcaModel marca)
        {
            _bancoContext.MarcaModel.Add(marca);
            _bancoContext.SaveChanges();

            return marca;
        }

        public MarcaModel ListaPorId(int id)
        {
            return _bancoContext.MarcaModel.FirstOrDefault(x => x.Id == id);
        }
    }
}
