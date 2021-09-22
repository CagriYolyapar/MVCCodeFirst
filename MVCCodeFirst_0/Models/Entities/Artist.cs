using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_0.Models.Entities
{
    public class Artist:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties
        public virtual List<MovieArtist> MovieArtists { get; set; }
    }
}