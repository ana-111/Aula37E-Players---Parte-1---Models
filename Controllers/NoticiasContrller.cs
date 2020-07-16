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
    public class NoticiasController : Controller
    {
        Noticias noticiasModel = new Noticias();

        public IActionResult Index()
        {
            ViewBag.Noticias = noticiasModel.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Noticias novaNoticias   = new Noticias();
            novaNoticias.IdNoticia = Int32.Parse( form["IdNoticia"]);
            novaNoticias.Titulo     = form["Titulo"];

            // Upload Início
            var file    = form.Files[0];
            var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Noticias");

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
                novaNoticias.Imagem   = file.FileName;
            }

            else
            {
                novaNoticias.Imagem   = "padrao.png";
            }
            // Upload Final

            
            noticiasModel.Create(novaNoticias);
            ViewBag.Equipes = noticiasModel.ReadAll();  

            return LocalRedirect("~/Noticias");
        }

        [Route("{id}")]
        public IActionResult Excluir( int id )
        {
            noticiasModel.Delet(id);            
            return LocalRedirect("~/Noticias");
        }

    }
}
