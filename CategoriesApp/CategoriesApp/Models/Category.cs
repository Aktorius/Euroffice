using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CategoriesApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        private string name;
        //property to access or edit the name of a category
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual List<string> imagesList { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public Category()
        {
            imagesList = new List<string>();
        }
    }
}