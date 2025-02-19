using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Hudgins.Models;
using SQLitePCL;

namespace Mission06_Hudgins.Controllers;

public class HomeController : Controller
{
    private readonly MoviesContext _context; // Declare _context
    public HomeController(MoviesContext temp)
    {
        _context = temp;
    }

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
    public IActionResult AddMovie(Movie response)
    {
        return View("Confirmation", response);
    }

    public IActionResult MovieList()
    {
        var movies = _context.Movies
            .OrderBy(x => x.Title).ToList();
        
        return View(movies);
    }
}
    