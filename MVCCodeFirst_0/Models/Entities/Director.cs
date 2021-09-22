using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_0.Models.Entities
{
    public class Director:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }


        //Relational Properties
        public virtual List<Movie> Movies { get; set; }

    }
}