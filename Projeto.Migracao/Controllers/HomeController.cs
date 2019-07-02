using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.Migracao.Data;
using Projeto.Migracao.Models;

namespace Projeto.Migracao.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext database;

        public HomeController(ApplicationDbContext database)
        {
            this.database = database;
        }


        [HttpGet]
        public async Task<IActionResult> ListarMes()
        {
            var dados = await database.Pais.ToListAsync();
            return Json(dados);
        }

        #region Cadastro de Usuário

        [HttpGet]
        public async Task<IActionResult> ListarUsuario()
        {
            var dados = await database.Usuario.Where(cat => cat.ativo == "T").ToListAsync();
            return View(dados);
        }

        public IActionResult NovoUsuario()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Salvar(Usuario dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                //Último registro
                var resultado = (from r in database.Usuario
                                 orderby r.iid descending
                                 select r).First();

                TempData["confirmacao"] = dadosTemporario.login + " foi cadastrado com sucesso.";

                Usuario dados = new Usuario();
                dados.iid = Convert.ToDouble(resultado.iid) + 1;
                dados.login = dadosTemporario.login;
                dados.senha = dadosTemporario.senha;
                dados.ativo = "T";
                database.Usuario.Add(dados);
                database.SaveChanges();
                return RedirectToAction("ListarUsuario", "Home");
            }
            else
            {
                return View("NovoUsuario");
            }
        }


        public IActionResult EditarUsuario(int id)
        {
            var dados = database.Usuario.First(cat => cat.iid == id);
            Usuario RView = new Usuario();
            RView.iid = dados.iid;
            RView.login = dados.login;
            RView.senha = dados.senha;
            return View(RView);
        }


        [HttpPost]
        public IActionResult Atualizar(Usuario dadosTemporario)
        {
            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = dadosTemporario.login + " foi atualizado com sucesso.";
                var dados = database.Usuario.First(cat => cat.iid == dadosTemporario.iid);
                dados.login = dadosTemporario.login;
                dados.senha = dadosTemporario.senha;
                database.SaveChanges();
                return RedirectToAction("ListarUsuario", "Home"); ;
            }
            else
            {
                return View("EditarUsuario");
            }
        }



        public IActionResult Deletar(int Id)
        {
            if (Id > 0)
            {
               
                var usuario = database.Usuario.First(cat => cat.iid == Id);
                TempData["confirmacao"] = usuario.login + " foi excluido com sucesso.";
                usuario.ativo = "F";
                database.SaveChanges();
            }
            return RedirectToAction("ListarUsuario", "Home"); ;
        }

        #endregion




        public IActionResult Index()
        {
            return View();
        }



    }
}
