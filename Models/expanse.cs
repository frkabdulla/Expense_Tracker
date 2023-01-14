using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    public class expanse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public string category { get; set; }
    }

}