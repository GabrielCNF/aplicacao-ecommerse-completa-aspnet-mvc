using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Ator
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Foto de Perfil")]
        public string FotoDePerfilURL { get; set; }
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }
        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relações
        public List<Ator_Filme> Atores_Filmes { get; set; }
    }
}
