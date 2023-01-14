using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    public class expanseContext : DbContext
    {
        public DbSet<expanse> expanses { get; set; }
    }
}