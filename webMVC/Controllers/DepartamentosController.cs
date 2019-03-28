using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webMVC.Models;

namespace webMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id=1, Nome="Financeiro" });
            lista.Add(new Departamento { Id = 2, Nome = "Suporte Técnico" });
            lista.Add(new Departamento { Id = 3, Nome = "Prodrução I" });

            return View(lista);

        }
    }
}