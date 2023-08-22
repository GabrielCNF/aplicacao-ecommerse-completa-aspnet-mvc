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
        [Required(ErrorMessage ="Foto de Perfil é obrigatória")]
        public string FotoDePerfilURL { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Nome Completo é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome Completo deve ter entre 3 e 50 caracteres")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "Biografia é obrigatória")]
        public string Bio { get; set; }

        //Relações
        public List<Ator_Filme> Atores_Filmes { get; set; }
    }
}
