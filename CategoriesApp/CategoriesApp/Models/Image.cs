using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CategoriesApp.Models
{
    public class Image
    {
        public int ImageId { get; set; }

        private string url;
        //property to access and edit the url of an image
        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        //Foreign Key
        public int categoryId { get; set; }
    }
}