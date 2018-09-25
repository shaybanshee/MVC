using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicApp2.Models
{
    public class Albums
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public string CoverArt { get; set; }
    }
}