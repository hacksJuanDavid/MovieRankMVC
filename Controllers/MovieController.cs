using Microsoft.AspNetCore.Mvc;
using MovieRank.Models;

namespace MovieRank.Controllers
{
    public class MovieController : Controller
    {
        // Create a list of movies
        private static List<Movie> _movies = LoadMovies();

        // LoadMovies method
        private static List<Movie> LoadMovies()
        {
            // Create a list of movies
            List<Movie> movies = new List<Movie>();

            // Add movies to the list
            movies.Add(new Movie
            {
                Id = 1,
                Title = "Avengers",
                Synopsis =
                    "The head of the SHIELD Agency decides to recruit a team to save the world from near-certain disaster when an enemy unexpectedly emerges as a major threat to global security.",
                Year = 2012,
                Duration = "2H:22M",
                Rate = 8.6,
                Poster = "/Public/Img/ImgMovie/avengers.jpeg",
                Genres = "Action,Aventure"
            });
            movies.Add(new Movie
            {
                Id = 2,
                Title = "Avengers End Game",
                Synopsis =
                    "The remaining Avengers must find a way to win back their allies for an epic showdown with Thanos, the villain who decimated the planet and the universe.",
                Year = 2019,
                Duration = "3H:2M",
                Rate = 9.0,
                Poster = "/Public/Img/ImgMovie/avengers-end-game.jpeg",
                Genres = "Action,Ciencie Fiction"
            });
            movies.Add(new Movie
            {
                Id = 3,
                Title = "Relentless Pursuit 3",
                Synopsis =
                    "After being framed for the death of his beloved ex-wife, ex-undercover officer Bryan Mills channels his anger and particular skills to exact revenge on the real killers and protect his daughter.",
                Year = 2014,
                Duration = "1H:49M",
                Rate = 8.0,
                Poster = "/Public/Img/ImgMovie/relentless-pursuit-3.jpeg",
                Genres = "Action"
            });
            movies.Add(new Movie
            {
                Id = 4,
                Title = "They Are Like Children",
                Synopsis =
                    "A group of friends and former teammates discover that getting old doesn't always mean growing up when they come together to honor the memory of their basketball coach.",
                Year = 2010,
                Duration = "1H:42M",
                Rate = 7.6,
                Poster = "/Public/Img/ImgMovie/they-are-like-children.jpeg",
                Genres = "Comedy"
            });
            movies.Add(new Movie
            {
                Id = 5,
                Title = "Wreck Ralph",
                Synopsis =
                    "After years of losing to his adversary, Ralph, an arcade game character, tires of being the bad guy and takes matters into his own hands to finally become a hero, but a deadly enemy is unleashed.",
                Year = 2012,
                Duration = "1H:48M",
                Rate = 3.9,
                Poster = "/Public/Img/ImgMovie/wreck-ralph.jpeg",
                Genres = "Animation,Avanture,Children"
            });

            return movies;
        }

        // GET: Movie
        public IActionResult Index()
        {
            return View();
        }

        // GET: Movie/Create
        public IActionResult Create()
        {
            return PartialView("Create");
        }

        // POST: Movie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Create");
            }
        }

        // GET: Movie/Edit/
        public IActionResult Edit(int id)
        {
            return PartialView("Edit");
        }

        // POST: Movie/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO : Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Edit");
            }
        }

        // GET: Movie/Details/
        public IActionResult Details(int id)
        {
            return PartialView("Details");
        }

        // GET: Movie/Delete/
        public IActionResult Delete(int id)
        {
            return PartialView("Delete");
        }

        // POST: Movie/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO : Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Delete");
            }
        }

        // GET: Movie/List/
        public IActionResult List()
        {
            return PartialView("List", _movies);
        }
    }
}