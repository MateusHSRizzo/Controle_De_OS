using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    [Table("Atendente")]
    public class Atendente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int Id { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(35,ErrorMessage ="Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [Display(Name ="NRF-(Numero de registro de funcionário)")]
        public int Registro { get; set;}

        [Display(Name = "Cliente")]
        public int Idcliente { get; set; }
        [ForeignKey("Idcliente")]
        public Cliente Cliente { get; set; }
        
    }
}
