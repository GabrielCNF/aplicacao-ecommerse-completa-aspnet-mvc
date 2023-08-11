using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Filme
    {
        [Key]

        public int Id { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string ImagemURL { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }
        public CategoriaFilme CategoriaFilme { get; set; }

        //Relações

        public List<Ator_Filme> Atores_Filmes { get; set; }

        //Cinema
        public int IdCinema { get; set; }
        [ForeignKey("IdCinema")]
        public Cinema Cinema { get; set; }

        //Produtor
        public int IdProdutor { get; set; }
        [ForeignKey("IdProdutor")]
        public Produtor Produtor { get; set; }

    }
}
