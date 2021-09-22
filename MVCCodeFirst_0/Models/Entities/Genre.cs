using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_0.Models.Entities
{
    public class Genre:BaseEntity
    {
        public string GenreName { get; set; }

        //Relational Properties

        public virtual List<Movie> Movies { get; set; }



    }
}