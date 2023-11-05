using Controle_De_OS.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Controle_De_OS.Controllers
{
    public class LoginController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(loginModel.Login == "adm" && loginModel.Senha == "123") 
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";



                }
                return View("Index");
            }
            catch (Exception erro) 
            {
                TempData["MensagemErro"] = $"Ops... Não foi possivel validar seu login, tente novamente,detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");

            }
        }
    }
}
