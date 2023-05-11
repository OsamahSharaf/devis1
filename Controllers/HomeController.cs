using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using devis.Models;

namespace devis.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Quiz()
    {
        return View();
    }
    public IActionResult Job_post_page()
    {
        return View();
    }
    public IActionResult MiniQuiz()
    {
        return View();
    }
    public IActionResult basvur()
    {
        return View();
    }

    public IActionResult joinpage()
    {
        return View();
    }
    public IActionResult signpage()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult job_listing()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult AboutUs()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        

        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
    }
    public IActionResult test()
    {
        return View();
    }
}

