using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Controle_De_OS.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Insira o Usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Insira a Senha")]
        public string Senha { get; set; }
    }
}
