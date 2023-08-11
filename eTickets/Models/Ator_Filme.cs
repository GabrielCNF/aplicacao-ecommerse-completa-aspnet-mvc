using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Ator_Filme
    {
        public int IdFilme { get; set; }
        public Filme Filme { get; set; }
        public int IdAtor { get; set; }
        public Ator Ator { get; set; }
    }
}
