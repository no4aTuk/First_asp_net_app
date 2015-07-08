using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zavod.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Name  { get; set; }
        public string Last  { get; set; }
        public string Place { get; set; }
    }
}
