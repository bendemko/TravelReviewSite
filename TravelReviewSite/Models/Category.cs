using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public string Name { get; set; }
    }
}