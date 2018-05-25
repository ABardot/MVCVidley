using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.Controllers
{
    internal class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Cusotmers { get; set; }
    }
}