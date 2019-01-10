using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UdemyCourseFollowThrough.Models
{
    public class Movies
    {
        [Key]
        public string MovieId { get; set; }
        public string Name { get; set; }

    }
}