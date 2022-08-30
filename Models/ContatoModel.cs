using contrleCarro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace contrleCarro.Models
{
    public class ContatoModel
    {
        [Key()]
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

       
        [ForeignKey("MarcaModel")]
        public int MarcaId { get; set; }
        public virtual MarcaModel Marca { get; set; }

       
    }
}
