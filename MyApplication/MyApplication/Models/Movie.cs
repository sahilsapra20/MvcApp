using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime releasedate { get; set; }
        public string genre { get; set; }
        public decimal price { get; set; }
    }
}