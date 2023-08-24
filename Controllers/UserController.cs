using Microsoft.AspNetCore.Mvc;
using MovieRank.Models;

namespace MovieRank.Controllers
{
    public class UserController : Controller
    {
        // Create a list of users
        private static List<User> _users = LoadUsers();

        // LoadUsers method
        private static List<User> LoadUsers()
        {
            // Create a list of users
            List<User> users = new List<User>();

            // Add users to the list
            users.Add(new User
            {
                Id = 1, UserEmail = "jonhdoe@gmail.com", FirstName = "John", LastName = "Doe", Password = "password"
            });
            users.Add(new User
            {
                Id = 2, UserEmail = "jonhdoe@gmail.com", FirstName = "John", LastName = "Doe", Password = "password"
            });
            users.Add(new User
            {
                Id = 3, UserEmail = "jonhdoe@gmail.com", FirstName = "John", LastName = "Doe", Password = "password"
            });
            users.Add(new User
            {
                Id = 4, UserEmail = "jonhdoe@gmail.com", FirstName = "John", LastName = "Doe", Password = "password"
            });
            users.Add(new User
            {
                Id = 5, UserEmail = "jonhdoe@gmail.com", FirstName = "John", LastName = "Doe", Password = "password"
            });

            return users;
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: User/Edit/
        public ActionResult Edit(int id)
        {
            return PartialView("Edit");
        }

        // POST: User/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Edit");
            }
        }

        // GET: User/Details/id
        public ActionResult Details(int id)
        {
            return PartialView("Details");
        }

        // GET: User/Delete/
        public ActionResult Delete(int id)
        {
            return PartialView("Delete");
        }

        // POST: User/Delete/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return PartialView("Delete");
            }
        }

        // GET: User/List/
        public ActionResult List(int id)
        {
            return PartialView("List", _users);
        }
    }
}