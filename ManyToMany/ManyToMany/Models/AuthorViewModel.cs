using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManyToMany.Models
{
    public class AuthorViewModel
    {
        [Key]
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<CheckBoxViewModel> Books { get; set; }
    }
}