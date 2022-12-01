﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace eTickets_Project.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships
        public ICollection<Movie>? Movies { get; set; }
    }
}
