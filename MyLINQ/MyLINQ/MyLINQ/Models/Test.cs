using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLINQ.Models
{
    class Test
    {
        public string Name { get; set; }
        public List <Ask> Category { get; set; }
        public List <Ask> ListAsk { get; set; }
        public int TimeMax { get; set; }
        public int MarkPass { get; set; }
    }
}
