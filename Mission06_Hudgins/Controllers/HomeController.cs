using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        ViewBag.Movies = _context.Movies
            .OrderBy(x => x.Title).ToList();
        return View("AddMovie");
    }

    // submitting add form
    [HttpPost]
    public IActionResult AddMovie(Movie response)
    {
        if (ModelState.IsValid) // Ensure the data is valid
        {
            _context.Movies.Add(response); // Add movie to the DbContext
            _context.SaveChanges(); // Save changes to the database

            return View("Confirmation", response); // Show confirmation page
        }

        // If model is invalid, return to form with validation messages
        return View(response);
    }


    public IActionResult MovieList()
    {
        var movies = _context.Movies
            .OrderBy(x => x.Title).ToList();
        
        return View(movies);
    }
    
    // Edit Movie (GET)
    public IActionResult EditMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.MovieID == id);
        if (movie == null)
        {
            return NotFound(); // If the movie is not found
        }

        return View(movie); // Return the movie for editing
    }
    // Edit Movie (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditMovie(int id, Movie movie)
    {
        if (id != movie.MovieID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(movie); // Update the movie in the database
                _context.SaveChanges(); // Save changes to the database
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Movies.Any(m => m.MovieID == movie.MovieID))
                {
                    return NotFound(); // If the movie does not exist
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(MovieList)); // Redirect back to the movie list page
        }
        return View(movie); // Return the movie to the view if there are errors
    }

    // Delete Movie (GET)
    public IActionResult Delete(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.MovieID == id);
        if (movie == null)
        {
            return NotFound();
        }
        return View(movie); // Show confirmation page to delete
    }

    // Delete Movie (POST)
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteMovie(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.MovieID == id);
        if (movie != null)
        {
            _context.Movies.Remove(movie); // Remove the movie
            _context.SaveChanges(); // Save changes to the database
        }

        return RedirectToAction("MovieList"); // Redirect back to the movie list
    }

}
    