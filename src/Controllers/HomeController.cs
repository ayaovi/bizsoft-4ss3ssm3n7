using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bizsoft_4ss3ssm3n7.Models;
using bizsoft_4ss3ssm3n7.Contexts;
using System.Linq;

namespace bizsoft_4ss3ssm3n7.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      using(var context = new SalesContext())
      {
        var clients = context.Clients.ToList();
        return View(clients);
      }
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
