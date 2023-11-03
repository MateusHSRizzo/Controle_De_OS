using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    [Table("Tecnico")]
    public class Tecnico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int Id { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(35, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [Display(Name = "NRF-(Numero de registro de funcionário)")]
        public int registro { get; set;}

        [Display(Name = "Procedimento")]
        public int Idprocedimento { get; set; }
        [ForeignKey("Idprocedimento")]
        public Procedimento Procedimento { get; set; }
    }
}
