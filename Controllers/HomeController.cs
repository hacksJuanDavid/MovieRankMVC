using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieRank.Models;
using MovieRank.Services;

namespace MovieRank.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static MovieService? _movieService;
    private List<Movie>? _movies = null!;

    public HomeController(ILogger<HomeController> logger, MovieService movieService)
    {
        _movieService = movieService;
        _logger = logger;
    }

    public IActionResult Index()
    {
        _movies = _movieService!.GetMovies();
        return View(_movies);
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