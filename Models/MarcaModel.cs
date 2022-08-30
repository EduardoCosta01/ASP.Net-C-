using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace contrleCarro.Models
{
    public class MarcaModel
    {
        public MarcaModel()
        {
            ContatoModel = new Collection<ContatoModel>(); 
        }

        public int Id { get; set; }

        public string Marca { get; set; }

        public virtual ICollection<ContatoModel> ContatoModel { get; set; }
    }
      
}
