using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspnet_mvc_docker.Models;
using Microsoft.Extensions.Configuration;

namespace aspnet_mvc_docker.Controllers
{
    public class HomeController : Controller
    {
       private IRepository repository;
       private string message;

    public HomeController(IRepository repository, IConfiguration config)
    {
      this.repository = repository;
      this.message = config["MESSAGE"]?? "ASP NET Core MVC - Docker";
    }

    public IActionResult Index(){
        ViewBag.Message = message;
        return View(repository.Produtos);
    }
  }
}
