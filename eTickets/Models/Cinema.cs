using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo do Cinema")]
        public string Logo { get; set; }
        [Display(Name = "Nome do Cinema")]
        public string Nome { get; set; }
        [Display(Name = "Descrição do Cinema")]
        public string Descricao { get; set; }
    }
}
