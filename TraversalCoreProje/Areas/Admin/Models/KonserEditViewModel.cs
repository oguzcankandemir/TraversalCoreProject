using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Admin.Models
{
    public class KonserEditViewModel
    {
        public string konserID { get; set; }
        public string city { get; set; }
        public string daynight { get; set; }
        public double price { get; set; }
        public string ımage { get; set; }
        public string description { get; set; }
        public int capacity { get; set; }
        public IFormFile Imagee { get; set; }
    }
}
