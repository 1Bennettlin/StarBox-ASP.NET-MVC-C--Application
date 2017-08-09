using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarBox3.Models;

namespace StarBox3.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}