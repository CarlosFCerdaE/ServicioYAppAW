using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class apiCls
    {
        [Display(Name = "Id Usuario")]
        public int userId { get; set; }
        [Display(Name = "Id Post")]
        public int id { get; set; }

        [Display(Name = "Title")]
        public string title { get; set; }

        [Display(Name = "Comment")]
        public string body { get; set; }

    }
}