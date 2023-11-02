﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    public class Atendente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int Idatendente { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(35,ErrorMessage ="Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set; }
        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(10, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name ="Código Atendente")]
        public int codigo_atendente { get; set;}
    }
}
