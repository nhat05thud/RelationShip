using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManyToMany.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<AuthorToBook> AuthorsToBooks { get; set; }
    }
}