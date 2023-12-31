﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_OS.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int Id { get; set;}

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(35, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(50, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Rua/Bairro")]
        public string endereco { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(13, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório*")]
        [StringLength(13, ErrorMessage = "Excedido o limite de caracteres")]
        [Display(Name = "Documento")]
        public string documento { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Formato de Email invalido")]
        [Display(Name = "Email")]
        [StringLength(100)]
        public string email {get; set;}
        [Display(Name = "Genero")]
        [StringLength(10, ErrorMessage = "Formato de Email invalido")]
        public string genero { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Nascimento")]
        public DateTime nasc { get; set; }

        [Display(Name = "Cidade")]
        public int Idcidade { get; set; }
        [ForeignKey("Idcidade")]
        public Cidade Cidade { get; set; }

    }
}
