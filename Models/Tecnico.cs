using System.ComponentModel.DataAnnotations;

namespace Controle_De_OS.Models
{
    public class Tecnico
    {
        [Key]
        public int Idtecnico { get; set;}

        [Required]
        [StringLength(35, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set;}

        [Required]
        [StringLength(100, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Codigo de Indentificação")]
        public int codigo_indentificador { get; set;}
    }
}
