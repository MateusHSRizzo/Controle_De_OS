using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    [Table ("Procedimento")]
    public class Procedimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int Id { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [Display(Name = "Codigo Procedimento")]
        public int codigo_procedimento { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(1000, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(5, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Prioridade")]
        public string prioridade { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Valor")]
        public float valor { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data da solicitação")]
        public DateTime data_solc {get; set; }

        [Display(Name = "Atendente")]
        public int Idatendente { get; set; }
        [ForeignKey("Idatendente")]
        public Atendente Atendente { get; set; }
    }
    }

