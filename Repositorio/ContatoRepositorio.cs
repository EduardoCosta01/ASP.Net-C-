using contrleCarro.Data;
using contrleCarro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contrleCarro.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel ListaPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();

            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDb = ListaPorId(contato.Id);

            if (contatoDb == null) throw new System.Exception("Houve um erro na atualização do Modelo");

            contatoDb.Modelo = contato.Modelo;
            contatoDb.Cor = contato.Cor;
            contatoDb.Placa = contato.Placa;

            _bancoContext.Contatos.Update(contatoDb);
            _bancoContext.SaveChanges();

            return contatoDb;

        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDb = ListaPorId(id);

            if (contatoDb == null) throw new System.Exception("Houve um erro Modelo não apagado" );

            _bancoContext.Contatos.Remove(contatoDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
