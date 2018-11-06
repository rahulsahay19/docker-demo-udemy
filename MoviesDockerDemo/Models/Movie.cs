using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDockerDemo.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public string ReleaseYear { get; set; }
        public string Genre { get; set; }
        
    }
}
