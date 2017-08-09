using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarBox3.Models;

namespace StarBox3.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}