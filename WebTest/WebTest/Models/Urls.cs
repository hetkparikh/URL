using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class Urls
    {
        public List<Url> UrlList { get; set; }
        public Url Url { get; set; }
    }
    public class Url
    {
        [Required]
        public string UrlLink { get; set; }
        public string Name { get; set; }
    }
}