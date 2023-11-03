using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int Id { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(100, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Cidade")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(2, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "UF")]
        public string estado { get; set; }
    }
}
