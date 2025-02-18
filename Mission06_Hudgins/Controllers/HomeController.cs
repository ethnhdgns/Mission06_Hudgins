using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Hudgins.Models;

namespace Mission06_Hudgins.Controllers;

public class HomeController : Controller
{
    // index page
    public IActionResult Index()
    {
        return View();
    }
    // page 2
    public IActionResult Gettoknow()
    {
        return View();
    }
    // viewing the add form
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View("AddMovie");
    }
    // submitting add form
    [HttpPost]
    public IActionResult AddMovie(movies response)
    {
        return View("Confirmation", response);
    }
}