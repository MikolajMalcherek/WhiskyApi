using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whisky
{
    internal class Distillery
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string country { get; set; }
        public string whiskybase_whiskies { get; set; }
        public string whiskybase_votes { get; set; }
        public string whiskybase_rating { get; set; }
        public override string ToString()
        {
            return $"{this.name}, Kraj: {this.country}, Ocena: {this.whiskybase_rating}";
        }
    }
}
