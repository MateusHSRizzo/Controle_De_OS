using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_OS.Models
{
    public class Atendente
    {
        [Key]
        public int Idatendente { get; set; }

        [Required]
        [StringLength(35,ErrorMessage ="Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name ="Código Atendente")]
        public int codigo_atendente { get; set;}
    }
}
