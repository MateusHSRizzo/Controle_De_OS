using System.ComponentModel.DataAnnotations;

namespace Controle_De_OS.Models
{
    public class Procedimento
    {
        [Key]
        public int Idprocedimento { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Codigo Procedimento")]
        public int codigo_procedimento { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required]
        [StringLength(5, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Prioridade")]
        public string prioridade { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public float valor { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da solicitação")]
        public DateTime data_solc {get; set; }
        }
    }

