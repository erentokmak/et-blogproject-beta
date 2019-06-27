using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class ArticleCommentController : Controller
    {
        public IActionResult AddArticle()
        {
            return View();
        }
    }
}