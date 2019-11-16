using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Interestelar" };


            return View(movie);
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
    }
}