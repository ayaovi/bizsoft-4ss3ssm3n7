using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bizsoft_4ss3ssm3n7.Models;
using bizsoft_4ss3ssm3n7.Contexts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
      ViewData["Message"] = "Using this for orders at the moment.";

      using(var context = new SalesContext())
      {
        var orders = context.Orders
                            .Include(x => x.Client)
                            .Include(x => x.OrderLines).ToList();
        return View(orders);
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
