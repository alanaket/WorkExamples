using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTrackRecipes
{
    class AboutContent
    {
        public static string Content { get; set; }

        public string AboutUsContent()
        {
            string aboutUs = "Inspired by my own need to organize my recipe cards" +
                " in one location, iTrackRecipes was created. Whether its creating," +
                " organizing, or editing recipes, iTrackRecipes wants to make it easier" +
                " for people who loves to cook to find their favorite recipes. Our mission" +
                " is to invent the ultimate kitchen tool so foodies can do what they love" +
                " -cook, eat, and share!  ";

            {
                return aboutUs;
            }
        }
    }
}
