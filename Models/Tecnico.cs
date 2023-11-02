using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    public class Tecnico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int Idtecnico { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(35, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(100, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Codigo de Indentificação")]
        public int codigo_indentificador { get; set;}
    }
}
