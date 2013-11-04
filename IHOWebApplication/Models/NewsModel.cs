using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
namespace IHOWebApplication.Models
{
    public class NewsModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public List<Image> Images { get; set; }
    }
}