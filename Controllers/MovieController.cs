using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Interestelar" };

            ViewResult viewResult = new ViewResult();
            List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Maria" },
                new Customer { Name = "José"}


            };

            RandomMovieViewModel rmvm = new RandomMovieViewModel();
            rmvm.Customers = customers;
            rmvm.Movie = movie;

            

            return View(rmvm);
        }

        public ActionResult Edit(int id)
        {
            return Content("id: " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            int realPageIndex = 0;
            string realSortBy = string.Empty;

            realPageIndex = !pageIndex.HasValue ? 1 : pageIndex.Value;
            realSortBy = string.IsNullOrEmpty(sortBy) ? "name" : sortBy;

            return Content(string.Format("pageIndex={0}&SortBy={1}", realPageIndex, realSortBy));
        }

        [Route("movies/released/{year}/month:regex(\\d{4})")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int id)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie { Id = 1, Name = "Interestelar" });
            movies.Add(new Movie { Id = 2, Name = "Poderoso Chefão I" });
            movies.Add(new Movie { Id = 3, Name = "Vingadores: Guerra Infinita" });

            Movie movieDetail = movies.Where(x => x.Id == id).FirstOrDefault();

            return View(movieDetail);
        }

        public ActionResult Movies()
        {
            MoviesViewModel moviesVM = new MoviesViewModel();
            moviesVM.Movies = new List<Movie>();
            moviesVM.Movies.Add(new Movie { Id = 1, Name = "Interestelar" });
            moviesVM.Movies.Add(new Movie { Id = 2, Name = "The GodFather I" });
            moviesVM.Movies.Add(new Movie { Id = 3, Name = "Avengers: Infinity War" });



            return View(moviesVM);
        }
    }
}