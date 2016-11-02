namespace CategoriesApp.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CategoriesApp.DBContext.CategoriesDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CategoriesApp.DBContext.CategoriesDBContext context)
        {
            //add some categories
            context.Categories.AddOrUpdate(i => i.Name,
                new Category
                {
                    Name = "Hats"
                },
                new Category
                {
                    Name = "Beers"
                },
                new Category
                {
                    Name = "Animals"
                }
            );

            //add some images
            context.Images.AddOrUpdate(i => i.URL,
                new Image
                {
                    URL = "https://www.skalp.com/wp-content/uploads/2015/07/SMP-Hat.jpg",
                    categoryId = 1
                },
                new Image
                {
                    URL = "http://www.thecultureconcept.com/wp-content/uploads/2014/07/Faddism-Straw-Fedora-Hat-P157281771.jpg",
                    categoryId = 1
                },
                new Image
                {
                    URL = "http://thefunkyhat.co.uk/54-pos_thickbox/watermelon-hat.jpg",
                    categoryId = 1
                },
                new Image
                {
                    URL = "https://www.roughguides.com/wp-content/uploads/2013/01/belgian-beer2.jpg",
                    categoryId = 2
                },
                new Image
                {
                    URL = "https://media.licdn.com/mpr/mpr/shrinknp_800_800/AAEAAQAAAAAAAAJ2AAAAJDE2MTQwMGNkLWFiYTctNDFjNS05OGUzLTI3N2YyN2U1MTI4OA.jpg",
                    categoryId = 2
                },
                new Image
                {
                    URL = "http://l7.alamy.com/zooms/566891efa321456ab032bb8badee3572/belgian-beers-bruges-west-vlaanderen-flanders-belgium-europe-d1ebma.jpg",
                    categoryId = 2
                },
                new Image
                {
                    URL = "http://yourshot.nationalgeographic.com/u/fQYSUbVfts-T7pS2VP2wnKyN8wxywmXtY0-FwsgxoQufDJR20dfArh3C8-z7w3383gb2b9Zkfbl1RC-xHSA3/",
                    categoryId = 3
                },
                new Image
                {
                    URL = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRg4qHPwtzO3pMDuCjLWrBCddNzJNfL2BwOAPcOtqwAXjZ1Hio6",
                    categoryId = 3
                },
                new Image
                {
                    URL = "https://columbuszoo.org/Media/columbus-zoo-aquarium/05-zoo-animals-lp_n-amer.jpg?sfvrsn=2&w=960&h=556&mode=crop",
                    categoryId = 3
                }
            );
        }
    }
}
