using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> Upcoming { get; set; }
        public bool IsShowing { get; set; }
        public string Heading { get; set; }
    }
}