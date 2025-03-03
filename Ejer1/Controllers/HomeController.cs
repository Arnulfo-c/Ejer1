using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ejer1.Models;
using Ejer1.Db;

namespace Ejer1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext appDbContext;

    public HomeController(ILogger<HomeController> logger, AppDbContext _dbContext)
    {
        _logger = logger;
        appDbContext = _dbContext;
    }

    public IActionResult Index()
    {
        var alunmos = appDbContext.Alunmos.ToList();
        return View(alunmos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
