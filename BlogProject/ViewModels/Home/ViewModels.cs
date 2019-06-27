using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewModels.Home
{
    public class ViewModels
    {
        public List<User> DbUsers { get; set; }
        public List<Category> DbArticles { get; set; }
        public List<Comment> DbComments { get; set; }
    }
}
