using MVCCodeFirst_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_0.ViewModels
{
    public class DirectorVM
    {
        public Director DirectorInstance { get; set; }
        public List<Director> Directors { get; set; }
    }
}