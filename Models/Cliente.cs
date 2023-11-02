using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Idclientes { get; set; }

        [Required]
        [StringLength(35, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Endereço")]
        public string endereco { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Required]
        [StringLength(13, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Telefone")]
        public char telefone { get; set; }

        [Required]
        [StringLength(13, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Documento")]
        public char documento { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Formato de Email invalido")]
        [Display(Name = "Email")]
        public char email {get; set;}
        [Display(Name = "Genero")]
        public char genero { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Nascimento")]
        public DateTime nasc { get; set; }

    }
}
