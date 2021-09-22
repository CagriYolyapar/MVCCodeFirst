using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_0.Models.Entities
{
    public class Movie:BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public int DirectorID { get; set; }
        public int GenreID { get; set; }


        //Relational Properties
        public virtual Director Director { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual List<MovieArtist> MovieArtists { get; set; }

    }
}