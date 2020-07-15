using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aula37E_Players___Parte_1___Models.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Aula37E_Players___Parte_1___Models.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe   = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse( form["IdEquipe"]);
            novaEquipe.Nome     = form["Nome"];

            // Upload Início
            var file    = form.Files[0];
            var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

            if(file != null)
            {
                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }
                //nome do arquivo
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    file.CopyTo(stream);  
                }
                novaEquipe.Imagem   = file.FileName;
            }

            else
            {
                novaEquipe.Imagem   = "padrao.png";
            }
            // Upload Final

            
            equipeModel.Create(novaEquipe);
            ViewBag.Equipes = equipeModel.ReadAll();  

            return LocalRedirect("~/Equipe");
        }

        [Route("{id}")]
        public IActionResult Excluir( int id )
        {
            equipeModel.Delet(id);            
            return LocalRedirect("~/Equipe");
        }

    }
}
