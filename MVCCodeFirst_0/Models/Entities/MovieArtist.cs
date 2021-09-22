using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_0.Models.Entities
{
    public class MovieArtist:BaseEntity
    {
        public int MovieID { get; set; }
        public int ArtistID { get; set; }

        //Relational Properties

        public virtual Artist Artist { get; set; }
        public virtual Movie Movie { get; set; }

    }
}