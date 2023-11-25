﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        /*
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Wall-e"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
           
            return View(viewModel);
        }*/
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Wall-e"}
            };
        }
        //public ActionResult Edit(int movieId)
        //{
        //    return Content("id=" + movieId);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
    }
}