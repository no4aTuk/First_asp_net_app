using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // entity

namespace Zavod.Models
{
    public class WorkerContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
    }
}